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
            password.Longitud = 8;

            password.generarPassword();
            Console.WriteLine(password.esFuerte());


            Console.WriteLine("Longitud array: ");
            int longitudArray = Convert.ToInt32(Console.ReadLine());

            string[] passwords = new string[longitudArray];

            for (int i = 0; i < passwords.Length; i++)
            {

                Password password[i] = new Password();
                passwords[i]= 



            }


        }
    }
}
