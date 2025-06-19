using GestorVehiculos.Repositorios;
using System.ComponentModel;

namespace GestorVehiculos
{
    public partial class Form1 : Form
    {
        private RepositorioVehiculos repositorio;
        private BindingList<Vehiculo> listaVehiculos;

        public Form1()
        {
            InitializeComponent();

            btnGuardar.Click += btnGuardar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;

            repositorio = new RepositorioVehiculos(Conexion.GetConexion());
            listaVehiculos = new BindingList<Vehiculo>(repositorio.Listar());

            dgvVehiculos.DataSource = listaVehiculos;
            dgvVehiculos.Columns["Id"].ReadOnly = true;

            nudAnio.Maximum = DateTime.Now.Year;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var vehiculo = new Vehiculo(
                    marca: txtMarca.Text.Trim(),
                    modelo: txtModelo.Text.Trim(),
                    anio: (int)nudAnio.Value,
                    ultimaRevision: dtpRevision.Value.Date,
                    tieneSeguro: chkSeguro.Checked,
                    kilometraje: (int)nudKilometraje.Value
                );

                repositorio.Crear(vehiculo);
                listaVehiculos.Insert(0, vehiculo);

                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCampos())
            {
                var filaSeleccionada = dgvVehiculos.SelectedRows[0];
                var vehiculoSeleccionado = (Vehiculo)filaSeleccionada.DataBoundItem;

                vehiculoSeleccionado.Marca = txtMarca.Text.Trim();
                vehiculoSeleccionado.Modelo = txtModelo.Text.Trim();
                vehiculoSeleccionado.Anio = (int)nudAnio.Value;
                vehiculoSeleccionado.UltimaRevision = dtpRevision.Value.Date;
                vehiculoSeleccionado.TieneSeguro = chkSeguro.Checked;
                vehiculoSeleccionado.Kilometraje = (int)nudKilometraje.Value;

                repositorio.Actualizar(vehiculoSeleccionado);

                dgvVehiculos.Refresh();

                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvVehiculos.SelectedRows[0];
            var vehiculoSeleccionado = (Vehiculo)filaSeleccionada.DataBoundItem;

            var confirm = MessageBox.Show($"¿Está seguro de eliminar el vehículo {vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                repositorio.Eliminar(vehiculoSeleccionado);
                listaVehiculos.Remove(vehiculoSeleccionado);
                LimpiarCampos();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("El campo Marca es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarca.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("El campo Modelo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelo.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            nudAnio.Value = DateTime.Now.Year;
            dtpRevision.Value = DateTime.Now.Date;
            chkSeguro.Checked = false;
            nudKilometraje.Value = 0;
        }
    }
}
