using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class Avion
    {
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío.");
                _id = value;
            }
        }
        private string _id;

        public string Modelo
        {
            get => _modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Modelo no puede estar vacío.");
                _modelo = value;
            }
        }
        private string _modelo;

        public int Capacidad
        {
            get => _capacidad;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La Capacidad debe ser mayor que cero.");
                _capacidad = value;
            }
        }
        private int _capacidad;

        public string Fabricante
        {
            get => _fabricante;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Fabricante no puede estar vacío.");
                _fabricante = value;
            }
        }
        private string _fabricante;

        public int AnioFabricacion
        {
            get => _anioFabricacion;
            set
            {
                if (value <= 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("El Año de Fabricación no es válido.");
                _anioFabricacion = value;
            }
        }
        private int _anioFabricacion;

        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Estado no puede estar vacío.");
                _estado = value;
            }
        }
        private string _estado;

        public string Matricula
        {
            get => _matricula;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La Matrícula no puede estar vacía.");
                _matricula = value;
            }
        }
        private string _matricula;

        public string TipoMotor
        {
            get => _tipoMotor;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Tipo de Motor no puede estar vacío.");
                _tipoMotor = value;
            }
        }
        private string _tipoMotor;

        private static string filePath = "aviones.json";

        public static void Guardar(Avion avion)
        {
            List<Avion> lista = Leer();
            lista.Add(avion);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Avion> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Avion>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Avion>>(json);
        }

        public string MostrarInfo()
        {
            return $"Avión {Id}: {Modelo} - {Estado}, Capacidad: {Capacidad}";
        }
    }
}