using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class Equipaje
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

        public decimal Peso
        {
            get => _peso;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El Peso debe ser mayor que cero.");
                _peso = value;
            }
        }
        private decimal _peso;

        public string Tipo
        {
            get => _tipo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Tipo no puede estar vacío.");
                _tipo = value;
            }
        }
        private string _tipo;

        public string Color
        {
            get => _color;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Color no puede estar vacío.");
                _color = value;
            }
        }
        private string _color;

        public string Dimensiones
        {
            get => _dimensiones;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Las Dimensiones no pueden estar vacías.");
                _dimensiones = value;
            }
        }
        private string _dimensiones;

        public string Etiqueta
        {
            get => _etiqueta;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La Etiqueta no puede estar vacía.");
                _etiqueta = value;
            }
        }
        private string _etiqueta;

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

        private static string filePath = "equipajes.json";

        public static void Guardar(Equipaje equipaje)
        {
            List<Equipaje> lista = Leer();
            lista.Add(equipaje);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Equipaje> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Equipaje>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Equipaje>>(json);
        }

        public string MostrarInfo()
        {
            return $"Equipaje {Id}: {Tipo}, Peso: {Peso} kg, Estado: {Estado}";
        }
    }
}