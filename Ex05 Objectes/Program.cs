using System;

namespace Ex05_Objectes
{
    class Program
    {
        static void Main(string[] args)
        {

            Password password = new Password();
            string contraseña = "ABCDEFG123dgf485";
            password.Contraseña = contraseña;
            

            
            


            Console.WriteLine("Longitud array: ");
            int longitudArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Longitud password: ");
            int longitudPassword = Convert.ToInt32(Console.ReadLine());

            string[] passwordsArray = new string[longitudArray];
            bool[] esForta = new bool[longitudArray];
            for (int i = 0; i < passwordsArray.Length; i++)
            {

                
                passwordsArray[i] = password.generarPassword(longitudPassword);
                esForta[i] = password.esFuerte(passwordsArray[i]);

            }

            for (int i = 0; i < passwordsArray.Length; i++)
            {
                Console.WriteLine(passwordsArray[i]);
                Console.WriteLine(esForta[i]);
            }


        }
    }
}
