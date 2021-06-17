
namespace Design_Dashboard_Modern
{
    partial class ConsultaModPensionado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaModPensionado));
            this.DataGridPensionados = new System.Windows.Forms.DataGridView();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.TxtCantidadH = new System.Windows.Forms.TextBox();
            this.TxtTotalPensionados = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtFiltroIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCantidadM = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCarrera = new System.Windows.Forms.ComboBox();
            this.DtgIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPensionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridPensionados
            // 
            this.DataGridPensionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPensionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DtgIdentificacion,
            this.DtgNombre,
            this.DtgApellido,
            this.DtgSexo,
            this.DtgCarrera,
            this.DtgTelefono});
            this.DataGridPensionados.Location = new System.Drawing.Point(84, 175);
            this.DataGridPensionados.Name = "DataGridPensionados";
            this.DataGridPensionados.Size = new System.Drawing.Size(647, 187);
            this.DataGridPensionados.TabIndex = 28;
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Por Hombres",
            "Por Mujeres"});
            this.CmbFiltro.Location = new System.Drawing.Point(554, 85);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(177, 28);
            this.CmbFiltro.TabIndex = 29;
            // 
            // TxtCantidadH
            // 
            this.TxtCantidadH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadH.Location = new System.Drawing.Point(269, 422);
            this.TxtCantidadH.Name = "TxtCantidadH";
            this.TxtCantidadH.Size = new System.Drawing.Size(40, 26);
            this.TxtCantidadH.TabIndex = 32;
            this.TxtCantidadH.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtTotalPensionados
            // 
            this.TxtTotalPensionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPensionados.Location = new System.Drawing.Point(269, 463);
            this.TxtTotalPensionados.Name = "TxtTotalPensionados";
            this.TxtTotalPensionados.Size = new System.Drawing.Size(40, 26);
            this.TxtTotalPensionados.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(202, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(462, 44);
            this.label6.TabIndex = 38;
            this.label6.Text = "CONSULTA PENSIONADOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(423, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tipos de filtro";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(99, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Identificacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(99, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Total de pensionados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(99, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Cantidad de hombres";
            // 
            // TxtFiltroIdentificacion
            // 
            this.TxtFiltroIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltroIdentificacion.Location = new System.Drawing.Point(210, 87);
            this.TxtFiltroIdentificacion.Name = "TxtFiltroIdentificacion";
            this.TxtFiltroIdentificacion.Size = new System.Drawing.Size(138, 26);
            this.TxtFiltroIdentificacion.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(99, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cantidad de mujeres";
            // 
            // TxtCantidadM
            // 
            this.TxtCantidadM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadM.Location = new System.Drawing.Point(269, 382);
            this.TxtCantidadM.Name = "TxtCantidadM";
            this.TxtCantidadM.Size = new System.Drawing.Size(40, 26);
            this.TxtCantidadM.TabIndex = 45;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.BtCancelar);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(576, 412);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(155, 44);
            this.bunifuGradientPanel4.TabIndex = 46;
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCancelar.Location = new System.Drawing.Point(5, 0);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(145, 44);
            this.BtCancelar.TabIndex = 13;
            this.BtCancelar.Text = "CANCELAR";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.ButCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(423, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Filtro por carrera";
            // 
            // CmbCarrera
            // 
            this.CmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Items.AddRange(new object[] {
            "PSICOLOGIA ",
            "ENFERMERIA",
            "ADMINISTRACION DE EMPRESAS",
            "ADMINISTRACION DE EMPRESAS TURISTICAS Y HOTELERAS",
            "COMERCIO INTERNACIONAL",
            "CONTADURIA PUBLICA ",
            "ECONOMIA",
            "DERECHO",
            "PSICOLOGIA",
            "SOCIOLOGIA",
            "ENFERMERIA",
            "INSTRUMENTACION QUIRURGICA ",
            "MICROBIOLOGIA",
            "INGENIERIA AGROINDUSTRIAL ",
            "INGENIERIA AMBIENTAL Y SANITARIAS",
            "INGENIERIA SISTEMAS",
            "INGENIERIA ELECTRONICA",
            "LICENCIATURA EN MATEMATICAS",
            "LICENCIATURA ESPAÑOL E INGLES",
            "LICENCIATURA EN LITERATURA Y LENGUAS CASTELLANAS",
            "LICENCIATURA EN EDUCACION FISICA, RECREACION Y DEPORTES",
            "LICENCIATURA EN CIENCIAS NATURALES Y EDUCACION AMBIENTAL",
            "LICENCIATURA EN ARTE",
            "MUSICA"});
            this.CmbCarrera.Location = new System.Drawing.Point(554, 133);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(177, 28);
            this.CmbCarrera.TabIndex = 48;
            // 
            // DtgIdentificacion
            // 
            this.DtgIdentificacion.HeaderText = "Identificacion";
            this.DtgIdentificacion.Name = "DtgIdentificacion";
            // 
            // DtgNombre
            // 
            this.DtgNombre.HeaderText = "Nombre";
            this.DtgNombre.Name = "DtgNombre";
            // 
            // DtgApellido
            // 
            this.DtgApellido.HeaderText = "Apellido";
            this.DtgApellido.Name = "DtgApellido";
            // 
            // DtgSexo
            // 
            this.DtgSexo.HeaderText = "Sexo";
            this.DtgSexo.Name = "DtgSexo";
            // 
            // DtgCarrera
            // 
            this.DtgCarrera.HeaderText = "Carrera";
            this.DtgCarrera.Name = "DtgCarrera";
            // 
            // DtgTelefono
            // 
            this.DtgTelefono.HeaderText = "Telefono";
            this.DtgTelefono.Name = "DtgTelefono";
            // 
            // ConsultaModPensionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.CmbCarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.TxtCantidadM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFiltroIdentificacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtTotalPensionados);
            this.Controls.Add(this.TxtCantidadH);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.DataGridPensionados);
            this.Name = "ConsultaModPensionado";
            this.Text = "ModificarPensionados";
            this.Load += new System.EventHandler(this.ModificarPensionados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPensionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridPensionados;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.TextBox TxtCantidadH;
        private System.Windows.Forms.TextBox TxtTotalPensionados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtFiltroIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCantidadM;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgTelefono;
    }
}