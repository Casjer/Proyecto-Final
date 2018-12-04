using SistemaEnvios.BLL;
using SistemaEnvios.DAL;
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
    public partial class rEntradaMonedas : Form
    {
        public rEntradaMonedas()
        {
            InitializeComponent();
        }

         private void LlenaComboBox()
        {
            Repositorio<Monedas> repositorio = new Repositorio<Monedas>(new Contexto());
            MonedacomboBox.DataSource = repositorio.GetList(c => true);
            MonedacomboBox.ValueMember = "MonedasId";
            MonedacomboBox.DisplayMember = "TipoMOnedas";
        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && IDnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(IDnumericUpDown, "Llenar Id");
                errores = true;
            }

            if (error == 2 && CantidadnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(CantidadnumericUpDown, "Llene Nombre");
                errores = true;
            }


            return errores;

        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            CantidadnumericUpDown.Value = 0;


            errorProvider1.Clear();
        }
        private EntradaMonedas Llenaclase()
        {
            EntradaMonedas EntradaMoneda = new EntradaMonedas();
            EntradaMoneda.EntradaID = Convert.ToInt32(IDnumericUpDown.Value);
            EntradaMoneda.MonedasID = (int)MonedacomboBox.SelectedValue;
            EntradaMoneda.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);


            return EntradaMoneda;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("llenar campos");
            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);
                EntradaMonedas EntradaRopa = BLL.EntradaMonedasBLL.Buscar(id);

                if (EntradaRopa != null)
                {
                    IDnumericUpDown.Value = EntradaRopa.EntradaID;
                    MonedacomboBox.SelectedValue = EntradaRopa.MonedasID;
                    CantidadnumericUpDown.Value = EntradaRopa.Cantidad;



                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!",
                        "buscar de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("llenar campos");
            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);

                if (BLL.EntradaMonedasBLL.Eliminar(id))
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

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            EntradaMonedas EntradaMoneda = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("llenar campos");
            }
            else
            {
                if (IDnumericUpDown.Value == 0)
                {
                    paso = BLL.EntradaMonedasBLL.Guardar(EntradaMoneda);
                }
                else
                {
                    var P = BLL.EntradaMonedasBLL.Buscar(Convert.ToInt32(EntradaMoneda));
                    if (P != null)
                    {
                        paso = BLL.EntradaMonedasBLL.Modificar(EntradaMoneda);
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
    }
}
