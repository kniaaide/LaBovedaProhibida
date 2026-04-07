using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBovedaProhibida.Modelos
{

    class AcertijoMatematico : Acertijo, IResoluble
    {
        private int resultado;

        public AcertijoMatematico() : base("", "El resultado es un numero entre 1 y 100")
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 20);
            int b = rnd.Next(1, 20);
            resultado = a * b - a;
            Pregunta = $"SISTEMA 2 - Descifra el codigo numerico:\nSi x = {a} y y = {b}, ¿cuanto es x * y - x?";
        }

        public override bool ValidarRespuesta(string respuesta)
        {
           
            bool esNumero = int.TryParse(respuesta.Trim(), out int numero);
            if (!esNumero) return false;
            return numero == resultado;
        }

        public bool Resolver(string respuesta)
        {
            return ValidarRespuesta(respuesta);
        }
    }
}
