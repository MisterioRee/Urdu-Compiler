using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPUrduCompiler
{
    public partial class Editor : Form
    {
        Filer filer = new Filer();
        Compiler compiler = new Compiler();
        PathConfigs paths = new PathConfigs();

        public Editor()
        {
            InitializeComponent();
        }      

        void resetEnvironment()
        {
            progressBar.Value = 0;
            textEnglish.Text = "";
        }

        void translate()
        {
            compiler.translate(ref progressBar, ref textUrdu, ref textEnglish);
            filer.removePrevious();
            if (compiler.compile(ref richTextOutput))
            {
                MessageBox.Show("Code Has Been Translated Sucessfully", "Translation Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Could not Translated The Code Sucessfully", "Translation Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void compile()
        {
            try
            {
                filer.removePrevious();
                compiler.translate(ref progressBar, ref textUrdu, ref textEnglish); 
                if (compiler.compile(ref richTextOutput))
                {
                    MessageBox.Show("Code Has Been Compiled Sucessfully", "Compiler Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Could not Compile The Code", "Compiler Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch
            {
                MessageBox.Show("Could not Compile The Code", "Compiler Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void compileAndRun()
        {
            try
            {
                filer.removePrevious();
                compiler.translate(ref progressBar, ref textUrdu, ref textEnglish);
                if(compiler.compile(ref richTextOutput))
                {
                    MessageBox.Show("Code Has Been Compiled Sucessfully", "Compiler Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(paths.executionFile);
                }
                else
                {
                    MessageBox.Show("Could not Compile The Code", "Compiler Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Has Been Occured \n Concern Zaki", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            textEnglish.Text = "";
            progressBar.Value = 0;

           

            InputLanguage myCurrentLanguage = GetUrduLanguage();
            if (myCurrentLanguage == null)
            {
                myCurrentLanguage = InputLanguage.DefaultInputLanguage;
            }
            textUrdu.RightToLeft = RightToLeft.Yes;
            //
            CultureInfo info = System.Globalization.CultureInfo.GetCultureInfo("ur-PK");
            InputLanguage.CurrentInputLanguage = myCurrentLanguage;
            textUrdu.SelectionAlignment = HorizontalAlignment.Right;
        }
        private InputLanguage GetUrduLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName == "اردو".Trim())
                    return lang;
            }
            return null;
        }
        private void compileAndRunCtrl2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEnglish.Text = "";
            compileAndRun();
        }

        private void urduFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            textUrdu.Text = "";
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                foreach(var text in filer.readFile(opd.FileName))
                {
                    textUrdu.AppendText(text + "\n");
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textUrdu.Text = "";
            textEnglish.Text = "";

        }

        private void englishCodeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            textEnglish.Text = "";
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                foreach (var text in filer.readFile(opd.FileName))
                {
                    textEnglish.AppendText(text + "\n");
                }
            }
        }

        private void urduEditorColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            textUrdu.BackColor = colorDialog.Color;
            if (colorDialog.Color == Color.Black)
            {
                textUrdu.ForeColor = Color.White;
            }
        }

        private void englishEditorColorToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            colorDialog.ShowDialog();
            textEnglish.BackColor = colorDialog.Color;
            if (colorDialog.Color == Color.Black)
            {
                textEnglish.ForeColor = Color.White;
            }
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compile();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void textUrdu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6 && e.Control)
            {
                compile();
            }
            else if (e.KeyCode == Keys.F5 && e.Control)
            {
                compileAndRun();
            }
            else if (e.KeyCode == Keys.T && e.Control)
            {
                compiler.translate(ref progressBar, ref textUrdu, ref textEnglish);
            }
            else if (e.KeyCode == Keys.OemOpenBrackets && e.Control)
            {
                textUrdu.ZoomFactor += 0.5f;
                textEnglish.ZoomFactor = textUrdu.ZoomFactor;
            }
            else if (e.KeyCode == Keys.OemCloseBrackets && e.Control)
            {
                if (textUrdu.ZoomFactor > 0)
                {
                    textUrdu.ZoomFactor -= 0.5f;
                    textEnglish.ZoomFactor = textUrdu.ZoomFactor;
                }

            }
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            textUrdu.Focus();
        }

        private void translateCtrlTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //compiler.translate(ref progressBar, ref textUrdu, ref textEnglish);
            translate();
        }

        private void textUrdu_TextChanged(object sender, EventArgs e)
        {
            textUrdu.DeselectAll();
            changeDatatypeColor();
            textUrdu.Select(textUrdu.Text.Length, textUrdu.Text.Length);
            //textUrdu.DeselectAll();
            //textUrdu.DeselectAll();
            changeOperatorColor();
            textUrdu.Select(textUrdu.Text.Length, textUrdu.Text.Length);
            textUrdu.DeselectAll();

        }

        void changeDatatypeColor()
        {
            Analyser analyser = new Analyser();
            string[] lines = textUrdu.Text.Split('\n');
            foreach (var line in lines)
            {
                string[] words = analyser.analyse(line).Split();
                foreach (var word in words)
                {
                    if (word.Length > 2)
                        if (KeyWords.find(word.Trim()) != "null")
                        {
                            if (textUrdu.Text.Contains(word))
                            {
                                textUrdu.Select(textUrdu.Text.IndexOf(word), (word.Length));
                                textUrdu.SelectionColor = Color.Blue;
                                textUrdu.DeselectAll();

                            }
                        }
                }
            }
        }

        void changeOperatorColor()
        {
            Analyser analyser = new Analyser();
            string[] lines = textUrdu.Text.Split('\n');
            foreach (var line in lines)
            {
                string[] words = analyser.analyse(line).Split();
                foreach (var word in words)
                {
                    if (Operators.find(word.Trim()) != "null")
                    {
                        if (textUrdu.Text.Contains(word))
                        {
                            textUrdu.Select(textUrdu.Text.IndexOf(word), (word.Length));
                            textUrdu.SelectionColor = Color.Red;
                            textUrdu.DeselectAll();

                        }

                    }
                    else if (KeyWords.find(word.Trim()) == "null" )
                    {
                        textUrdu.Select(textUrdu.Text.IndexOf(word), (word.Length));
                        textUrdu.SelectionColor = Color.Black;
                        textUrdu.DeselectAll();
                    }
                }
                 
            }

        }

        

        private void textUrdu_Leave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CharMap charmap = new CharMap();
            MessageBox.Show(charmap.convertUniCode('ا'));
        }
    }
}
