using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Vuelo
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

        // Propiedad Origen
        public string Origen
        {
            get => _origen;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Origen no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El Origen debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El Origen no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El Origen solo puede contener letras."); // Solo letras
                if (value.StartsWith(" "))
                    throw new ArgumentException("El Origen no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El Origen no puede terminar con espacio."); // Sin espacio final
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El Origen no puede contener números."); // Sin números

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
                    throw new ArgumentException("El Destino no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El Destino debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El Destino no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El Destino solo puede contener letras."); // Solo letras
                if (value.StartsWith(" "))
                    throw new ArgumentException("El Destino no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El Destino no puede terminar con espacio."); // Sin espacio final
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El Destino no puede contener números."); // Sin números

                _destino = value;
            }
        }
        private string _destino;

        // Propiedad Fecha
        public DateTime Fecha
        {
            get => _fecha;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha no puede estar vacía."); // No vacío
                if (value.Year < 2000)
                    throw new ArgumentException("La fecha no puede ser anterior al año 2000."); // Año mínimo
                if (value.Year > DateTime.Now.Year + 5)
                    throw new ArgumentException("La fecha no puede ser demasiado futura."); // Año máximo
                if (value.Date < DateTime.Today)
                    throw new ArgumentException("La fecha no puede ser en el pasado."); // Sin fecha pasada
                if (value.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se permiten vuelos en domingo."); // Restricción día
                if (value.Month == 2 && value.Day > 29)
                    throw new ArgumentException("Fecha inválida para febrero."); // Validación febrero
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29)
                    throw new ArgumentException("El año no es bisiesto."); // Año bisiesto

                _fecha = value;
            }
        }
        private DateTime _fecha;

        // Propiedad HoraSalida
        public DateTime HoraSalida
        {
            get => _horaSalida;
            set
            {
                if (value == default)
                    throw new ArgumentException("La hora de salida no puede estar vacía."); // No vacío
                if (value < DateTime.Today)
                    throw new ArgumentException("La hora de salida no puede ser en el pasado."); // Sin hora pasada
                if (value.Hour < 0 || value.Hour > 23)
                    throw new ArgumentException("Hora inválida."); // Hora válida
                if (value.Minute < 0 || value.Minute > 59)
                    throw new ArgumentException("Minutos inválidos."); // Minuto válido
                if (value < Fecha)
                    throw new ArgumentException("La hora de salida no puede ser antes de la fecha del vuelo."); // Lógica fecha
                if (value.Hour < 5)
                    throw new ArgumentException("No se permiten vuelos antes de las 5 AM."); // Restricción horaria
                if (value.Hour > 23)
                    throw new ArgumentException("No se permiten vuelos después de las 11 PM."); // Restricción horaria

                _horaSalida = value;
            }
        }
        private DateTime _horaSalida;

        // Propiedad HoraLlegada
        public DateTime HoraLlegada
        {
            get => _horaLlegada;
            set
            {
                if (value == default)
                    throw new ArgumentException("La hora de llegada no puede estar vacía."); // No vacío
                if (value < HoraSalida)
                    throw new ArgumentException("La hora de llegada no puede ser antes de la salida."); // Lógica
                if (value.Hour < 0 || value.Hour > 23)
                    throw new ArgumentException("Hora inválida."); // Hora válida
                if (value.Minute < 0 || value.Minute > 59)
                    throw new ArgumentException("Minutos inválidos."); // Minuto válido
                if (value.Date != Fecha.Date)
                    throw new ArgumentException("La hora de llegada debe ser el mismo día del vuelo."); // Mismo día
                if ((value - HoraSalida).TotalMinutes < 30)
                    throw new ArgumentException("El vuelo debe durar al menos 30 minutos."); // Duración mínima
                if ((value - HoraSalida).TotalHours > 24)
                    throw new ArgumentException("El vuelo no puede durar más de 24 horas."); // Duración máxima

                _horaLlegada = value;
            }
        }
        private DateTime _horaLlegada;

        // Propiedad Aerolinea
        public string Aerolinea
        {
            get => _aerolinea;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La aerolínea no puede estar vacía."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("La aerolínea debe tener al menos 2 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("La aerolínea no puede tener más de 50 caracteres."); // Máximo de caracteres
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

        // Propiedad Estado
        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El estado no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El estado debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 20)
                    throw new ArgumentException("El estado no puede tener más de 20 caracteres."); // Máximo de caracteres
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
        private static string filePath = "vuelos.json";

        public static void Guardar(Vuelo obj)
        {
            List<Vuelo> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Vuelo> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Vuelo>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Vuelo>>(json);
        }

        public string MostrarInfo()
        {
            return $"Vuelo {Id} - {Origen} a {Destino} el {Fecha.ToShortDateString()}";
        }
    }
}