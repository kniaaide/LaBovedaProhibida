using LaBovedaProhibida.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBovedaProhibida
{
    class GestorNiveles
    {
        private List<Acertijo> acertijos;
        private int nivelActual;

        public int NivelActual => nivelActual;
        public int TotalNiveles => acertijos.Count;

        public GestorNiveles()
        {
            acertijos = new List<Acertijo>();
            nivelActual = 0;
            CargarAcertijos();
        }

        private void CargarAcertijos()
        {
            

            acertijos.Add(new AcertijoTexto(
                "SISTEMA 1 - Seguridad de entrada:\nTengo teclas pero no abro puertas, tengo espacio pero no soy una habitacion. ¿Que soy?",
                "teclado",
                "Piensa en lo que usas para escribir"
            ));

            
            acertijos.Add(new AcertijoMatematico());

           
            acertijos.Add(new AcertijoCifrado(
                "SURJUDPD",
                "programa",
                "Cada letra se movio 3 posiciones en el abecedario"
            ));

           
            acertijos.Add(new AcertijoLogico(
                "SISTEMA 4 - Firewall logico:\nbool a = true;\nbool b = false;\nConsole.WriteLine(a && !b);\n¿Que imprime este codigo?",
                "true",
                "Recuerda como funciona el operador AND (&&)"
            ));

            acertijos.Add(new AcertijoTexto(
                "SISTEMA 5 - BOVEDA PRINCIPAL:\nSoy invisible pero todos me necesitan. Me roban pero no me pierdo. Sin mi no hay internet ni banco. ¿Que soy?",
                "contrasena",
                "Es lo que escribes para entrar a tus cuentas"
            ));
        }

        public Acertijo ObtenerAcertijoActual()
        {
            return acertijos[nivelActual];
        }

        public void AvanzarNivel()
        {
            nivelActual++;
        }

        public bool JuegoTerminado()
        {
            return nivelActual >= acertijos.Count;
        }
    }
}
