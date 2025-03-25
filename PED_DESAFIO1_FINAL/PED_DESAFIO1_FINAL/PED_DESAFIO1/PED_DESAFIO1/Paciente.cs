using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_DESAFIO1
{
    public class Paciente
    {
        private string presion;

        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string TipoSangre { get; set; }
        public string PresionArterial { get; set; }

        public Paciente(string nombre, string genero, string tipoSangre, string presionArterial)
        {
            Nombre = nombre;
            Genero = genero;
            TipoSangre = tipoSangre;
            PresionArterial = presionArterial;
        }

        public Paciente(string genero, string tipoSangre, string presion)
        {
            Genero = genero;
            TipoSangre = tipoSangre;
            this.presion = presion;
        }

        public string CalcularRiesgoEnfermedad()
        {
            // Combinaciones completas de Tipo de Sangre + Presión
            if (PresionArterial == "Alta")
            {
                switch (TipoSangre)
                {
                    case "A": return "Alto riesgo: Hipertensión + Problemas cardiovasculares";
                    case "B": return "Alto riesgo: Hipertensión + Predisposición a diabetes";
                    case "AB": return "Riesgo grave: Hipertensión + Enfermedades autoinmunes";
                    case "O": return "Riesgo moderado: Hipertensión + Úlceras gástricas";
                    default: return "Riesgo alto por hipertensión";
                }
            }
            else if (PresionArterial == "Baja")
            {
                switch (TipoSangre)
                {
                    case "A": return "Riesgo bajo: Hipotensión + Fatiga crónica";
                    case "B": return "Riesgo moderado: Hipotensión + Mareos frecuentes";
                    case "AB": return "Riesgo especial: Hipotensión + Desmayos";
                    case "O": return "Riesgo alto: Hipotensión + Anemia";
                    default: return "Riesgo por hipotensión";
                }
            }
            else if (PresionArterial == "Normal")
            {
                switch (TipoSangre)
                {
                    case "AB": return "Riesgo especial: Alergias estacionales";
                    case "A": return "Riesgo bajo: Salud estable";
                    case "B": return "Riesgo bajo: Buena resistencia física";
                    case "O": return "Riesgo bajo: Sistema inmune fuerte";
                    default: return "Riesgo general bajo";
                }
            }
            else
            {
                return "⚠️ Monitorizar constantes vitales";
            }
        }


    }
}