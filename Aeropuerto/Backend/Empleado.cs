using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Empleado
    {
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El ID debe tener al menos 3 caracteres.");
                if (value.Length > 10) throw new ArgumentException("El ID no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]+$")) throw new ArgumentException("El ID solo puede contener letras y números.");
                if (value.Contains(" ")) throw new ArgumentException("El ID no puede contener espacios.");
                if (value.StartsWith("0")) throw new ArgumentException("El ID no puede iniciar con 0.");
                if (value != value.ToUpper()) throw new ArgumentException("El ID debe estar en mayúsculas.");
                _id = value;
            }
        }
        private string _id;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El nombre no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El nombre debe tener al menos 2 caracteres.");
                if (value.Length > 50) throw new ArgumentException("El nombre no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$")) throw new ArgumentException("El nombre solo puede contener letras.");
                if (value.Any(char.IsDigit)) throw new ArgumentException("El nombre no puede contener números.");
                if (value.StartsWith(" ") || value.EndsWith(" ")) throw new ArgumentException("El nombre no puede iniciar/terminar con espacio.");
                _nombre = value;
            }
        }
        private string _nombre;

        public string Apellido
        {
            get => _apellido;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El apellido no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El apellido debe tener al menos 2 caracteres.");
                if (value.Length > 50) throw new ArgumentException("El apellido no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$")) throw new ArgumentException("El apellido solo puede contener letras.");
                if (value.Any(char.IsDigit)) throw new ArgumentException("El apellido no puede contener números.");
                if (value.StartsWith(" ") || value.EndsWith(" ")) throw new ArgumentException("El apellido no puede iniciar/terminar con espacio.");
                _apellido = value;
            }
        }
        private string _apellido;

        public string Cargo
        {
            get => _cargo;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El cargo no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El cargo debe tener al menos 2 caracteres.");
                if (value.Length > 50) throw new ArgumentException("El cargo no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$")) throw new ArgumentException("El cargo solo puede contener letras.");
                _cargo = value;
            }
        }
        private string _cargo;

        public decimal Salario
        {
            get => _salario;
            set
            {
                if (value < 100) throw new ArgumentException("El salario no puede ser menor a 100.");
                if (value > 1000000) throw new ArgumentException("El salario no puede ser mayor a 1,000,000.");
                _salario = value;
            }
        }
        private decimal _salario;

        public string Turno
        {
            get => _turno;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El turno no puede estar vacío.");
                if (value != "Mañana" && value != "Tarde" && value != "Noche") throw new ArgumentException("El turno debe ser Mañana, Tarde o Noche.");
                _turno = value;
            }
        }
        private string _turno;

        public DateTime FechaIngreso
        {
            get => _fechaIngreso;
            set
            {
                if (value == default) throw new ArgumentException("La fecha de ingreso no puede estar vacía.");
                if (value > DateTime.Today) throw new ArgumentException("La fecha de ingreso no puede ser futura.");
                if (value.Year < 1950) throw new ArgumentException("La fecha de ingreso no puede ser anterior a 1950.");
                _fechaIngreso = value;
            }
        }
        private DateTime _fechaIngreso;

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El email no puede estar vacío.");
                if (value.Length < 5) throw new ArgumentException("El email debe tener al menos 5 caracteres.");
                if (value.Length > 100) throw new ArgumentException("El email no puede tener más de 100 caracteres.");
                if (!value.Contains("@") || !value.Contains(".")) throw new ArgumentException("El email debe contener '@' y '.'.");
                if (value.StartsWith(" ") || value.EndsWith(" ")) throw new ArgumentException("El email no puede iniciar/terminar con espacio.");
                _email = value;
            }
        }
        private string _email;

        private static string filePath = "empleados.json";

        public static void Guardar(Empleado obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static List<Empleado> Leer()
        {
            try
            {
                if (!File.Exists(filePath)) return new List<Empleado>();
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) return new List<Empleado>();
                return JsonSerializer.Deserialize<List<Empleado>>(json) ?? new List<Empleado>();
            }
            catch
            {
                return new List<Empleado>();
            }
        }

        public static void GuardarLista(List<Empleado> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public string MostrarInfo()
        {
            return $"Empleado {Id} - {Nombre} {Apellido}, Cargo: {Cargo}";
        }
    }
}