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
    public partial class rEnvios : Form
    {
        public rEnvios()
        {
            InitializeComponent();
            LlenarComboBox();

        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }
        public void Limpiar()
        {
            EnviosIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            AutorizaciontextBox.Clear();
            BeneficiariotextBox.Clear();
            OrdenantetextBox.Clear();
            IdentidadtextBox.Clear();
            TelefonoOrdenatetextBox.Clear();
            PaisOrigentextBox.Clear();
            CajerotextBox.Clear();
           
            DetalledataGridView.DataSource = null;

           
            errorProvider1.Clear();
        }

        private Envios LlenaClase()
        {
            Envios envios = new Envios();

            envios.EnviosID = Convert.ToInt32(EnviosIDnumericUpDown.Value);
            envios.ClientesID = Convert.ToInt32(ClientecomboBox.Text);
            envios.Fecha = FechadateTimePicker.Value;
            envios.Autorizacion = AutorizaciontextBox.Text;
            envios.Beneficiario = BeneficiariotextBox.Text;
            envios.Ordenante = OrdenantetextBox.Text;
            envios.Identidad = IdentidadtextBox.Text;
            envios.TelefonoOrdenante = TelefonoOrdenatetextBox.Text;
            envios.PaisOrigen = PaisOrigentextBox.Text;
            envios.Cajero = CajerotextBox.Text;
            

            foreach (DataGridViewRow item in DetalledataGridView.Rows)
            {

                envios.AgregarDetalle
                    (ToInt(item.Cells["id"].Value),
                    envios.EnviosID,
                    ToInt(item.Cells["enviosid"].Value),
                    ToInt(item.Cells["usuarioid"].Value),
                    ToInt(item.Cells["monedasid"].Value),
                    Convert.ToString(item.Cells["monedas"].Value),
                    ToInt(item.Cells["cantidad"].Value),
                    ToInt(item.Cells["importe"].Value)
                   
                            
                 );
            }
            return envios;
        }


        private void LlenarCampos(Envios envios)
        {
            Limpiar();
            EnviosIDnumericUpDown.Value = envios.EnviosID;

            FechadateTimePicker.Value = envios.Fecha;
            AutorizaciontextBox.Text = envios.Autorizacion;
            BeneficiariotextBox.Text = envios.Beneficiario;
            OrdenantetextBox.Text = envios.Ordenante;
            EfectivocomboBox.Text = envios.Efectivo.ToString();
            TelefonoOrdenatetextBox.Text = envios.TelefonoOrdenante.ToString();


            DetalledataGridView.DataSource = envios.Detalle;

        }

       private void LlenarComboBox()
        {
            Repositorio<Clientes> Cliente = new Repositorio<Clientes>(new Contexto());
            ClientecomboBox.DataSource = Cliente.GetList(c => true);
            ClientecomboBox.ValueMember = "ClienteID";
            ClientecomboBox.DisplayMember = "Nombre";

            Repositorio<Usuarios> Usuario = new Repositorio<Usuarios>(new Contexto());
            UsuariocomboBox.DataSource = Usuario.GetList(c => true);
            UsuariocomboBox.ValueMember = "UsuarioID";
            UsuariocomboBox.DisplayMember = "Nombre";


            Repositorio<Monedas> Entrada = new Repositorio<Monedas>(new Contexto());
            EfectivocomboBox.DataSource = Entrada.GetList(c => true);
            EfectivocomboBox.ValueMember = "MonedasID";
            EfectivocomboBox.DisplayMember = "Tipomoneda";
        }


      

        private void rEnvios_Load(object sender, EventArgs e)
        {

        }

        private void EfectivocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in BLL.MonedasBLL.GetList(x => x.TipoMonedas == EfectivocomboBox.Text))
            {
                //Cantidad.Text = item.Cantidad.ToString();
            }

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            List<EnviosDetalles> Detalle = new List<EnviosDetalles>();


            if (DetalledataGridView.DataSource != null)
            {
                Detalle = (List<EnviosDetalles>)DetalledataGridView.DataSource;
            }



            foreach (var item in BLL.MonedasBLL.GetList(x => x.Inventario < CantidadnumericUpDown.Value))
            {

                MessageBox.Show("No hay ",
                    "validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (string.IsNullOrEmpty(EfectivocomboBox.Text))
            {
                MessageBox.Show("llena cantidad",
                    "validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Detalle.Add(
                    new EnviosDetalles(id: 0,
                    enviosid: (int)Convert.ToInt32(EnviosIDnumericUpDown.Value),
                       usuarioid:(int) UsuariocomboBox.SelectedValue,
                        monedasid:(int) EfectivocomboBox.SelectedValue,
                         monedas: (string)BLL.MonedasBLL.RetornarTipoMonedas(EfectivocomboBox.Text),
                       cantidad: (int)Convert.ToDecimal(CantidadnumericUpDown.Value),
                       importe: (int)Convert.ToDecimal(ImportetextBox.Text),
                       clientesid:Convert.ToInt32(EfectivocomboBox.Text)
                                     










                    ));

                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = Detalle;


        }  }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImportetextBox.Text = BLL.EnviosBLL.CalcularImporte(Convert.ToDecimal(EfectivocomboBox.Text), Convert.ToInt32(CantidadnumericUpDown.Value)).ToString();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(EnviosIDnumericUpDown.Value);
            Envios envios = BLL.EnviosBLL.Buscar(id);

            if (envios != null)
            {
                LlenarCampos(envios);

            }
            else
                MessageBox.Show("No se encontro!", "buscar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {

                List<EnviosDetalles> Detalle = (List<EnviosDetalles>)DetalledataGridView.DataSource;


                Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);

                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = Detalle;
            }
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {


                MessageBox.Show("llenar campos!",
                    "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int id = Convert.ToInt32(EnviosIDnumericUpDown.Value);
                if (BLL.EnviosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!",
                        "trata de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("agreagar moneda al grid",
                    "validar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                Envios envios = LlenaClase();
                bool Paso = false;



                if (EnviosIDnumericUpDown.Value == 0)
                {
                    Paso = BLL.EnviosBLL.Guardar(envios);
                    errorProvider1.Clear();
                }
                else
                {
                    var P = BLL.EnviosBLL.Buscar(Convert.ToInt32(EnviosIDnumericUpDown.Value));
                    if (P != null)
                    {
                        Paso = BLL.EnviosBLL.Modificar(envios);
                    }

                    errorProvider1.Clear();
                }

                if (Paso)
                {

                    MessageBox.Show("Guardado!!", "Exitosamente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo guardar!!",
                        "trata de nuevo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool Validar(int error)
        {
            bool paso = false;



            if (error == 1 && EnviosIDnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(EnviosIDnumericUpDown,
                   "No dejes id vacio");
                paso = true;
            }
            
            if (error == 2 && DetalledataGridView.RowCount == 0)
            {
                errorProvider1.SetError(DetalledataGridView,
                    "siempre agregue una efectivo");
                paso = true;
            }

            if (error == 3 && string.IsNullOrEmpty(ImportetextBox.Text))
            {
                errorProvider1.SetError(ImportetextBox,
                    "siempre agregue una efectivo");
                paso = true;
            }

            return paso;
        }
    }
}
