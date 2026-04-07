using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBovedaProhibida
{
    class GestorArchivos
    {
        private string rutaArchivo = "records.txt";

        public void GuardarRecord(string nombre, int puntaje)
        {
            try
            {
                string linea = $"{nombre},{puntaje},{DateTime.Now:dd/MM/yyyy}";
                File.AppendAllText(rutaArchivo, linea + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el record: " + ex.Message);
            }
        }

        public List<string> ObtenerRecords()
        {
            List<string> records = new List<string>();

            try
            {
                if (!File.Exists(rutaArchivo))
                    return records;

                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    if (linea != "")
                        records.Add(linea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer records: " + ex.Message);
            }

            return records;
        }
    }
}

