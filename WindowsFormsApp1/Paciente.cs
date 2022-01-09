using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Paciente
    {
        public class Persona
        {
            private string nombre;

            public string GetNombre()

            {
                return nombre;

            }
            public void SetNombre(string nombre)
            {
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    this.nombre = nombre.Trim();


                }

            }
            public class Pacientes
            {

                private string seguroSocial;
                private string DNI;
                private string Edad;

                public Pacientes(string seguroSocial, string DNI, string Edad)

                {

                    this.seguroSocial = seguroSocial;
                    this.DNI = DNI;
                    this.Edad = Edad;
                }
            }
        }
    }
}

