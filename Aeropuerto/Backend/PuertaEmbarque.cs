using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class PuertaEmbarque
    {
        private string _id;
        private string _numero;
        private string _terminal;
        private string _estado;
        private int _capacidad;
        private string _ubicacion;
        private DateTime _horarioApertura;
        private DateTime _horarioCierre;

        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID no puede estar vacío.");
                var v = value.Trim();
                if (v.Length < 2) throw new ArgumentException("El ID debe tener al menos 2 caracteres.");
                if (v.Length > 12) throw new ArgumentException("El ID no puede tener más de 12 caracteres.");
                if (v.Contains(" ")) throw new ArgumentException("El ID no puede contener espacios.");
                if (!Regex.IsMatch(v, @"^[A-Z0-9]+$")) throw new ArgumentException("El ID debe ser alfanumérico en mayúsculas.");
                if (Regex.IsMatch(v, @"^\d+$")) throw new ArgumentException("El ID no puede ser solo números.");
                if (v.StartsWith("0")) throw new ArgumentException("El ID no puede iniciar con 0.");
                if (v != value) throw new ArgumentException("El ID no debe tener espacios al inicio o final.");
                _id = v;
            }
        }

        public string Numero
        {
            get => _numero;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El número no puede estar vacío.");
                var v = value.Trim();
                if (v.Length < 1) throw new ArgumentException("El número debe tener al menos 1 dígito.");
                if (v.Length > 4) throw new ArgumentException("El número no puede tener más de 4 dígitos.");
                if (v.Contains(" ")) throw new ArgumentException("El número no puede contener espacios.");
                if (!Regex.IsMatch(v, @"^\d+$")) throw new ArgumentException("El número debe contener solo dígitos.");
                if (v.StartsWith("0")) throw new ArgumentException("El número no puede iniciar con 0.");
                var n = int.Parse(v);
                if (n < 1 || n > 9999) throw new ArgumentException("El número debe estar entre 1 y 9999.");
                if (_terminal != null && _terminal.Equals(v, StringComparison.OrdinalIgnoreCase)) throw new ArgumentException("El número no puede ser igual a la terminal.");
                _numero = v;
            }
        }

        public string Terminal
        {
            get => _terminal;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("La terminal no puede estar vacía.");
                var v = value.Trim().ToUpper();
                if (v.Length < 1) throw new ArgumentException("La terminal debe tener al menos 1 carácter.");
                if (v.Length > 5) throw new ArgumentException("La terminal no puede tener más de 5 caracteres.");
                if (v.Contains(" ")) throw new ArgumentException("La terminal no puede contener espacios.");
                if (!Regex.IsMatch(v, @"^[A-Z0-9]+$")) throw new ArgumentException("La terminal debe ser alfanumérica en mayúsculas.");
                if (v.StartsWith("0")) throw new ArgumentException("La terminal no puede iniciar con 0.");
                if (v == "N/A") throw new ArgumentException("La terminal no puede ser N/A.");
                if (_numero != null && _numero.Equals(v, StringComparison.OrdinalIgnoreCase)) throw new ArgumentException("La terminal no puede ser igual al número.");
                _terminal = v;
            }
        }

        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El estado no puede estar vacío.");
                var v = value.Trim();
                if (v.Length < 6) throw new ArgumentException("El estado es demasiado corto.");
                if (v.Length > 25) throw new ArgumentException("El estado es demasiado largo.");
                if (!Regex.IsMatch(v, @"^[A-Za-zÁÉÍÓÚÜÑáéíóúüñ\s]+$")) throw new ArgumentException("El estado solo puede contener letras y espacios.");
                if (v.Contains("  ")) throw new ArgumentException("El estado no puede contener espacios dobles.");
                var permitidos = new[] { "Disponible", "Ocupada", "Mantenimiento", "Cerrada Temporalmente" };
                if (!permitidos.Contains(v)) throw new ArgumentException("Estado inválido.");
                if (v != value) throw new ArgumentException("El estado no debe tener espacios al inicio o final.");
                _estado = v;
            }
        }

        public int Capacidad
        {
            get => _capacidad;
            set
            {
                if (value <= 0) throw new ArgumentException("La capacidad debe ser mayor que 0.");
                if (value < 10) throw new ArgumentException("La capacidad mínima es 10.");
                if (value > 500) throw new ArgumentException("La capacidad máxima es 500.");
                if (value == int.MaxValue) throw new ArgumentException("La capacidad es inválida.");
                if (_estado == "Ocupada" && value < 10) throw new ArgumentException("La capacidad no puede ser menor a 10 estando Ocupada.");
                if (_estado == "Mantenimiento" && value > 50) throw new ArgumentException("En Mantenimiento la capacidad no puede exceder 50.");
                if (_terminal != null && _terminal.StartsWith("T") && value > 500) throw new ArgumentException("La capacidad excede el máximo para esta terminal.");
                _capacidad = value;
            }
        }

        public string Ubicacion
        {
            get => _ubicacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("La ubicación no puede estar vacía.");
                var v = value.Trim();
                if (v.Length < 3) throw new ArgumentException("La ubicación debe tener al menos 3 caracteres.");
                if (v.Length > 100) throw new ArgumentException("La ubicación no puede superar 100 caracteres.");
                if (v.Contains("  ")) throw new ArgumentException("La ubicación no puede contener espacios dobles.");
                if (!Regex.IsMatch(v, @"^[A-Za-zÁÉÍÓÚÜÑáéíóúüñ0-9\s\.\-]+$")) throw new ArgumentException("La ubicación contiene caracteres inválidos.");
                if (Regex.IsMatch(v, @"^\d+$")) throw new ArgumentException("La ubicación no puede ser solo números.");
                if (v != value) throw new ArgumentException("La ubicación no debe tener espacios al inicio o final.");
                _ubicacion = v;
            }
        }

        public DateTime HorarioApertura
        {
            get => _horarioApertura;
            set
            {
                if (value == default) throw new ArgumentException("El horario de apertura es inválido.");
                if (value.Date < DateTime.Today) throw new ArgumentException("El horario de apertura no puede estar en el pasado.");
                if (value.Date > DateTime.Today.AddYears(2)) throw new ArgumentException("El horario de apertura no puede superar 2 años.");
                if (value.DayOfWeek == DayOfWeek.Sunday) throw new ArgumentException("No se permite apertura en domingo.");
                if (value.TimeOfDay < TimeSpan.Zero) throw new ArgumentException("Hora de apertura inválida.");
                if (value.TimeOfDay > new TimeSpan(23, 59, 59)) throw new ArgumentException("Hora de apertura inválida.");
                if (_horarioCierre != default && value >= _horarioCierre) throw new ArgumentException("La apertura debe ser anterior al cierre.");
                if (value.Kind == DateTimeKind.Utc) throw new ArgumentException("El horario de apertura debe estar en hora local.");
                _horarioApertura = value;
            }
        }

        public DateTime HorarioCierre
        {
            get => _horarioCierre;
            set
            {
                if (value == default) throw new ArgumentException("El horario de cierre es inválido.");
                if (value.Date < DateTime.Today) throw new ArgumentException("El horario de cierre no puede estar en el pasado.");
                if (value.Date > DateTime.Today.AddYears(2)) throw new ArgumentException("El horario de cierre no puede superar 2 años.");
                if (value.DayOfWeek == DayOfWeek.Sunday) throw new ArgumentException("No se permite cierre en domingo.");
                if (value.TimeOfDay < TimeSpan.Zero) throw new ArgumentException("Hora de cierre inválida.");
                if (value.TimeOfDay > new TimeSpan(23, 59, 59)) throw new ArgumentException("Hora de cierre inválida.");
                if (_horarioApertura != default && value <= _horarioApertura) throw new ArgumentException("El cierre debe ser posterior a la apertura.");
                if (_horarioApertura != default && value - _horarioApertura > TimeSpan.FromHours(24)) throw new ArgumentException("El intervalo entre apertura y cierre no puede superar 24 horas.");
                if (value.Kind == DateTimeKind.Utc) throw new ArgumentException("El horario de cierre debe estar en hora local.");
                _horarioCierre = value;
            }
        }

        private static string filePath = "puertasEmbarque.json";

        public static void Guardar(PuertaEmbarque obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static void GuardarLista(List<PuertaEmbarque> lista)
        {
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<PuertaEmbarque> Leer()
        {
            if (!File.Exists(filePath)) return new List<PuertaEmbarque>();
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<PuertaEmbarque>>(json) ?? new List<PuertaEmbarque>();
        }

        public string MostrarInfo()
        {
            return $"Puerta {Numero} - Terminal {Terminal}, Estado: {Estado}, Capacidad: {Capacidad}";
        }
    }
}