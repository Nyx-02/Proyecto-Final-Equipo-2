using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
                    throw new ArgumentException("La Fecha no puede estar vacía.");
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
                    throw new ArgumentException("La Hora de Salida no puede estar vacía.");
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
                    throw new ArgumentException("La Hora de Llegada no puede estar vacía.");
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
                    throw new ArgumentException("La Aerolínea no puede estar vacía.");
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
                    throw new ArgumentException("El Estado no puede estar vacío.");
                _estado = value;
            }
        }
        private string _estado;

        private static string filePath = "vuelos.json";

        public static void Guardar(Vuelo vuelo)
        {
            List<Vuelo> lista = Leer();
            lista.Add(vuelo);
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
            return $"Vuelo {Id}: {Origen} → {Destino} | Estado: {Estado} - Fecha: {Fecha:dd/MM/yyyy}";
        }
    }
}