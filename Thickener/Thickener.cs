using System;
using System.Collections.Generic;
using System.Linq;

namespace Thicken
{
    public static class Thickener
    {
        public static string Thicken(this string s){

            return new String(s.ToCharArray()
                .Select(c => c.Thicken())
                .ToArray());
        }

        public static char Thicken(this char c)
        {
            char.ToLowerInvariant(c);
            //Use switch case to convert to the thicken alphabet
            //卂乃匚刀乇下厶卄工丁长乚从𠘨口尸㔿尺丂丅凵リ山乂丫乙
            switch (c)
            {
                case 'a':
                    c = '卂';
                    break;
                case 'b':
                    c = '乃';
                    break;
                case 'c':
                    c = '匚';
                    break;
                case 'd':
                    c = '刀';
                    break;
                case 'e':
                    c = '乇';
                    break;
                case 'f':
                    c = '下';
                    break;
                case 'g':
                    c = '厶';
                    break;
                case 'h':
                    c = '卄';
                    break;
                case 'i':
                    c = '工';
                    break;
                case 'j':
                    c = '丁';
                    break;
                case 'k':
                    c = '长';
                    break;
                case 'l':
                    c = '乚';
                    break;
                case 'm':
                    c = '从';
                    break;
                case 'n':
                    c = '几';
                    break;
                case 'o':
                    c = '口';
                    break;
                case 'p':
                    c = '尸';
                    break;
                case 'q':
                    c = '㔿';
                    break;
                case 'r':
                    c = '尺';
                    break;
                case 's':
                    c = '丂';
                    break;
                case 't':
                    c = '丅';
                    break;
                case 'u':
                    c = '凵';
                    break;
                case 'v':
                    c = 'リ';
                    break;
                case 'w':
                    c = '山';
                    break;
                case 'x':
                    c = '乂';
                    break;
                case 'y':
                    c = '丫';
                    break;
                case 'z':
                    c = '乙';
                    break;
                default:
                    //default to unknown character, I guess?
                    c = '�';
                    break;
            }
            return c;
        }
    }
}
