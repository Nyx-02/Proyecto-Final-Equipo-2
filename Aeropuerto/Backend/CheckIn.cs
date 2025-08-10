using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class CheckIn
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

        // Propiedad Pasajero
        public string Pasajero
        {
            get => _pasajero;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del pasajero no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El nombre del pasajero debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 50)
                    throw new ArgumentException("El nombre del pasajero no puede tener más de 50 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El nombre del pasajero solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El nombre del pasajero no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El nombre del pasajero no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El nombre del pasajero no puede terminar con espacio."); // Sin espacio final

                _pasajero = value;
            }
        }
        private string _pasajero;

        // Propiedad NumeroVuelo
        public string NumeroVuelo
        {
            get => _numeroVuelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El número de vuelo no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El número de vuelo debe tener al menos 3 caracteres."); // Mínimo
                if (value.Length > 10)
                    throw new ArgumentException("El número de vuelo no puede tener más de 10 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El número de vuelo solo puede contener letras mayúsculas y números."); // Formato
                if (value.Contains(" "))
                    throw new ArgumentException("El número de vuelo no puede contener espacios."); // Sin espacios
                if (value.Any(char.IsLower))
                    throw new ArgumentException("El número de vuelo no puede contener minúsculas."); // Sin minúsculas
                if (value.StartsWith("0"))
                    throw new ArgumentException("El número de vuelo no puede iniciar con 0."); // Sin ceros iniciales

                _numeroVuelo = value;
            }
        }
        private string _numeroVuelo;

        // Propiedad Fecha
        public DateTime Fecha
        {
            get => _fecha;
            set
            {
                if (value == default)
                    throw new ArgumentException("La fecha no puede estar vacía."); // No vacío
                if (value < DateTime.Today.AddYears(-1))
                    throw new ArgumentException("La fecha no puede ser más de 1 año en el pasado."); // Pasado límite
                if (value > DateTime.Today.AddYears(1))
                    throw new ArgumentException("La fecha no puede ser más de 1 año en el futuro."); // Futuro límite
                if (value.Month == 2 && value.Day > 29)
                    throw new ArgumentException("Fecha inválida para febrero."); // Validación febrero
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29)
                    throw new ArgumentException("El año no es bisiesto."); // Año bisiesto
                if (value.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se permiten check-ins en domingo."); // Restricción
                if (Hora != default && value.Date > Fecha.Date)
                    throw new ArgumentException("La fecha no puede ser posterior al mismo día del vuelo."); // Lógica

                _fecha = value;
            }
        }
        private DateTime _fecha;

        // Propiedad Hora
        public TimeSpan Hora
        {
            get => _hora;
            set
            {
                if (value == default)
                    throw new ArgumentException("La hora no puede estar vacía."); // No vacío
                if (value < new TimeSpan(0, 0, 0))
                    throw new ArgumentException("La hora no puede ser negativa."); // No negativa
                if (value > new TimeSpan(23, 59, 59))
                    throw new ArgumentException("La hora no puede ser mayor a 23:59."); // Máximo
                if (value.Minutes % 5 != 0)
                    throw new ArgumentException("La hora debe tener minutos múltiplos de 5."); // Intervalos
                if (value.Hours < 4 || value.Hours > 22)
                    throw new ArgumentException("El check-in solo puede hacerse entre las 4:00 y las 22:00."); // Rango permitido
                if (value.Hours == 0 && value.Minutes == 0)
                    throw new ArgumentException("La hora no puede ser 00:00."); // Sin hora nula
                if (value.Seconds != 0)
                    throw new ArgumentException("Los segundos deben ser 0."); // Segundos exactos

                _hora = value;
            }
        }
        private TimeSpan _hora;

        // Propiedad PuertaEmbarque
        public string PuertaEmbarque
        {
            get => _puertaEmbarque;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La puerta de embarque no puede estar vacía."); // No vacío
                if (value.Length < 1)
                    throw new ArgumentException("La puerta de embarque debe tener al menos 1 carácter."); // Mínimo
                if (value.Length > 5)
                    throw new ArgumentException("La puerta de embarque no puede tener más de 5 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("La puerta de embarque solo puede contener letras mayúsculas y números."); // Formato
                if (value.Contains(" "))
                    throw new ArgumentException("La puerta de embarque no puede contener espacios."); // Sin espacios
                if (value.Any(char.IsLower))
                    throw new ArgumentException("La puerta de embarque no puede contener letras minúsculas."); // Sin minúsculas
                if (value.StartsWith("0"))
                    throw new ArgumentException("La puerta de embarque no puede iniciar con 0."); // Sin ceros iniciales

                _puertaEmbarque = value;
            }
        }
        private string _puertaEmbarque;

        // Propiedad Asiento
        public string Asiento
        {
            get => _asiento;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El asiento no puede estar vacío."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("El asiento debe tener al menos 2 caracteres."); // Mínimo
                if (value.Length > 4)
                    throw new ArgumentException("El asiento no puede tener más de 4 caracteres."); // Máximo
                if (!Regex.IsMatch(value, @"^[0-9]{1,3}[A-Z]$"))
                    throw new ArgumentException("El asiento debe ser un número seguido de una letra mayúscula."); // Formato
                if (value.Contains(" "))
                    throw new ArgumentException("El asiento no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("El asiento no puede iniciar con 0."); // Sin ceros iniciales
                if (value.Any(char.IsLower))
                    throw new ArgumentException("El asiento no puede contener letras minúsculas."); // Sin minúsculas

                _asiento = value;
            }
        }
        private string _asiento;

        // Propiedad EquipajeFacturado
        public int EquipajeFacturado
        {
            get => _equipajeFacturado;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El equipaje facturado no puede ser negativo."); // No negativo
                if (value > 5)
                    throw new ArgumentException("No se puede facturar más de 5 maletas."); // Máximo
                if (value > 0 && value < 1)
                    throw new ArgumentException("El equipaje facturado debe ser al menos 1 si no es 0."); // Lógica
                if (value % 1 != 0)
                    throw new ArgumentException("El equipaje facturado debe ser un número entero."); // Entero
                if (value == 3 && Asiento.StartsWith("A"))
                    throw new ArgumentException("No se permiten 3 maletas en asiento A."); // Lógica
                if (value == 0 && Estado.ToLower() == "completado")
                    throw new ArgumentException("Un check-in completado debe tener al menos 1 maleta."); // Lógica
                if (value > 2 && Estado.ToLower() == "pendiente")
                    throw new ArgumentException("Check-in pendiente no puede tener más de 2 maletas."); // Lógica

                _equipajeFacturado = value;
            }
        }
        private int _equipajeFacturado;

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
        private static string filePath = "checkins.json";

        public static void Guardar(CheckIn obj)
        {
            List<CheckIn> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<CheckIn> Leer()
        {
            if (!File.Exists(filePath))
                return new List<CheckIn>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<CheckIn>>(json);
        }

        public string MostrarInfo()
        {
            return $"CheckIn {Id} - Pasajero: {Pasajero}, Vuelo: {NumeroVuelo}, Estado: {Estado}";
        }
    }
}