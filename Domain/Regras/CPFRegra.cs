using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Regras
{
    public class CPFRegra
    {

        public static bool ValidarCPF(int cpf)
        {
            string CPF = Convert.ToString(cpf);
            char[] quebra;

            quebra = CPF.ToCharArray(0, 11);
            int[] numeros = Array.ConvertAll(quebra, c => (int)Char.GetNumericValue(c));
            bool validoDigito10 = false;
            bool validoDigito11 = false;


            if (numeros.Length <= 11)
            {

                int digito10 = (10 * numeros[0] + 9 * numeros[1] + 8 * numeros[2] + 7 * numeros[3] + 6 * numeros[4] + 5 * numeros[5] + 4 * numeros[6] + 3 * numeros[7] +
                    2 * numeros[8]);

                int divisao10 = digito10 / 11;
                int modulo10 = digito10 % 11;

                // verificar o 10º digito digito10 = 11.(quociente da divisao por 11) + (o resto da divisao)
                if (modulo10 == 0 | modulo10 == 1)
                {
                    //digito 10 do cpf vai valer 0
                    if (numeros[9] == 0)
                    {
                        validoDigito10 = true;
                        //Console.WriteLine("Valido primeiro IF");
                    }
                }

                // digito 10 do cpf vai valer 11 - (o resto)
                else if (numeros[9] == (11 - modulo10))
                {
                    validoDigito10 = true;
                    //Console.WriteLine("valido segundo IF");
                }
                else
                {
                    //Console.WriteLine("digito 10 não valido");
                }

                int digito11 = (10 * numeros[1] + 9 * numeros[2] + 8 * numeros[3] + 7 * numeros[4] + 6 * numeros[5] + 5 * numeros[6] + 4 * numeros[7] + 3 * numeros[8] +
                    2 * numeros[9]);

                int divisao11 = digito11 / 11;
                int modulo11 = digito11 % 11;

                // verificar o 10º digito digito10 = 11.(quociente da divisao por 11) + (o resto da divisao)
                if (modulo11 == 0 | modulo11 == 1)
                {
                    //digito 10 do cpf vai valer 0
                    if (numeros[10] == 0)
                    {
                        validoDigito11 = true;
                        //Console.WriteLine("Valido primeiro IF");
                    }
                }

                // digito 10 do cpf vai valer 11 - (o resto)
                else if (numeros[10] == (11 - modulo11))
                {
                    validoDigito11 = true;
                    //Console.WriteLine("valido segundo IF");
                }
                else
                {
                    //Console.WriteLine("digito 11 não valido");
                }

            }
            if (validoDigito10 == true & validoDigito11 == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
