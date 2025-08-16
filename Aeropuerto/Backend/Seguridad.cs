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
        // Propiedad Id
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

        // Propiedad NombreGuardia
        private string _nombreGuardia;
        public string NombreGuardia
        {
            get => _nombreGuardia;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del guardia no puede estar vacío.");
                if (value.Length < 3)
                    throw new ArgumentException("El nombre debe tener al menos 3 caracteres.");
                if (value.Length > 50)
                    throw new ArgumentException("El nombre no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El nombre solo puede contener letras.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El nombre no puede contener números.");
                if (value.StartsWith(" "))
                    throw new ArgumentException("El nombre no puede iniciar con espacio.");
                if (value.EndsWith(" "))
                    throw new ArgumentException("El nombre no puede terminar con espacio.");

                _nombreGuardia = value;
            }
        }

        // Propiedad Puesto
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

        // Propiedad Turno
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

        // Propiedad ZonaAsignada
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

        // Propiedad FechaInicio
        private DateTime _fechaInicio;
        public DateTime FechaInicio
        {
            get => _fechaInicio;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha de inicio no puede estar vacía.");
                if (value.Year < 2000)
                    throw new ArgumentException("La fecha de inicio no puede ser anterior al 2000.");
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

        // Propiedad NivelAcceso
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
                if (value % 1 != 0)
                    throw new ArgumentException("El nivel de acceso debe ser un número entero.");

                _nivelAcceso = value;
            }
        }

        // Propiedad Estado
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

        // Métodos estáticos
        private static string filePath = "seguridad.json";

        public static void Guardar(Seguridad obj)
        {
            List<Seguridad> lista = Leer();
            lista.Add(obj);
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
            return $"Seguridad {Id} - Guardia: {NombreGuardia}, Puesto: {Puesto}, Zona: {ZonaAsignada}";
        }
    }
}