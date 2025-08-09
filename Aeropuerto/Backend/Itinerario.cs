using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class Itinerario
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

        public string Actividades
        {
            get => _actividades;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Las Actividades no pueden estar vacías.");
                _actividades = value;
            }
        }
        private string _actividades;

        public DateTime FechaInicio
        {
            get => _fechaInicio;
            set
            {
                if (value == default)
                    throw new ArgumentException("La Fecha de Inicio no puede estar vacía.");
                _fechaInicio = value;
            }
        }
        private DateTime _fechaInicio;

        public DateTime FechaFin
        {
            get => _fechaFin;
            set
            {
                if (value == default)
                    throw new ArgumentException("La Fecha de Fin no puede estar vacía.");
                _fechaFin = value;
            }
        }
        private DateTime _fechaFin;

        public string Escalas
        {
            get => _escalas;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Las Escalas no pueden estar vacías.");
                _escalas = value;
            }
        }
        private string _escalas;

        public string Observaciones
        {
            get => _observaciones;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Las Observaciones no pueden estar vacías.");
                _observaciones = value;
            }
        }
        private string _observaciones;

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

        private static string filePath = "itinerarios.json";

        public static void Guardar(Itinerario itinerario)
        {
            List<Itinerario> lista = Leer();
            lista.Add(itinerario);
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
            return $"Itinerario {Id} - Vuelo: {IdVuelo}, Estado: {Estado}, Inicio: {FechaInicio:dd/MM/yyyy}, Fin: {FechaFin:dd/MM/yyyy}";
        }
    }
}