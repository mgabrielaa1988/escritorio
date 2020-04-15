namespace MainCorreo
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.lblTrackiingID = new System.Windows.Forms.Label();
            this.lbllDireccion = new System.Windows.Forms.Label();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.gBoxPaquete = new System.Windows.Forms.GroupBox();
            this.gBoxEstadosPaquetes = new System.Windows.Forms.GroupBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxPaquete.SuspendLayout();
            this.gBoxEstadosPaquetes.SuspendLayout();
            this.mostrarToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(298, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 69);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(298, 127);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(142, 69);
            this.btnMostrarTodos.TabIndex = 1;
            this.btnMostrarTodos.Text = "&Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // lblTrackiingID
            // 
            this.lblTrackiingID.AutoSize = true;
            this.lblTrackiingID.Location = new System.Drawing.Point(49, 35);
            this.lblTrackiingID.Name = "lblTrackiingID";
            this.lblTrackiingID.Size = new System.Drawing.Size(80, 17);
            this.lblTrackiingID.TabIndex = 2;
            this.lblTrackiingID.Text = "Tracking ID";
            // 
            // lbllDireccion
            // 
            this.lbllDireccion.AutoSize = true;
            this.lbllDireccion.Location = new System.Drawing.Point(49, 127);
            this.lbllDireccion.Name = "lbllDireccion";
            this.lbllDireccion.Size = new System.Drawing.Size(67, 17);
            this.lbllDireccion.TabIndex = 3;
            this.lbllDireccion.Text = "Direccion";
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(34, 23);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(71, 17);
            this.lblEstadoIngresado.TabIndex = 4;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(378, 23);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(60, 17);
            this.lblEstadoEnViaje.TabIndex = 5;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(718, 23);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(74, 17);
            this.lblEstadoEntregado.TabIndex = 6;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(54, 158);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(218, 23);
            this.txtDireccion.TabIndex = 7;
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(54, 69);
            this.mtxtTrackingID.Mask = "000-000-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(218, 23);
            this.mtxtTrackingID.TabIndex = 8;
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.ItemHeight = 16;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(18, 43);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(309, 228);
            this.lstEstadoIngresado.TabIndex = 9;
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.ItemHeight = 16;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(363, 43);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(309, 228);
            this.lstEstadoEnViaje.TabIndex = 10;
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.ItemHeight = 16;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(707, 43);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(309, 228);
            this.lstEstadoEntregado.TabIndex = 11;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Enabled = false;
            this.rtbMostrar.Location = new System.Drawing.Point(16, 337);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(541, 201);
            this.rtbMostrar.TabIndex = 12;
            this.rtbMostrar.Text = "";
            // 
            // gBoxPaquete
            // 
            this.gBoxPaquete.Controls.Add(this.mtxtTrackingID);
            this.gBoxPaquete.Controls.Add(this.txtDireccion);
            this.gBoxPaquete.Controls.Add(this.lbllDireccion);
            this.gBoxPaquete.Controls.Add(this.lblTrackiingID);
            this.gBoxPaquete.Controls.Add(this.btnMostrarTodos);
            this.gBoxPaquete.Controls.Add(this.btnAgregar);
            this.gBoxPaquete.Location = new System.Drawing.Point(594, 325);
            this.gBoxPaquete.Name = "gBoxPaquete";
            this.gBoxPaquete.Size = new System.Drawing.Size(456, 214);
            this.gBoxPaquete.TabIndex = 13;
            this.gBoxPaquete.TabStop = false;
            this.gBoxPaquete.Text = "Paquete";
            // 
            // gBoxEstadosPaquetes
            // 
            this.gBoxEstadosPaquetes.Controls.Add(this.lstEstadoEntregado);
            this.gBoxEstadosPaquetes.Controls.Add(this.lstEstadoEnViaje);
            this.gBoxEstadosPaquetes.Controls.Add(this.lstEstadoIngresado);
            this.gBoxEstadosPaquetes.Controls.Add(this.lblEstadoEntregado);
            this.gBoxEstadosPaquetes.Controls.Add(this.lblEstadoEnViaje);
            this.gBoxEstadosPaquetes.Controls.Add(this.lblEstadoIngresado);
            this.gBoxEstadosPaquetes.Location = new System.Drawing.Point(16, 15);
            this.gBoxEstadosPaquetes.Name = "gBoxEstadosPaquetes";
            this.gBoxEstadosPaquetes.Size = new System.Drawing.Size(1034, 295);
            this.gBoxEstadosPaquetes.TabIndex = 14;
            this.gBoxEstadosPaquetes.TabStop = false;
            this.gBoxEstadosPaquetes.Text = "Estados Paquetes";
            // 
            // cmsListas
            // 
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(61, 4);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem1});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Controls.Add(this.gBoxEstadosPaquetes);
            this.Controls.Add(this.gBoxPaquete);
            this.Controls.Add(this.rtbMostrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "Form1";
            this.Text = "Correo UTN por Gabriela.Aragón.2A";
            this.gBoxPaquete.ResumeLayout(false);
            this.gBoxPaquete.PerformLayout();
            this.gBoxEstadosPaquetes.ResumeLayout(false);
            this.gBoxEstadosPaquetes.PerformLayout();
            this.mostrarToolStripMenuItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label lblTrackiingID;
        private System.Windows.Forms.Label lbllDireccion;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.GroupBox gBoxPaquete;
        private System.Windows.Forms.GroupBox gBoxEstadosPaquetes;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ContextMenuStrip mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
    }
}

