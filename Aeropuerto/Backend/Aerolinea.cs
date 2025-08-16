using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Aerolinea
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
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El ID solo puede contener letras mayúsculas y números.");
                if (value.Contains(" "))
                    throw new ArgumentException("El ID no puede contener espacios.");
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID no puede iniciar con 0.");
                if (value.Any(char.IsLower))
                    throw new ArgumentException("El ID no puede tener letras minúsculas.");

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
                if (!Regex.IsMatch(value, @"^[A-Za-záéíóúñÑ\s]+$"))
                    throw new ArgumentException("El nombre solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El nombre no puede contener números.");
                if (value.StartsWith(" "))
                    throw new ArgumentException("El nombre no puede iniciar con espacio.");
                if (value.EndsWith(" "))
                    throw new ArgumentException("El nombre no puede terminar con espacio.");

                _nombre = value;
            }
        }
        private string _nombre;

        public string Pais
        {
            get => _pais;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El país no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El país debe tener al menos 3 caracteres.");
                if (value.Length > 50)
                    throw new ArgumentException("El país no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-záéíóúñÑ\s]+$"))
                    throw new ArgumentException("El país solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El país no puede contener números.");
                if (value.StartsWith(" "))
                    throw new ArgumentException("El país no puede iniciar con espacio.");
                if (value.EndsWith(" "))
                    throw new ArgumentException("El país no puede terminar con espacio.");

                _pais = value;
            }
        }
        private string _pais;

        public string Telefono
        {
            get => _telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El teléfono no puede estar vacío.");
                if (value.Length < 8)
                    throw new ArgumentException("El teléfono debe tener al menos 8 dígitos.");
                if (value.Length > 15)
                    throw new ArgumentException("El teléfono no puede tener más de 15 dígitos.");
                if (!Regex.IsMatch(value, @"^[0-9]+$"))
                    throw new ArgumentException("El teléfono solo puede contener números.");
                if (value.StartsWith("0"))
                    throw new ArgumentException("El teléfono no puede iniciar con 0.");
                if (value.Contains(" "))
                    throw new ArgumentException("El teléfono no puede contener espacios.");
                if (value.Any(char.IsLetter))
                    throw new ArgumentException("El teléfono no puede contener letras.");

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
                if (!value.Contains("@"))
                    throw new ArgumentException("El email debe contener '@'.");
                if (!value.Contains("."))
                    throw new ArgumentException("El email debe contener un punto.");
                if (value.StartsWith(" "))
                    throw new ArgumentException("El email no puede iniciar con espacio.");
                if (value.EndsWith(" "))
                    throw new ArgumentException("El email no puede terminar con espacio.");

                _email = value;
            }
        }
        private string _email;

        public string Direccion
        {
            get => _direccion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La dirección no puede estar vacía.");
                if (value.Length < 5)
                    throw new ArgumentException("La dirección debe tener al menos 5 caracteres.");
                if (value.Length > 100)
                    throw new ArgumentException("La dirección no puede tener más de 100 caracteres.");
                if (value.StartsWith(" "))
                    throw new ArgumentException("La dirección no puede iniciar con espacio.");
                if (value.EndsWith(" "))
                    throw new ArgumentException("La dirección no puede terminar con espacio.");
                if (value.Count(char.IsLetterOrDigit) < 3)
                    throw new ArgumentException("La dirección debe contener al menos 3 caracteres alfanuméricos.");
                if (value.Contains("@"))
                    throw new ArgumentException("La dirección no puede contener '@'.");

                _direccion = value;
            }
        }
        private string _direccion;

        public string SitioWeb
        {
            get => _sitioWeb;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El sitio web no puede estar vacío.");
                if (value.Length < 5)
                    throw new ArgumentException("El sitio web debe tener al menos 5 caracteres.");
                if (value.Length > 100)
                    throw new ArgumentException("El sitio web no puede tener más de 100 caracteres.");
                if (!value.StartsWith("http://") && !value.StartsWith("https://"))
                    throw new ArgumentException("El sitio web debe iniciar con http:// o https://");
                if (!value.Contains("."))
                    throw new ArgumentException("El sitio web debe contener un punto.");
                if (value.Contains(" "))
                    throw new ArgumentException("El sitio web no puede contener espacios.");
                if (value.EndsWith("."))
                    throw new ArgumentException("El sitio web no puede terminar con punto.");

                _sitioWeb = value;
            }
        }
        private string _sitioWeb;

        public string CodigoIATA
        {
            get => _codigoIATA;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código IATA no puede estar vacío.");
                if (value.Length != 2)
                    throw new ArgumentException("El código IATA debe tener exactamente 2 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z]+$"))
                    throw new ArgumentException("El código IATA solo puede contener letras mayúsculas.");
                if (value.Contains(" "))
                    throw new ArgumentException("El código IATA no puede contener espacios.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El código IATA no puede contener números.");
                if (value.StartsWith("X"))
                    throw new ArgumentException("El código IATA no puede iniciar con X.");
                if (value.EndsWith("Z"))
                    throw new ArgumentException("El código IATA no puede terminar con Z.");

                _codigoIATA = value;
            }
        }
        private string _codigoIATA;

        private static string filePath = "aerolineas.json";

        public static void Guardar(Aerolinea obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static void GuardarLista(List<Aerolinea> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Aerolinea> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Aerolinea>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Aerolinea>>(json) ?? new List<Aerolinea>();
        }

        public string MostrarInfo()
        {
            return $"Aerolínea {Id} - {Nombre} ({CodigoIATA}) | Tel: {Telefono}";
        }
    }
}