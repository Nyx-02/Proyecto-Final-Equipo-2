using Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmEquipaje : Form
    {
        public FrmEquipaje()
        {
            InitializeComponent();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var equipaje = new Equipaje
                {
                    Id = textID.Text,
                    IdPasajero = texpasajero.Text,
                    Peso = nupdpeso.Value,
                    Tipo = cbtipo.Text,
                    Color = texcolor.Text,
                    Dimensiones = texdimensiones.Text,
                    Etiqueta = texetiqueta.Text,
                    Estado = cbEstado.Text
                };

                Equipaje.Guardar(equipaje);
                MessageBox.Show("Equipaje guardado correctamente.");
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
                List<Equipaje> lista = Equipaje.Leer();
                var equipaje = lista.Find(eq => eq.Id == textID.Text);

                if (equipaje != null)
                {
                    equipaje.IdPasajero = texpasajero.Text;
                    equipaje.Peso = nupdpeso.Value;
                    equipaje.Tipo = cbtipo.Text;
                    equipaje.Color = texcolor.Text;
                    equipaje.Dimensiones = texdimensiones.Text;
                    equipaje.Etiqueta = texetiqueta.Text;
                    equipaje.Estado = cbEstado.Text;

                    GuardarLista(lista);
                    MessageBox.Show("Equipaje editado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró un equipaje con ese ID.");
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
                List<Equipaje> lista = Equipaje.Leer();
                var equipaje = lista.Find(eq => eq.Id == textID.Text);

                if (equipaje != null)
                {
                    lista.Remove(equipaje);
                    GuardarLista(lista);
                    MessageBox.Show("Equipaje eliminado correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró un equipaje con ese ID.");
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
                List<Equipaje> lista = Equipaje.Leer();
                var equipaje = lista.Find(eq => eq.Id == textID.Text);

                if (equipaje != null)
                {
                    texpasajero.Text = equipaje.IdPasajero;
                    nupdpeso.Value = equipaje.Peso;
                    cbtipo.Text = equipaje.Tipo;
                    texcolor.Text = equipaje.Color;
                    texdimensiones.Text = equipaje.Dimensiones;
                    texetiqueta.Text = equipaje.Etiqueta;
                    cbEstado.Text = equipaje.Estado;
                }
                else
                {
                    MessageBox.Show("No se encontró un equipaje con ese ID.");
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
            texpasajero.Clear();
            nupdpeso.Value = 0;
            cbtipo.SelectedIndex = -1;
            texcolor.Clear();
            texdimensiones.Clear();
            texetiqueta.Clear();
            cbEstado.SelectedIndex = -1;
        }

        private void GuardarLista(List<Equipaje> lista)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(lista, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("equipajes.json", json);
        }
    }
}