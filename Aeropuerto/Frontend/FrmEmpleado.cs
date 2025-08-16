using System;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
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
                Backend.Empleado.Guardar(emp);
                MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
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
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lista = Backend.Empleado.Leer();
                int idx = lista.FindIndex(x => x.Id == id);
                if (idx < 0)
                {
                    MessageBox.Show("No se encontró un empleado con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var actualizado = ConstruirDesdeFormulario();
                actualizado.Id = id;
                lista[idx] = actualizado;
                Backend.Empleado.GuardarLista(lista);

                MessageBox.Show("Empleado editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lista = Backend.Empleado.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == id);
                if (existente == null)
                {
                    MessageBox.Show("No se encontró un empleado con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show($"¿Seguro que desea eliminar al empleado {existente.MostrarInfo()}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    lista.RemoveAll(x => x.Id == id);
                    Backend.Empleado.GuardarLista(lista);
                    MessageBox.Show("Empleado eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
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
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lista = Backend.Empleado.Leer();
                var emp = lista.FirstOrDefault(x => x.Id == id);
                if (emp == null)
                {
                    MessageBox.Show("No se encontró un empleado con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                textID.Text = emp.Id;
                texDestino.Text = emp.Nombre;
                textBox4.Text = emp.Apellido;
                texCargo.Text = emp.Cargo;
                nupdsalario.Value = emp.Salario;
                cbturno.Text = emp.Turno;
                DTPfechadeingreso.Value = emp.FechaIngreso;
                textBox2.Text = emp.Email;

                MessageBox.Show("Empleado cargado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Backend.Empleado ConstruirDesdeFormulario()
        {
            var id = (textID.Text ?? "").Trim().ToUpper();
            var emp = new Backend.Empleado
            {
                Id = id,
                Nombre = (texDestino.Text ?? "").Trim(),
                Apellido = (textBox4.Text ?? "").Trim(),
                Cargo = (texCargo.Text ?? "").Trim(),
                Salario = nupdsalario.Value,
                Turno = cbturno.Text.Trim(),
                FechaIngreso = DTPfechadeingreso.Value.Date,
                Email = (textBox2.Text ?? "").Trim()
            };
            return emp;
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texDestino.Clear();
            textBox4.Clear();
            texCargo.Clear();
            nupdsalario.Value = 0;
            cbturno.SelectedIndex = -1;
            DTPfechadeingreso.Value = DateTime.Today;
            textBox2.Clear();
            textID.Focus();
        }
    }
}