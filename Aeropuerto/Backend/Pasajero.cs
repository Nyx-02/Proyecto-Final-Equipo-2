using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class Pasajero
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

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Nombre no puede estar vacío.");
                _nombre = value;
            }
        }
        private string _nombre;

        public string Apellido
        {
            get => _apellido;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Apellido no puede estar vacío.");
                _apellido = value;
            }
        }
        private string _apellido;

        public DateTime FechaNacimiento
        {
            get => _fechaNacimiento;
            set
            {
                if (value == default)
                    throw new ArgumentException("La Fecha de Nacimiento no puede estar vacía.");
                _fechaNacimiento = value;
            }
        }
        private DateTime _fechaNacimiento;

        public string Nacionalidad
        {
            get => _nacionalidad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La Nacionalidad no puede estar vacía.");
                _nacionalidad = value;
            }
        }
        private string _nacionalidad;

        public string Pasaporte
        {
            get => _pasaporte;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Pasaporte no puede estar vacío.");
                _pasaporte = value;
            }
        }
        private string _pasaporte;

        public string Telefono
        {
            get => _telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Teléfono no puede estar vacío.");
                _telefono = value;
            }
        }
        private string _telefono;

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Email no puede estar vacío.");
                _email = value;
            }
        }
        private string _email;

        private static string filePath = "pasajeros.json";

        public static void Guardar(Pasajero pasajero)
        {
            List<Pasajero> lista = Leer();
            lista.Add(pasajero);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Pasajero> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Pasajero>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Pasajero>>(json);
        }

        public string MostrarInfo()
        {
            return $"Pasajero {Id}: {Nombre} {Apellido}, Nacionalidad: {Nacionalidad}";
        }
    }
}