using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Avion
    {
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El ID debe tener al menos 3 caracteres.");
                if (value.Length > 10) throw new ArgumentException("El ID no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]+$")) throw new ArgumentException("El ID solo puede contener letras y números.");
                if (value.Contains(" ")) throw new ArgumentException("El ID no puede contener espacios.");
                if (value.StartsWith("0")) throw new ArgumentException("El ID no puede iniciar con 0.");
                if (value != value.ToUpper()) throw new ArgumentException("El ID debe estar en mayúsculas.");
                _id = value;
            }
        }
        private string _id;

        public string Modelo
        {
            get => _modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El modelo no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El modelo debe tener al menos 2 caracteres.");
                if (value.Length > 50) throw new ArgumentException("El modelo no puede tener más de 50 caracteres.");
                _modelo = value;
            }
        }
        private string _modelo;

        public int Capacidad
        {
            get => _capacidad;
            set
            {
                if (value < 10) throw new ArgumentException("La capacidad mínima es de 10.");
                if (value > 1000) throw new ArgumentException("La capacidad máxima es de 1000.");
                _capacidad = value;
            }
        }
        private int _capacidad;

        public string Fabricante
        {
            get => _fabricante;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El fabricante no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El fabricante debe tener al menos 2 caracteres.");
                if (value.Length > 50) throw new ArgumentException("El fabricante no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$")) throw new ArgumentException("El fabricante solo puede contener letras.");
                _fabricante = value;
            }
        }
        private string _fabricante;

        public int AnioFabricacion
        {
            get => _anioFabricacion;
            set
            {
                if (value < 1950) throw new ArgumentException("El año de fabricación no puede ser anterior a 1950.");
                if (value > DateTime.Now.Year) throw new ArgumentException("El año de fabricación no puede ser futuro.");
                _anioFabricacion = value;
            }
        }
        private int _anioFabricacion;

        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El estado no puede estar vacío.");
                if (value != "Activo" && value != "En Mantenimiento" && value != "Retirado") throw new ArgumentException("Estado inválido.");
                _estado = value;
            }
        }
        private string _estado;

        public string Matricula
        {
            get => _matricula;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("La matrícula no puede estar vacía.");
                if (value.Length < 5) throw new ArgumentException("La matrícula debe tener al menos 5 caracteres.");
                if (value.Length > 10) throw new ArgumentException("La matrícula no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]+$")) throw new ArgumentException("La matrícula solo puede contener letras y números.");
                if (value != value.ToUpper()) throw new ArgumentException("La matrícula debe estar en mayúsculas.");
                _matricula = value;
            }
        }
        private string _matricula;

        public string Motor
        {
            get => _motor;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El motor no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El motor debe tener al menos 2 caracteres.");
                if (value.Length > 50) throw new ArgumentException("El motor no puede tener más de 50 caracteres.");
                _motor = value;
            }
        }
        private string _motor;

        private static string filePath = "aviones.json";

        public static void Guardar(Avion obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static List<Avion> Leer()
        {
            try
            {
                if (!File.Exists(filePath)) return new List<Avion>();
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) return new List<Avion>();
                return JsonSerializer.Deserialize<List<Avion>>(json) ?? new List<Avion>();
            }
            catch
            {
                return new List<Avion>();
            }
        }

        public static void GuardarLista(List<Avion> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public string MostrarInfo()
        {
            return $"Avión {Id} - Modelo {Modelo}, Matrícula: {Matricula}";
        }
    }
}