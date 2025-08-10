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

        // Propiedad Apellido
        public string Apellido
        {
            get => _apellido;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido no puede estar vacío."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("El apellido debe tener al menos 2 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El apellido no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El apellido solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El apellido no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El apellido no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El apellido no puede terminar con espacio."); // Sin espacio final

                _apellido = value;
            }
        }
        private string _apellido;

        // Propiedad FechaNacimiento
        public DateTime FechaNacimiento
        {
            get => _fechaNacimiento;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha de nacimiento no puede estar vacía."); // No vacío
                if (value.Year < 1900)
                    throw new ArgumentException("La fecha de nacimiento no puede ser anterior a 1900."); // Año mínimo
                if (value > DateTime.Today)
                    throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro."); // Sin fecha futura
                if ((DateTime.Today.Year - value.Year) < 0)
                    throw new ArgumentException("Edad inválida."); // Lógica de edad
                if ((DateTime.Today.Year - value.Year) > 120)
                    throw new ArgumentException("Edad demasiado alta."); // Edad máxima
                if (value.Month < 1 || value.Month > 12)
                    throw new ArgumentException("Mes inválido."); // Mes válido
                if (value.Day < 1 || value.Day > DateTime.DaysInMonth(value.Year, value.Month))
                    throw new ArgumentException("Día inválido para el mes indicado."); // Día válido

                _fechaNacimiento = value;
            }
        }
        private DateTime _fechaNacimiento;

        // Propiedad Nacionalidad
        public string Nacionalidad
        {
            get => _nacionalidad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La nacionalidad no puede estar vacía."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("La nacionalidad debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("La nacionalidad no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("La nacionalidad solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("La nacionalidad no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("La nacionalidad no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("La nacionalidad no puede terminar con espacio."); // Sin espacio final

                _nacionalidad = value;
            }
        }
        private string _nacionalidad;

        // Propiedad Pasaporte
        public string Pasaporte
        {
            get => _pasaporte;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El pasaporte no puede estar vacío."); // No vacío
                if (value.Length < 6)
                    throw new ArgumentException("El pasaporte debe tener al menos 6 caracteres."); // Mínimo de caracteres
                if (value.Length > 9)
                    throw new ArgumentException("El pasaporte no puede tener más de 9 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]+$"))
                    throw new ArgumentException("El pasaporte solo puede contener letras y números."); // Solo alfanumérico
                if (value.Any(char.IsWhiteSpace))
                    throw new ArgumentException("El pasaporte no puede contener espacios."); // Sin espacios
                if (value != value.ToUpper())
                    throw new ArgumentException("El pasaporte debe estar en mayúsculas."); // Solo mayúsculas
                if (value.StartsWith("0"))
                    throw new ArgumentException("El pasaporte no puede iniciar con 0."); // No iniciar con cero

                _pasaporte = value;
            }
        }
        private string _pasaporte;

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

        // Métodos estáticos
        private static string filePath = "pasajeros.json";

        public static void Guardar(Pasajero obj)
        {
            List<Pasajero> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Pasajero> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Pasajero>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Pasajero>>(json);
        }

        public string MostrarInfo()
        {
            return $"Pasajero {Id} - {Nombre} {Apellido}, {Nacionalidad}";
        }
    }
}