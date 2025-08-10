using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Equipaje
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

        // Propiedad IdPasajero
        public string IdPasajero
        {
            get => _idPasajero;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID del pasajero no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El ID del pasajero debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 10)
                    throw new ArgumentException("El ID del pasajero no puede tener más de 10 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El ID del pasajero solo puede contener letras mayúsculas y números."); // Solo mayúsculas
                if (value.Contains(" "))
                    throw new ArgumentException("El ID del pasajero no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID del pasajero no puede iniciar con 0."); // No iniciar con cero
                if (value == Id)
                    throw new ArgumentException("El ID del pasajero no puede ser igual al ID del equipaje."); // Lógica

                _idPasajero = value;
            }
        }
        private string _idPasajero;

        // Propiedad Peso
        public decimal Peso
        {
            get => _peso;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El peso debe ser mayor que 0."); // Positivo
                if (value < 1)
                    throw new ArgumentException("El peso mínimo es de 1 kg."); // Peso mínimo
                if (value > 50)
                    throw new ArgumentException("El peso máximo permitido es de 50 kg."); // Peso máximo
                if (decimal.Round(value, 2) != value)
                    throw new ArgumentException("El peso solo puede tener dos decimales."); // Decimales
                if (value % 0.5m != 0m)
                    throw new ArgumentException("El peso debe estar en múltiplos de 0.5 kg."); // Múltiplo
                if (value > 30 && Tipo.ToLower() == "mano")
                    throw new ArgumentException("El equipaje de mano no puede pesar más de 30 kg."); // Lógica tipo
                if (value < 0)
                    throw new ArgumentException("El peso no puede ser negativo."); // No negativo

                _peso = value;
            }
        }
        private decimal _peso;

        // Propiedad Tipo
        public string Tipo
        {
            get => _tipo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El tipo de equipaje no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El tipo de equipaje debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 20)
                    throw new ArgumentException("El tipo de equipaje no puede tener más de 20 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El tipo de equipaje solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El tipo de equipaje no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El tipo de equipaje no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El tipo de equipaje no puede terminar con espacio."); // Sin espacio final

                _tipo = value;
            }
        }
        private string _tipo;

        // Propiedad Color
        public string Color
        {
            get => _color;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El color no puede estar vacío."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("El color debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 20)
                    throw new ArgumentException("El color no puede tener más de 20 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("El color solo puede contener letras."); // Solo letras
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El color no puede contener números."); // Sin números
                if (value.StartsWith(" "))
                    throw new ArgumentException("El color no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("El color no puede terminar con espacio."); // Sin espacio final

                _color = value;
            }
        }
        private string _color;

        // Propiedad Dimensiones
        public string Dimensiones
        {
            get => _dimensiones;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Las dimensiones no pueden estar vacías."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("Las dimensiones deben tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 20)
                    throw new ArgumentException("Las dimensiones no pueden tener más de 20 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[0-9xX\s]+$"))
                    throw new ArgumentException("Las dimensiones deben estar en formato numérico (Ej: 40x30x20)."); // Formato
                if (!value.Contains("x") && !value.Contains("X"))
                    throw new ArgumentException("Las dimensiones deben contener la letra 'x' como separador."); // Separador
                if (value.Contains(" "))
                    throw new ArgumentException("Las dimensiones no pueden contener espacios."); // Sin espacios
                if (value.Count(c => c == 'x' || c == 'X') != 2)
                    throw new ArgumentException("Las dimensiones deben contener dos separadores 'x'."); // Formato correcto

                _dimensiones = value;
            }
        }
        private string _dimensiones;

        // Propiedad Etiqueta
        public string Etiqueta
        {
            get => _etiqueta;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La etiqueta no puede estar vacía."); // No vacío
                if (value.Length < 5)
                    throw new ArgumentException("La etiqueta debe tener al menos 5 caracteres."); // Mínimo de caracteres
                if (value.Length > 15)
                    throw new ArgumentException("La etiqueta no puede tener más de 15 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("La etiqueta solo puede contener letras mayúsculas y números."); // Formato permitido
                if (value.Contains(" "))
                    throw new ArgumentException("La etiqueta no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("La etiqueta no puede iniciar con 0."); // No iniciar con cero
                if (value.Any(char.IsLower))
                    throw new ArgumentException("La etiqueta no puede contener letras minúsculas."); // Solo mayúsculas

                _etiqueta = value;
            }
        }
        private string _etiqueta;

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

        // Métodos estáticos
        private static string filePath = "equipajes.json";

        public static void Guardar(Equipaje obj)
        {
            List<Equipaje> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Equipaje> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Equipaje>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Equipaje>>(json);
        }

        public string MostrarInfo()
        {
            return $"Equipaje {Id} - Pasajero: {IdPasajero}, Peso: {Peso} kg";
        }
    }
}