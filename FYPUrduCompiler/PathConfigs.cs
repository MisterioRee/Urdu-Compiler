using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPUrduCompiler
{
    class PathConfigs
    {
        private string path = @"C:\Users\Professor\Desktop\v3\FYPUrduCompiler\FYPUrduCompiler\bin\Debug\";
        private string execution = "a.exe";
        private string file = "extra.cpp";
        private string compilerPath = @"C:\TDM-GCC-64\bin\g++.exe";
        private string dectionertPath = @"C:\Users\Professor\Desktop\v3\FYPUrduCompiler\FYPUrduCompiler\";
        private string decFilename = "database.xlsx";

        public string dbPath
        {
            get
            {
                return dectionertPath;
            }
        }
        public string dbSheet
        {
            get
            {
                return decFilename;
            }
        }

        public string compilePath
        {
            get
            {
                return compilerPath;
            }
        }
        public String filesPath
        {
            get
            {
               return path;
            }
        }

        public String executionFile
        {
            get
            {
                return execution;
            }
        }

        public String sourceFile
        {
            get
            {
                return file;
            }
        }
    }
}
