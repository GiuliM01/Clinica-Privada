using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Medicos

    {

        private string medicosdisponibles;
        private string especialidad;
        private string turno;

        public Medicos(string medicosdisponibles, string especialidad, string turno)

        {

            this.medicosdisponibles = medicosdisponibles;
            this.especialidad = especialidad;
            this.turno = turno;
        }
        int TurnosDisponibles; 
        public void AgregarTurnosDisponibles()
        {
            TurnosDisponibles++;
        }

        public string Especialidad { get => especialidad; }
    }
}  

            
        
    

