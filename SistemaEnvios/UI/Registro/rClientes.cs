using SistemaEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaEnvios.UI.Registro
{
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && IDnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(IDnumericUpDown, "Llenar Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(NombrestextBox.Text))
            {
                errorProvider1.SetError(NombrestextBox, "Llene nombre");
                errores = true;
            }


            if (error == 2 && string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                errorProvider1.SetError(DirecciontextBox, "Llene direccion");
                errores = true;
            }


            if (error == 2 && string.IsNullOrEmpty(IdentidadmaskedTextBox.Text))
            {
                errorProvider1.SetError(IdentidadmaskedTextBox, "Llene cedula");
                errores = true;
            }


            if (error == 2 && string.IsNullOrEmpty(TelefonomaskedTextBox.Text))
            {
                errorProvider1.SetError(TelefonomaskedTextBox, "Llene telefono");
                errores = true;
            }

            return errores;

        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombrestextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            IdentidadmaskedTextBox.Clear();


            errorProvider1.Clear();
        }
        private Clientes Llenaclase()
        {

            Clientes Cliente = new Clientes();
            Cliente.ClienteID = Convert.ToInt32(IDnumericUpDown.Value);
            Cliente.Nombres = NombrestextBox.Text;
            Cliente.Direccion = DirecciontextBox.Text;
            Cliente.Identidad = IdentidadmaskedTextBox.Text;
            Cliente.Telefono = TelefonomaskedTextBox.Text;


            return Cliente;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("llenar clienteId");
            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);
                Clientes Cliente = BLL.ClientesBLL.Buscar(id);

                if (Cliente != null)
                {
                    IDnumericUpDown.Value = Cliente.ClienteID;
                    NombrestextBox.Text = Cliente.Nombres;
                    DirecciontextBox.Text = Cliente.Direccion;
                    IdentidadmaskedTextBox.Text = Cliente.Identidad;
                    TelefonomaskedTextBox.Text = Cliente.Telefono;


                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!",
                        "busacr de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Clientes Cliente = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("llenar los campos");
            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);
                if (id == 0)
                {
                    paso = BLL.ClientesBLL.Guardar(Cliente);
                }
                else
                {
                    var P = BLL.ClientesBLL.Buscar(id);
                    if (P != null)
                    {
                        paso = BLL.ClientesBLL.Modificar(Cliente);
                    }
                }
                Limpiar();
                errorProvider1.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!",
                        "guardar de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("llenar clienteId");
            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);

                if (BLL.ClientesBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No fue Eliminar!",
                        "eliminar de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
