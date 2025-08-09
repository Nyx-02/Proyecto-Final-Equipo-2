using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Backend
{
    public class Aerolinea
    {
        public string Id
        {
            get => _id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío.");
                _id = value;
            }
        }
        private string _id;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Nombre no puede estar vacío.");
                _nombre = value;
            }
        }
        private string _nombre;

        public string Pais
        {
            get => _pais;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El País no puede estar vacío.");
                _pais = value;
            }
        }
        private string _pais;

        public string Telefono
        {
            get => _telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Teléfono no puede estar vacío.");
                _telefono = value;
            }
        }
        private string _telefono;

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Email no puede estar vacío.");
                _email = value;
            }
        }
        private string _email;

        public string Direccion
        {
            get => _direccion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La Dirección no puede estar vacía.");
                _direccion = value;
            }
        }
        private string _direccion;

        public string SitioWeb
        {
            get => _sitioWeb;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Sitio Web no puede estar vacío.");
                _sitioWeb = value;
            }
        }
        private string _sitioWeb;

        public string CodigoIATA
        {
            get => _codigoIATA;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Código IATA no puede estar vacío.");
                _codigoIATA = value;
            }
        }
        private string _codigoIATA;

        private static string filePath = "aerolineas.json";

        public static void Guardar(Aerolinea aerolinea)
        {
            List<Aerolinea> lista = Leer();
            lista.Add(aerolinea);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Aerolinea> Leer()
        {
            if (!File.Exists(filePath))
                return new List<Aerolinea>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Aerolinea>>(json);
        }

        public string MostrarInfo()
        {
            return $"Aerolínea {Id}: {Nombre} ({Pais})";
        }
    }
}