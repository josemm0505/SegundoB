namespace FrmLogIn.cs
{
    partial class frmPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesMatemáticasBásicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesTrigonométricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesLógicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.serieFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dígitoVerificadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu,
            this.acercaDeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(543, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(60, 20);
            this.fileMenu.Text = "&Archivo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesMatemáticasBásicasToolStripMenuItem,
            this.operacionesTrigonométricasToolStripMenuItem,
            this.operacionesLógicasToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(64, 20);
            this.editMenu.Text = "&Procesar";
            // 
            // operacionesMatemáticasBásicasToolStripMenuItem
            // 
            this.operacionesMatemáticasBásicasToolStripMenuItem.Name = "operacionesMatemáticasBásicasToolStripMenuItem";
            this.operacionesMatemáticasBásicasToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.operacionesMatemáticasBásicasToolStripMenuItem.Text = "Operaciones Matemáticas Básicas";
            this.operacionesMatemáticasBásicasToolStripMenuItem.Click += new System.EventHandler(this.operacionesMatemáticasBásicasToolStripMenuItem_Click);
            // 
            // operacionesTrigonométricasToolStripMenuItem
            // 
            this.operacionesTrigonométricasToolStripMenuItem.Name = "operacionesTrigonométricasToolStripMenuItem";
            this.operacionesTrigonométricasToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.operacionesTrigonométricasToolStripMenuItem.Text = "Operaciones Trigonométricas";
            this.operacionesTrigonométricasToolStripMenuItem.Click += new System.EventHandler(this.operacionesTrigonométricasToolStripMenuItem_Click);
            // 
            // operacionesLógicasToolStripMenuItem
            // 
            this.operacionesLógicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serieFibonacciToolStripMenuItem,
            this.dígitoVerificadorToolStripMenuItem});
            this.operacionesLógicasToolStripMenuItem.Name = "operacionesLógicasToolStripMenuItem";
            this.operacionesLógicasToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.operacionesLógicasToolStripMenuItem.Text = "Operaciones Lógicas";
            this.operacionesLógicasToolStripMenuItem.Click += new System.EventHandler(this.operacionesLógicasToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(543, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 268);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(543, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // serieFibonacciToolStripMenuItem
            // 
            this.serieFibonacciToolStripMenuItem.Name = "serieFibonacciToolStripMenuItem";
            this.serieFibonacciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serieFibonacciToolStripMenuItem.Text = "Serie Fibonacci";
            // 
            // dígitoVerificadorToolStripMenuItem
            // 
            this.dígitoVerificadorToolStripMenuItem.Name = "dígitoVerificadorToolStripMenuItem";
            this.dígitoVerificadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dígitoVerificadorToolStripMenuItem.Text = "Dígito Verificador";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmLogIn.cs.Properties.Resources._1622281927_419_Berserk_cinco_veces_el_manga_de_Kentaro_Miura_conmociono;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 290);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Calculo G3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem operacionesMatemáticasBásicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesTrigonométricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesLógicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dígitoVerificadorToolStripMenuItem;
    }
}



