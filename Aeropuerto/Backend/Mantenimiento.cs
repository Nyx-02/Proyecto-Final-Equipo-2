using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class Mantenimiento
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

        public string IdAvion
        {
            get => _idAvion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El IdAvion no puede estar vacío.");
                _idAvion = value;
            }
        }
        private string _idAvion;

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

        public string TipoMantenimiento
        {
            get => _tipoMantenimiento;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Tipo de Mantenimiento no puede estar vacío.");
                _tipoMantenimiento = value;
            }
        }
        private string _tipoMantenimiento;

        public string Descripcion
        {
            get => _descripcion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La Descripción no puede estar vacía.");
                _descripcion = value;
            }
        }
        private string _descripcion;

        public decimal Costo
        {
            get => _costo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El Costo debe ser mayor que cero.");
                _costo = value;
            }
        }
        private decimal _costo;

        public string Responsable
        {
            get => _responsable;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Responsable no puede estar vacío.");
                _responsable = value;
            }
        }
        private string _responsable;

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

        private static string filePath = "mantenimientos.json";

        public static void Guardar(Mantenimiento mantenimiento)
        {
            List<Mantenimiento> lista = Leer();
            lista.Add(mantenimiento);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Mantenimiento> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Mantenimiento>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Mantenimiento>>(json);
        }

        public string MostrarInfo()
        {
            return $"Mantenimiento {Id} - Avión: {IdAvion}, Tipo: {TipoMantenimiento}, Estado: {Estado}";
        }
    }
}