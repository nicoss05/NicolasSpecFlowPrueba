using System;

namespace NicolasLogica

{
    public class Logica
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Resultado { get; set; }
        public object Profesion { get; set; }
        public string Bufete { get; set; }

        public void Datos()
        {
            Resultado = Nombre + Apellido;
        }

        public void DatosDeLaProfesion()
        {
            Resultado = Profesion + Bufete;
        }
    }
}