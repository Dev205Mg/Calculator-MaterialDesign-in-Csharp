using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calcul
    {
        string operation, signe;

        public Calcul(string signe, string operation)
        {
            this.signe = signe;
            this.operation = operation;
        }

        public double Egale()
        {
            double resultat = 0;
            operation = operation.Trim();
            operation = operation.Remove(operation.Length - 1);
            string[] arrayOfDisplay = operation.Split(signe, 2);
            double beginsValue = double.Parse(arrayOfDisplay[0]);
            double endignValue = double.Parse(arrayOfDisplay[1]);

            switch (signe)
            {
                case "+":
                    resultat = beginsValue + endignValue;
                    break;
                case "-":
                    resultat = beginsValue - endignValue;
                    break;
                case "*":
                    resultat = beginsValue * endignValue;
                    break;
                case "/":
                    resultat = beginsValue / endignValue;
                    break;
                case "^":
                    resultat = Math.Pow(beginsValue, endignValue);
                    break;
            }

            return resultat;
        }
    }
}
