using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Itinerario
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

        // Propiedad Origen
        public string Origen
        {
            get => _origen;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El origen no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El origen debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 50)
                    throw new ArgumentException("El origen no puede tener más de 50 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El origen solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El origen no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El origen no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El origen no puede terminar con espacio."); // Sin espacio final

                _origen = value;
            }
        }
        private string _origen;

        // Propiedad Destino
        public string Destino
        {
            get => _destino;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El destino no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El destino debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 50)
                    throw new ArgumentException("El destino no puede tener más de 50 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El destino solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El destino no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El destino no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El destino no puede terminar con espacio."); // Sin espacio final

                _destino = value;
            }
        }
        private string _destino;

        // Propiedad FechaSalida
        public DateTime FechaSalida
        {
            get => _fechaSalida;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha de salida no puede estar vacía."); // No vacío
                if (value < DateTime.Today)
                    throw new ArgumentException("La fecha de salida no puede ser anterior a hoy."); // No pasado
                if (value > DateTime.Today.AddYears(2))
                    throw new ArgumentException("La fecha de salida no puede ser más de 2 años en el futuro."); // Límite
                if (value.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se permiten salidas en domingo."); // Restricción
                if (value.Month == 2 && value.Day > 29)
                    throw new ArgumentException("Fecha inválida para febrero."); // Validación febrero
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29)
                    throw new ArgumentException("El año no es bisiesto."); // Año bisiesto
                if (FechaLlegada != default && value >= FechaLlegada)
                    throw new ArgumentException("La fecha de salida debe ser antes que la de llegada."); // Lógica

                _fechaSalida = value;
            }
        }
        private DateTime _fechaSalida;

        // Propiedad FechaLlegada
        public DateTime FechaLlegada
        {
            get => _fechaLlegada;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha de llegada no puede estar vacía."); // No vacío
                if (value < DateTime.Today)
                    throw new ArgumentException("La fecha de llegada no puede ser anterior a hoy."); // No pasado
                if (value > DateTime.Today.AddYears(2))
                    throw new ArgumentException("La fecha de llegada no puede ser más de 2 años en el futuro."); // Límite
                if (value < FechaSalida)
                    throw new ArgumentException("La fecha de llegada debe ser posterior a la de salida."); // Lógica
                if (value.Month == 2 && value.Day > 29)
                    throw new ArgumentException("Fecha inválida para febrero."); // Validación febrero
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29)
                    throw new ArgumentException("El año no es bisiesto."); // Año bisiesto
                if (value.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se permiten llegadas en domingo."); // Restricción

                _fechaLlegada = value;
            }
        }
        private DateTime _fechaLlegada;

        // Propiedad Aerolinea
        public string Aerolinea
        {
            get => _aerolinea;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La aerolínea no puede estar vacía."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("La aerolínea debe tener al menos 2 caracteres."); // Mínimo
                if (value.Length > 50)
                    throw new ArgumentException("La aerolínea no puede tener más de 50 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("La aerolínea solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("La aerolínea no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("La aerolínea no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("La aerolínea no puede terminar con espacio."); // Sin espacio final

                _aerolinea = value;
            }
        }
        private string _aerolinea;

        // Propiedad NumeroVuelo
        public string NumeroVuelo
        {
            get => _numeroVuelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El número de vuelo no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El número de vuelo debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 10)
                    throw new ArgumentException("El número de vuelo no puede tener más de 10 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El número de vuelo solo puede contener letras mayúsculas y números."); // Formato
                if (value.Contains(" "))
                    throw new ArgumentException("El número de vuelo no puede contener espacios."); // Sin espacios
                if (value.Any(char.IsLower))
                    throw new ArgumentException("El número de vuelo no puede contener minúsculas."); // Sin minúsculas
                if (value.StartsWith("0"))
                    throw new ArgumentException("El número de vuelo no puede iniciar con 0."); // Sin ceros iniciales

                _numeroVuelo = value;
            }
        }
        private string _numeroVuelo;

        // Propiedad Estado
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

        // Métodos estáticos
        private static string filePath = "itinerarios.json";

        public static void Guardar(Itinerario obj)
        {
            List<Itinerario> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Itinerario> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Itinerario>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Itinerario>>(json);
        }

        public string MostrarInfo()
        {
            return $"Itinerario {Id} - {Origen} -> {Destino}, {Estado}";
        }
    }
}