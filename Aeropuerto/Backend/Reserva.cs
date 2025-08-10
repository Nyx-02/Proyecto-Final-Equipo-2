using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Reserva
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

        // Propiedad IdPasajero
        public string IdPasajero
        {
            get => _idPasajero;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID del pasajero no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El ID del pasajero debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 10)
                    throw new ArgumentException("El ID del pasajero no puede tener más de 10 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El ID del pasajero solo puede contener letras mayúsculas y números."); // Solo mayúsculas
                if (value.Contains(" "))
                    throw new ArgumentException("El ID del pasajero no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID del pasajero no puede iniciar con 0."); // No iniciar con cero
                if (value == Id)
                    throw new ArgumentException("El ID del pasajero no puede ser igual al ID de la reserva."); // Lógica

                _idPasajero = value;
            }
        }
        private string _idPasajero;

        // Propiedad IdVuelo
        public string IdVuelo
        {
            get => _idVuelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID del vuelo no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El ID del vuelo debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 10)
                    throw new ArgumentException("El ID del vuelo no puede tener más de 10 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El ID del vuelo solo puede contener letras mayúsculas y números."); // Solo mayúsculas
                if (value.Contains(" "))
                    throw new ArgumentException("El ID del vuelo no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID del vuelo no puede iniciar con 0."); // No iniciar con cero
                if (value == Id)
                    throw new ArgumentException("El ID del vuelo no puede ser igual al ID de la reserva."); // Lógica

                _idVuelo = value;
            }
        }
        private string _idVuelo;

        // Propiedad FechaReserva
        public DateTime FechaReserva
        {
            get => _fechaReserva;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha de reserva no puede estar vacía."); // No vacío
                if (value.Year < 2000)
                    throw new ArgumentException("La fecha de reserva no puede ser anterior al año 2000."); // Año mínimo
                if (value > DateTime.Today.AddYears(2))
                    throw new ArgumentException("La fecha de reserva no puede ser más de 2 años en el futuro."); // Año máximo
                if (value.Date < DateTime.Today)
                    throw new ArgumentException("La fecha de reserva no puede ser en el pasado."); // Sin fecha pasada
                if (value.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se pueden hacer reservas los domingos."); // Restricción día
                if (value.Month == 2 && value.Day > 29)
                    throw new ArgumentException("Fecha inválida para febrero."); // Validación febrero
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29)
                    throw new ArgumentException("El año no es bisiesto."); // Año bisiesto

                _fechaReserva = value;
            }
        }
        private DateTime _fechaReserva;

        // Propiedad Asiento
        public string Asiento
        {
            get => _asiento;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El asiento no puede estar vacío."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("El asiento debe tener al menos 2 caracteres."); // Mínimo de caracteres
                if (value.Length > 5)
                    throw new ArgumentException("El asiento no puede tener más de 5 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El asiento solo puede contener letras mayúsculas y números."); // Formato permitido
                if (value.Contains(" "))
                    throw new ArgumentException("El asiento no puede contener espacios."); // Sin espacios
                if (value.Any(char.IsLower))
                    throw new ArgumentException("El asiento no puede contener letras minúsculas."); // Solo mayúsculas
                if (value.StartsWith("0"))
                    throw new ArgumentException("El asiento no puede iniciar con 0."); // No iniciar con cero

                _asiento = value;
            }
        }
        private string _asiento;

        // Propiedad Clase
        public string Clase
        {
            get => _clase;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La clase no puede estar vacía."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("La clase debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 20)
                    throw new ArgumentException("La clase no puede tener más de 20 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("La clase solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("La clase no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("La clase no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("La clase no puede terminar con espacio."); // Sin espacio final

                _clase = value;
            }
        }
        private string _clase;

        // Propiedad Precio
        public decimal Precio
        {
            get => _precio;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que 0."); // Positivo
                if (value < 50)
                    throw new ArgumentException("El precio no puede ser menor a 50."); // Precio mínimo
                if (value > 10000)
                    throw new ArgumentException("El precio no puede superar los 10,000."); // Precio máximo
                if (decimal.Round(value, 2) != value)
                    throw new ArgumentException("El precio solo puede tener dos decimales."); // Decimales
                if (value % 1m != 0m && value % 0.5m != 0m)
                    throw new ArgumentException("El precio debe estar en múltiplos de 0.50."); // Múltiplo válido
                if (value > 0 && value < 100)
                    throw new ArgumentException("Precio demasiado bajo para una reserva."); // Lógica de negocio
                if (value > 5000 && Clase.ToLower().Contains("economica"))
                    throw new ArgumentException("Una clase económica no puede tener precio tan alto."); // Lógica clase

                _precio = value;
            }
        }
        private decimal _precio;

        // Propiedad EstadoPago
        public string EstadoPago
        {
            get => _estadoPago;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El estado de pago no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El estado de pago debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 20)
                    throw new ArgumentException("El estado de pago no puede tener más de 20 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El estado de pago solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El estado de pago no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El estado de pago no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El estado de pago no puede terminar con espacio."); // Sin espacio final

                _estadoPago = value;
            }
        }
        private string _estadoPago;

        // Métodos estáticos
        private static string filePath = "reservas.json";

        public static void Guardar(Reserva obj)
        {
            List<Reserva> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Reserva> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Reserva>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Reserva>>(json);
        }

        public string MostrarInfo()
        {
            return $"Reserva {Id} - Pasajero: {IdPasajero}, Vuelo: {IdVuelo}, Asiento: {Asiento}";
        }
    }
}