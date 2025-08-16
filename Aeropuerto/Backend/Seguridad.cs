using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Seguridad
    {
        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El ID debe tener al menos 3 caracteres.");
                if (value.Length > 10)
                    throw new ArgumentException("El ID no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El ID solo puede contener letras mayúsculas y números.");
                if (value.Contains(" "))
                    throw new ArgumentException("El ID no puede contener espacios.");
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID no puede iniciar con 0.");
                if (value.Any(char.IsLower))
                    throw new ArgumentException("El ID no puede contener letras minúsculas.");

                _id = value;
            }
        }

        private string _idEmpleado;
        public string IdEmpleado
        {
            get => _idEmpleado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID del empleado no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El ID del empleado debe tener al menos 3 caracteres.");
                if (value.Length > 15)
                    throw new ArgumentException("El ID del empleado no puede tener más de 15 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El ID del empleado solo puede contener letras mayúsculas y números.");
                if (value.Contains(" "))
                    throw new ArgumentException("El ID del empleado no puede contener espacios.");
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID del empleado no puede iniciar con 0.");

                _idEmpleado = value;
            }
        }

        private string _turno;
        public string Turno
        {
            get => _turno;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El turno no puede estar vacío.");
                if (value.Length < 4)
                    throw new ArgumentException("El turno debe tener al menos 4 caracteres.");
                if (value.Length > 20)
                    throw new ArgumentException("El turno no puede tener más de 20 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El turno solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El turno no puede contener números.");
                if (value.StartsWith(" "))
                    throw new ArgumentException("El turno no puede iniciar con espacio.");
                if (value.EndsWith(" "))
                    throw new ArgumentException("El turno no puede terminar con espacio.");

                _turno = value;
            }
        }

        private string _zonaAsignada;
        public string ZonaAsignada
        {
            get => _zonaAsignada;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La zona asignada no puede estar vacía.");
                if (value.Length < 3)
                    throw new ArgumentException("La zona asignada debe tener al menos 3 caracteres.");
                if (value.Length > 30)
                    throw new ArgumentException("La zona asignada no puede tener más de 30 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("La zona asignada solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("La zona asignada no puede contener números.");
                if (value.StartsWith(" "))
                    throw new ArgumentException("La zona asignada no puede iniciar con espacio.");
                if (value.EndsWith(" "))
                    throw new ArgumentException("La zona asignada no puede terminar con espacio.");

                _zonaAsignada = value;
            }
        }

        private DateTime _fechaInicio;
        public DateTime FechaInicio
        {
            get => _fechaInicio;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha de inicio no puede estar vacía.");
                if (value.Year < 2000)
                    throw new ArgumentException("La fecha de inicio no puede ser anterior al año 2000.");
                if (value > DateTime.Today.AddYears(1))
                    throw new ArgumentException("La fecha de inicio no puede ser más de 1 año en el futuro.");
                if (value.Date > DateTime.Today)
                    throw new ArgumentException("La fecha de inicio no puede ser futura.");
                if (value.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se puede asignar inicio en domingo.");
                if (value.Month == 2 && value.Day > 29)
                    throw new ArgumentException("Fecha inválida para febrero.");
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29)
                    throw new ArgumentException("El año no es bisiesto.");

                _fechaInicio = value;
            }
        }

        private int _nivelAcceso;
        public int NivelAcceso
        {
            get => _nivelAcceso;
            set
            {
                if (value < 1)
                    throw new ArgumentException("El nivel de acceso mínimo es 1.");
                if (value > 5)
                    throw new ArgumentException("El nivel de acceso máximo es 5.");
                if (value == 0)
                    throw new ArgumentException("El nivel de acceso no puede ser 0.");
                if (value < 3 && ZonaAsignada != null && ZonaAsignada.ToLower().Contains("vip"))
                    throw new ArgumentException("Zona VIP requiere nivel de acceso 3 o superior.");
                if (value < 0)
                    throw new ArgumentException("Nivel de acceso no puede ser negativo.");

                _nivelAcceso = value;
            }
        }

        private string _identificacion;
        public string Identificacion
        {
            get => _identificacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La identificación no puede estar vacía.");
                if (value.Length < 6)
                    throw new ArgumentException("La identificación debe tener al menos 6 caracteres.");
                if (value.Length > 15)
                    throw new ArgumentException("La identificación no puede tener más de 15 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("La identificación solo puede contener letras mayúsculas y números.");
                if (value.Contains(" "))
                    throw new ArgumentException("La identificación no puede contener espacios.");
                if (value.StartsWith("0"))
                    throw new ArgumentException("La identificación no puede iniciar con 0.");
                if (value.Any(char.IsLower))
                    throw new ArgumentException("La identificación no puede contener letras minúsculas.");

                _identificacion = value;
            }
        }

        private string _estado;
        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El estado no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El estado debe tener al menos 3 caracteres.");
                if (value.Length > 20)
                    throw new ArgumentException("El estado no puede tener más de 20 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El estado solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El estado no puede contener números.");
                if (value.StartsWith(" "))
                    throw new ArgumentException("El estado no puede iniciar con espacio.");
                if (value.EndsWith(" "))
                    throw new ArgumentException("El estado no puede terminar con espacio.");

                _estado = value;
            }
        }

        private string _puesto;
        public string Puesto
        {
            get => _puesto;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El puesto no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El puesto debe tener al menos 3 caracteres.");
                if (value.Length > 30)
                    throw new ArgumentException("El puesto no puede tener más de 30 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El puesto solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El puesto no puede contener números.");
                if (value.StartsWith(" "))
                    throw new ArgumentException("El puesto no puede iniciar con espacio.");
                if (value.EndsWith(" "))
                    throw new ArgumentException("El puesto no puede terminar con espacio.");

                _puesto = value;
            }
        }

        private static string filePath = "seguridad.json";

        public static void Guardar(Seguridad obj)
        {
            List<Seguridad> lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static List<Seguridad> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Seguridad>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Seguridad>>(json) ?? new List<Seguridad>();
        }

        public static void GuardarLista(List<Seguridad> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public string MostrarInfo()
        {
            return $"Seguridad {Id} - Empleado: {IdEmpleado}, Puesto: {Puesto}, Zona: {ZonaAsignada}";
        }
    }
}