namespace SCADA_1_1
{
    partial class MainPanel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hora = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.ConfiguracionesButton = new System.Windows.Forms.Button();
            this.subMenu = new System.Windows.Forms.Panel();
            this.Inyectora10StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora9StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora8StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora7StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora6StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora5StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora4StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora3StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora2StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora1StatusPilot = new System.Windows.Forms.Panel();
            this.Inyectora10Button = new System.Windows.Forms.Button();
            this.Inyectora9Button = new System.Windows.Forms.Button();
            this.Inyectora8Button = new System.Windows.Forms.Button();
            this.Inyectora7Button = new System.Windows.Forms.Button();
            this.Inyectora6Button = new System.Windows.Forms.Button();
            this.Inyectora5Button = new System.Windows.Forms.Button();
            this.Inyectora4Button = new System.Windows.Forms.Button();
            this.Inyectora3Button = new System.Windows.Forms.Button();
            this.Inyectora2Button = new System.Windows.Forms.Button();
            this.Inyectora1Button = new System.Windows.Forms.Button();
            this.InyectorasStatusPilot = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InyectorasButton = new System.Windows.Forms.Button();
            this.DatosOperativosButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.Contenedor1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HoraTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.subMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Hora);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.MenuIcon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 40);
            this.panel1.TabIndex = 0;
            // 
            // Hora
            // 
            this.Hora.BackColor = System.Drawing.Color.White;
            this.Hora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Hora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Hora.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.Hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.Hora.Location = new System.Drawing.Point(1207, 12);
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Size = new System.Drawing.Size(93, 18);
            this.Hora.TabIndex = 19;
            this.Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hora.WordWrap = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SCADA_1_1.Properties.Resources.imagotipo;
            this.pictureBox2.Location = new System.Drawing.Point(1307, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MenuIcon
            // 
            this.MenuIcon.Image = global::SCADA_1_1.Properties.Resources.menu;
            this.MenuIcon.Location = new System.Drawing.Point(5, 0);
            this.MenuIcon.Name = "MenuIcon";
            this.MenuIcon.Size = new System.Drawing.Size(40, 40);
            this.MenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuIcon.TabIndex = 0;
            this.MenuIcon.TabStop = false;
            this.MenuIcon.Click += new System.EventHandler(this.MenuIcon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCADA_1_1.Properties.Resources.A;
            this.pictureBox1.Location = new System.Drawing.Point(49, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Menu.Controls.Add(this.panel15);
            this.Menu.Controls.Add(this.ConfiguracionesButton);
            this.Menu.Controls.Add(this.subMenu);
            this.Menu.Controls.Add(this.InyectorasStatusPilot);
            this.Menu.Controls.Add(this.panel2);
            this.Menu.Controls.Add(this.InyectorasButton);
            this.Menu.Controls.Add(this.DatosOperativosButton);
            this.Menu.Controls.Add(this.DashboardButton);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 40);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(194, 689);
            this.Menu.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel15.Location = new System.Drawing.Point(26, 633);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(140, 1);
            this.panel15.TabIndex = 4;
            // 
            // ConfiguracionesButton
            // 
            this.ConfiguracionesButton.FlatAppearance.BorderSize = 0;
            this.ConfiguracionesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ConfiguracionesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfiguracionesButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.ConfiguracionesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ConfiguracionesButton.Location = new System.Drawing.Point(0, 640);
            this.ConfiguracionesButton.Name = "ConfiguracionesButton";
            this.ConfiguracionesButton.Size = new System.Drawing.Size(194, 35);
            this.ConfiguracionesButton.TabIndex = 6;
            this.ConfiguracionesButton.Text = "     Configuraciones";
            this.ConfiguracionesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfiguracionesButton.UseVisualStyleBackColor = true;
            this.ConfiguracionesButton.Click += new System.EventHandler(this.ConfiguracionesButton_Click);
            // 
            // subMenu
            // 
            this.subMenu.Controls.Add(this.Inyectora10StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora9StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora8StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora7StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora6StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora5StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora4StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora3StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora2StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora1StatusPilot);
            this.subMenu.Controls.Add(this.Inyectora10Button);
            this.subMenu.Controls.Add(this.Inyectora9Button);
            this.subMenu.Controls.Add(this.Inyectora8Button);
            this.subMenu.Controls.Add(this.Inyectora7Button);
            this.subMenu.Controls.Add(this.Inyectora6Button);
            this.subMenu.Controls.Add(this.Inyectora5Button);
            this.subMenu.Controls.Add(this.Inyectora4Button);
            this.subMenu.Controls.Add(this.Inyectora3Button);
            this.subMenu.Controls.Add(this.Inyectora2Button);
            this.subMenu.Controls.Add(this.Inyectora1Button);
            this.subMenu.Location = new System.Drawing.Point(-1, 135);
            this.subMenu.Name = "subMenu";
            this.subMenu.Size = new System.Drawing.Size(194, 404);
            this.subMenu.TabIndex = 5;
            // 
            // Inyectora10StatusPilot
            // 
            this.Inyectora10StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora10StatusPilot.Location = new System.Drawing.Point(0, 369);
            this.Inyectora10StatusPilot.Name = "Inyectora10StatusPilot";
            this.Inyectora10StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora10StatusPilot.TabIndex = 7;
            // 
            // Inyectora9StatusPilot
            // 
            this.Inyectora9StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora9StatusPilot.Location = new System.Drawing.Point(0, 328);
            this.Inyectora9StatusPilot.Name = "Inyectora9StatusPilot";
            this.Inyectora9StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora9StatusPilot.TabIndex = 7;
            // 
            // Inyectora8StatusPilot
            // 
            this.Inyectora8StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora8StatusPilot.Location = new System.Drawing.Point(0, 287);
            this.Inyectora8StatusPilot.Name = "Inyectora8StatusPilot";
            this.Inyectora8StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora8StatusPilot.TabIndex = 7;
            // 
            // Inyectora7StatusPilot
            // 
            this.Inyectora7StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora7StatusPilot.Location = new System.Drawing.Point(0, 246);
            this.Inyectora7StatusPilot.Name = "Inyectora7StatusPilot";
            this.Inyectora7StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora7StatusPilot.TabIndex = 7;
            // 
            // Inyectora6StatusPilot
            // 
            this.Inyectora6StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora6StatusPilot.Location = new System.Drawing.Point(0, 205);
            this.Inyectora6StatusPilot.Name = "Inyectora6StatusPilot";
            this.Inyectora6StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora6StatusPilot.TabIndex = 6;
            // 
            // Inyectora5StatusPilot
            // 
            this.Inyectora5StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora5StatusPilot.Location = new System.Drawing.Point(0, 164);
            this.Inyectora5StatusPilot.Name = "Inyectora5StatusPilot";
            this.Inyectora5StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora5StatusPilot.TabIndex = 6;
            // 
            // Inyectora4StatusPilot
            // 
            this.Inyectora4StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora4StatusPilot.Location = new System.Drawing.Point(0, 123);
            this.Inyectora4StatusPilot.Name = "Inyectora4StatusPilot";
            this.Inyectora4StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora4StatusPilot.TabIndex = 13;
            // 
            // Inyectora3StatusPilot
            // 
            this.Inyectora3StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora3StatusPilot.Location = new System.Drawing.Point(0, 82);
            this.Inyectora3StatusPilot.Name = "Inyectora3StatusPilot";
            this.Inyectora3StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora3StatusPilot.TabIndex = 6;
            // 
            // Inyectora2StatusPilot
            // 
            this.Inyectora2StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora2StatusPilot.Location = new System.Drawing.Point(0, 41);
            this.Inyectora2StatusPilot.Name = "Inyectora2StatusPilot";
            this.Inyectora2StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora2StatusPilot.TabIndex = 6;
            // 
            // Inyectora1StatusPilot
            // 
            this.Inyectora1StatusPilot.BackColor = System.Drawing.Color.Gray;
            this.Inyectora1StatusPilot.Location = new System.Drawing.Point(0, 0);
            this.Inyectora1StatusPilot.Name = "Inyectora1StatusPilot";
            this.Inyectora1StatusPilot.Size = new System.Drawing.Size(10, 35);
            this.Inyectora1StatusPilot.TabIndex = 5;
            // 
            // Inyectora10Button
            // 
            this.Inyectora10Button.FlatAppearance.BorderSize = 0;
            this.Inyectora10Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora10Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora10Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora10Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora10Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora10Button.Location = new System.Drawing.Point(0, 369);
            this.Inyectora10Button.Name = "Inyectora10Button";
            this.Inyectora10Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora10Button.TabIndex = 12;
            this.Inyectora10Button.Text = "   Inyectora 10";
            this.Inyectora10Button.UseVisualStyleBackColor = true;
            // 
            // Inyectora9Button
            // 
            this.Inyectora9Button.FlatAppearance.BorderSize = 0;
            this.Inyectora9Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora9Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora9Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora9Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora9Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora9Button.Location = new System.Drawing.Point(0, 328);
            this.Inyectora9Button.Name = "Inyectora9Button";
            this.Inyectora9Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora9Button.TabIndex = 11;
            this.Inyectora9Button.Text = "   Inyectora 9";
            this.Inyectora9Button.UseVisualStyleBackColor = true;
            // 
            // Inyectora8Button
            // 
            this.Inyectora8Button.FlatAppearance.BorderSize = 0;
            this.Inyectora8Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora8Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora8Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora8Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora8Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora8Button.Location = new System.Drawing.Point(0, 287);
            this.Inyectora8Button.Name = "Inyectora8Button";
            this.Inyectora8Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora8Button.TabIndex = 10;
            this.Inyectora8Button.Text = "   Inyectora 8";
            this.Inyectora8Button.UseVisualStyleBackColor = true;
            // 
            // Inyectora7Button
            // 
            this.Inyectora7Button.FlatAppearance.BorderSize = 0;
            this.Inyectora7Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora7Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora7Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora7Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora7Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora7Button.Location = new System.Drawing.Point(0, 246);
            this.Inyectora7Button.Name = "Inyectora7Button";
            this.Inyectora7Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora7Button.TabIndex = 9;
            this.Inyectora7Button.Text = "   Inyectora 7";
            this.Inyectora7Button.UseVisualStyleBackColor = true;
            // 
            // Inyectora6Button
            // 
            this.Inyectora6Button.FlatAppearance.BorderSize = 0;
            this.Inyectora6Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora6Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora6Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora6Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora6Button.Location = new System.Drawing.Point(0, 205);
            this.Inyectora6Button.Name = "Inyectora6Button";
            this.Inyectora6Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora6Button.TabIndex = 8;
            this.Inyectora6Button.Text = "   Inyectora 6";
            this.Inyectora6Button.UseVisualStyleBackColor = true;
            // 
            // Inyectora5Button
            // 
            this.Inyectora5Button.FlatAppearance.BorderSize = 0;
            this.Inyectora5Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora5Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora5Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora5Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora5Button.Location = new System.Drawing.Point(0, 164);
            this.Inyectora5Button.Name = "Inyectora5Button";
            this.Inyectora5Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora5Button.TabIndex = 7;
            this.Inyectora5Button.Text = "   Inyectora 5";
            this.Inyectora5Button.UseVisualStyleBackColor = true;
            // 
            // Inyectora4Button
            // 
            this.Inyectora4Button.FlatAppearance.BorderSize = 0;
            this.Inyectora4Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora4Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora4Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora4Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora4Button.Location = new System.Drawing.Point(0, 123);
            this.Inyectora4Button.Name = "Inyectora4Button";
            this.Inyectora4Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora4Button.TabIndex = 6;
            this.Inyectora4Button.Text = "   Inyectora 4";
            this.Inyectora4Button.UseVisualStyleBackColor = true;
            // 
            // Inyectora3Button
            // 
            this.Inyectora3Button.FlatAppearance.BorderSize = 0;
            this.Inyectora3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora3Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora3Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora3Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora3Button.Location = new System.Drawing.Point(0, 82);
            this.Inyectora3Button.Name = "Inyectora3Button";
            this.Inyectora3Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora3Button.TabIndex = 5;
            this.Inyectora3Button.Text = "   Inyectora 3";
            this.Inyectora3Button.UseVisualStyleBackColor = true;
            // 
            // Inyectora2Button
            // 
            this.Inyectora2Button.FlatAppearance.BorderSize = 0;
            this.Inyectora2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora2Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora2Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora2Button.Location = new System.Drawing.Point(0, 41);
            this.Inyectora2Button.Name = "Inyectora2Button";
            this.Inyectora2Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora2Button.TabIndex = 4;
            this.Inyectora2Button.Text = "   Inyectora 2";
            this.Inyectora2Button.UseVisualStyleBackColor = true;
            // 
            // Inyectora1Button
            // 
            this.Inyectora1Button.FlatAppearance.BorderSize = 0;
            this.Inyectora1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Inyectora1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inyectora1Button.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Inyectora1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Inyectora1Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inyectora1Button.Location = new System.Drawing.Point(0, 0);
            this.Inyectora1Button.Name = "Inyectora1Button";
            this.Inyectora1Button.Size = new System.Drawing.Size(173, 35);
            this.Inyectora1Button.TabIndex = 3;
            this.Inyectora1Button.Text = "   Inyectora 1";
            this.Inyectora1Button.UseVisualStyleBackColor = true;
            this.Inyectora1Button.Click += new System.EventHandler(this.Inyectora1Button_Click);
            // 
            // InyectorasStatusPilot
            // 
            this.InyectorasStatusPilot.BackColor = System.Drawing.Color.Gray;
            this.InyectorasStatusPilot.Location = new System.Drawing.Point(-1, 94);
            this.InyectorasStatusPilot.Name = "InyectorasStatusPilot";
            this.InyectorasStatusPilot.Size = new System.Drawing.Size(10, 35);
            this.InyectorasStatusPilot.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Location = new System.Drawing.Point(26, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 1);
            this.panel2.TabIndex = 3;
            // 
            // InyectorasButton
            // 
            this.InyectorasButton.FlatAppearance.BorderSize = 0;
            this.InyectorasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.InyectorasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InyectorasButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.InyectorasButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.InyectorasButton.Image = global::SCADA_1_1.Properties.Resources.arrow;
            this.InyectorasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InyectorasButton.Location = new System.Drawing.Point(-1, 94);
            this.InyectorasButton.Name = "InyectorasButton";
            this.InyectorasButton.Size = new System.Drawing.Size(194, 35);
            this.InyectorasButton.TabIndex = 2;
            this.InyectorasButton.Text = "     Inyectoras";
            this.InyectorasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InyectorasButton.UseVisualStyleBackColor = true;
            this.InyectorasButton.Click += new System.EventHandler(this.InyectorasButton_Click);
            // 
            // DatosOperativosButton
            // 
            this.DatosOperativosButton.FlatAppearance.BorderSize = 0;
            this.DatosOperativosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.DatosOperativosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatosOperativosButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.DatosOperativosButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DatosOperativosButton.Location = new System.Drawing.Point(-1, 53);
            this.DatosOperativosButton.Name = "DatosOperativosButton";
            this.DatosOperativosButton.Size = new System.Drawing.Size(194, 35);
            this.DatosOperativosButton.TabIndex = 1;
            this.DatosOperativosButton.Text = "     Datos operativos";
            this.DatosOperativosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatosOperativosButton.UseVisualStyleBackColor = true;
            this.DatosOperativosButton.Click += new System.EventHandler(this.DatosOperativosButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.DashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DashboardButton.Location = new System.Drawing.Point(0, 6);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(194, 35);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "     Dashboard";
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // Contenedor1
            // 
            this.Contenedor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor1.Location = new System.Drawing.Point(194, 40);
            this.Contenedor1.Name = "Contenedor1";
            this.Contenedor1.Size = new System.Drawing.Size(1156, 689);
            this.Contenedor1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HoraTimer
            // 
            this.HoraTimer.Enabled = true;
            this.HoraTimer.Tick += new System.EventHandler(this.HoraTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.textBox1.Location = new System.Drawing.Point(962, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(239, 18);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Contenedor1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPanel";
            this.Text = "SCADA 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.subMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.PictureBox MenuIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button InyectorasButton;
        private System.Windows.Forms.Button DatosOperativosButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel subMenu;
        private System.Windows.Forms.Button Inyectora3Button;
        private System.Windows.Forms.Button Inyectora2Button;
        private System.Windows.Forms.Button Inyectora1Button;
        private System.Windows.Forms.Panel InyectorasStatusPilot;
        private System.Windows.Forms.Panel Inyectora10StatusPilot;
        private System.Windows.Forms.Panel Inyectora9StatusPilot;
        private System.Windows.Forms.Panel Inyectora8StatusPilot;
        private System.Windows.Forms.Panel Inyectora7StatusPilot;
        private System.Windows.Forms.Panel Inyectora6StatusPilot;
        private System.Windows.Forms.Panel Inyectora5StatusPilot;
        private System.Windows.Forms.Panel Inyectora4StatusPilot;
        private System.Windows.Forms.Panel Inyectora3StatusPilot;
        private System.Windows.Forms.Panel Inyectora2StatusPilot;
        private System.Windows.Forms.Panel Inyectora1StatusPilot;
        private System.Windows.Forms.Button Inyectora10Button;
        private System.Windows.Forms.Button Inyectora9Button;
        private System.Windows.Forms.Button Inyectora8Button;
        private System.Windows.Forms.Button Inyectora7Button;
        private System.Windows.Forms.Button Inyectora6Button;
        private System.Windows.Forms.Button Inyectora5Button;
        private System.Windows.Forms.Button Inyectora4Button;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button ConfiguracionesButton;
        private System.Windows.Forms.Panel Contenedor1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Hora;
        private System.Windows.Forms.Timer HoraTimer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

