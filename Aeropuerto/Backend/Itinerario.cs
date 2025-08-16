using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Backend
{
    public class Itinerario
    {

        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El ID no puede estar vacío.");          
                if (value.Length < 3) throw new ArgumentException("El ID debe tener al menos 3 caracteres.");                 
                if (value.Length > 12) throw new ArgumentException("El ID no puede tener más de 12 caracteres.");          
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) throw new ArgumentException("El ID solo puede ser alfanumérico en mayúsculas."); 
                if (value.Contains(" ")) throw new ArgumentException("El ID no puede contener espacios.");               
                if (value.Any(char.IsLower)) throw new ArgumentException("El ID no puede tener letras minúsculas.");       
                if (value.StartsWith("0")) throw new ArgumentException("El ID no puede iniciar con 0.");                       
                _id = value;
            }
        }

        private string _idVuelo;
        public string IdVuelo
        {
            get => _idVuelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El IdVuelo no puede estar vacío.");       
                if (value.Length < 3) throw new ArgumentException("El IdVuelo debe tener al menos 3 caracteres.");            
                if (value.Length > 12) throw new ArgumentException("El IdVuelo no puede tener más de 12 caracteres.");       
                if (!Regex.IsMatch(value, @"^[A-Z0-9]+$")) throw new ArgumentException("El IdVuelo debe ser alfanumérico en mayúsculas.");
                if (value.Contains(" ")) throw new ArgumentException("El IdVuelo no puede contener espacios.");              
                if (value.Any(char.IsLower)) throw new ArgumentException("El IdVuelo no puede contener minúsculas.");        
                if (value.StartsWith("0")) throw new ArgumentException("El IdVuelo no puede iniciar con 0.");                 
                _idVuelo = value;
            }
        }

        private string _actividades;
        public string Actividades
        {
            get => _actividades;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Las actividades no pueden estar vacías.");
                if (value.Length < 5) throw new ArgumentException("Las actividades deben tener al menos 5 caracteres.");      
                if (value.Length > 100) throw new ArgumentException("Las actividades no pueden tener más de 100 caracteres."); 
                if (!Regex.IsMatch(value, @"^[A-Za-zÁÉÍÓÚÜÑáéíóúüñ\s]+$")) throw new ArgumentException("Las actividades solo pueden contener letras y espacios."); 
                if (value.Any(char.IsDigit)) throw new ArgumentException("Las actividades no pueden contener números.");      
                if (value.StartsWith(" ")) throw new ArgumentException("Las actividades no pueden iniciar con espacio.");     
                if (value.EndsWith(" ")) throw new ArgumentException("Las actividades no pueden terminar con espacio.");      
                _actividades = value;
            }
        }

        private DateTime _fechaInicio;
        public DateTime FechaInicio
        {
            get => _fechaInicio;
            set
            {
                if (value == default) throw new ArgumentException("La fecha de inicio no puede estar vacía.");                 
                if (value.Date < DateTime.Today) throw new ArgumentException("La fecha de inicio no puede ser en el pasado.");
                if (value > DateTime.Today.AddYears(2)) throw new ArgumentException("La fecha de inicio no puede superar 2 años en el futuro."); 
                if (value.DayOfWeek == DayOfWeek.Sunday) throw new ArgumentException("La fecha de inicio no puede ser domingo."); 
                if (value.Month == 2 && value.Day > 29) throw new ArgumentException("Fecha inválida para febrero.");         
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29) throw new ArgumentException("El año no es bisiesto."); 
                if (_fechaFin != default && value >= _fechaFin) throw new ArgumentException("La fecha de inicio debe ser menor a la fecha fin."); 
                _fechaInicio = value;
            }
        }

        private DateTime _fechaFin;
        public DateTime FechaFin
        {
            get => _fechaFin;
            set
            {
                if (value == default) throw new ArgumentException("La fecha fin no puede estar vacía.");                       
                if (value.Date < DateTime.Today) throw new ArgumentException("La fecha fin no puede estar en el pasado.");     
                if (value > DateTime.Today.AddYears(2)) throw new ArgumentException("La fecha fin no puede superar 2 años en el futuro."); 
                if (value.DayOfWeek == DayOfWeek.Sunday) throw new ArgumentException("La fecha fin no puede ser domingo.");    
                if (value.Month == 2 && value.Day > 29) throw new ArgumentException("Fecha inválida para febrero.");           
                if (!DateTime.IsLeapYear(value.Year) && value.Month == 2 && value.Day == 29) throw new ArgumentException("El año no es bisiesto."); 
                if (_fechaInicio != default && value <= _fechaInicio) throw new ArgumentException("La fecha fin debe ser mayor a la fecha inicio."); 
                _fechaFin = value;
            }
        }

        private string _escalas;
        public string Escalas
        {
            get => _escalas;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Las escalas no pueden estar vacías.");     
                if (value.Length < 2) throw new ArgumentException("Las escalas deben tener al menos 2 caracteres.");          
                if (value.Length > 50) throw new ArgumentException("Las escalas no pueden tener más de 50 caracteres.");      
                if (!Regex.IsMatch(value, @"^[A-Za-zÁÉÍÓÚÜÑáéíóúüñ\s]+$")) throw new ArgumentException("Las escalas solo pueden contener letras."); 
                if (value.Any(char.IsDigit)) throw new ArgumentException("Las escalas no pueden contener números.");          
                if (value.StartsWith(" ")) throw new ArgumentException("Las escalas no pueden iniciar con espacio.");         
                if (value.EndsWith(" ")) throw new ArgumentException("Las escalas no pueden terminar con espacio.");          
                _escalas = value;
            }
        }

        private string _observaciones;
        public string Observaciones
        {
            get => _observaciones;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Las observaciones no pueden estar vacías."); 
                if (value.Length < 5) throw new ArgumentException("Las observaciones deben tener al menos 5 caracteres.");     
                if (value.Length > 200) throw new ArgumentException("Las observaciones no pueden tener más de 200 caracteres."); 
                if (value.StartsWith(" ")) throw new ArgumentException("Las observaciones no pueden iniciar con espacio.");   
                if (value.EndsWith(" ")) throw new ArgumentException("Las observaciones no pueden terminar con espacio.");    
                if (value.Contains("@")) throw new ArgumentException("Las observaciones no pueden contener @.");              
                if (value.Contains("  ")) throw new ArgumentException("Las observaciones no pueden contener espacios dobles."); 
                _observaciones = value;
            }
        }

        private string _estado;
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

        private static string filePath = "itinerarios.json";

        public static void Guardar(Itinerario obj)
        {
            var lista = Leer();
            lista.Add(obj);
            GuardarLista(lista);
        }

        public static void GuardarLista(List<Itinerario> lista)
        {
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Itinerario> Leer()
        {
            if (!File.Exists(filePath)) return new List<Itinerario>();
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Itinerario>>(json) ?? new List<Itinerario>();
        }

        public string MostrarInfo()
        {
            return $"Itinerario {Id} - Vuelo {IdVuelo}, Estado: {Estado}";
        }
    }
}