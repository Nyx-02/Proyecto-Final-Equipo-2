using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Frontend
{
    public partial class FrmEmpleado : Form
    {
        private bool expandido = false;

        public FrmEmpleado()
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
                var emp = ConstruirDesdeFormulario();
                Empleado.Guardar(emp);

                MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textID.Text.Trim().ToUpper();
                var lista = Empleado.Leer();
                var emp = lista.FirstOrDefault(x => x.Id == id);

                if (emp != null)
                {
                    var actualizado = ConstruirDesdeFormulario();
                    actualizado.Id = id;
                    lista[lista.IndexOf(emp)] = actualizado;
                    Empleado.GuardarLista(lista);

                    MessageBox.Show("Empleado editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("No se encontró un empleado con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textID.Text.Trim().ToUpper();
                var lista = Empleado.Leer();
                var emp = lista.FirstOrDefault(x => x.Id == id);

                if (emp != null)
                {
                    lista.Remove(emp);
                    Empleado.GuardarLista(lista);
                    MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("No se encontró un empleado con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textID.Text.Trim().ToUpper();
                var lista = Empleado.Leer();
                var emp = lista.FirstOrDefault(x => x.Id == id);

                if (emp != null)
                {
                    textID.Text = emp.Id;
                    texnombre.Text = emp.Nombre;
                    texapellido.Text = emp.Apellido;
                    texCargo.Text = emp.Cargo;
                    nupdsalario.Value = emp.Salario;
                    cbturno.Text = emp.Turno;
                    DTPfechadeingreso.Value = emp.FechaIngreso;
                    texemail.Text = emp.Email;

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = new List<Empleado> { emp };

                    MessageBox.Show("Empleado encontrado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private Empleado ConstruirDesdeFormulario()
        {
            return new Empleado
            {
                Id = textID.Text.Trim().ToUpper(),
                Nombre = texnombre.Text.Trim(),
                Apellido = texapellido.Text.Trim(),
                Cargo = texCargo.Text.Trim(),
                Salario = nupdsalario.Value,
                Turno = cbturno.Text.Trim(),
                FechaIngreso = DTPfechadeingreso.Value.Date,
                Email = texemail.Text.Trim()
            };
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texnombre.Clear();
            texapellido.Clear();
            texCargo.Clear();
            nupdsalario.Value = 0;
            cbturno.SelectedIndex = -1;
            DTPfechadeingreso.Value = DateTime.Today;
            texemail.Clear();
        }

        private void CargarGrid()
        {
            List<Empleado> lista = Empleado.Leer();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }
    }
}