
namespace Design_Dashboard_Modern
{
    partial class MenuHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHotel));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.PanelHijo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.BtIngrGast = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtRegistrarCandidatos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubPensionados = new System.Windows.Forms.Panel();
            this.BtVotacionesEstudiantes = new System.Windows.Forms.Button();
            this.BtConsultarEstudiantes = new System.Windows.Forms.Button();
            this.BTEstudiantes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.PanelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.PanelSideMenu.SuspendLayout();
            this.panelSubPensionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.AnimacionSidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.MenuSidebar);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.Salir);
            this.bunifuGradientPanel1.Controls.Add(this.Maximizar);
            this.bunifuGradientPanel1.Controls.Add(this.Restaurar);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.Minimizar);
            this.AnimacionSidebar.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1131, 75);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // MenuSidebar
            // 
            this.MenuSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(19, 14);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(50, 44);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 24;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(176, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "VOTACIONES DEL PERSONERO";
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1089, 21);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1053, 21);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1053, 21);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1017, 21);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // PanelHijo
            // 
            this.PanelHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelHijo.Controls.Add(this.pictureBox3);
            this.AnimacionSidebar.SetDecoration(this.PanelHijo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.PanelHijo, BunifuAnimatorNS.DecorationType.None);
            this.PanelHijo.Location = new System.Drawing.Point(6, 11);
            this.PanelHijo.Name = "PanelHijo";
            this.PanelHijo.Size = new System.Drawing.Size(833, 553);
            this.PanelHijo.TabIndex = 4;
            this.PanelHijo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHijo_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(285, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(288, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.label3);
            this.Sidebar.Controls.Add(this.PanelSideMenu);
            this.Sidebar.Controls.Add(this.BTEstudiantes);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label4);
            this.Sidebar.Controls.Add(this.pictureBox4);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.Blue;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(11, 11);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(260, 553);
            this.Sidebar.TabIndex = 19;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(122, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "2021-1";
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.AutoScroll = true;
            this.PanelSideMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelSideMenu.Controls.Add(this.BtIngrGast);
            this.PanelSideMenu.Controls.Add(this.BtRegistrarCandidatos);
            this.PanelSideMenu.Controls.Add(this.panelSubPensionados);
            this.AnimacionSidebar.SetDecoration(this.PanelSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.PanelSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelSideMenu.Location = new System.Drawing.Point(7, 130);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(245, 418);
            this.PanelSideMenu.TabIndex = 2;
            // 
            // BtIngrGast
            // 
            this.BtIngrGast.Activecolor = System.Drawing.Color.Transparent;
            this.BtIngrGast.BackColor = System.Drawing.Color.Transparent;
            this.BtIngrGast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIngrGast.BorderRadius = 0;
            this.BtIngrGast.ButtonText = "      RESULTADOS CANDIDATOS";
            this.BtIngrGast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtIngrGast, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtIngrGast, BunifuAnimatorNS.DecorationType.None);
            this.BtIngrGast.DisabledColor = System.Drawing.Color.Gray;
            this.BtIngrGast.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtIngrGast.Iconcolor = System.Drawing.Color.Transparent;
            this.BtIngrGast.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtIngrGast.Iconimage")));
            this.BtIngrGast.Iconimage_right = null;
            this.BtIngrGast.Iconimage_right_Selected = null;
            this.BtIngrGast.Iconimage_Selected = null;
            this.BtIngrGast.IconMarginLeft = 9;
            this.BtIngrGast.IconMarginRight = 0;
            this.BtIngrGast.IconRightVisible = true;
            this.BtIngrGast.IconRightZoom = 0D;
            this.BtIngrGast.IconVisible = true;
            this.BtIngrGast.IconZoom = 90D;
            this.BtIngrGast.IsTab = false;
            this.BtIngrGast.Location = new System.Drawing.Point(0, 134);
            this.BtIngrGast.Margin = new System.Windows.Forms.Padding(5);
            this.BtIngrGast.Name = "BtIngrGast";
            this.BtIngrGast.Normalcolor = System.Drawing.Color.Transparent;
            this.BtIngrGast.OnHovercolor = System.Drawing.Color.Blue;
            this.BtIngrGast.OnHoverTextColor = System.Drawing.Color.White;
            this.BtIngrGast.selected = false;
            this.BtIngrGast.Size = new System.Drawing.Size(245, 46);
            this.BtIngrGast.TabIndex = 19;
            this.BtIngrGast.Text = "      RESULTADOS CANDIDATOS";
            this.BtIngrGast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtIngrGast.Textcolor = System.Drawing.Color.LightGray;
            this.BtIngrGast.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtIngrGast.Click += new System.EventHandler(this.BtIngrGast_Click);
            // 
            // BtRegistrarCandidatos
            // 
            this.BtRegistrarCandidatos.Activecolor = System.Drawing.Color.Transparent;
            this.BtRegistrarCandidatos.BackColor = System.Drawing.Color.Transparent;
            this.BtRegistrarCandidatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtRegistrarCandidatos.BorderRadius = 0;
            this.BtRegistrarCandidatos.ButtonText = "         REGISTRAR CANDIDATOS";
            this.BtRegistrarCandidatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BtRegistrarCandidatos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtRegistrarCandidatos, BunifuAnimatorNS.DecorationType.None);
            this.BtRegistrarCandidatos.DisabledColor = System.Drawing.Color.Gray;
            this.BtRegistrarCandidatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtRegistrarCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegistrarCandidatos.Iconcolor = System.Drawing.Color.Transparent;
            this.BtRegistrarCandidatos.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtRegistrarCandidatos.Iconimage")));
            this.BtRegistrarCandidatos.Iconimage_right = null;
            this.BtRegistrarCandidatos.Iconimage_right_Selected = null;
            this.BtRegistrarCandidatos.Iconimage_Selected = null;
            this.BtRegistrarCandidatos.IconMarginLeft = 14;
            this.BtRegistrarCandidatos.IconMarginRight = 0;
            this.BtRegistrarCandidatos.IconRightVisible = true;
            this.BtRegistrarCandidatos.IconRightZoom = 0D;
            this.BtRegistrarCandidatos.IconVisible = true;
            this.BtRegistrarCandidatos.IconZoom = 60D;
            this.BtRegistrarCandidatos.IsTab = false;
            this.BtRegistrarCandidatos.Location = new System.Drawing.Point(0, 88);
            this.BtRegistrarCandidatos.Margin = new System.Windows.Forms.Padding(4);
            this.BtRegistrarCandidatos.Name = "BtRegistrarCandidatos";
            this.BtRegistrarCandidatos.Normalcolor = System.Drawing.Color.Transparent;
            this.BtRegistrarCandidatos.OnHovercolor = System.Drawing.Color.Blue;
            this.BtRegistrarCandidatos.OnHoverTextColor = System.Drawing.Color.White;
            this.BtRegistrarCandidatos.selected = false;
            this.BtRegistrarCandidatos.Size = new System.Drawing.Size(245, 46);
            this.BtRegistrarCandidatos.TabIndex = 18;
            this.BtRegistrarCandidatos.Text = "         REGISTRAR CANDIDATOS";
            this.BtRegistrarCandidatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRegistrarCandidatos.Textcolor = System.Drawing.Color.LightGray;
            this.BtRegistrarCandidatos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtRegistrarCandidatos.Click += new System.EventHandler(this.BtReservas_Click);
            // 
            // panelSubPensionados
            // 
            this.panelSubPensionados.Controls.Add(this.BtVotacionesEstudiantes);
            this.panelSubPensionados.Controls.Add(this.BtConsultarEstudiantes);
            this.AnimacionSidebar.SetDecoration(this.panelSubPensionados, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panelSubPensionados, BunifuAnimatorNS.DecorationType.None);
            this.panelSubPensionados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubPensionados.Location = new System.Drawing.Point(0, 0);
            this.panelSubPensionados.Name = "panelSubPensionados";
            this.panelSubPensionados.Size = new System.Drawing.Size(245, 88);
            this.panelSubPensionados.TabIndex = 2;
            // 
            // BtVotacionesEstudiantes
            // 
            this.BtVotacionesEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.BtVotacionesEstudiantes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtVotacionesEstudiantes, BunifuAnimatorNS.DecorationType.None);
            this.BtVotacionesEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtVotacionesEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVotacionesEstudiantes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtVotacionesEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("BtVotacionesEstudiantes.Image")));
            this.BtVotacionesEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtVotacionesEstudiantes.Location = new System.Drawing.Point(0, 43);
            this.BtVotacionesEstudiantes.Name = "BtVotacionesEstudiantes";
            this.BtVotacionesEstudiantes.Size = new System.Drawing.Size(245, 42);
            this.BtVotacionesEstudiantes.TabIndex = 3;
            this.BtVotacionesEstudiantes.Text = "                  VOTACIONES ESTUDIANTES";
            this.BtVotacionesEstudiantes.UseVisualStyleBackColor = false;
            this.BtVotacionesEstudiantes.Click += new System.EventHandler(this.BtConsultarPensionado_Click);
            // 
            // BtConsultarEstudiantes
            // 
            this.AnimacionSidebarBack.SetDecoration(this.BtConsultarEstudiantes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BtConsultarEstudiantes, BunifuAnimatorNS.DecorationType.None);
            this.BtConsultarEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtConsultarEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConsultarEstudiantes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtConsultarEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("BtConsultarEstudiantes.Image")));
            this.BtConsultarEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultarEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.BtConsultarEstudiantes.Name = "BtConsultarEstudiantes";
            this.BtConsultarEstudiantes.Size = new System.Drawing.Size(245, 43);
            this.BtConsultarEstudiantes.TabIndex = 2;
            this.BtConsultarEstudiantes.Text = "             CONSULTA ESTUDIANTES";
            this.BtConsultarEstudiantes.UseVisualStyleBackColor = true;
            this.BtConsultarEstudiantes.Click += new System.EventHandler(this.BtRegistrarPencionado_Click);
            // 
            // BTEstudiantes
            // 
            this.BTEstudiantes.Activecolor = System.Drawing.Color.Transparent;
            this.BTEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.BTEstudiantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTEstudiantes.BorderRadius = 0;
            this.BTEstudiantes.ButtonText = "        ESTUDIANTES";
            this.BTEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.BTEstudiantes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BTEstudiantes, BunifuAnimatorNS.DecorationType.None);
            this.BTEstudiantes.DisabledColor = System.Drawing.Color.Gray;
            this.BTEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEstudiantes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BTEstudiantes.Iconcolor = System.Drawing.Color.Transparent;
            this.BTEstudiantes.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTEstudiantes.Iconimage")));
            this.BTEstudiantes.Iconimage_right = null;
            this.BTEstudiantes.Iconimage_right_Selected = null;
            this.BTEstudiantes.Iconimage_Selected = null;
            this.BTEstudiantes.IconMarginLeft = 14;
            this.BTEstudiantes.IconMarginRight = 0;
            this.BTEstudiantes.IconRightVisible = true;
            this.BTEstudiantes.IconRightZoom = 0D;
            this.BTEstudiantes.IconVisible = true;
            this.BTEstudiantes.IconZoom = 60D;
            this.BTEstudiantes.IsTab = false;
            this.BTEstudiantes.Location = new System.Drawing.Point(8, 82);
            this.BTEstudiantes.Name = "BTEstudiantes";
            this.BTEstudiantes.Normalcolor = System.Drawing.Color.Transparent;
            this.BTEstudiantes.OnHovercolor = System.Drawing.Color.Blue;
            this.BTEstudiantes.OnHoverTextColor = System.Drawing.Color.White;
            this.BTEstudiantes.selected = false;
            this.BTEstudiantes.Size = new System.Drawing.Size(244, 46);
            this.BTEstudiantes.TabIndex = 20;
            this.BTEstudiantes.Text = "        ESTUDIANTES";
            this.BTEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTEstudiantes.Textcolor = System.Drawing.Color.LightGray;
            this.BTEstudiantes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BTEstudiantes.Click += new System.EventHandler(this.BTPensionados_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(235, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "VOTACIONES";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 75);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(280, 576);
            this.SidebarWrapper.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.PanelHijo);
            this.AnimacionSidebar.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(280, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 576);
            this.panel3.TabIndex = 21;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.bunifuGradientPanel1;
            this.MoverDashboard.Vertical = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation6;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 1;
            animation5.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 2F;
            animation5.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation5;
            // 
            // MenuHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.panel1);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuHotel";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.PanelHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.PanelSideMenu.ResumeLayout(false);
            this.panelSubPensionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelHijo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Minimizar;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelSideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton BtIngrGast;
        private Bunifu.Framework.UI.BunifuFlatButton BtRegistrarCandidatos;
        private System.Windows.Forms.Panel panelSubPensionados;
        private System.Windows.Forms.Button BtVotacionesEstudiantes;
        private System.Windows.Forms.Button BtConsultarEstudiantes;
        private Bunifu.Framework.UI.BunifuFlatButton BTEstudiantes;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
    }
}