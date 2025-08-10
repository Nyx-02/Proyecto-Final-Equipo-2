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
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El ID debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 10)
                    throw new ArgumentException("El ID no puede tener más de 10 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El ID solo puede contener letras mayúsculas y números."); // Formato
                if (value.Contains(" "))
                    throw new ArgumentException("El ID no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID no puede iniciar con 0."); // Sin ceros iniciales
                if (value.Any(char.IsLower))
                    throw new ArgumentException("El ID no puede contener letras minúsculas."); // Sin minúsculas

                _id = value;
            }
        }
        private string _id;

        // Propiedad NombreGuardia
        public string NombreGuardia
        {
            get => _nombreGuardia;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del guardia no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El nombre debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 50)
                    throw new ArgumentException("El nombre no puede tener más de 50 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El nombre solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El nombre no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El nombre no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El nombre no puede terminar con espacio."); // Sin espacio final

                _nombreGuardia = value;
            }
        }
        private string _nombreGuardia;

        // Propiedad Turno
        public string Turno
        {
            get => _turno;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El turno no puede estar vacío."); // No vacío
                if (value.Length < 4)
                    throw new ArgumentException("El turno debe tener al menos 4 caracteres."); // Mínimo
                if (value.Length > 20)
                    throw new ArgumentException("El turno no puede tener más de 20 caracteres."); // Máximo
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

        // Propiedad ZonaAsignada
        public string ZonaAsignada
        {
            get => _zonaAsignada;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La zona asignada no puede estar vacía."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("La zona asignada debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 30)
                    throw new ArgumentException("La zona asignada no puede tener más de 30 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("La zona asignada solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("La zona asignada no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("La zona asignada no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("La zona asignada no puede terminar con espacio."); // Sin espacio final

                _zonaAsignada = value;
            }
        }
        private string _zonaAsignada;

        // Propiedad FechaInicio
        public DateTime FechaInicio
        {
            get => _fechaInicio;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha de inicio no puede estar vacía."); // No vacío
                if (value.Year < 2000)
                    throw new ArgumentException("La fecha de inicio no puede ser anterior al 2000."); // Año mínimo
                if (value > DateTime.Today.AddYears(1))
                    throw new ArgumentException("La fecha de inicio no puede ser más de 1 año en el futuro."); // Año máximo
                if (value.Date > DateTime.Today)
                    throw new ArgumentException("La fecha de inicio no puede ser futura."); // No futura
                if (value.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se puede asignar inicio en domingo."); // Restricción
                if (value.Month == 2 && value.Day > 29)
                    throw new ArgumentException("Fecha inválida para febrero."); // Validación febrero
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29)
                    throw new ArgumentException("El año no es bisiesto."); // Año bisiesto

                _fechaInicio = value;
            }
        }
        private DateTime _fechaInicio;

        // Propiedad NivelAcceso
        public int NivelAcceso
        {
            get => _nivelAcceso;
            set
            {
                if (value < 1)
                    throw new ArgumentException("El nivel de acceso mínimo es 1."); // Mínimo
                if (value > 5)
                    throw new ArgumentException("El nivel de acceso máximo es 5."); // Máximo
                if (value % 1 != 0)
                    throw new ArgumentException("El nivel de acceso debe ser un número entero."); // Entero
                if (value == 0)
                    throw new ArgumentException("El nivel de acceso no puede ser 0."); // No cero
                if (value < 3 && ZonaAsignada.ToLower().Contains("vip"))
                    throw new ArgumentException("Zona VIP requiere nivel de acceso 3 o superior."); // Lógica zona
                if (value > 5)
                    throw new ArgumentException("Nivel de acceso fuera de rango lógico."); // Lógica
                if (value < 0)
                    throw new ArgumentException("Nivel de acceso no puede ser negativo."); // No negativo

                _nivelAcceso = value;
            }
        }
        private int _nivelAcceso;

        // Propiedad Identificacion
        public string Identificacion
        {
            get => _identificacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La identificación no puede estar vacía."); // No vacío
                if (value.Length < 6)
                    throw new ArgumentException("La identificación debe tener al menos 6 caracteres."); // Mínimo
                if (value.Length > 15)
                    throw new ArgumentException("La identificación no puede tener más de 15 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("La identificación solo puede contener letras mayúsculas y números."); // Formato
                if (value.Contains(" "))
                    throw new ArgumentException("La identificación no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("La identificación no puede iniciar con 0."); // Sin cero inicial
                if (value.Any(char.IsLower))
                    throw new ArgumentException("La identificación no puede contener letras minúsculas."); // Sin minúsculas

                _identificacion = value;
            }
        }
        private string _identificacion;

        // Propiedad Estado
        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El estado no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El estado debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 20)
                    throw new ArgumentException("El estado no puede tener más de 20 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El estado solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El estado no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El estado no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El estado no puede terminar con espacio."); // Sin espacio final

                _estado = value;
            }
        }
        private string _estado;

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
            return $"Seguridad {Id} - Guardia: {NombreGuardia}, Zona: {ZonaAsignada}";
        }
    }
}