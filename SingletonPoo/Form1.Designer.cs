namespace SingletonPoo
{
    partial class SolucionPoo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profecionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoProfecionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProfecionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profecionalesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.turnosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profecionalesToolStripMenuItem
            // 
            this.profecionalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoProfecionalToolStripMenuItem,
            this.listadoDeProfecionalesToolStripMenuItem});
            this.profecionalesToolStripMenuItem.Name = "profecionalesToolStripMenuItem";
            this.profecionalesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.profecionalesToolStripMenuItem.Text = "Profecionales";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoClienteToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTurnoToolStripMenuItem,
            this.listadoDeTurnosToolStripMenuItem});
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // ingresarNuevoProfecionalToolStripMenuItem
            // 
            this.ingresarNuevoProfecionalToolStripMenuItem.Name = "ingresarNuevoProfecionalToolStripMenuItem";
            this.ingresarNuevoProfecionalToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ingresarNuevoProfecionalToolStripMenuItem.Text = "Ingresar Nuevo Profecional";
            this.ingresarNuevoProfecionalToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoProfecionalToolStripMenuItem_Click);
            // 
            // listadoDeProfecionalesToolStripMenuItem
            // 
            this.listadoDeProfecionalesToolStripMenuItem.Name = "listadoDeProfecionalesToolStripMenuItem";
            this.listadoDeProfecionalesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.listadoDeProfecionalesToolStripMenuItem.Text = "Listado de profecionales";
            this.listadoDeProfecionalesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProfecionalesToolStripMenuItem_Click);
            // 
            // ingresarNuevoClienteToolStripMenuItem
            // 
            this.ingresarNuevoClienteToolStripMenuItem.Name = "ingresarNuevoClienteToolStripMenuItem";
            this.ingresarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ingresarNuevoClienteToolStripMenuItem.Text = "Ingresar Nuevo cliente";
            this.ingresarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoClienteToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de clientes";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // nuevoTurnoToolStripMenuItem
            // 
            this.nuevoTurnoToolStripMenuItem.Name = "nuevoTurnoToolStripMenuItem";
            this.nuevoTurnoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nuevoTurnoToolStripMenuItem.Text = "Nuevo turno";
            this.nuevoTurnoToolStripMenuItem.Click += new System.EventHandler(this.nuevoTurnoToolStripMenuItem_Click);
            // 
            // listadoDeTurnosToolStripMenuItem
            // 
            this.listadoDeTurnosToolStripMenuItem.Name = "listadoDeTurnosToolStripMenuItem";
            this.listadoDeTurnosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listadoDeTurnosToolStripMenuItem.Text = "Listado de turnos";
            // 
            // SolucionPoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 433);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SolucionPoo";
            this.Text = "Contenedor";
            this.Load += new System.EventHandler(this.SolucionPoo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profecionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoProfecionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProfecionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTurnosToolStripMenuItem;
    }
}

