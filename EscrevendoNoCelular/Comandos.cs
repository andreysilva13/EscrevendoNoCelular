using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular
{
    public class Comandos
    {
        public string Converter(string mensagem)
        {
            string mensagem1 = null;
            string recebe2 = "", recebe3 = "", recebe4 = "", recebe5 = "",
                recebe6 = "", recebe7 = "", recebe8 = "", recebe9 = "";

            char[] mensagemSeparada = mensagem.ToCharArray();
            for (int i = 0; i < mensagemSeparada.Length; i++)
            {
                int a = i + 1;
                if (mensagemSeparada[i] == '2')
                {
                    recebe2 += "2";
                    if (a >= mensagemSeparada.Length)
                    {
                        mensagem1 += Comands(recebe2);
                    }
                    else if (mensagemSeparada[a] != '2')
                    {
                        mensagem1 += Comands(recebe2);
                        ResetRecebe(out recebe2, out recebe3, out recebe4, out recebe5, out recebe6, out recebe7, out recebe8, out recebe9);
                    }
                }
                else if (mensagemSeparada[i] == '3')
                {
                    recebe3 += "3";
                    if (a >= mensagemSeparada.Length)
                    {
                        mensagem1 +=Comands(recebe3);
                    }
                    else if (mensagemSeparada[a] != '3')
                    {
                        mensagem1 += Comands(recebe3);
                        ResetRecebe(out recebe2, out recebe3, out recebe4, out recebe5, out recebe6, out recebe7, out recebe8, out recebe9);
                    }
                }
                else if (mensagemSeparada[i] == '4')
                {
                    recebe4 += "4";
                    if (a >= mensagemSeparada.Length)
                    {
                        mensagem1 += Comands(recebe4);
                    }
                    else if (mensagemSeparada[a] != '4')
                    {
                        mensagem1 += Comands(recebe4);
                        ResetRecebe(out recebe2, out recebe3, out recebe4, out recebe5, out recebe6, out recebe7, out recebe8, out recebe9);
                    }
                }
                else if (mensagemSeparada[i] == '5')
                {
                    recebe5 += "5";
                    if (a >= mensagemSeparada.Length)
                    {
                        mensagem1 += Comands(recebe5);
                    }
                    else if (mensagemSeparada[a] != '5')
                    {
                        mensagem1 += Comands(recebe5);
                        ResetRecebe(out recebe2, out recebe3, out recebe4, out recebe5, out recebe6, out recebe7, out recebe8, out recebe9);
                    }
                }
                else if (mensagemSeparada[i] == '6')
                {
                    recebe6 += "6";
                    if (a >= mensagemSeparada.Length)
                    {
                        mensagem1 += Comands(recebe6);
                    }
                    else if (mensagemSeparada[a] != '6')
                    {
                        mensagem1 += Comands(recebe6);
                        ResetRecebe(out recebe2, out recebe3, out recebe4, out recebe5, out recebe6, out recebe7, out recebe8, out recebe9);
                    }
                }
                else if (mensagemSeparada[i] == '7')
                {
                    recebe7 += "7";
                    if (a >= mensagemSeparada.Length)
                    {
                        mensagem1 += Comands(recebe7);
                    }
                    else if (mensagemSeparada[a] != '7')
                    {
                        mensagem1 += Comands(recebe7);
                        ResetRecebe(out recebe2, out recebe3, out recebe4, out recebe5, out recebe6, out recebe7, out recebe8, out recebe9);
                    }
                }
                else if (mensagemSeparada[i] == '8')
                {
                    recebe8 += "8";
                    if (a >= mensagemSeparada.Length)
                    {
                        mensagem1 += Comands(recebe8);
                    }
                    else if (mensagemSeparada[a] != '8')
                    {
                        mensagem1 += Comands(recebe8);
                        ResetRecebe(out recebe2, out recebe3, out recebe4, out recebe5, out recebe6, out recebe7, out recebe8, out recebe9);
                    }
                }
                else if (mensagemSeparada[i] == '9')
                {
                    recebe9 += "9";
                    if (a >= mensagemSeparada.Length)
                    {
                        mensagem1 += Comands(recebe9);
                    }
                    else if (mensagemSeparada[a] != '9')
                    {
                        mensagem1 += Comands(recebe9);
                        ResetRecebe(out recebe2, out recebe3, out recebe4, out recebe5, out recebe6, out recebe7, out recebe8, out recebe9);
                    }
                }
                else if (mensagemSeparada[i] == '0')
                {
                    mensagem1 += " ";
                } 
            }

            return mensagem1;
        }

        private static void ResetRecebe(out string recebe2, out string recebe3, out string recebe4, out string recebe5, out string recebe6, out string recebe7, out string recebe8, out string recebe9)
        {
            recebe2 = ""; recebe3 = ""; recebe4 = ""; recebe5 = "";
                        recebe6 = ""; recebe7 = ""; recebe8 = ""; recebe9 = "";
        }

        public string Comands(string digito)
        {

            switch (digito)
            {
                case "2": return "A";
                case "22": return "B";
                case "222": return "C";
                case "3": return "D";
                case "33": return "E";
                case "333": return "F";
                case "4": return "G";
                case "44": return "H";
                case "444": return "I";
                case "5": return "J";
                case "55": return "K";
                case "555": return "L";
                case "6": return "M";
                case "66": return "N";
                case "666": return "O";
                case "7": return "P";
                case "77": return "Q";
                case "777": return "R";
                case "7777": return "S";
                case "8": return "T";
                case "88": return "U";
                case "888": return "V";
                case "9": return "W";
                case "99": return "X";
                case "999": return "Y";
                case "9999": return "Z";
                case "0": return " ";
                default: return "";
            }
        }
    }
}
