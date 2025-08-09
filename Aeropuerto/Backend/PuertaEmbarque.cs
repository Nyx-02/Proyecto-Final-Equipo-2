using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class PuertaEmbarque
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

        public string Numero
        {
            get => _numero;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Número no puede estar vacío.");
                _numero = value;
            }
        }
        private string _numero;

        public string Terminal
        {
            get => _terminal;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La Terminal no puede estar vacía.");
                _terminal = value;
            }
        }
        private string _terminal;

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

        public int Capacidad
        {
            get => _capacidad;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La Capacidad debe ser mayor que cero.");
                _capacidad = value;
            }
        }
        private int _capacidad;

        public string Ubicacion
        {
            get => _ubicacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La Ubicación no puede estar vacía.");
                _ubicacion = value;
            }
        }
        private string _ubicacion;

        public DateTime HorarioApertura
        {
            get => _horarioApertura;
            set
            {
                if (value == default)
                    throw new ArgumentException("El Horario de Apertura no puede estar vacío.");
                _horarioApertura = value;
            }
        }
        private DateTime _horarioApertura;

        public DateTime HorarioCierre
        {
            get => _horarioCierre;
            set
            {
                if (value == default)
                    throw new ArgumentException("El Horario de Cierre no puede estar vacío.");
                _horarioCierre = value;
            }
        }
        private DateTime _horarioCierre;

        private static string filePath = "puertasEmbarque.json";

        public static void Guardar(PuertaEmbarque puerta)
        {
            List<PuertaEmbarque> lista = Leer();
            lista.Add(puerta);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<PuertaEmbarque> Leer()
        {
            if (!File.Exists(filePath))
                return new List<PuertaEmbarque>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<PuertaEmbarque>>(json);
        }

        public string MostrarInfo()
        {
            return $"Puerta {Numero} - Terminal {Terminal}, Estado: {Estado}, Capacidad: {Capacidad}";
        }
    }
}