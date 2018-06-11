using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPUrduCompiler
{
    class KeyWords
    {
        public static string find(string type)
        {
            switch (type.Trim())
            {
                case "عدد":
                    return "int";
                case "اعشاریہ":
                    return "float";
                case "جملہ":
                    return "string";
                case "اگر":
                    return "if";
                case "ورنہ":
                    return "else";
                case "کرین":
                    return "do";
                case "جبتک":
                    return "while";
                case "چلائين":
                    return "for";
                case "حرف":
                    return "char";
                case "معاملہ":
                    return "case";
                case "خالی":
                    return "void";
                case "دوگنا":
                    return "double";
                case "طویل":
                    return "long";
                case "منتخب":
                    return "switch";
                case "لوٹائين":
                    return "return";
                case "طےشدہ":
                    return "default";
                case "روایتی":
                    return "signed";
                case "غیرروایتی":
                    return "unsigned";
                case "چھاپو":
                    return "wcout";
                case "جائزہ":
                    return "cin";
                case "وقفے":
                    return "break";
                case "جامد":
                    return "static";
                case "مستقل":
                    return "const";
                case "جاریرکھیں":
                    return "continue";
                case "مرکزی":
                    return "main";
                default:
                    return "null";
            }

        }
    }
}
