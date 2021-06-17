
namespace Design_Dashboard_Modern
{
    partial class VotacionesEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VotacionesEstudiantes));
            this.DtgVotaciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtRegistrarVoto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NumeroTarjeton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelColor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgVotaciones)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel5.SuspendLayout();
            this.bunifuGradientPanel6.SuspendLayout();
            this.PanelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgVotaciones
            // 
            this.DtgVotaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgVotaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroTarjeton,
            this.Nombre});
            this.DtgVotaciones.Location = new System.Drawing.Point(68, 178);
            this.DtgVotaciones.Name = "DtgVotaciones";
            this.DtgVotaciones.Size = new System.Drawing.Size(348, 221);
            this.DtgVotaciones.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(155, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 44);
            this.label2.TabIndex = 36;
            this.label2.Text = "VOTACIONES DE ESTUDIANTES";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtRegistrarVoto);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(152, 425);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(177, 44);
            this.bunifuGradientPanel1.TabIndex = 39;
            // 
            // BtRegistrarVoto
            // 
            this.BtRegistrarVoto.Activecolor = System.Drawing.Color.Transparent;
            this.BtRegistrarVoto.BackColor = System.Drawing.Color.Transparent;
            this.BtRegistrarVoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtRegistrarVoto.BorderRadius = 0;
            this.BtRegistrarVoto.ButtonText = "  REGISTRAR VOTO";
            this.BtRegistrarVoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRegistrarVoto.DisabledColor = System.Drawing.Color.Gray;
            this.BtRegistrarVoto.Iconcolor = System.Drawing.Color.Transparent;
            this.BtRegistrarVoto.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtRegistrarVoto.Iconimage")));
            this.BtRegistrarVoto.Iconimage_right = null;
            this.BtRegistrarVoto.Iconimage_right_Selected = null;
            this.BtRegistrarVoto.Iconimage_Selected = null;
            this.BtRegistrarVoto.IconMarginLeft = 8;
            this.BtRegistrarVoto.IconMarginRight = 0;
            this.BtRegistrarVoto.IconRightVisible = true;
            this.BtRegistrarVoto.IconRightZoom = 0D;
            this.BtRegistrarVoto.IconVisible = true;
            this.BtRegistrarVoto.IconZoom = 80D;
            this.BtRegistrarVoto.IsTab = false;
            this.BtRegistrarVoto.Location = new System.Drawing.Point(4, 1);
            this.BtRegistrarVoto.Name = "BtRegistrarVoto";
            this.BtRegistrarVoto.Normalcolor = System.Drawing.Color.Transparent;
            this.BtRegistrarVoto.OnHovercolor = System.Drawing.Color.Blue;
            this.BtRegistrarVoto.OnHoverTextColor = System.Drawing.Color.White;
            this.BtRegistrarVoto.selected = false;
            this.BtRegistrarVoto.Size = new System.Drawing.Size(168, 43);
            this.BtRegistrarVoto.TabIndex = 28;
            this.BtRegistrarVoto.Text = "  REGISTRAR VOTO";
            this.BtRegistrarVoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRegistrarVoto.Textcolor = System.Drawing.Color.White;
            this.BtRegistrarVoto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(626, 447);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(155, 44);
            this.bunifuGradientPanel4.TabIndex = 40;
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
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.Controls.Add(this.BtConsultar);
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(419, 72);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(55, 44);
            this.bunifuGradientPanel5.TabIndex = 52;
            // 
            // BtConsultar
            // 
            this.BtConsultar.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtConsultar.BorderRadius = 0;
            this.BtConsultar.ButtonText = "";
            this.BtConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.BtConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtConsultar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtConsultar.Iconimage")));
            this.BtConsultar.Iconimage_right = null;
            this.BtConsultar.Iconimage_right_Selected = null;
            this.BtConsultar.Iconimage_Selected = null;
            this.BtConsultar.IconMarginLeft = 8;
            this.BtConsultar.IconMarginRight = 0;
            this.BtConsultar.IconRightVisible = true;
            this.BtConsultar.IconRightZoom = 0D;
            this.BtConsultar.IconVisible = true;
            this.BtConsultar.IconZoom = 80D;
            this.BtConsultar.IsTab = false;
            this.BtConsultar.Location = new System.Drawing.Point(1, 2);
            this.BtConsultar.Name = "BtConsultar";
            this.BtConsultar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultar.selected = false;
            this.BtConsultar.Size = new System.Drawing.Size(49, 43);
            this.BtConsultar.TabIndex = 28;
            this.BtConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultar.Textcolor = System.Drawing.Color.White;
            this.BtConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtConsultar.Click += new System.EventHandler(this.BtConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(64, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Identificacion";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(196, 131);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(351, 26);
            this.TxtNombre.TabIndex = 49;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.labNombre.Location = new System.Drawing.Point(64, 131);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(65, 20);
            this.labNombre.TabIndex = 48;
            this.labNombre.Text = "Nombre";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(196, 90);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(210, 26);
            this.TxtIdentificacion.TabIndex = 47;
            // 
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.Controls.Add(this.BtLimpiar);
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(492, 72);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(55, 44);
            this.bunifuGradientPanel6.TabIndex = 53;
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Activecolor = System.Drawing.Color.Transparent;
            this.BtLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BtLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtLimpiar.BorderRadius = 0;
            this.BtLimpiar.ButtonText = "";
            this.BtLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.BtLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtLimpiar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtLimpiar.Iconimage")));
            this.BtLimpiar.Iconimage_right = null;
            this.BtLimpiar.Iconimage_right_Selected = null;
            this.BtLimpiar.Iconimage_Selected = null;
            this.BtLimpiar.IconMarginLeft = 8;
            this.BtLimpiar.IconMarginRight = 0;
            this.BtLimpiar.IconRightVisible = true;
            this.BtLimpiar.IconRightZoom = 0D;
            this.BtLimpiar.IconVisible = true;
            this.BtLimpiar.IconZoom = 80D;
            this.BtLimpiar.IsTab = false;
            this.BtLimpiar.Location = new System.Drawing.Point(0, 1);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtLimpiar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtLimpiar.selected = false;
            this.BtLimpiar.Size = new System.Drawing.Size(55, 44);
            this.BtLimpiar.TabIndex = 28;
            this.BtLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtLimpiar.Textcolor = System.Drawing.Color.White;
            this.BtLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // NumeroTarjeton
            // 
            this.NumeroTarjeton.HeaderText = "NumeroTarjeton";
            this.NumeroTarjeton.Name = "NumeroTarjeton";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // PanelColor
            // 
            this.PanelColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelColor.BackgroundImage")));
            this.PanelColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelColor.Controls.Add(this.pictureBox1);
            this.PanelColor.GradientBottomLeft = System.Drawing.Color.Blue;
            this.PanelColor.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.PanelColor.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PanelColor.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelColor.Location = new System.Drawing.Point(518, 178);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Quality = 10;
            this.PanelColor.Size = new System.Drawing.Size(263, 237);
            this.PanelColor.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // VotacionesEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.PanelColor);
            this.Controls.Add(this.bunifuGradientPanel6);
            this.Controls.Add(this.bunifuGradientPanel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtgVotaciones);
            this.Name = "VotacionesEstudiantes";
            this.Text = "Consultar Ganancias";
            this.Load += new System.EventHandler(this.ConsultarGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgVotaciones)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel5.ResumeLayout(false);
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.PanelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgVotaciones;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtRegistrarVoto;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.Button BtCancelar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private Bunifu.Framework.UI.BunifuFlatButton BtLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTarjeton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}