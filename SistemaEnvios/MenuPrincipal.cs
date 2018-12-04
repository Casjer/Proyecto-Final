using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaEnvios
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registro.rUsuarios abrir = new UI.Registro.rUsuarios();
            //abrir.MdiParent = this;
            abrir.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registro.rClientes abrir = new UI.Registro.rClientes();
            //abrir.MdiParent = this;
            abrir.Show();
        }

        private void monedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registro.rMonedas abrir = new UI.Registro.rMonedas();
           // abrir.MdiParent = this;
            abrir.Show();
        }

        private void entradaMonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registro.rEntradaMonedas abrir = new UI.Registro.rEntradaMonedas();
            //abrir.MdiParent = this;
            abrir.Show();
        }

        private void enviosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registro.rEnvios abrir = new UI.Registro.rEnvios();
           // abrir.MdiParent = this;
            abrir.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UI.Consulta.cUsuarios abrir = new UI.Consulta.cUsuarios();
            //abrir.MdiParent = this;
            abrir.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consulta.cClientes abrir = new UI.Consulta.cClientes();
            //abrir.MdiParent = this;
            abrir.Show();
        }

        private void monedasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consulta.cMonedas abrir = new UI.Consulta.cMonedas();
            //abrir.MdiParent = this;
            abrir.Show();
        }

        private void entradaMonedasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consulta.cEntradaMonedas abrir = new UI.Consulta.cEntradaMonedas();
            //abrir.MdiParent = this;
            abrir.Show();
        }

        private void enviosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consulta.cEnvios abrir = new UI.Consulta.cEnvios();
            //abrir.MdiParent = this;
            abrir.Show();
        }
        
    }
}
