using Backend;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmPuertaEmbarque : Form
    {
        public FrmPuertaEmbarque()
        {
            InitializeComponent();
            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
            Butdata.Click += Butdata_Click; 
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var puerta = ConstruirDesdeFormulario();
                PuertaEmbarque.Guardar(puerta);
                MessageBox.Show("Puerta guardada correctamente.");
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
                var lista = PuertaEmbarque.Leer();
                var puerta = lista.FirstOrDefault(x => x.Id == textID.Text.Trim().ToUpper());

                if (puerta != null)
                {
                    puerta.Numero = texnumero.Text;
                    puerta.Terminal = cbterminal.Text;
                    puerta.Estado = cbestado.Text;
                    puerta.Capacidad = (int)nupdCapacidad.Value;
                    puerta.Ubicacion = texubicacion.Text;
                    puerta.HorarioApertura = DTPapertura.Value;
                    puerta.HorarioCierre = DTPcierre.Value;

                    PuertaEmbarque.GuardarLista(lista);
                    MessageBox.Show("Puerta editada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró una puerta con ese ID.");
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
                var lista = PuertaEmbarque.Leer();
                var puerta = lista.FirstOrDefault(x => x.Id == textID.Text.Trim().ToUpper());

                if (puerta != null)
                {
                    lista.Remove(puerta);
                    PuertaEmbarque.GuardarLista(lista);
                    MessageBox.Show("Puerta eliminada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró una puerta con ese ID.");
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
                var lista = PuertaEmbarque.Leer();
                var puerta = lista.FirstOrDefault(x => x.Id == textID.Text.Trim().ToUpper());

                if (puerta != null)
                {
                    texnumero.Text = puerta.Numero;
                    cbterminal.Text = puerta.Terminal;
                    cbestado.Text = puerta.Estado;
                    nupdCapacidad.Value = puerta.Capacidad;
                    texubicacion.Text = puerta.Ubicacion;
                    DTPapertura.Value = puerta.HorarioApertura;
                    DTPcierre.Value = puerta.HorarioCierre;
                }
                else
                {
                    MessageBox.Show("No se encontró una puerta con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Butdata_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = PuertaEmbarque.Leer();

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No hay puertas de embarque registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Form ventanaDatos = new Form
                {
                    Text = "Listado de Puertas de Embarque",
                    Size = new Size(900, 500),
                    StartPosition = FormStartPosition.CenterScreen
                };

                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    DataSource = lista,
                    ReadOnly = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect
                };

                ventanaDatos.Controls.Add(dgv);
                ventanaDatos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PuertaEmbarque ConstruirDesdeFormulario()
        {
            return new PuertaEmbarque
            {
                Id = textID.Text.Trim().ToUpper(),
                Numero = texnumero.Text.Trim(),
                Terminal = cbterminal.Text.Trim(),
                Estado = cbestado.Text.Trim(),
                Capacidad = (int)nupdCapacidad.Value,
                Ubicacion = texubicacion.Text.Trim(),
                HorarioApertura = DTPapertura.Value,
                HorarioCierre = DTPcierre.Value
            };
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texnumero.Clear();
            cbterminal.SelectedIndex = -1;
            cbestado.SelectedIndex = -1;
            nupdCapacidad.Value = 0;
            texubicacion.Clear();
            DTPapertura.Value = DateTime.Now;
            DTPcierre.Value = DateTime.Now;
        }
    }
}