namespace SistemaEnvios.UI.Consulta
{
    partial class cEnvios
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
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.desdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnviosdataGridView = new System.Windows.Forms.DataGridView();
            this.reportebutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FechacheckBox = new System.Windows.Forms.CheckBox();
            this.Consulta = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EnviosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Id",
            "ClienteId",
            "Beneficiario",
            "Ordenante",
            "TelefonoOrdenante",
            "Efectivo",
            "Todos"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(95, 16);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Filtro:";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(302, 17);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(168, 20);
            this.CriteriotextBox.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Criterio:";
            // 
            // desdedateTimePicker
            // 
            this.desdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.desdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdedateTimePicker.Location = new System.Drawing.Point(95, 75);
            this.desdedateTimePicker.Name = "desdedateTimePicker";
            this.desdedateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.desdedateTimePicker.TabIndex = 51;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTimePicker.Location = new System.Drawing.Point(302, 74);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.HastadateTimePicker.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Hasta:";
            // 
            // EnviosdataGridView
            // 
            this.EnviosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnviosdataGridView.Location = new System.Drawing.Point(37, 124);
            this.EnviosdataGridView.Name = "EnviosdataGridView";
            this.EnviosdataGridView.Size = new System.Drawing.Size(480, 219);
            this.EnviosdataGridView.TabIndex = 55;
            // 
            // reportebutton
            // 
            this.reportebutton.FlatAppearance.BorderSize = 0;
            this.reportebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportebutton.Image = global::SistemaEnvios.Properties.Resources.icons8_Print_321;
            this.reportebutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportebutton.Location = new System.Drawing.Point(37, 366);
            this.reportebutton.Name = "reportebutton";
            this.reportebutton.Size = new System.Drawing.Size(75, 51);
            this.reportebutton.TabIndex = 56;
            this.reportebutton.Text = "Reporte";
            this.reportebutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportebutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Image = global::SistemaEnvios.Properties.Resources.icons8_Search_Property_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.Location = new System.Drawing.Point(476, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 37);
            this.Buscarbutton.TabIndex = 57;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FechacheckBox
            // 
            this.FechacheckBox.AutoSize = true;
            this.FechacheckBox.Checked = true;
            this.FechacheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FechacheckBox.Location = new System.Drawing.Point(95, 43);
            this.FechacheckBox.Name = "FechacheckBox";
            this.FechacheckBox.Size = new System.Drawing.Size(56, 17);
            this.FechacheckBox.TabIndex = 58;
            this.FechacheckBox.Text = "Fecha";
            this.FechacheckBox.UseVisualStyleBackColor = true;
            // 
            // Consulta
            // 
            this.Consulta.AutoSize = true;
            this.Consulta.Location = new System.Drawing.Point(37, 108);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(47, 13);
            this.Consulta.TabIndex = 59;
            this.Consulta.Text = "consulta";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 441);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.FechacheckBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.reportebutton);
            this.Controls.Add(this.EnviosdataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.desdedateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrocomboBox);
            this.MaximumSize = new System.Drawing.Size(579, 480);
            this.MinimumSize = new System.Drawing.Size(579, 480);
            this.Name = "cEnvios";
            this.Text = "cEnvios";
            ((System.ComponentModel.ISupportInitialize)(this.EnviosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker desdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView EnviosdataGridView;
        private System.Windows.Forms.Button reportebutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.CheckBox FechacheckBox;
        private System.Windows.Forms.Label Consulta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}