using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Mantenimiento
    {
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El ID debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 10)
                    throw new ArgumentException("El ID no puede tener más de 10 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El ID solo puede contener letras mayúsculas y números."); // Formato
                if (value.Contains(" "))
                    throw new ArgumentException("El ID no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID no puede iniciar con 0."); // Sin ceros iniciales
                if (value.Any(char.IsLower))
                    throw new ArgumentException("El ID no puede contener letras minúsculas."); // Sin minúsculas

                _id = value;
            }
        }
        private string _id;

        public string Tipo
        {
            get => _tipo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El tipo no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El tipo debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 30)
                    throw new ArgumentException("El tipo no puede tener más de 30 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El tipo solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El tipo no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El tipo no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El tipo no puede terminar con espacio."); // Sin espacio final

                _tipo = value;
            }
        }
        private string _tipo;

        public string Descripcion
        {
            get => _descripcion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La descripción no puede estar vacía."); // No vacío
                if (value.Length < 5)
                    throw new ArgumentException("La descripción debe tener al menos 5 caracteres."); // Mínimo
                if (value.Length > 200)
                    throw new ArgumentException("La descripción no puede tener más de 200 caracteres."); // Máximo
                if (value.StartsWith(" "))
                    throw new ArgumentException("La descripción no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("La descripción no puede terminar con espacio."); // Sin espacio final
                if (value.Count(char.IsLetterOrDigit) < 3)
                    throw new ArgumentException("La descripción debe contener al menos 3 caracteres alfanuméricos."); // Contenido mínimo
                if (value.Contains("@"))
                    throw new ArgumentException("La descripción no puede contener '@'."); // Sin caracteres inválidos

                _descripcion = value;
            }
        }
        private string _descripcion;

        public DateTime Fecha
        {
            get => _fecha;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha no puede estar vacía."); // No vacío
                if (value.Year < 2000)
                    throw new ArgumentException("La fecha no puede ser anterior al año 2000."); // Año mínimo
                if (value > DateTime.Today.AddYears(1))
                    throw new ArgumentException("La fecha no puede ser más de 1 año en el futuro."); // Año máximo
                if (value.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se permite mantenimiento los domingos."); // Restricción
                if (value.Month == 2 && value.Day > 29)
                    throw new ArgumentException("Fecha inválida para febrero."); // Validación febrero
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29)
                    throw new ArgumentException("El año no es bisiesto."); // Año bisiesto
                if (value.Date < DateTime.Today.AddYears(-1))
                    throw new ArgumentException("La fecha no puede ser más de 1 año en el pasado."); // Pasado límite

                _fecha = value;
            }
        }
        private DateTime _fecha;

        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El estado no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El estado debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 20)
                    throw new ArgumentException("El estado no puede tener más de 20 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El estado solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El estado no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El estado no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El estado no puede terminar con espacio."); // Sin espacio final

                _estado = value;
            }
        }
        private string _estado;

        public decimal Costo
        {
            get => _costo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El costo debe ser mayor que 0."); // Positivo
                if (value < 50)
                    throw new ArgumentException("El costo mínimo es de 50."); // Mínimo
                if (value > 100000)
                    throw new ArgumentException("El costo no puede ser mayor de 100000."); // Máximo
                if (decimal.Round(value, 2) != value)
                    throw new ArgumentException("El costo solo puede tener dos decimales."); // Decimales
                if (value % 10 != 0)
                    throw new ArgumentException("El costo debe ser múltiplo de 10."); // Múltiplo
                if (value < 0)
                    throw new ArgumentException("El costo no puede ser negativo."); // No negativo
                if (value > 50000 && Estado.ToLower() == "pendiente")
                    throw new ArgumentException("Un mantenimiento pendiente no puede costar más de 50000."); // Lógica

                _costo = value;
            }
        }
        private decimal _costo;

        public string Responsable
        {
            get => _responsable;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El responsable no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El responsable debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 50)
                    throw new ArgumentException("El responsable no puede tener más de 50 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El responsable solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El responsable no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El responsable no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El responsable no puede terminar con espacio."); // Sin espacio final

                _responsable = value;
            }
        }
        private string _responsable;

        public string Ubicacion
        {
            get => _ubicacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La ubicación no puede estar vacía."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("La ubicación debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 50)
                    throw new ArgumentException("La ubicación no puede tener más de 50 caracteres."); // Máximo
                if (value.StartsWith(" "))
                    throw new ArgumentException("La ubicación no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("La ubicación no puede terminar con espacio."); // Sin espacio final
                if (value.Count(char.IsLetterOrDigit) < 3)
                    throw new ArgumentException("La ubicación debe contener al menos 3 caracteres alfanuméricos."); // Contenido mínimo
                if (value.Contains("@"))
                    throw new ArgumentException("La ubicación no puede contener '@'."); // Sin caracteres inválidos

                _ubicacion = value;
            }
        }
        private string _ubicacion;

        private static string filePath = "mantenimientos.json";

        public static void Guardar(Mantenimiento obj)
        {
            List<Mantenimiento> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Mantenimiento> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Mantenimiento>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Mantenimiento>>(json);
        }

        public string MostrarInfo()
        {
            return $"Mantenimiento {Id} - Tipo: {Tipo}, Estado: {Estado}";
        }
    }
}