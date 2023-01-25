using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Objectes
{
    class Password
    {

        int longitud;
        string contraseña;

        public Password()
        {
            this.longitud = 8;
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = generarPassword(longitud);
        }

        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Longitud { get => longitud; set => longitud = value; }

        public string generarPassword(int longitud)
        {
            string password="";

            for(int i =0; i<Longitud; i++)
            {
                Random rnd = new Random();
                Random rnd2 = new Random();

               int num = rnd2.Next(0, 3);

                if (num==0)
                {
                    password += Convert.ToChar(rnd.Next(48, 58));

                }
                else if (num==1)
                {
                    password += Convert.ToChar(rnd.Next(65, 91));

                }

                else if (num==2)
                {
                    password += Convert.ToChar(rnd.Next(97, 123));

                }

            }

            Console.WriteLine(password);
            return password;
            
        }

        public bool esFuerte( string contraseña)
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;
            foreach (char c in Contraseña)
            {
                if (char.IsUpper(c))
                {
                    mayusculas++;
                }
                else if (char.IsLower(c))
                {
                    minusculas++;
                }
                else if (char.IsNumber(c))
                {
                    numeros++;
                }
            }
            return mayusculas > 2 && minusculas > 1 && numeros > 5;
        }
    }

  
}
