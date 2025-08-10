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
        // Propiedad Id
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El ID debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 10)
                    throw new ArgumentException("El ID no puede tener más de 10 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]+$"))
                    throw new ArgumentException("El ID solo puede contener letras y números."); // Solo alfanumérico
                if (value.Contains(" "))
                    throw new ArgumentException("El ID no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID no puede iniciar con 0."); // No iniciar con cero
                if (value != value.ToUpper())
                    throw new ArgumentException("El ID debe estar en mayúsculas."); // Solo mayúsculas

                _id = value;
            }
        }
        private string _id;

        // Propiedad Nombre
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("El nombre debe tener al menos 2 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El nombre no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El nombre solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El nombre no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El nombre no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El nombre no puede terminar con espacio."); // Sin espacio final

                _nombre = value;
            }
        }
        private string _nombre;

        // Propiedad Pais
        public string Pais
        {
            get => _pais;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El país no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El país debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El país no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El país solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El país no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El país no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El país no puede terminar con espacio."); // Sin espacio final

                _pais = value;
            }
        }
        private string _pais;

        // Propiedad Telefono
        public string Telefono
        {
            get => _telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El teléfono no puede estar vacío."); // No vacío
                if (!Regex.IsMatch(value, @"^[0-9]+$"))
                    throw new ArgumentException("El teléfono solo puede contener números."); // Solo números
                if (value.Length < 8)
                    throw new ArgumentException("El teléfono debe tener al menos 8 dígitos."); // Mínimo de dígitos
                if (value.Length > 15)
                    throw new ArgumentException("El teléfono no puede tener más de 15 dígitos."); // Máximo de dígitos
                if (value.StartsWith("0"))
                    throw new ArgumentException("El teléfono no puede iniciar con 0."); // No iniciar con cero
                if (value.Contains(" "))
                    throw new ArgumentException("El teléfono no puede contener espacios."); // Sin espacios
                if (value.Any(char.IsLetter))
                    throw new ArgumentException("El teléfono no puede contener letras."); // Sin letras

                _telefono = value;
            }
        }
        private string _telefono;

        // Propiedad Email
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El email no puede estar vacío."); // No vacío
                if (value.Length < 5)
                    throw new ArgumentException("El email debe tener al menos 5 caracteres."); // Mínimo de caracteres
                if (value.Length > 100)
                    throw new ArgumentException("El email no puede tener más de 100 caracteres."); // Máximo de caracteres
                if (!value.Contains("@"))
                    throw new ArgumentException("El email debe contener '@'."); // Contener arroba
                if (!value.Contains("."))
                    throw new ArgumentException("El email debe contener un punto."); // Contener punto
                if (value.StartsWith(" "))
                    throw new ArgumentException("El email no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El email no puede terminar con espacio."); // Sin espacio final

                _email = value;
            }
        }
        private string _email;

        // Propiedad Direccion
        public string Direccion
        {
            get => _direccion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La dirección no puede estar vacía."); // No vacío
                if (value.Length < 5)
                    throw new ArgumentException("La dirección debe tener al menos 5 caracteres."); // Mínimo de caracteres
                if (value.Length > 100)
                    throw new ArgumentException("La dirección no puede tener más de 100 caracteres."); // Máximo de caracteres
                if (value.StartsWith(" "))
                    throw new ArgumentException("La dirección no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("La dirección no puede terminar con espacio."); // Sin espacio final
                if (value.Count(char.IsLetterOrDigit) < 3)
                    throw new ArgumentException("La dirección debe contener al menos 3 caracteres alfanuméricos."); // Contenido
                if (value.Contains("@"))
                    throw new ArgumentException("La dirección no puede contener '@'."); // Sin caracteres inválidos

                _direccion = value;
            }
        }
        private string _direccion;

        // Propiedad SitioWeb
        public string SitioWeb
        {
            get => _sitioWeb;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El sitio web no puede estar vacío."); // No vacío
                if (value.Length < 5)
                    throw new ArgumentException("El sitio web debe tener al menos 5 caracteres."); // Mínimo de caracteres
                if (value.Length > 100)
                    throw new ArgumentException("El sitio web no puede tener más de 100 caracteres."); // Máximo de caracteres
                if (!value.StartsWith("http://") && !value.StartsWith("https://"))
                    throw new ArgumentException("El sitio web debe iniciar con http:// o https://"); // Validar protocolo
                if (!value.Contains("."))
                    throw new ArgumentException("El sitio web debe contener un punto."); // Contener punto
                if (value.Contains(" "))
                    throw new ArgumentException("El sitio web no puede contener espacios."); // Sin espacios
                if (value.EndsWith("."))
                    throw new ArgumentException("El sitio web no puede terminar con punto."); // No terminar en punto

                _sitioWeb = value;
            }
        }
        private string _sitioWeb;

        // Propiedad CodigoIATA
        public string CodigoIATA
        {
            get => _codigoIATA;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código IATA no puede estar vacío."); // No vacío
                if (value.Length != 2 && value.Length != 3)
                    throw new ArgumentException("El código IATA debe tener 2 o 3 caracteres."); // Longitud fija
                if (!Regex.IsMatch(value, @"^[A-Z]+$"))
                    throw new ArgumentException("El código IATA solo puede contener letras mayúsculas."); // Solo mayúsculas
                if (value.Contains(" "))
                    throw new ArgumentException("El código IATA no puede contener espacios."); // Sin espacios
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El código IATA no puede contener números."); // Sin números
                if (value.StartsWith("X"))
                    throw new ArgumentException("El código IATA no puede iniciar con X."); // Restricción de letra inicial
                if (value.EndsWith("Z"))
                    throw new ArgumentException("El código IATA no puede terminar con Z."); // Restricción de letra final

                _codigoIATA = value;
            }
        }
        private string _codigoIATA;

        // Métodos estáticos
        private static string filePath = "aerolineas.json";

        public static void Guardar(Aerolinea obj)
        {
            List<Aerolinea> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Aerolinea> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Aerolinea>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Aerolinea>>(json);
        }

        public string MostrarInfo()
        {
            return $"Aerolínea {Id} - {Nombre} ({Pais})";
        }
    }
}