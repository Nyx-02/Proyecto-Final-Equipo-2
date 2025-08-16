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

                _id = value;
            }
        }
        private string _id;

        public string Origen
        {
            get => _origen;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Origen no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El Origen debe tener al menos 3 caracteres.");
                if (value.Length > 50)
                    throw new ArgumentException("El Origen no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El Origen solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El Origen no puede contener números.");
                if (value.StartsWith(" ") || value.EndsWith(" "))
                    throw new ArgumentException("El Origen no puede iniciar o terminar con espacio.");

                _origen = value;
            }
        }
        private string _origen;

        public string Destino
        {
            get => _destino;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Destino no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El Destino debe tener al menos 3 caracteres.");
                if (value.Length > 50)
                    throw new ArgumentException("El Destino no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El Destino solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El Destino no puede contener números.");
                if (value.StartsWith(" ") || value.EndsWith(" "))
                    throw new ArgumentException("El Destino no puede iniciar o terminar con espacio.");

                _destino = value;
            }
        }
        private string _destino;

        public DateTime Fecha
        {
            get => _fecha;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha no puede estar vacía.");
                if (value.Year < 2000)
                    throw new ArgumentException("La fecha no puede ser anterior al año 2000.");
                if (value.Year > DateTime.Now.Year + 5)
                    throw new ArgumentException("La fecha no puede ser demasiado futura.");
                if (value.Date < DateTime.Today)
                    throw new ArgumentException("La fecha no puede ser en el pasado.");
                if (value.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se permiten vuelos en domingo.");
                if (value.Month == 2 && value.Day > 29)
                    throw new ArgumentException("Fecha inválida para febrero.");
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29)
                    throw new ArgumentException("El año no es bisiesto.");

                _fecha = value;
            }
        }
        private DateTime _fecha;

        public DateTime HoraSalida
        {
            get => _horaSalida;
            set
            {
                if (value == default)
                    throw new ArgumentException("La hora de salida no puede estar vacía.");
                if (value < Fecha)
                    throw new ArgumentException("La hora de salida no puede ser antes de la fecha del vuelo.");
                if (value.Hour < 5 || value.Hour > 23)
                    throw new ArgumentException("La hora de salida debe estar entre las 5 AM y 11 PM.");

                _horaSalida = value;
            }
        }
        private DateTime _horaSalida;

        public DateTime HoraLlegada
        {
            get => _horaLlegada;
            set
            {
                if (value == default)
                    throw new ArgumentException("La hora de llegada no puede estar vacía.");
                if (value < HoraSalida)
                    throw new ArgumentException("La hora de llegada no puede ser antes de la salida.");
                if (value.Date != Fecha.Date)
                    throw new ArgumentException("La hora de llegada debe ser el mismo día del vuelo.");
                if ((value - HoraSalida).TotalMinutes < 30)
                    throw new ArgumentException("El vuelo debe durar al menos 30 minutos.");
                if ((value - HoraSalida).TotalHours > 24)
                    throw new ArgumentException("El vuelo no puede durar más de 24 horas.");

                _horaLlegada = value;
            }
        }
        private DateTime _horaLlegada;

        public string Aerolinea
        {
            get => _aerolinea;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La aerolínea no puede estar vacía.");
                if (value.Length < 2)
                    throw new ArgumentException("La aerolínea debe tener al menos 2 caracteres.");
                if (value.Length > 50)
                    throw new ArgumentException("La aerolínea no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("La aerolínea solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("La aerolínea no puede contener números.");
                if (value.StartsWith(" ") || value.EndsWith(" "))
                    throw new ArgumentException("La aerolínea no puede iniciar o terminar con espacio.");

                _aerolinea = value;
            }
        }
        private string _aerolinea;

        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El estado no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El estado debe tener al menos 3 caracteres.");
                if (value.Length > 20)
                    throw new ArgumentException("El estado no puede tener más de 20 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El estado solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El estado no puede contener números.");
                if (value.StartsWith(" ") || value.EndsWith(" "))
                    throw new ArgumentException("El estado no puede iniciar o terminar con espacio.");

                _estado = value;
            }
        }
        private string _estado;

        private static string filePath = "vuelos.json";

        public static void Guardar(Vuelo obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static void GuardarLista(List<Vuelo> lista)
        {
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
            return $"Vuelo {Id} - {Origen} a {Destino} el {Fecha:dd/MM/yyyy}";
        }
    }
}