using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBovedaProhibida.Modelos
{

    class AcertijoCifrado : Acertijo, IResoluble
    {
        private string respuestaCorrecta;

        public AcertijoCifrado(string textoCifrado, string respuesta, string pista)
            : base("", pista)
        {
            respuestaCorrecta = respuesta.ToLower().Trim();
            Pregunta = $"SISTEMA 3 - Mensaje interceptado (cifrado Cesar +3):\n\"{textoCifrado}\"\n¿Que dice el mensaje?";
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