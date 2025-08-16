using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Pasajero
    {
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El ID debe tener al menos 3 caracteres.");
                if (value.Length > 10)
                    throw new ArgumentException("El ID no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]+$"))
                    throw new ArgumentException("El ID solo puede contener letras y números.");
                if (value.Contains(" "))
                    throw new ArgumentException("El ID no puede contener espacios.");
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID no puede iniciar con 0.");
                if (value != value.ToUpper())
                    throw new ArgumentException("El ID debe estar en mayúsculas.");
                _id = value;
            }
        }
        private string _id;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                if (value.Length < 2)
                    throw new ArgumentException("El nombre debe tener al menos 2 caracteres.");
                if (value.Length > 50)
                    throw new ArgumentException("El nombre no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El nombre solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El nombre no puede contener números.");
                if (value.StartsWith(" ") || value.EndsWith(" "))
                    throw new ArgumentException("El nombre no puede iniciar/terminar con espacio.");
                _nombre = value;
            }
        }
        private string _nombre;

        public string Apellido
        {
            get => _apellido;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido no puede estar vacío.");
                if (value.Length < 2)
                    throw new ArgumentException("El apellido debe tener al menos 2 caracteres.");
                if (value.Length > 50)
                    throw new ArgumentException("El apellido no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El apellido solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El apellido no puede contener números.");
                if (value.StartsWith(" ") || value.EndsWith(" "))
                    throw new ArgumentException("El apellido no puede iniciar/terminar con espacio.");
                _apellido = value;
            }
        }
        private string _apellido;

        public DateTime FechaNacimiento
        {
            get => _fechaNacimiento;
            set
            {
                if (value == default) throw new ArgumentException("La fecha de nacimiento no puede estar vacía.");
                if (value.Year < 1900) throw new ArgumentException("La fecha de nacimiento no puede ser anterior a 1900.");
                if (value > DateTime.Today) throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");
                var edad = DateTime.Today.Year - value.Year - (DateTime.Today.Date < value.Date.AddYears(DateTime.Today.Year - value.Year) ? 1 : 0);
                if (edad < 0) throw new ArgumentException("Edad inválida.");
                if (edad > 120) throw new ArgumentException("Edad demasiado alta.");
                _fechaNacimiento = value;
            }
        }
        private DateTime _fechaNacimiento;

        public string Nacionalidad
        {
            get => _nacionalidad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La nacionalidad no puede estar vacía.");
                if (value.Length < 3)
                    throw new ArgumentException("La nacionalidad debe tener al menos 3 caracteres.");
                if (value.Length > 50)
                    throw new ArgumentException("La nacionalidad no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("La nacionalidad solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("La nacionalidad no puede contener números.");
                if (value.StartsWith(" ") || value.EndsWith(" "))
                    throw new ArgumentException("La nacionalidad no puede iniciar/terminar con espacio.");
                _nacionalidad = value;
            }
        }
        private string _nacionalidad;

        public string Pasaporte
        {
            get => _pasaporte;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El pasaporte no puede estar vacío.");
                if (value.Length < 6)
                    throw new ArgumentException("El pasaporte debe tener al menos 6 caracteres.");
                if (value.Length > 9)
                    throw new ArgumentException("El pasaporte no puede tener más de 9 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]+$"))
                    throw new ArgumentException("El pasaporte solo puede contener letras y números.");
                if (value.Any(char.IsWhiteSpace))
                    throw new ArgumentException("El pasaporte no puede contener espacios.");
                if (value != value.ToUpper())
                    throw new ArgumentException("El pasaporte debe estar en mayúsculas.");
                if (value.StartsWith("0"))
                    throw new ArgumentException("El pasaporte no puede iniciar con 0.");
                _pasaporte = value;
            }
        }
        private string _pasaporte;

        public string Telefono
        {
            get => _telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El teléfono no puede estar vacío.");
                if (!Regex.IsMatch(value, @"^[0-9]+$"))
                    throw new ArgumentException("El teléfono solo puede contener números.");
                if (value.Length < 8)
                    throw new ArgumentException("El teléfono debe tener al menos 8 dígitos.");
                if (value.Length > 15)
                    throw new ArgumentException("El teléfono no puede tener más de 15 dígitos.");
                if (value.StartsWith("0"))
                    throw new ArgumentException("El teléfono no puede iniciar con 0.");
                if (value.Contains(" "))
                    throw new ArgumentException("El teléfono no puede contener espacios.");
                _telefono = value;
            }
        }
        private string _telefono;

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El email no puede estar vacío.");
                if (value.Length < 5)
                    throw new ArgumentException("El email debe tener al menos 5 caracteres.");
                if (value.Length > 100)
                    throw new ArgumentException("El email no puede tener más de 100 caracteres.");
                if (!value.Contains("@") || !value.Contains("."))
                    throw new ArgumentException("El email debe contener '@' y '.'.");
                if (value.StartsWith(" ") || value.EndsWith(" "))
                    throw new ArgumentException("El email no puede iniciar/terminar con espacio.");
                _email = value;
            }
        }
        private string _email;

        private static string filePath = "pasajeros.json";

        public static void Guardar(Pasajero obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static List<Pasajero> Leer()
        {
            try
            {
                if (!File.Exists(filePath)) return new List<Pasajero>();
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) return new List<Pasajero>();
                return JsonSerializer.Deserialize<List<Pasajero>>(json) ?? new List<Pasajero>();
            }
            catch
            {
                return new List<Pasajero>();
            }
        }

        public static void GuardarLista(List<Pasajero> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public string MostrarInfo()
        {
            return $"Pasajero {Id} - {Nombre} {Apellido}, {Nacionalidad}";
        }
    }
}