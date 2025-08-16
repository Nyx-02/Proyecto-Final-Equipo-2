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
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El ID debe tener al menos 3 caracteres.");
                if (value.Length > 10) throw new ArgumentException("El ID no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) throw new ArgumentException("El ID solo puede contener letras mayúsculas y números.");
                if (value.StartsWith("0")) throw new ArgumentException("El ID no puede iniciar con 0.");
                if (value.Contains(" ")) throw new ArgumentException("El ID no puede contener espacios.");
                if (value.Any(char.IsLower)) throw new ArgumentException("El ID no puede tener letras minúsculas.");
                _id = value;
            }
        }
        private string _id;

        public string IdReserva
        {
            get => _idReserva;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID de reserva no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El ID de reserva debe tener al menos 3 caracteres.");
                if (value.Length > 12) throw new ArgumentException("El ID de reserva no puede tener más de 12 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) throw new ArgumentException("El ID de reserva debe contener solo letras mayúsculas y números.");
                if (value.Contains(" ")) throw new ArgumentException("El ID de reserva no puede contener espacios.");
                if (value.StartsWith("0")) throw new ArgumentException("El ID de reserva no puede iniciar con 0.");
                if (value.Any(char.IsLower)) throw new ArgumentException("El ID de reserva no puede tener letras minúsculas.");
                _idReserva = value;
            }
        }
        private string _idReserva;

        public string IdPasajero
        {
            get => _idPasajero;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID del pasajero no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El ID del pasajero debe tener al menos 3 caracteres.");
                if (value.Length > 12) throw new ArgumentException("El ID del pasajero no puede tener más de 12 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) throw new ArgumentException("El ID del pasajero debe contener solo letras mayúsculas y números.");
                if (value.Contains(" ")) throw new ArgumentException("El ID del pasajero no puede contener espacios.");
                if (value.StartsWith("0")) throw new ArgumentException("El ID del pasajero no puede iniciar con 0.");
                if (value.Any(char.IsLower)) throw new ArgumentException("El ID del pasajero no puede tener letras minúsculas.");
                _idPasajero = value;
            }
        }
        private string _idPasajero;

        public string IdVuelo
        {
            get => _idVuelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID del vuelo no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El ID del vuelo debe tener al menos 3 caracteres.");
                if (value.Length > 12) throw new ArgumentException("El ID del vuelo no puede tener más de 12 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) throw new ArgumentException("El ID del vuelo debe contener solo letras mayúsculas y números.");
                if (value.Contains(" ")) throw new ArgumentException("El ID del vuelo no puede contener espacios.");
                if (value.StartsWith("0")) throw new ArgumentException("El ID del vuelo no puede iniciar con 0.");
                if (value.Any(char.IsLower)) throw new ArgumentException("El ID del vuelo no puede tener letras minúsculas.");
                _idVuelo = value;
            }
        }
        private string _idVuelo;

        public string Facturado
        {
            get => _facturado;
            set
            {
                string[] valoresValidos = { "SI", "NO" };
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El campo Facturado no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("Facturado debe tener al menos 2 caracteres.");
                if (value.Length > 2) throw new ArgumentException("Facturado no puede tener más de 2 caracteres.");
                if (!valoresValidos.Contains(value.ToUpper())) throw new ArgumentException("Facturado debe ser 'SI' o 'NO'.");
                if (value.StartsWith(" ")) throw new ArgumentException("Facturado no puede iniciar con espacio.");
                if (value.EndsWith(" ")) throw new ArgumentException("Facturado no puede terminar con espacio.");
                if (value.Any(char.IsDigit)) throw new ArgumentException("Facturado no puede contener números.");
                _facturado = value.ToUpper();
            }
        }
        private string _facturado;

        public string Estado
        {
            get => _estado;
            set
            {
                string[] estadosValidos = { "Pendiente", "Completado", "Cancelado" };
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El estado no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El estado debe tener al menos 3 caracteres.");
                if (value.Length > 20) throw new ArgumentException("El estado no puede tener más de 20 caracteres.");
                if (!estadosValidos.Contains(value)) throw new ArgumentException("El estado debe ser Pendiente, Completado o Cancelado.");
                if (value.StartsWith(" ")) throw new ArgumentException("El estado no puede iniciar con espacio.");
                if (value.EndsWith(" ")) throw new ArgumentException("El estado no puede terminar con espacio.");
                if (value.Any(char.IsDigit)) throw new ArgumentException("El estado no puede contener números.");
                _estado = value;
            }
        }
        private string _estado;

        public DateTime Fecha
        {
            get => _fecha;
            set
            {
                if (value == default) throw new ArgumentException("La fecha no puede estar vacía.");
                if (value < DateTime.Today.AddYears(-1)) throw new ArgumentException("La fecha no puede ser más antigua de un año.");
                if (value > DateTime.Today.AddDays(1)) throw new ArgumentException("La fecha no puede ser futura.");
                if (value.Year < 2000) throw new ArgumentException("La fecha no puede ser anterior al año 2000.");
                if (value.DayOfWeek == DayOfWeek.Sunday) throw new ArgumentException("La fecha no puede ser domingo.");
                if (value.Month == 2 && value.Day > 29) throw new ArgumentException("Fecha inválida para febrero.");
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29) throw new ArgumentException("El año no es bisiesto.");
                _fecha = value;
            }
        }
        private DateTime _fecha;

        private static string filePath = "checkins.json";

        public static void Guardar(CheckIn obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static List<CheckIn> Leer()
        {
            try
            {
                if (!File.Exists(filePath)) return new List<CheckIn>();
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) return new List<CheckIn>();
                return JsonSerializer.Deserialize<List<CheckIn>>(json) ?? new List<CheckIn>();
            }
            catch
            {
                return new List<CheckIn>();
            }
        }

        public static void GuardarLista(List<CheckIn> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public string MostrarInfo()
        {
            return $"CheckIn {Id} - Reserva {IdReserva}, Pasajero {IdPasajero}, Vuelo {IdVuelo}, Facturado {Facturado}, Estado {Estado}, Fecha {Fecha.ToShortDateString()}";
        }
    }
}