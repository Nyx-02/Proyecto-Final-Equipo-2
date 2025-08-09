using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class CheckIn
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

        public string IdReserva
        {
            get => _idReserva;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El IdReserva no puede estar vacío.");
                _idReserva = value;
            }
        }
        private string _idReserva;

        public string IdEmpleado
        {
            get => _idEmpleado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El IdEmpleado no puede estar vacío.");
                _idEmpleado = value;
            }
        }
        private string _idEmpleado;

        public DateTime Fecha
        {
            get => _fecha;
            set
            {
                if (value == default)
                    throw new ArgumentException("La Fecha no puede estar vacía.");
                _fecha = value;
            }
        }
        private DateTime _fecha;

        public DateTime Hora
        {
            get => _hora;
            set
            {
                if (value == default)
                    throw new ArgumentException("La Hora no puede estar vacía.");
                _hora = value;
            }
        }
        private DateTime _hora;

        public string Mostrador
        {
            get => _mostrador;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Mostrador no puede estar vacío.");
                _mostrador = value;
            }
        }
        private string _mostrador;

        public string EquipajeFacturado
        {
            get => _equipajeFacturado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El campo EquipajeFacturado no puede estar vacío.");
                _equipajeFacturado = value;
            }
        }
        private string _equipajeFacturado;

        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Estado no puede estar vacío.");
                _estado = value;
            }
        }
        private string _estado;

        private static string filePath = "checkin.json";

        public static void Guardar(CheckIn checkIn)
        {
            List<CheckIn> lista = Leer();
            lista.Add(checkIn);
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

        public string MostrarInfo()
        {
            return $"Check-In {Id} - Reserva: {IdReserva}, Mostrador: {Mostrador}, Estado: {Estado}";
        }
    }
}