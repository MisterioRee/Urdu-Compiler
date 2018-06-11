using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FYPUrduCompiler
{
    class Analyser
    {
        char[] sparatorArry = { '(', ')', ';', '"', '%', ',', '،', '&',':' };

        public string analyse(string line)
        {
            //چاپنا("جسدفسجف سیف ")؛
            string revision = string.Empty;
            for(int i=0; i<line.Length; i++)
            {               
                if (separator(line[i]))
                {
                    revision += " ";
                }
                revision += line[i];
            }
            string[] splits = revision.Split('"');
            revision = string.Empty;
            foreach (var sps in splits)
            {
                revision += sps + " \" ";
            }
            revision = revision.Substring(0, revision.Length - 2);
            splits = revision.Split('،');
            revision = string.Empty;
            foreach (var sps in splits)
            {
                revision += sps + " ، ";
            }
            revision = revision.Substring(0, revision.Length - 2);

            splits = revision.Split('%');
            revision = string.Empty;
            foreach (var sps in splits)
            {
                revision += sps + " % ";
            }
            revision = revision.Substring(0, revision.Length - 2);

            splits = revision.Split(':');
            revision = string.Empty;
            foreach (var sps in splits)
            {
                revision += sps + " : ";
            }
            revision = revision.Substring(0, revision.Length - 2);

            splits = Regex.Split(revision, "؛");
            revision = string.Empty;
            foreach (var sps in splits)
            {
                revision += sps + " ؛ ";
            }
            revision = revision.Substring(0, revision.Length - 2);

            splits = Regex.Split(revision, "<<");
            revision = string.Empty;
            foreach (var sps in splits)
            {
                revision += sps + " << ";
            }
            revision = revision.Substring(0, revision.Length - 4);

            splits = Regex.Split(revision, ">>");
            revision = string.Empty;
            foreach (var sps in splits)
            {
                revision += sps + " >> ";
            }
            revision = revision.Substring(0, revision.Length - 4);


            return spacer(revision);
        }

        private string spacer(string line)
        {
            string revision = "";
            for(int i=0; i< sparatorArry.Length; i++)
            {
                revision = "";
                if (separator(sparatorArry[i]))
                {
                    string[] splits = line.Split(sparatorArry[i]);
                    foreach (var sps in splits)
                    {
                        revision += sps + " " + sparatorArry[i].ToString()+" ";
                    }
                    revision = revision.Substring(0, revision.Length - 2);
                }
            }

            return revision;
        }

        private bool separator(char _separator)
        {
            return sparatorArry.Contains(_separator);
        }
    }
}
