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

        public string IdPasajero
        {
            get => _idPasajero;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID del pasajero no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El ID del pasajero debe tener al menos 3 caracteres.");
                if (value.Length > 10) throw new ArgumentException("El ID del pasajero no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) throw new ArgumentException("El ID del pasajero solo puede contener letras mayúsculas y números.");
                if (value.Contains(" ")) throw new ArgumentException("El ID del pasajero no puede contener espacios.");
                if (value.StartsWith("0")) throw new ArgumentException("El ID del pasajero no puede iniciar con 0.");
                if (value == Id) throw new ArgumentException("El ID del pasajero no puede ser igual al ID del equipaje.");
                _idPasajero = value;
            }
        }
        private string _idPasajero;

        public decimal Peso
        {
            get => _peso;
            set
            {
                if (value <= 0) throw new ArgumentException("El peso debe ser mayor que 0.");
                if (value < 1) throw new ArgumentException("El peso mínimo es de 1 kg.");
                if (value > 50) throw new ArgumentException("El peso máximo permitido es de 50 kg.");
                if (decimal.Round(value, 2) != value) throw new ArgumentException("El peso solo puede tener dos decimales.");
                if (value % 0.5m != 0m) throw new ArgumentException("El peso debe estar en múltiplos de 0.5 kg.");
                if (value > 30 && (Tipo ?? "").ToLower() == "mano") throw new ArgumentException("El equipaje de mano no puede pesar más de 30 kg.");
                if (value < 0) throw new ArgumentException("El peso no puede ser negativo.");
                _peso = value;
            }
        }
        private decimal _peso;

        public string Tipo
        {
            get => _tipo;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El tipo de equipaje no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El tipo de equipaje debe tener al menos 3 caracteres.");
                if (value.Length > 20) throw new ArgumentException("El tipo de equipaje no puede tener más de 20 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$")) throw new ArgumentException("El tipo de equipaje solo puede contener letras.");
                if (value.Any(char.IsDigit)) throw new ArgumentException("El tipo de equipaje no puede contener números.");
                if (value.StartsWith(" ")) throw new ArgumentException("El tipo de equipaje no puede iniciar con espacio.");
                if (value.EndsWith(" ")) throw new ArgumentException("El tipo de equipaje no puede terminar con espacio.");
                _tipo = value;
            }
        }
        private string _tipo;

        public string Color
        {
            get => _color;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El color no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El color debe tener al menos 3 caracteres.");
                if (value.Length > 20) throw new ArgumentException("El color no puede tener más de 20 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$")) throw new ArgumentException("El color solo puede contener letras.");
                if (value.Any(char.IsDigit)) throw new ArgumentException("El color no puede contener números.");
                if (value.StartsWith(" ")) throw new ArgumentException("El color no puede iniciar con espacio.");
                if (value.EndsWith(" ")) throw new ArgumentException("El color no puede terminar con espacio.");
                _color = value;
            }
        }
        private string _color;

        public string Dimensiones
        {
            get => _dimensiones;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Las dimensiones no pueden estar vacías.");
                if (value.Length < 3) throw new ArgumentException("Las dimensiones deben tener al menos 3 caracteres.");
                if (value.Length > 20) throw new ArgumentException("Las dimensiones no pueden tener más de 20 caracteres.");
                if (!Regex.IsMatch(value, @"^[0-9xX]+$")) throw new ArgumentException("Use formato numérico, p. ej. 40x30x20.");
                if (!value.Contains("x") && !value.Contains("X")) throw new ArgumentException("Las dimensiones deben contener 'x' como separador.");
                if (value.Count(c => c == 'x' || c == 'X') != 2) throw new ArgumentException("Las dimensiones deben contener dos separadores 'x'.");
                _dimensiones = value;
            }
        }
        private string _dimensiones;

        public string Etiqueta
        {
            get => _etiqueta;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("La etiqueta no puede estar vacía.");
                if (value.Length < 5) throw new ArgumentException("La etiqueta debe tener al menos 5 caracteres.");
                if (value.Length > 15) throw new ArgumentException("La etiqueta no puede tener más de 15 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) throw new ArgumentException("La etiqueta solo puede contener letras mayúsculas y números.");
                if (value.Contains(" ")) throw new ArgumentException("La etiqueta no puede contener espacios.");
                if (value.StartsWith("0")) throw new ArgumentException("La etiqueta no puede iniciar con 0.");
                if (value.Any(char.IsLower)) throw new ArgumentException("La etiqueta no puede contener letras minúsculas.");
                _etiqueta = value;
            }
        }
        private string _etiqueta;

        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El estado no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El estado debe tener al menos 3 caracteres.");
                if (value.Length > 20) throw new ArgumentException("El estado no puede tener más de 20 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$")) throw new ArgumentException("El estado solo puede contener letras.");
                if (value.Any(char.IsDigit)) throw new ArgumentException("El estado no puede contener números.");
                if (value.StartsWith(" ")) throw new ArgumentException("El estado no puede iniciar con espacio.");
                if (value.EndsWith(" ")) throw new ArgumentException("El estado no puede terminar con espacio.");
                _estado = value;
            }
        }
        private string _estado;

        private static readonly string filePath = "equipajes.json";

        public static void Guardar(Equipaje obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static List<Equipaje> Leer()
        {
            try
            {
                if (!File.Exists(filePath)) return new List<Equipaje>();
                var json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) return new List<Equipaje>();
                return JsonSerializer.Deserialize<List<Equipaje>>(json) ?? new List<Equipaje>();
            }
            catch
            {
                return new List<Equipaje>();
            }
        }

        public static void GuardarLista(List<Equipaje> lista)
        {
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public string MostrarInfo() => $"Equipaje {Id} - Pasajero: {IdPasajero}, Peso: {Peso} kg";
    }
}