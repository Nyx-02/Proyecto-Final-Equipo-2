using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class Empleado
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

        public string Cargo
        {
            get => _cargo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Cargo no puede estar vacío.");
                _cargo = value;
            }
        }
        private string _cargo;

        public decimal Salario
        {
            get => _salario;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El Salario debe ser mayor que cero.");
                _salario = value;
            }
        }
        private decimal _salario;

        public DateTime FechaIngreso
        {
            get => _fechaIngreso;
            set
            {
                if (value == default)
                    throw new ArgumentException("La Fecha de Ingreso no puede estar vacía.");
                _fechaIngreso = value;
            }
        }
        private DateTime _fechaIngreso;

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

        private static string filePath = "empleados.json";

        public static void Guardar(Empleado empleado)
        {
            List<Empleado> lista = Leer();
            lista.Add(empleado);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Empleado> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Empleado>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Empleado>>(json);
        }

        public string MostrarInfo()
        {
            return $"Empleado {Id}: {Nombre} {Apellido}, Cargo: {Cargo}";
        }
    }
}