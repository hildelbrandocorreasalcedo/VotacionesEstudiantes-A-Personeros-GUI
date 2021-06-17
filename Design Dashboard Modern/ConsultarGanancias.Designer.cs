
namespace Design_Dashboard_Modern
{
    partial class ConsultarGanancias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarGanancias));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtCancelarGanancias = new System.Windows.Forms.Button();
            this.BtConsultarGanancias = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelColor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtConsultarGanancias)).BeginInit();
            this.PanelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // BtCancelarGanancias
            // 
            this.BtCancelarGanancias.Location = new System.Drawing.Point(557, 408);
            this.BtCancelarGanancias.Name = "BtCancelarGanancias";
            this.BtCancelarGanancias.Size = new System.Drawing.Size(106, 52);
            this.BtCancelarGanancias.TabIndex = 17;
            this.BtCancelarGanancias.Text = "CANCELAR";
            this.BtCancelarGanancias.UseVisualStyleBackColor = true;
            this.BtCancelarGanancias.Click += new System.EventHandler(this.BtCancelarGanancias_Click);
            // 
            // BtConsultarGanancias
            // 
            this.BtConsultarGanancias.Image = ((System.Drawing.Image)(resources.GetObject("BtConsultarGanancias.Image")));
            this.BtConsultarGanancias.Location = new System.Drawing.Point(444, 91);
            this.BtConsultarGanancias.Name = "BtConsultarGanancias";
            this.BtConsultarGanancias.Size = new System.Drawing.Size(37, 28);
            this.BtConsultarGanancias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtConsultarGanancias.TabIndex = 35;
            this.BtConsultarGanancias.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(184, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 44);
            this.label2.TabIndex = 36;
            this.label2.Text = "CONSULTAR GANANCIAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(94, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Filtro por fecha";
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
            this.PanelColor.Location = new System.Drawing.Point(668, 10);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Quality = 10;
            this.PanelColor.Size = new System.Drawing.Size(127, 121);
            this.PanelColor.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultarGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.PanelColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtConsultarGanancias);
            this.Controls.Add(this.BtCancelarGanancias);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarGanancias";
            this.Text = "Consultar Ganancias";
            this.Load += new System.EventHandler(this.ConsultarGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtConsultarGanancias)).EndInit();
            this.PanelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtCancelarGanancias;
        private System.Windows.Forms.PictureBox BtConsultarGanancias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}