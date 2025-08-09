using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class Reserva
    {
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío.");
                _id = value;
            }
        }
        private string _id;

        public string IdPasajero
        {
            get => _idPasajero;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El IdPasajero no puede estar vacío.");
                _idPasajero = value;
            }
        }
        private string _idPasajero;

        public string IdVuelo
        {
            get => _idVuelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El IdVuelo no puede estar vacío.");
                _idVuelo = value;
            }
        }
        private string _idVuelo;

        public DateTime FechaReserva
        {
            get => _fechaReserva;
            set
            {
                if (value == default)
                    throw new ArgumentException("La Fecha de Reserva no puede estar vacía.");
                _fechaReserva = value;
            }
        }
        private DateTime _fechaReserva;

        public string Asiento
        {
            get => _asiento;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Asiento no puede estar vacío.");
                _asiento = value;
            }
        }
        private string _asiento;

        public string Clase
        {
            get => _clase;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La Clase no puede estar vacía.");
                _clase = value;
            }
        }
        private string _clase;

        public decimal Precio
        {
            get => _precio;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El Precio debe ser mayor que cero.");
                _precio = value;
            }
        }
        private decimal _precio;

        public string EstadoPago
        {
            get => _estadoPago;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Estado de Pago no puede estar vacío.");
                _estadoPago = value;
            }
        }
        private string _estadoPago;

        private static string filePath = "reservas.json";

        public static void Guardar(Reserva reserva)
        {
            List<Reserva> lista = Leer();
            lista.Add(reserva);
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
            return $"Reserva {Id}: Pasajero {IdPasajero}, Vuelo {IdVuelo}, Clase: {Clase}";
        }
    }
}