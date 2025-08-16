using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Frontend
{
    public partial class FrmEquipaje : Form
    {
        private bool expandido = false;

        public FrmEquipaje()
        {
            InitializeComponent();
            CargarGrid();

            Butdata.Click += Butdata_Click;
            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var equipaje = new Backend.Equipaje
                {
                    Id = textID.Text.Trim(),
                    IdPasajero = texpasajero.Text.Trim(),
                    Peso = nupdpeso.Value,
                    Tipo = cbtipo.SelectedItem?.ToString() ?? "",
                    Color = texcolor.Text.Trim(),
                    Dimensiones = texdimensiones.Text.Trim(),
                    Etiqueta = texetiqueta.Text.Trim(),
                    Estado = cbEstado.SelectedItem?.ToString() ?? ""
                };

                Backend.Equipaje.Guardar(equipaje);
                MessageBox.Show("Equipaje guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Backend.Equipaje.Leer();
                var equipaje = lista.FirstOrDefault(eq => eq.Id == textID.Text.Trim());

                if (equipaje != null)
                {
                    equipaje.IdPasajero = texpasajero.Text.Trim();
                    equipaje.Peso = nupdpeso.Value;
                    equipaje.Tipo = cbtipo.SelectedItem?.ToString() ?? "";
                    equipaje.Color = texcolor.Text.Trim();
                    equipaje.Dimensiones = texdimensiones.Text.Trim();
                    equipaje.Etiqueta = texetiqueta.Text.Trim();
                    equipaje.Estado = cbEstado.SelectedItem?.ToString() ?? "";

                    Backend.Equipaje.GuardarLista(lista);
                    MessageBox.Show("Equipaje editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Equipaje no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Backend.Equipaje.Leer();
                var equipaje = lista.FirstOrDefault(eq => eq.Id == textID.Text.Trim());

                if (equipaje != null)
                {
                    lista.Remove(equipaje);
                    Backend.Equipaje.GuardarLista(lista);
                    MessageBox.Show("Equipaje eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Equipaje no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Backend.Equipaje.Leer();
                var equipaje = lista.FirstOrDefault(eq => eq.Id == textID.Text.Trim());

                if (equipaje != null)
                {
                    texpasajero.Text = equipaje.IdPasajero;
                    nupdpeso.Value = equipaje.Peso;
                    cbtipo.SelectedItem = equipaje.Tipo;
                    texcolor.Text = equipaje.Color;
                    texdimensiones.Text = equipaje.Dimensiones;
                    texetiqueta.Text = equipaje.Etiqueta;
                    cbEstado.SelectedItem = equipaje.Estado;

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = new List<Backend.Equipaje> { equipaje };
                }
                else
                {
                    MessageBox.Show("Equipaje no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Butdata_Click(object sender, EventArgs e)
        {
            if (!expandido)
            {
                dgvDatos.Dock = DockStyle.Fill;
                dgvDatos.BringToFront();
                expandido = true;
                lbdata.Text = "Restaurar";
            }
            else
            {
                dgvDatos.Dock = DockStyle.None;
                dgvDatos.Size = new Size(600, 200);
                dgvDatos.Location = new Point(100, 300);
                expandido = false;
                lbdata.Text = "DataGridView";
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

        private void CargarGrid()
        {
            List<Equipaje> lista = Equipaje.Leer();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}