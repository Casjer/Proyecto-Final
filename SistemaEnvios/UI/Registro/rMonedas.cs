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
    public partial class rMonedas : Form
    {
        public rMonedas()
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

            if (error == 2 && string.IsNullOrEmpty(TipoMonedastextBox.Text))
            {
                errorProvider1.SetError(TipoMonedastextBox, "Llena TipoMonedas");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(InventariotextBox.Text))
            {
                errorProvider1.SetError(InventariotextBox, "Llena Inventario");
                errores = true;
            }


            return errores;

        }


        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            InventariotextBox.Clear();
            TipoMonedastextBox.Clear();
            InventariotextBox.Text = 0.ToString();


            errorProvider1.Clear();
        }

        private Monedas Llenaclase()
        {
            Monedas moneda = new Monedas();

            InventariotextBox.Text = 0.ToString();
            moneda.MonedasID = Convert.ToInt32(IDnumericUpDown.Value);
            moneda.TipoMonedas = TipoMonedastextBox.Text;
            moneda.Inventario = Convert.ToInt32(InventariotextBox.Text);

            return moneda;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Monedas Moneda = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("llenar campo");
            }
            else
            {
                if (IDnumericUpDown.Value == 0)
                {
                    paso = BLL.MonedasBLL.Guardar(Moneda);
                }
                else
                {
                    var P = BLL.MonedasBLL.Buscar(Convert.ToInt32(IDnumericUpDown.Value));
                    if (P != null)
                    {
                        paso = BLL.MonedasBLL.Modificar(Moneda);
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
                    MessageBox.Show("No se pudo Guardar!",
                        "trata de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("llenar los campos");
            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);
                Monedas Moneda = BLL.MonedasBLL.Buscar(id);

                if (Moneda != null)
                {
                    IDnumericUpDown.Value = Moneda.MonedasID;
                    TipoMonedastextBox.Text = Moneda.TipoMonedas;
                    InventariotextBox.Text = Moneda.Inventario.ToString();

                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!",
                        "trata de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("llenar los campos");
            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);

                if (BLL.MonedasBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se Pudo Eliminar!",
                        "trata de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();
            }
        }
    }
}
