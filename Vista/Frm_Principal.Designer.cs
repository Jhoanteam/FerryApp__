namespace Ferriapp.Vista
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.Btn_Configuracion = new FontAwesome.Sharp.IconButton();
            this.Btn_Renta = new FontAwesome.Sharp.IconButton();
            this.Btn_Estadisticas = new FontAwesome.Sharp.IconButton();
            this.Btn_Inventario = new FontAwesome.Sharp.IconButton();
            this.Btn_gasto = new FontAwesome.Sharp.IconButton();
            this.BTN_Venta = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.iconButton8);
            this.panel1.Controls.Add(this.Btn_Configuracion);
            this.panel1.Controls.Add(this.Btn_Renta);
            this.panel1.Controls.Add(this.Btn_Estadisticas);
            this.panel1.Controls.Add(this.Btn_Inventario);
            this.panel1.Controls.Add(this.Btn_gasto);
            this.panel1.Controls.Add(this.BTN_Venta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 631);
            this.panel1.TabIndex = 0;
            // 
            // iconButton8
            // 
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.iconButton8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton8.IconSize = 40;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(3, 581);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(206, 50);
            this.iconButton8.TabIndex = 8;
            this.iconButton8.Text = "Cerrar Cesión ";
            this.iconButton8.UseMnemonic = false;
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // Btn_Configuracion
            // 
            this.Btn_Configuracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Configuracion.FlatAppearance.BorderSize = 0;
            this.Btn_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Configuracion.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Configuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_Configuracion.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.Btn_Configuracion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_Configuracion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Configuracion.IconSize = 40;
            this.Btn_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Configuracion.Location = new System.Drawing.Point(0, 407);
            this.Btn_Configuracion.Name = "Btn_Configuracion";
            this.Btn_Configuracion.Size = new System.Drawing.Size(209, 50);
            this.Btn_Configuracion.TabIndex = 7;
            this.Btn_Configuracion.Text = "Configuracion";
            this.Btn_Configuracion.UseMnemonic = false;
            this.Btn_Configuracion.UseVisualStyleBackColor = true;
            this.Btn_Configuracion.Click += new System.EventHandler(this.Btn_Configuracion_Click);
            // 
            // Btn_Renta
            // 
            this.Btn_Renta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Renta.FlatAppearance.BorderSize = 0;
            this.Btn_Renta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Renta.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Renta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_Renta.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.Btn_Renta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_Renta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Renta.IconSize = 40;
            this.Btn_Renta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Renta.Location = new System.Drawing.Point(0, 357);
            this.Btn_Renta.Name = "Btn_Renta";
            this.Btn_Renta.Size = new System.Drawing.Size(209, 50);
            this.Btn_Renta.TabIndex = 6;
            this.Btn_Renta.Text = "Renta";
            this.Btn_Renta.UseMnemonic = false;
            this.Btn_Renta.UseVisualStyleBackColor = true;
            this.Btn_Renta.Visible = false;
            this.Btn_Renta.Click += new System.EventHandler(this.Btn_Renta_Click);
            // 
            // Btn_Estadisticas
            // 
            this.Btn_Estadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Estadisticas.FlatAppearance.BorderSize = 0;
            this.Btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Estadisticas.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Estadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_Estadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.Btn_Estadisticas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_Estadisticas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Estadisticas.IconSize = 40;
            this.Btn_Estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Estadisticas.Location = new System.Drawing.Point(0, 307);
            this.Btn_Estadisticas.Name = "Btn_Estadisticas";
            this.Btn_Estadisticas.Size = new System.Drawing.Size(209, 50);
            this.Btn_Estadisticas.TabIndex = 5;
            this.Btn_Estadisticas.Text = "Estadistica";
            this.Btn_Estadisticas.UseMnemonic = false;
            this.Btn_Estadisticas.UseVisualStyleBackColor = true;
            this.Btn_Estadisticas.Visible = false;
            this.Btn_Estadisticas.Click += new System.EventHandler(this.Btn_Estadisticas_Click);
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Inventario.FlatAppearance.BorderSize = 0;
            this.Btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Inventario.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_Inventario.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.Btn_Inventario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_Inventario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Inventario.IconSize = 40;
            this.Btn_Inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Inventario.Location = new System.Drawing.Point(0, 257);
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Size = new System.Drawing.Size(209, 50);
            this.Btn_Inventario.TabIndex = 4;
            this.Btn_Inventario.Text = "Inventario";
            this.Btn_Inventario.UseMnemonic = false;
            this.Btn_Inventario.UseVisualStyleBackColor = true;
            this.Btn_Inventario.Click += new System.EventHandler(this.Btn_Inventario_Click);
            // 
            // Btn_gasto
            // 
            this.Btn_gasto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_gasto.FlatAppearance.BorderSize = 0;
            this.Btn_gasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_gasto.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_gasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_gasto.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.Btn_gasto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Btn_gasto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_gasto.IconSize = 40;
            this.Btn_gasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_gasto.Location = new System.Drawing.Point(0, 207);
            this.Btn_gasto.Name = "Btn_gasto";
            this.Btn_gasto.Size = new System.Drawing.Size(209, 50);
            this.Btn_gasto.TabIndex = 3;
            this.Btn_gasto.Text = "Gasto";
            this.Btn_gasto.UseMnemonic = false;
            this.Btn_gasto.UseVisualStyleBackColor = true;
            this.Btn_gasto.Visible = false;
            this.Btn_gasto.Click += new System.EventHandler(this.Btn_gasto_Click);
            // 
            // BTN_Venta
            // 
            this.BTN_Venta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Venta.FlatAppearance.BorderSize = 0;
            this.BTN_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Venta.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.BTN_Venta.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.BTN_Venta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.BTN_Venta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BTN_Venta.IconSize = 40;
            this.BTN_Venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Venta.Location = new System.Drawing.Point(0, 157);
            this.BTN_Venta.Name = "BTN_Venta";
            this.BTN_Venta.Size = new System.Drawing.Size(209, 50);
            this.BTN_Venta.TabIndex = 2;
            this.BTN_Venta.Text = "Venta";
            this.BTN_Venta.UseMnemonic = false;
            this.BTN_Venta.UseVisualStyleBackColor = true;
            this.BTN_Venta.Click += new System.EventHandler(this.BTN_Venta_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.iconButton9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 157);
            this.panel3.TabIndex = 1;
            // 
            // iconButton9
            // 
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton9.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton9.IconSize = 90;
            this.iconButton9.Location = new System.Drawing.Point(37, 12);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(131, 82);
            this.iconButton9.TabIndex = 3;
            this.iconButton9.UseMnemonic = false;
            this.iconButton9.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre completo usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(58, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rol Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 30);
            this.panel2.TabIndex = 1;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(1058, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(32, 30);
            this.iconButton2.TabIndex = 16;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.CausesValidation = false;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(1090, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 30);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(209, 30);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1126, 601);
            this.Contenedor.TabIndex = 2;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1335, 631);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BTN_Venta;
        private FontAwesome.Sharp.IconButton Btn_Estadisticas;
        private FontAwesome.Sharp.IconButton Btn_Inventario;
        private FontAwesome.Sharp.IconButton Btn_gasto;
        private FontAwesome.Sharp.IconButton Btn_Renta;
        private FontAwesome.Sharp.IconButton Btn_Configuracion;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.Panel Contenedor;
    }
}