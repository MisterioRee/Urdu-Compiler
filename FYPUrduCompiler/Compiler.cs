using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPUrduCompiler
{
    class Compiler
    {
        Filer filer = new Filer();
        Translator translator = new Translator();
        Analyser analyser = new Analyser();
        PathConfigs paths = new PathConfigs();
        CharMap charMap = new CharMap();

        string outPut = string.Empty;
        //private string preText = "#include <iostream>\nusing namespace std; \nint main()\n{ \n";
        //private string postText = "\n int dummy;\n cin>>dummy;\n return 0; \n }";
        private string preText = "#include <iostream>\n #include<fcntl.h>\n #include<io.h>\n using namespace std; \n  \n";
        private string postText = "\n int dummy;\n cin>>dummy;\n return 0; \n  ";
        private string fileOutput = "";

        Stack<string> arabicWords = new Stack<string>();

        public void translate(ref ProgressBar progressBar, ref RichTextBox textUrdu, ref RichTextBox textEnglish)
        {
            arabicWords = new Stack<string>();
            outPut = string.Empty;
            outPut += preText;
            string[] lines = textUrdu.Text.Split('\n');

            progressBar.Value = 0;  // Reset The progress bar to start
            progressBar.Maximum = lines.Length;   // The percentage of the totel lines equal to the totel lines
            
            foreach (var line in lines)
            {
                if (line.Contains("\""))
                {
                    bool isLitral = true;
                    int const_str_start_ind= line.IndexOf("\"") + 1;
                    int const_str_ending_ind = line.LastIndexOf("\"");
                    outPut += "wcout";
                    for(int i=0; i< line.Length; i++)
                    {
                        if (i > const_str_start_ind && i < const_str_ending_ind)
                        {
                            arabicWords.Push(charMap.convertUniCode(line[i]));
                        }
                        else
                        {
                            while (arabicWords.Count > 0)
                            {
                                outPut += arabicWords.Pop();
                            }
                            //string nonLitrel = string.Empty;
                            //while (outPut[i] != '"')
                            //{
                            //    nonLitrel += outPut[i];
                            //}
                            charWrap(line[i], ref isLitral);
                        }
                    }

                }
                else {
                    wrapWord(line);
                }
                outPut += "\n";
                progressBar.Increment(1);  //Increament in progress-barr 
            }
           
            fileOutput = outPut;// + postText;
            fileOutput = fileOutput.Insert(fileOutput.LastIndexOf('}'), postText);
            fileOutput = fileOutput.Insert(fileOutput.LastIndexOf('{')+1, "\n _setmode(_fileno(stdout), _O_U16TEXT);");
            //outPut += "}";//postText;         
            textEnglish.Text = outPut;
        }

        private void charWrap(char ch, ref bool isLitral)
        {

            if (KeyWords.find(ch.ToString()) != "null")
            {
                outPut += KeyWords.find(ch.ToString()).Trim() ;
            }
            else if(Operators.find(ch.ToString()).Trim() != "null")
            {
                if (isLitral && Operators.find(ch.ToString()).Trim()=="\"")
                {
                    isLitral = false;
                    outPut += " L";
                }
                outPut += Operators.find(ch.ToString()).Trim();
            }
            else if(ch==' ')
            {
                outPut += " ";
            }
        }
        private void wrapWord(string lineString)
        {
            string[] words = analyser.analyse(lineString).Split();
            for (int i = 0; i < words.Length; i++)
            {

                if (KeyWords.find(words[i]) != "null")
                {
                    outPut += KeyWords.find(words[i]).Trim() + " ";

                }
                else if (Operators.find(words[i]).Trim() != "null")
                {
                    outPut += Operators.find(words[i]).Trim() + " ";
                }
                else if (words[i] == " " || words[i] == "")
                {

                }
                else
                {
                    //outPut += words[i];
                    string translated = translator.Translate(words[i]);
                    outPut += (translated[0]) + translated.Substring(1).Replace(" ", String.Empty) + " ";
                }
            }

        }

        public bool compile(ref RichTextBox compilerResult)
        {
            try
            {
                List<string> linesList = new List<string>();
                string[] lines = fileOutput.Split('\n');
                foreach (var line in lines)
                {
                    linesList.Add(line);
                }

                filer.createFile(linesList);


                string compilerReport = "**********************  Compiler Result  **************************\n";
                compilerReport = RunExternalExe("g++", "-Wall "+paths.sourceFile);
               
                // ProcessStartInfo psi = new ProcessStartInfo(paths.compilePath, "-Wall " + paths.sourceFile + " -o " + paths.executionFile);
                // Process.Start(psi);

                Thread.Sleep(1000);
                return File.Exists(paths.filesPath + paths.executionFile);
            }
            catch (Exception s)
            {
                compilerResult.Text = "**********************  Compiler Result  **************************\n";
                compilerResult.AppendText(s.ToString());
               // MessageBox.Show(s.ToString());
                return false;
            }
        }

        public string RunExternalExe(string filename, string arguments = null)
        {
            var process = new Process();

            process.StartInfo.FileName = filename;
            if (!string.IsNullOrEmpty(arguments))
            {
                process.StartInfo.Arguments = arguments;
            }

            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            var stdOutput = new StringBuilder();
            process.OutputDataReceived += (sender, args) => stdOutput.AppendLine(args.Data); // Use AppendLine rather than Append since args.Data is one line of output, not including the newline character.

            string stdError = null;
            try
            {
                process.Start();
                process.BeginOutputReadLine();
                stdError = process.StandardError.ReadToEnd();
                process.WaitForExit();
            }
            catch (Exception e)
            {
                throw new Exception("OS error while executing " + Format(filename, arguments) + ": " + e.Message, e);
            }

            if (process.ExitCode == 0)
            {
                return stdOutput.ToString();
            }
            else
            {
                var message = new StringBuilder();

                if (!string.IsNullOrEmpty(stdError))
                {
                    message.AppendLine(stdError);
                }

                if (stdOutput.Length != 0)
                {
                    message.AppendLine("Std output:");
                    message.AppendLine(stdOutput.ToString());
                }

                throw new Exception(Format(filename, arguments) + " finished with exit code = " + process.ExitCode + ": " + message);
            }
        }

        private string Format(string filename, string arguments)
        {
            return "'" + filename +
                ((string.IsNullOrEmpty(arguments)) ? string.Empty : " " + arguments) +
                "'";
        }
    }

}
