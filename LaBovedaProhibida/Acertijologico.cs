using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBovedaProhibida.Modelos
{
    
    class AcertijoLogico : Acertijo, IResoluble
    {
        private string respuestaCorrecta;

        public AcertijoLogico(string pregunta, string respuesta, string pista)
            : base(pregunta, pista)
        {
            respuestaCorrecta = respuesta.ToLower().Trim();
        }

        public override bool ValidarRespuesta(string respuesta)
        {
            return respuesta.ToLower().Trim() == respuestaCorrecta;
        }

        public bool Resolver(string respuesta)
        {
            return ValidarRespuesta(respuesta);
        }
    }
}