using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPUrduCompiler
{
    class Operators
    {
    	//For Operators
        public static string find(string _operator)
        {
            switch (_operator)
            {
                case "=":
                    return "=";
                case "؛":
                    return ";";
                case "{":
                    return "{";
                case "}":
                    return "}";
                case "-":
                    return "-";
                case "%":
                    return "%";
                case "*":
                    return "*";
                case "/":
                    return "/";
                case "(":
                    return "(";
                case ")":
                    return ")";
                case "+":
                    return "+";
                case "<":
                    return "<";
                case ">":
                    return ">";
                case "!":
                    return "!";
                case "|":
                    return "|";
                case "&":
                    return "&";
                case "\"":
                    return "\"";
                case "<<":
                    return "<<";
                case ">>":
                    return ">>";
                case "/ن":
                    return "\\n";
                case "<=":
                    return "<=";
                case ">=":
                    return ">=";
                default:
                    return "null";
            }

        }

    }
}
