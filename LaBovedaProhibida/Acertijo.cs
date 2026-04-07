namespace LaBovedaProhibida.Modelos
{
    abstract class Acertijo
    {
        public string Pregunta { get; set; }
        public int Intentos { get; set; }
        public string Pista { get; set; }

        public Acertijo(string pregunta, string pista, int intentos = 3)
        {
            Pregunta = pregunta;
            Pista = pista;
            Intentos = intentos;
        }

        public abstract bool ValidarRespuesta(string respuesta);
    }
}