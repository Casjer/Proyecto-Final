namespace SistemaEnvios.UI.Registro
{
    partial class rEnvios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EnviosIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AutorizaciontextBox = new System.Windows.Forms.TextBox();
            this.BeneficiariotextBox = new System.Windows.Forms.TextBox();
            this.OrdenantetextBox = new System.Windows.Forms.TextBox();
            this.IdentidadtextBox = new System.Windows.Forms.TextBox();
            this.TelefonoOrdenatetextBox = new System.Windows.Forms.TextBox();
            this.PaisOrigentextBox = new System.Windows.Forms.TextBox();
            this.CajerotextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.EfectivocomboBox = new System.Windows.Forms.ComboBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnviosIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nuevobutton.Image = global::SistemaEnvios.Properties.Resources.icons8_Add_Property_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.Location = new System.Drawing.Point(108, 382);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(84, 56);
            this.Nuevobutton.TabIndex = 0;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Guardarbutton.Image = global::SistemaEnvios.Properties.Resources.icons8_Save_as_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.Location = new System.Drawing.Point(231, 382);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(87, 56);
            this.Guardarbutton.TabIndex = 1;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Eliminarbutton.Image = global::SistemaEnvios.Properties.Resources.icons8_Delete_Document_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.Location = new System.Drawing.Point(375, 382);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(84, 56);
            this.Eliminarbutton.TabIndex = 2;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Buscarbutton.Image = global::SistemaEnvios.Properties.Resources.icons8_Search_Property_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.Location = new System.Drawing.Point(680, 7);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 36);
            this.Buscarbutton.TabIndex = 3;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "EnviosID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(29, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(39, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Efectivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(29, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(372, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "TelefonoOrdenante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(372, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "PaisOrigen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(372, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cajero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(29, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Autorizacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(29, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Beneficiario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(372, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ordenante";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(372, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Identidad";
            // 
            // EnviosIDnumericUpDown
            // 
            this.EnviosIDnumericUpDown.Location = new System.Drawing.Point(108, 17);
            this.EnviosIDnumericUpDown.Name = "EnviosIDnumericUpDown";
            this.EnviosIDnumericUpDown.Size = new System.Drawing.Size(115, 20);
            this.EnviosIDnumericUpDown.TabIndex = 16;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(108, 76);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.FechadateTimePicker.TabIndex = 19;
            // 
            // AutorizaciontextBox
            // 
            this.AutorizaciontextBox.Location = new System.Drawing.Point(108, 109);
            this.AutorizaciontextBox.Name = "AutorizaciontextBox";
            this.AutorizaciontextBox.Size = new System.Drawing.Size(115, 20);
            this.AutorizaciontextBox.TabIndex = 20;
            // 
            // BeneficiariotextBox
            // 
            this.BeneficiariotextBox.Location = new System.Drawing.Point(108, 140);
            this.BeneficiariotextBox.Name = "BeneficiariotextBox";
            this.BeneficiariotextBox.Size = new System.Drawing.Size(115, 20);
            this.BeneficiariotextBox.TabIndex = 21;
            // 
            // OrdenantetextBox
            // 
            this.OrdenantetextBox.Location = new System.Drawing.Point(485, 16);
            this.OrdenantetextBox.Name = "OrdenantetextBox";
            this.OrdenantetextBox.Size = new System.Drawing.Size(142, 20);
            this.OrdenantetextBox.TabIndex = 22;
            // 
            // IdentidadtextBox
            // 
            this.IdentidadtextBox.Location = new System.Drawing.Point(485, 42);
            this.IdentidadtextBox.Name = "IdentidadtextBox";
            this.IdentidadtextBox.Size = new System.Drawing.Size(142, 20);
            this.IdentidadtextBox.TabIndex = 23;
            // 
            // TelefonoOrdenatetextBox
            // 
            this.TelefonoOrdenatetextBox.Location = new System.Drawing.Point(485, 73);
            this.TelefonoOrdenatetextBox.Name = "TelefonoOrdenatetextBox";
            this.TelefonoOrdenatetextBox.Size = new System.Drawing.Size(142, 20);
            this.TelefonoOrdenatetextBox.TabIndex = 24;
            // 
            // PaisOrigentextBox
            // 
            this.PaisOrigentextBox.Location = new System.Drawing.Point(485, 102);
            this.PaisOrigentextBox.Name = "PaisOrigentextBox";
            this.PaisOrigentextBox.Size = new System.Drawing.Size(142, 20);
            this.PaisOrigentextBox.TabIndex = 25;
            // 
            // CajerotextBox
            // 
            this.CajerotextBox.Location = new System.Drawing.Point(485, 136);
            this.CajerotextBox.Name = "CajerotextBox";
            this.CajerotextBox.Size = new System.Drawing.Size(142, 20);
            this.CajerotextBox.TabIndex = 27;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(42, 243);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(608, 133);
            this.DetalledataGridView.TabIndex = 28;
            // 
            // EfectivocomboBox
            // 
            this.EfectivocomboBox.FormattingEnabled = true;
            this.EfectivocomboBox.Location = new System.Drawing.Point(91, 216);
            this.EfectivocomboBox.Name = "EfectivocomboBox";
            this.EfectivocomboBox.Size = new System.Drawing.Size(82, 21);
            this.EfectivocomboBox.TabIndex = 29;
            this.EfectivocomboBox.SelectedIndexChanged += new System.EventHandler(this.EfectivocomboBox_SelectedIndexChanged);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Agregarbutton.Image = global::SistemaEnvios.Properties.Resources.icons8_Add_Property_32;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(575, 199);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 38);
            this.Agregarbutton.TabIndex = 84;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = false;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Removerbutton.Image = global::SistemaEnvios.Properties.Resources.icons8_Delete_Document_32;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Removerbutton.Location = new System.Drawing.Point(565, 382);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(75, 56);
            this.Removerbutton.TabIndex = 97;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Removerbutton.UseVisualStyleBackColor = false;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(108, 46);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(115, 21);
            this.ClientecomboBox.TabIndex = 98;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cantidad.Location = new System.Drawing.Point(198, 224);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 99;
            this.Cantidad.Text = "Cantidad";
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(264, 217);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(82, 20);
            this.CantidadnumericUpDown.TabIndex = 100;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(29, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Usuario";
            // 
            // UsuariocomboBox
            // 
            this.UsuariocomboBox.FormattingEnabled = true;
            this.UsuariocomboBox.Location = new System.Drawing.Point(108, 169);
            this.UsuariocomboBox.Name = "UsuariocomboBox";
            this.UsuariocomboBox.Size = new System.Drawing.Size(115, 21);
            this.UsuariocomboBox.TabIndex = 102;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 103;
            this.label13.Text = "Importe";
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(428, 218);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.Size = new System.Drawing.Size(82, 20);
            this.ImportetextBox.TabIndex = 104;
            // 
            // rEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEnvios.Properties.Resources.images1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.ImportetextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.UsuariocomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.EfectivocomboBox);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.CajerotextBox);
            this.Controls.Add(this.PaisOrigentextBox);
            this.Controls.Add(this.TelefonoOrdenatetextBox);
            this.Controls.Add(this.IdentidadtextBox);
            this.Controls.Add(this.OrdenantetextBox);
            this.Controls.Add(this.BeneficiariotextBox);
            this.Controls.Add(this.AutorizaciontextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.EnviosIDnumericUpDown);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Name = "rEnvios";
            this.Text = "rEnvios";
            this.Load += new System.EventHandler(this.rEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnviosIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown EnviosIDnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox AutorizaciontextBox;
        private System.Windows.Forms.TextBox BeneficiariotextBox;
        private System.Windows.Forms.TextBox OrdenantetextBox;
        private System.Windows.Forms.TextBox IdentidadtextBox;
        private System.Windows.Forms.TextBox TelefonoOrdenatetextBox;
        private System.Windows.Forms.TextBox PaisOrigentextBox;
        private System.Windows.Forms.TextBox CajerotextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox EfectivocomboBox;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.ComboBox UsuariocomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.Label label13;
    }
}