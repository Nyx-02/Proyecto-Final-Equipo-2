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
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("El ID solo puede contener letras mayúsculas y números."); // Solo mayúsculas y números
                if (value.Contains(" "))
                    throw new ArgumentException("El ID no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("El ID no puede iniciar con 0."); // No iniciar con cero
                if (value.Any(char.IsLower))
                    throw new ArgumentException("El ID no puede contener letras minúsculas."); // Sin minúsculas

                _id = value;
            }
        }
        private string _id;

        // Propiedad Numero
        public string Numero
        {
            get => _numero;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El número no puede estar vacío."); // No vacío
                if (!Regex.IsMatch(value, @"^[0-9]+$"))
                    throw new ArgumentException("El número solo puede contener dígitos."); // Solo números
                if (value.Length < 1)
                    throw new ArgumentException("El número debe tener al menos 1 dígito."); // Mínimo de dígitos
                if (value.Length > 3)
                    throw new ArgumentException("El número no puede tener más de 3 dígitos."); // Máximo de dígitos
                if (value.StartsWith("0"))
                    throw new ArgumentException("El número no puede iniciar con 0."); // No iniciar con cero
                if (int.Parse(value) <= 0)
                    throw new ArgumentException("El número debe ser mayor que 0."); // Positivo
                if (int.Parse(value) > 999)
                    throw new ArgumentException("El número no puede ser mayor a 999."); // Límite máximo

                _numero = value;
            }
        }
        private string _numero;

        // Propiedad Terminal
        public string Terminal
        {
            get => _terminal;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La terminal no puede estar vacía."); // No vacío
                if (value.Length < 1)
                    throw new ArgumentException("La terminal debe tener al menos 1 carácter."); // Mínimo de caracteres
                if (value.Length > 5)
                    throw new ArgumentException("La terminal no puede tener más de 5 caracteres."); // Máximo de caracteres
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                    throw new ArgumentException("La terminal solo puede contener letras mayúsculas y números."); // Formato permitido
                if (value.Contains(" "))
                    throw new ArgumentException("La terminal no puede contener espacios."); // Sin espacios
                if (value.StartsWith("0"))
                    throw new ArgumentException("La terminal no puede iniciar con 0."); // No iniciar con cero
                if (value.Any(char.IsLower))
                    throw new ArgumentException("La terminal no puede contener letras minúsculas."); // Sin minúsculas

                _terminal = value;
            }
        }
        private string _terminal;

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

        // Propiedad Capacidad
        public int Capacidad
        {
            get => _capacidad;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La capacidad debe ser mayor que 0."); // Positivo
                if (value < 10)
                    throw new ArgumentException("La capacidad mínima es de 10 personas."); // Mínimo
                if (value > 500)
                    throw new ArgumentException("La capacidad máxima es de 500 personas."); // Máximo
                if (value % 5 != 0)
                    throw new ArgumentException("La capacidad debe ser múltiplo de 5."); // Múltiplo de 5
                if (value > 400 && Estado.ToLower().Contains("cerrada"))
                    throw new ArgumentException("Una puerta cerrada no puede tener tanta capacidad."); // Lógica de estado
                if (value < 0)
                    throw new ArgumentException("La capacidad no puede ser negativa."); // No negativo
                if (value > 1000)
                    throw new ArgumentException("Capacidad fuera de rango lógico."); // Lógica adicional

                _capacidad = value;
            }
        }
        private int _capacidad;

        // Propiedad Ubicacion
        public string Ubicacion
        {
            get => _ubicacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La ubicación no puede estar vacía."); // No vacío
                if (value.Length < 3)
                    throw new ArgumentException("La ubicación debe tener al menos 3 caracteres."); // Mínimo de caracteres
                if (value.Length > 50)
                    throw new ArgumentException("La ubicación no puede tener más de 50 caracteres."); // Máximo de caracteres
                if (value.StartsWith(" "))
                    throw new ArgumentException("La ubicación no puede iniciar con espacio."); // Sin espacio inicial
                if (value.EndsWith(" "))
                    throw new ArgumentException("La ubicación no puede terminar con espacio."); // Sin espacio final
                if (value.Count(char.IsLetterOrDigit) < 3)
                    throw new ArgumentException("La ubicación debe contener al menos 3 caracteres alfanuméricos."); // Contenido mínimo
                if (value.Contains("@"))
                    throw new ArgumentException("La ubicación no puede contener '@'."); // Sin caracteres inválidos

                _ubicacion = value;
            }
        }
        private string _ubicacion;

        // Propiedad HorarioApertura
        public DateTime HorarioApertura
        {
            get => _horarioApertura;
            set
            {
                if (value == default)
                    throw new ArgumentException("El horario de apertura no puede estar vacío."); // No vacío
                if (value.Hour < 0 || value.Hour > 23)
                    throw new ArgumentException("Hora inválida."); // Hora válida
                if (value.Minute < 0 || value.Minute > 59)
                    throw new ArgumentException("Minutos inválidos."); // Minuto válido
                if (value.Hour < 4)
                    throw new ArgumentException("La apertura no puede ser antes de las 4 AM."); // Restricción horaria
                if (value.Hour > 12)
                    throw new ArgumentException("La apertura no puede ser después del mediodía."); // Restricción horaria
                if (value.Second != 0)
                    throw new ArgumentException("Los segundos deben ser 0."); // Sin segundos
                if (HorarioCierre != default && value >= HorarioCierre)
                    throw new ArgumentException("La apertura debe ser antes del cierre."); // Lógica de horario

                _horarioApertura = value;
            }
        }
        private DateTime _horarioApertura;

        // Propiedad HorarioCierre
        public DateTime HorarioCierre
        {
            get => _horarioCierre;
            set
            {
                if (value == default)
                    throw new ArgumentException("El horario de cierre no puede estar vacío."); // No vacío
                if (value.Hour < 0 || value.Hour > 23)
                    throw new ArgumentException("Hora inválida."); // Hora válida
                if (value.Minute < 0 || value.Minute > 59)
                    throw new ArgumentException("Minutos inválidos."); // Minuto válido
                if (value.Hour < 6)
                    throw new ArgumentException("El cierre no puede ser antes de las 6 AM."); // Restricción horaria
                if (value.Hour > 23)
                    throw new ArgumentException("El cierre no puede ser después de las 11 PM."); // Restricción horaria
                if (value.Second != 0)
                    throw new ArgumentException("Los segundos deben ser 0."); // Sin segundos
                if (HorarioApertura != default && value <= HorarioApertura)
                    throw new ArgumentException("El cierre debe ser después de la apertura."); // Lógica de horario

                _horarioCierre = value;
            }
        }
        private DateTime _horarioCierre;

        // Métodos estáticos
        private static string filePath = "puertasEmbarque.json";

        public static void Guardar(PuertaEmbarque obj)
        {
            List<PuertaEmbarque> lista = Leer();
            lista.Add(obj);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<PuertaEmbarque> Leer()
        {
            if (!File.Exists(filePath))
                return new List<PuertaEmbarque>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<PuertaEmbarque>>(json);
        }

        public string MostrarInfo()
        {
            return $"Puerta {Numero} - Terminal: {Terminal}, Estado: {Estado}";
        }
    }
}