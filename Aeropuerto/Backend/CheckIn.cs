using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class CheckIn
    {
        // ---------------- PROPIEDADES ----------------

        // 1. Id
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // 1
                    throw new ArgumentException("El ID no puede estar vacío.");
                if (value.Length < 3) // 2
                    throw new ArgumentException("El ID debe tener al menos 3 caracteres.");
                if (value.Length > 10) // 3
                    throw new ArgumentException("El ID no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) // 4
                    throw new ArgumentException("El ID solo puede contener letras mayúsculas y números.");
                if (value.StartsWith("0")) // 5
                    throw new ArgumentException("El ID no puede iniciar con 0.");
                if (value.Contains(" ")) // 6
                    throw new ArgumentException("El ID no puede contener espacios.");
                if (value.Any(char.IsLower)) // 7
                    throw new ArgumentException("El ID no puede tener letras minúsculas.");

                _id = value;
            }
        }
        private string _id;

        // 2. IdReserva
        public string IdReserva
        {
            get => _idReserva;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // 1
                    throw new ArgumentException("El ID de reserva no puede estar vacío.");
                if (value.Length < 3) // 2
                    throw new ArgumentException("El ID de reserva debe tener al menos 3 caracteres.");
                if (value.Length > 12) // 3
                    throw new ArgumentException("El ID de reserva no puede tener más de 12 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) // 4
                    throw new ArgumentException("El ID de reserva debe contener solo letras mayúsculas y números.");
                if (value.Contains(" ")) // 5
                    throw new ArgumentException("El ID de reserva no puede contener espacios.");
                if (value.StartsWith("0")) // 6
                    throw new ArgumentException("El ID de reserva no puede iniciar con 0.");
                if (value.Any(char.IsLower)) // 7
                    throw new ArgumentException("El ID de reserva no puede tener minúsculas.");

                _idReserva = value;
            }
        }
        private string _idReserva;

        // 3. IdPasajero
        public string IdPasajero
        {
            get => _idPasajero;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // 1
                    throw new ArgumentException("El ID del pasajero no puede estar vacío.");
                if (value.Length < 3) // 2
                    throw new ArgumentException("El ID del pasajero debe tener al menos 3 caracteres.");
                if (value.Length > 12) // 3
                    throw new ArgumentException("El ID del pasajero no puede tener más de 12 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) // 4
                    throw new ArgumentException("El ID del pasajero debe contener solo letras mayúsculas y números.");
                if (value.Contains(" ")) // 5
                    throw new ArgumentException("El ID del pasajero no puede contener espacios.");
                if (value.StartsWith("0")) // 6
                    throw new ArgumentException("El ID del pasajero no puede iniciar con 0.");
                if (value.Any(char.IsLower)) // 7
                    throw new ArgumentException("El ID del pasajero no puede tener minúsculas.");

                _idPasajero = value;
            }
        }
        private string _idPasajero;

        // 4. IdVuelo
        public string IdVuelo
        {
            get => _idVuelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // 1
                    throw new ArgumentException("El ID del vuelo no puede estar vacío.");
                if (value.Length < 3) // 2
                    throw new ArgumentException("El ID del vuelo debe tener al menos 3 caracteres.");
                if (value.Length > 12) // 3
                    throw new ArgumentException("El ID del vuelo no puede tener más de 12 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) // 4
                    throw new ArgumentException("El ID del vuelo debe contener solo letras mayúsculas y números.");
                if (value.Contains(" ")) // 5
                    throw new ArgumentException("El ID del vuelo no puede contener espacios.");
                if (value.StartsWith("0")) // 6
                    throw new ArgumentException("El ID del vuelo no puede iniciar con 0.");
                if (value.Any(char.IsLower)) // 7
                    throw new ArgumentException("El ID del vuelo no puede tener minúsculas.");

                _idVuelo = value;
            }
        }
        private string _idVuelo;

        // 5. NumeroAsiento
        public string NumeroAsiento
        {
            get => _numeroAsiento;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // 1
                    throw new ArgumentException("El asiento no puede estar vacío.");
                if (value.Length < 2) // 2
                    throw new ArgumentException("El asiento debe tener al menos 2 caracteres.");
                if (value.Length > 4) // 3
                    throw new ArgumentException("El asiento no puede tener más de 4 caracteres.");
                if (!Regex.IsMatch(value, @"^[0-9]+[A-Z]$")) // 4
                    throw new ArgumentException("Formato de asiento inválido (ejemplo: 12A).");
                if (value.StartsWith("0")) // 5
                    throw new ArgumentException("El asiento no puede iniciar en 0.");
                if (value.Contains(" ")) // 6
                    throw new ArgumentException("El asiento no puede contener espacios.");
                if (value.Any(char.IsLower)) // 7
                    throw new ArgumentException("El asiento no puede tener letras minúsculas.");

                _numeroAsiento = value;
            }
        }
        private string _numeroAsiento;

        // 6. Estado
        public string Estado
        {
            get => _estado;
            set
            {
                string[] estadosValidos = { "Pendiente", "Completado", "Cancelado" };

                if (string.IsNullOrWhiteSpace(value)) // 1
                    throw new ArgumentException("El estado no puede estar vacío.");
                if (value.Length < 3) // 2
                    throw new ArgumentException("El estado debe tener al menos 3 caracteres.");
                if (value.Length > 20) // 3
                    throw new ArgumentException("El estado no puede tener más de 20 caracteres.");
                if (!estadosValidos.Contains(value)) // 4
                    throw new ArgumentException("El estado debe ser Pendiente, Completado o Cancelado.");
                if (value.StartsWith(" ")) // 5
                    throw new ArgumentException("El estado no puede iniciar con espacio.");
                if (value.EndsWith(" ")) // 6
                    throw new ArgumentException("El estado no puede terminar con espacio.");
                if (value.Any(char.IsDigit)) // 7
                    throw new ArgumentException("El estado no puede contener números.");

                _estado = value;
            }
        }
        private string _estado;

        // 7. Fecha
        public DateTime Fecha
        {
            get => _fecha;
            set
            {
                if (value == default) // 1
                    throw new ArgumentException("La fecha no puede estar vacía.");
                if (value < DateTime.Today.AddYears(-1)) // 2
                    throw new ArgumentException("La fecha no puede ser más antigua de un año.");
                if (value > DateTime.Today.AddDays(1)) // 3
                    throw new ArgumentException("La fecha no puede ser futura.");
                if (value.Year < 2000) // 4
                    throw new ArgumentException("La fecha no puede ser anterior al año 2000.");
                if (value.DayOfWeek == DayOfWeek.Sunday) // 5
                    throw new ArgumentException("La fecha no puede ser domingo.");
                if (value.Month == 2 && value.Day > 29) // 6
                    throw new ArgumentException("Fecha inválida para febrero.");
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29) // 7
                    throw new ArgumentException("El año no es bisiesto.");

                _fecha = value;
            }
        }
        private DateTime _fecha;

        // ---------------- PERSISTENCIA ----------------

        private static string filePath = "checkins.json";

        public static void Guardar(CheckIn obj)
        {
            List<CheckIn> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<CheckIn> Leer()
        {
            if (!File.Exists(filePath))
                return new List<CheckIn>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<CheckIn>>(json);
        }

        // ---------------- UTILIDAD ----------------
        public string MostrarInfo()
        {
            return $"CheckIn {Id} - Reserva: {IdReserva}, Pasajero: {IdPasajero}, Vuelo: {IdVuelo}, Asiento: {NumeroAsiento}, Estado: {Estado}, Fecha: {Fecha.ToShortDateString()}";
        }
    }
}