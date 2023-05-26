using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Fonction
    {
        /// <summary>
        /// Fonction qui place toujour le nombre zero sur l'ecran
        /// </summary>
        /// <param name="content"> strign source</param>
        /// <param name="number"> nombre click</param>
        /// <returns> string</returns>
        public static string Zero(string content, string number)
        {
            if(content == "0")
            {
                if(number == "00")
                {
                    content = "0";
                }
                else
                {
                    content = "";
                    content += number;
                }
            }
            else
            {
                content += number;
            }

            return content;
        }
        /// <summary>
        /// Fonction qui teste si l'ecran n'est pas vide
        /// </summary>
        /// <param name="content">chaine de caractere a tester</param>
        /// <returns>valeur boolen</returns>
        public static bool IsEmpty(string content)
        {
            try
            {
                double val = double.Parse(content);
                if(content == string.Empty)
                {
                    return false;
                }
                
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Fonction qui teste si la valeur en entrer contien de tableau d'operateur en entrer
        /// </summary>
        /// <param name="signes"> tableau de chaine</param>
        /// <param name="content">contenue a tester</param>
        /// <returns> boolen</returns>
        public static bool IsOperatorMissigns(string[] signes, string content)
        {
            foreach(var signe in signes)
            {
                if (content.Contains(signe))
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Returne la valeur de dernier caractere au chaine d'entrer
        /// </summary>
        /// <param name="value"></param>
        /// <returns> char </returns>
        public static char LastStringValue(string value)
        {
            int index = value.Length;
            return value[index - 1];
        }
        /// <summary>
        /// Fonction qui teste la valeur deu bas et inserer la valeur du haut
        /// </summary>
        /// <param name="bottom"></param>
        /// <param name="top"></param>
        /// <param name="operateur"></param>
        public static bool IsContains( string signe, string value)
        {
            if (value.Contains(signe))
            {
                return true;
            }

            return false;
        }
    }
}
