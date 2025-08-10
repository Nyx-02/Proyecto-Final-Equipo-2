using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Avion
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

        // Propiedad Modelo
        public string Modelo
        {
            get => _modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El modelo no puede estar vacío."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("El modelo debe tener al menos 2 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El modelo no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9\s\-]+$"))
                    throw new ArgumentException("El modelo solo puede contener letras, números y guiones."); // Formato permitido
                if (value.StartsWith(" "))
                    throw new ArgumentException("El modelo no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El modelo no puede terminar con espacio."); // Sin espacio final
                if (value.Contains("--"))
                    throw new ArgumentException("El modelo no puede contener guiones dobles."); // Sin guiones dobles

                _modelo = value;
            }
        }
        private string _modelo;

        // Propiedad Capacidad
        public int Capacidad
        {
            get => _capacidad;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La capacidad debe ser mayor que 0."); // Positivo
                if (value < 50)
                    throw new ArgumentException("La capacidad mínima es de 50 pasajeros."); // Mínimo
                if (value > 850)
                    throw new ArgumentException("La capacidad máxima es de 850 pasajeros."); // Máximo
                if (value % 10 != 0)
                    throw new ArgumentException("La capacidad debe ser múltiplo de 10."); // Múltiplo de 10
                if (value > 0 && value < 100)
                    throw new ArgumentException("Capacidad muy baja para un avión comercial."); // Lógica negocio
                if (value > 800 && Modelo.ToLower().Contains("regional"))
                    throw new ArgumentException("Un avión regional no puede tener más de 800 asientos."); // Lógica modelo
                if (value < 0)
                    throw new ArgumentException("La capacidad no puede ser negativa."); // No negativo

                _capacidad = value;
            }
        }
        private int _capacidad;

        // Propiedad Fabricante
        public string Fabricante
        {
            get => _fabricante;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El fabricante no puede estar vacío."); // No vacío
                if (value.Length < 2)
                    throw new ArgumentException("El fabricante debe tener al menos 2 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El fabricante no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El fabricante solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El fabricante no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El fabricante no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El fabricante no puede terminar con espacio."); // Sin espacio final

                _fabricante = value;
            }
        }
        private string _fabricante;

        // Propiedad AnioFabricacion
        public int AnioFabricacion
        {
            get => _anioFabricacion;
            set
            {
                if (value < 1950)
                    throw new ArgumentException("El año de fabricación no puede ser anterior a 1950."); // Año mínimo
                if (value > DateTime.Now.Year)
                    throw new ArgumentException("El año de fabricación no puede ser en el futuro."); // Sin año futuro
                if (value > DateTime.Now.Year - 1 && Modelo.ToLower().Contains("usado"))
                    throw new ArgumentException("Un avión usado no puede ser del año actual."); // Lógica modelo
                if (value > DateTime.Now.Year - 5 && Modelo.ToLower().Contains("antiguo"))
                    throw new ArgumentException("Un avión antiguo no puede ser tan reciente."); // Lógica modelo
                if (value < 1980 && Modelo.ToLower().Contains("moderno"))
                    throw new ArgumentException("Un avión moderno no puede ser tan viejo."); // Lógica modelo
                if (value > DateTime.Now.Year + 1)
                    throw new ArgumentException("Año de fabricación inválido."); // Año fuera de rango
                if ((DateTime.Now.Year - value) > 50)
                    throw new ArgumentException("El avión no puede tener más de 50 años."); // Límite antigüedad

                _anioFabricacion = value;
            }
        }
        private int _anioFabricacion;

        // Propiedad Estado
        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El estado no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El estado debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 20)
                    throw new ArgumentException("El estado no puede tener más de 20 caracteres."); // Máximo de caracteres
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

        // Propiedad Matricula
        public string Matricula
        {
            get => _matricula;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La matrícula no puede estar vacía."); // No vacío
                if (value.Length < 5)
                    throw new ArgumentException("La matrícula debe tener al menos 5 caracteres."); // Mínimo de caracteres
                if (value.Length > 10)
                    throw new ArgumentException("La matrícula no puede tener más de 10 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Z0-9\-]+$"))
                    throw new ArgumentException("La matrícula solo puede contener letras mayúsculas, números y guiones."); // Formato permitido
                if (!value.Contains("-"))
                    throw new ArgumentException("La matrícula debe contener un guión."); // Debe tener guión
                if (value.Contains(" "))
                    throw new ArgumentException("La matrícula no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("La matrícula no puede iniciar con 0."); // No iniciar con cero

                _matricula = value;
            }
        }
        private string _matricula;

        // Propiedad TipoMotor
        public string TipoMotor
        {
            get => _tipoMotor;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El tipo de motor no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El tipo de motor debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("El tipo de motor no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9\s]+$"))
                    throw new ArgumentException("El tipo de motor solo puede contener letras y números."); // Formato permitido
                if (value.Any(char.IsPunctuation))
                    throw new ArgumentException("El tipo de motor no puede contener signos de puntuación."); // Sin signos
                if (value.StartsWith(" "))
                    throw new ArgumentException("El tipo de motor no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El tipo de motor no puede terminar con espacio."); // Sin espacio final

                _tipoMotor = value;
            }
        }
        private string _tipoMotor;

        // Métodos estáticos
        private static string filePath = "aviones.json";

        public static void Guardar(Avion obj)
        {
            List<Avion> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Avion> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Avion>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Avion>>(json);
        }

        public string MostrarInfo()
        {
            return $"Avión {Id} - {Modelo}, Capacidad: {Capacidad}";
        }
    }
}