using SistemaEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace SistemaEnvios.UI.Consulta
{
    public partial class cEnvios : Form
    {
        List<Envios> facturas = new List<Envios>();
        public cEnvios()
        {
            InitializeComponent();
        }

        public List<Envios> Envios { get; private set; }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Envios, bool>> filtro = x => true;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.EnviosID == id && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.EnviosID == id;
                        }


                        if (BLL.EnviosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 1://ClienteID

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int clienteId = Convert.ToInt32(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.ClientesID == clienteId && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.ClientesID == clienteId;
                        }



                        if (BLL.EnviosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;


                case 2://Beneficiario

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string Beneficiario = Convert.ToString(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Beneficiario == Beneficiario && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);

                        }
                        else
                        {

                            filtro = x => x.Beneficiario == Beneficiario;
                        }

                        if (BLL.EnviosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 3://ordenante

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string Ordenante = Convert.ToString(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Ordenante == Ordenante && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);

                        }
                        else
                        {

                            filtro = x => x.Ordenante == Ordenante;
                        }

                        if (BLL.EnviosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;


                case 4://TelefonoOrdenante

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        String TelefonoOrdenante = Convert.ToString(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.TelefonoOrdenante == TelefonoOrdenante && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);

                        }
                        else
                        {

                            filtro = x => x.TelefonoOrdenante == TelefonoOrdenante;
                        }

                        if (BLL.EnviosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 5://Efectivo

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal Efectivo = Convert.ToDecimal(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Efectivo == Efectivo && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);

                        }
                        else
                        {

                            filtro = x => x.Efectivo == Efectivo;
                        }

                        if (BLL.EnviosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 6: //Todo
                    filtro = x => true;
                    break;
            }

            Envios = BLL.EnviosBLL.GetList(filtro);
            EnviosdataGridView.DataSource = Envios;
            CriteriotextBox.Clear();
            errorProvider1.Clear();
        }
            private bool Validar(int error)
              { 
                bool paso = false;
                int num = 0;

                if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
                {
                    errorProvider1.SetError(CriteriotextBox, "Por Favor, LLenar Casilla!");
                    paso = true;
                }
                if (error == 2 && int.TryParse(CriteriotextBox.Text, out num) == false)
                {
                    errorProvider1.SetError(CriteriotextBox, "Debe Digitar un Numero");
                    paso = true;
                }

                if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
                {
                    errorProvider1.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                    paso = true;
                }

                if (error == 4 && int.TryParse(CriteriotextBox.Text, out num) == true)
                {
                    errorProvider1.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                    paso = true;
                }

                if (error == 5 && int.TryParse(CriteriotextBox.Text, out num) == true)
                {
                    errorProvider1.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                    paso = true;
                }

                if (error == 6 && int.TryParse(CriteriotextBox.Text, out num) == true)
                {
                    errorProvider1.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                    paso = true;
                }

                return paso;
            }
        
    }
}
