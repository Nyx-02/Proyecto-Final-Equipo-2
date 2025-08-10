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
        // Propiedad Id
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El ID debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 10)
                    throw new ArgumentException("El ID no puede tener más de 10 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]+$"))
                    throw new ArgumentException("El ID solo puede contener letras y números."); // Solo alfanumérico
                if (value.Contains(" "))
                    throw new ArgumentException("El ID no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID no puede iniciar con 0."); // No iniciar con cero
                if (value != value.ToUpper())
                    throw new ArgumentException("El ID debe estar en mayúsculas."); // Solo mayúsculas

                _id = value;
            }
        }
        private string _id;

        // Propiedad Nombre
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("El nombre debe tener al menos 2 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El nombre no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El nombre solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El nombre no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El nombre no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El nombre no puede terminar con espacio."); // Sin espacio final

                _nombre = value;
            }
        }
        private string _nombre;

        // Propiedad Apellido
        public string Apellido
        {
            get => _apellido;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido no puede estar vacío."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("El apellido debe tener al menos 2 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El apellido no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El apellido solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El apellido no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El apellido no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El apellido no puede terminar con espacio."); // Sin espacio final

                _apellido = value;
            }
        }
        private string _apellido;

        // Propiedad Cargo
        public string Cargo
        {
            get => _cargo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El cargo no puede estar vacío."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("El cargo debe tener al menos 2 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El cargo no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El cargo solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El cargo no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El cargo no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El cargo no puede terminar con espacio."); // Sin espacio final

                _cargo = value;
            }
        }
        private string _cargo;

        // Propiedad Salario
        public decimal Salario
        {
            get => _salario;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El salario debe ser mayor que 0."); // Positivo
                if (value < 500)
                    throw new ArgumentException("El salario no puede ser menor a 500."); // Salario mínimo
                if (value > 100000)
                    throw new ArgumentException("El salario no puede superar los 100,000."); // Salario máximo
                if (decimal.Round(value, 2) != value)
                    throw new ArgumentException("El salario solo puede tener dos decimales."); // Decimales
                if (value % 1m != 0m && value % 0.5m != 0m)
                    throw new ArgumentException("El salario debe estar en múltiplos de 0.50."); // Múltiplo válido
                if (value > 0 && value < 100)
                    throw new ArgumentException("Salario demasiado bajo para un empleado."); // Lógica de negocio
                if (value > 50000 && Cargo.ToLower().Contains("junior"))
                    throw new ArgumentException("Un cargo junior no puede tener un salario tan alto."); // Lógica de cargo

                _salario = value;
            }
        }
        private decimal _salario;

        // Propiedad FechaIngreso
        public DateTime FechaIngreso
        {
            get => _fechaIngreso;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha de ingreso no puede estar vacía."); // No vacío
                if (value.Year < 2000)
                    throw new ArgumentException("La fecha de ingreso no puede ser anterior al año 2000."); // Año mínimo
                if (value > DateTime.Today)
                    throw new ArgumentException("La fecha de ingreso no puede ser en el futuro."); // Sin fecha futura
                if (value < FechaNacimiento.AddYears(18))
                    throw new ArgumentException("El empleado debe tener al menos 18 años al ingresar."); // Edad mínima
                if ((DateTime.Today - value).TotalDays < 0)
                    throw new ArgumentException("Fecha de ingreso inválida."); // Lógica de fecha
                if (value.Month < 1 || value.Month > 12)
                    throw new ArgumentException("Mes inválido."); // Mes válido
                if (value.Day < 1 || value.Day > DateTime.DaysInMonth(value.Year, value.Month))
                    throw new ArgumentException("Día inválido para el mes indicado."); // Día válido

                _fechaIngreso = value;
            }
        }
        private DateTime _fechaIngreso;

        // Propiedad Turno
        public string Turno
        {
            get => _turno;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El turno no puede estar vacío."); // No vacío
                if (value.Length < 4)
                    throw new ArgumentException("El turno debe tener al menos 4 caracteres."); // Mínimo de caracteres
                if (value.Length > 20)
                    throw new ArgumentException("El turno no puede tener más de 20 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El turno solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El turno no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El turno no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El turno no puede terminar con espacio."); // Sin espacio final

                _turno = value;
            }
        }
        private string _turno;

        // Propiedad Email
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El email no puede estar vacío."); // No vacío
                if (value.Length < 5)
                    throw new ArgumentException("El email debe tener al menos 5 caracteres."); // Mínimo de caracteres
                if (value.Length > 100)
                    throw new ArgumentException("El email no puede tener más de 100 caracteres."); // Máximo de caracteres
                if (!value.Contains("@"))
                    throw new ArgumentException("El email debe contener '@'."); // Contener arroba
                if (!value.Contains("."))
                    throw new ArgumentException("El email debe contener un punto."); // Contener punto
                if (value.StartsWith(" "))
                    throw new ArgumentException("El email no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El email no puede terminar con espacio."); // Sin espacio final

                _email = value;
            }
        }
        private string _email;

        // Métodos estáticos
        private static string filePath = "empleados.json";

        public static void Guardar(Empleado obj)
        {
            List<Empleado> lista = Leer();
            lista.Add(obj);
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
            return $"Empleado {Id} - {Nombre} {Apellido}, Cargo: {Cargo}";
        }

        // Esto es necesario para validaciones de FechaIngreso
        public DateTime FechaNacimiento { get; set; }
    }
}