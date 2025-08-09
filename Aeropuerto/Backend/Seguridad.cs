using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class Seguridad
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

        public string Puesto
        {
            get => _puesto;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Puesto no puede estar vacío.");
                _puesto = value;
            }
        }
        private string _puesto;

        public string Turno
        {
            get => _turno;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Turno no puede estar vacío.");
                _turno = value;
            }
        }
        private string _turno;

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

        public string NivelAcceso
        {
            get => _nivelAcceso;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Nivel de Acceso no puede estar vacío.");
                _nivelAcceso = value;
            }
        }
        private string _nivelAcceso;

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

        private static string filePath = "seguridad.json";

        public static void Guardar(Seguridad seguridad)
        {
            List<Seguridad> lista = Leer();
            lista.Add(seguridad);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Seguridad> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Seguridad>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Seguridad>>(json);
        }

        public string MostrarInfo()
        {
            return $"Seguridad {Id} - Puesto: {Puesto}, Turno: {Turno}, Estado: {Estado}";
        }
    }
}