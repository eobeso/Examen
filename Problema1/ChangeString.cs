using System.Linq;

namespace Problema1
{
    public class ChangeString
    {
        public string build(string cadena)
        {
            int cuenta = cadena.Length;
            int cont;
            string evalua=string.Empty;
            bool valcaracter;
            for (cont = 0; cont <= cadena.Length; cont++)
            {
                string caracter = cadena.Substring(cont, 1);
                valcaracter = ValidaNumerico(caracter);
                if (valcaracter == false)
                {
                    evalua = evalua + Abecedario(caracter);
                }
                else
                {
                    evalua = evalua + cadena.Substring(cont, 1);
                }
                if (cont == cadena.Length-1)
                {
                    break;
                }             
            }
            return evalua;

        }

        public bool ValidaNumerico(string letra)
        {
            bool textIsNumeric = true;
            try
            {
                int.Parse(letra);
            }
            catch
            {
                textIsNumeric = false;
            }
            return textIsNumeric;
        }
        public string Abecedario(string letra)
        {
            string convertida= string.Empty;
            switch (letra.ToLower())
            {
                case "a":
                    convertida = "b";
                break;
                case "b":
                    convertida = "c";
                    break;
                case "c":
                    convertida = "d";
                    break;
                case "d":
                    convertida = "e";
                    break;
                case "e":
                    convertida = "f";
                    break;
                case "f":
                    convertida = "g";
                    break;
                case "g":
                    convertida = "h";
                    break;
                case "h":
                    convertida = "i";
                    break;
                case "i":
                    convertida = "j";
                    break;
                case "j":
                    convertida = "k";
                    break;
                case "k":
                    convertida = "l";
                    break;
                case "l":
                    convertida = "m";
                    break;
                case "m":
                    convertida = "n";
                    break;
                case "n":
                    convertida = "o";
                    break;
                case "o":
                    convertida = "p";
                    break;
                case "p":
                    convertida = "q";
                    break;
                case "q":
                    convertida = "r";
                    break;
                case "r":
                    convertida = "s";
                    break;
                case "s":
                    convertida = "t";
                    break;
                case "t":
                    convertida = "u";
                    break;
                case "u":
                    convertida = "v";
                    break;
                case "v":
                    convertida = "w";
                    break;
                case "w":
                    convertida = "x";
                    break;
                case "x":
                    convertida = "y";
                    break;
                case "y":
                    convertida = "z";
                    break;
                case "z":
                    convertida = "z";
                    break;
                case " ":
                    convertida = " ";
                    break;
                default:
                    convertida = letra;
                    break;
            }
            bool valida = letra.Any(char.IsUpper);
            if (valida == true)
            {
                convertida = convertida.ToUpper();
            }
            return convertida;
        }
    }
}
