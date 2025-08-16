using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Avion
    {
        // ===== ID =====
        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID no puede estar vacío.");
                if (value.Length < 3) throw new ArgumentException("El ID debe tener al menos 3 caracteres.");
                if (value.Length > 10) throw new ArgumentException("El ID no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) throw new ArgumentException("El ID solo puede contener letras mayúsculas y números.");
                if (value.Contains(" ")) throw new ArgumentException("El ID no puede contener espacios.");
                if (value.StartsWith("0")) throw new ArgumentException("El ID no puede iniciar con 0.");
                if (value != value.ToUpper()) throw new ArgumentException("El ID debe estar en MAYÚSCULAS.");
                _id = value;
            }
        }

        // ===== MODELO =====
        private string _modelo;
        public string Modelo
        {
            get => _modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El modelo no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El modelo debe tener al menos 2 caracteres.");
                if (value.Length > 50) throw new ArgumentException("El modelo no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9\s\-]+$")) throw new ArgumentException("El modelo solo puede tener letras, números, espacios y guiones.");
                if (value.StartsWith(" ")) throw new ArgumentException("El modelo no puede iniciar con espacio.");
                if (value.EndsWith(" ")) throw new ArgumentException("El modelo no puede terminar con espacio.");
                if (value.Contains("  ")) throw new ArgumentException("El modelo no puede contener espacios dobles.");
                _modelo = value;
            }
        }

        // ===== CAPACIDAD =====
        private int _capacidad;
        public int Capacidad
        {
            get => _capacidad;
            set
            {
                if (value < 10) throw new ArgumentException("La capacidad mínima es 10 asientos.");
                if (value > 1000) throw new ArgumentException("La capacidad no puede superar 1000 asientos.");
                if (value == 0) throw new ArgumentException("La capacidad no puede ser 0.");
                if (value < 0) throw new ArgumentException("La capacidad no puede ser negativa.");
                if (value % 2 != 0) throw new ArgumentException("Por estandarización, la capacidad debe ser un número PAR.");
                if (value == 13) throw new ArgumentException("Capacidad 13 no permitida por política interna.");
                if (value > 600) throw new ArgumentException("Capacidad fuera de rango lógico para configuración comercial estándar (>600).");
                _capacidad = value;
            }
        }

        // ===== FABRICANTE =====
        private string _fabricante;
        public string Fabricante
        {
            get => _fabricante;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El fabricante no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El fabricante debe tener al menos 2 caracteres.");
                if (value.Length > 50) throw new ArgumentException("El fabricante no puede tener más de 50 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]+$")) throw new ArgumentException("El fabricante solo puede contener letras y espacios.");
                if (value.Any(char.IsDigit)) throw new ArgumentException("El fabricante no puede contener números.");
                if (value.StartsWith(" ")) throw new ArgumentException("El fabricante no puede iniciar con espacio.");
                if (value.EndsWith(" ")) throw new ArgumentException("El fabricante no puede terminar con espacio.");
                _fabricante = value;
            }
        }

        // ===== AÑO DE FABRICACIÓN =====
        private int _anioFabricacion;
        public int AnioFabricacion
        {
            get => _anioFabricacion;
            set
            {
                if (value == 0) throw new ArgumentException("El año de fabricación no puede ser 0.");
                if (value < 1950) throw new ArgumentException("El año de fabricación no puede ser anterior a 1950.");
                if (value > DateTime.Now.Year) throw new ArgumentException("El año de fabricación no puede ser futuro.");
                if (value < 1960 && (Motor ?? "").ToLower().Contains("turbofan"))
                    throw new ArgumentException("Inconsistencia: Turbofan no aplica para aeronaves previas a 1960.");
                if (value > 2015 && (Motor ?? "").ToLower().Contains("pist"))
                    throw new ArgumentException("Inconsistencia: Motores a pistón son atípicos posterior a 2015.");
                if (value < 1970 && Capacidad > 400)
                    throw new ArgumentException("Inconsistencia: Capacidad > 400 no es lógica para aeronaves previas a 1970.");
                if (value < 1960 && (Estado ?? "").Equals("Activo", StringComparison.OrdinalIgnoreCase))
                    throw new ArgumentException("Inconsistencia: Aeronave anterior a 1960 difícilmente está 'Activa'.");
                _anioFabricacion = value;
            }
        }

        // ===== ESTADO =====
        private string _estado;
        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El estado no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El estado debe tener al menos 2 caracteres.");
                if (value.Length > 20) throw new ArgumentException("El estado no puede tener más de 20 caracteres.");
                if (value.Any(char.IsDigit)) throw new ArgumentException("El estado no puede contener números.");
                if (value.StartsWith(" ")) throw new ArgumentException("El estado no puede iniciar con espacio.");
                if (value.EndsWith(" ")) throw new ArgumentException("El estado no puede terminar con espacio.");
                var permitido = new[] { "Activo", "En Mantenimiento", "Retirado" };
                if (Array.IndexOf(permitido, value) < 0) throw new ArgumentException("Estado inválido. Use: Activo, En Mantenimiento o Retirado.");
                _estado = value;
            }
        }

        // ===== MATRÍCULA =====
        private string _matricula;
        public string Matricula
        {
            get => _matricula;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("La matrícula no puede estar vacía.");
                if (value.Length < 5) throw new ArgumentException("La matrícula debe tener al menos 5 caracteres.");
                if (value.Length > 10) throw new ArgumentException("La matrícula no puede tener más de 10 caracteres.");
                if (!Regex.IsMatch(value, @"^[A-Z0-9\-]+$")) throw new ArgumentException("La matrícula solo puede contener letras mayúsculas, números y guiones.");
                if (value.Contains(" ")) throw new ArgumentException("La matrícula no puede contener espacios.");
                if (value == value.TrimStart('-').TrimEnd('-') && !value.Any(char.IsLetter))
                    throw new ArgumentException("La matrícula debe contener al menos una letra.");
                if (value != value.ToUpper()) throw new ArgumentException("La matrícula debe estar en MAYÚSCULAS.");
                _matricula = value;
            }
        }

        // ===== MOTOR =====
        private string _motor;
        public string Motor
        {
            get => _motor;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El tipo de motor no puede estar vacío.");
                if (value.Length < 2) throw new ArgumentException("El tipo de motor debe tener al menos 2 caracteres.");
                if (value.Length > 30) throw new ArgumentException("El tipo de motor no puede tener más de 30 caracteres.");
                if (value.StartsWith(" ")) throw new ArgumentException("El tipo de motor no puede iniciar con espacio.");
                if (value.EndsWith(" ")) throw new ArgumentException("El tipo de motor no puede terminar con espacio.");
                if (value.Contains("  ")) throw new ArgumentException("El tipo de motor no puede contener espacios dobles.");
                var permitidos = new[] { "Pistón", "Turboprop", "Turbofan", "Turbojet", "Eléctrico" };
                if (Array.IndexOf(permitidos, value) < 0) throw new ArgumentException("Motor inválido. Use: Pistón, Turboprop, Turbofan, Turbojet o Eléctrico.");
                _motor = value;
            }
        }

        // ===== Persistencia =====
        private static string filePath = "aviones.json";

        public static void Guardar(Avion obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static List<Avion> Leer()
        {
            try
            {
                if (!File.Exists(filePath)) return new List<Avion>();
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) return new List<Avion>();
                return JsonSerializer.Deserialize<List<Avion>>(json) ?? new List<Avion>();
            }
            catch
            {
                return new List<Avion>();
            }
        }

        public static void GuardarLista(List<Avion> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public string MostrarInfo()
        {
            return $"Avión {Id} - Modelo {Modelo}, Matrícula: {Matricula}";
        }
    }
}