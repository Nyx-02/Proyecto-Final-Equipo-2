using Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmAerolinea : Form
    {
        public FrmAerolinea()
        {
            InitializeComponent();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var aerolinea = new Aerolinea
                {
                    Id = textID.Text,
                    Nombre = texDestino.Text,
                    Pais = tepais.Text,
                    Telefono = textelefono.Text,
                    Email = textBox2.Text,
                    Direccion = texdireccion.Text,
                    SitioWeb = texsitioweb.Text,
                    CodigoIATA = texcodigo.Text
                };

                Aerolinea.Guardar(aerolinea);
                MessageBox.Show("Aerolínea guardada correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Aerolinea> lista = Aerolinea.Leer();
                var aerolinea = lista.Find(a => a.Id == textID.Text);

                if (aerolinea != null)
                {
                    aerolinea.Nombre = texDestino.Text;
                    aerolinea.Pais = tepais.Text;
                    aerolinea.Telefono = textelefono.Text;
                    aerolinea.Email = textBox2.Text;
                    aerolinea.Direccion = texdireccion.Text;
                    aerolinea.SitioWeb = texsitioweb.Text;
                    aerolinea.CodigoIATA = texcodigo.Text;

                    GuardarLista(lista);
                    MessageBox.Show("Aerolínea editada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró una aerolínea con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Aerolinea> lista = Aerolinea.Leer();
                var aerolinea = lista.Find(a => a.Id == textID.Text);

                if (aerolinea != null)
                {
                    lista.Remove(aerolinea);
                    GuardarLista(lista);
                    MessageBox.Show("Aerolínea eliminada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró una aerolínea con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Aerolinea> lista = Aerolinea.Leer();
                var aerolinea = lista.Find(a => a.Id == textID.Text);

                if (aerolinea != null)
                {
                    texDestino.Text = aerolinea.Nombre;
                    tepais.Text = aerolinea.Pais;
                    textelefono.Text = aerolinea.Telefono;
                    textBox2.Text = aerolinea.Email;
                    texdireccion.Text = aerolinea.Direccion;
                    texsitioweb.Text = aerolinea.SitioWeb;
                    texcodigo.Text = aerolinea.CodigoIATA;
                }
                else
                {
                    MessageBox.Show("No se encontró una aerolínea con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texDestino.Clear();
            tepais.Clear();
            textelefono.Clear();
            textBox2.Clear();
            texdireccion.Clear();
            texsitioweb.Clear();
            texcodigo.Clear();
        }

        private void GuardarLista(List<Aerolinea> lista)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(lista, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("aerolineas.json", json);
        }
    }
}