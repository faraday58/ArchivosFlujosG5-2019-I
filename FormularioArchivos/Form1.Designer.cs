namespace FormularioArchivos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbNotas = new System.Windows.Forms.RichTextBox();
            this.txtbEntero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDouble = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmtContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.limpiarCamposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmtContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // rtbNotas
            // 
            this.rtbNotas.ContextMenuStrip = this.cmtContextual;
            this.rtbNotas.Location = new System.Drawing.Point(49, 47);
            this.rtbNotas.Name = "rtbNotas";
            this.rtbNotas.Size = new System.Drawing.Size(326, 219);
            this.rtbNotas.TabIndex = 1;
            this.rtbNotas.Text = "";
            // 
            // txtbEntero
            // 
            this.txtbEntero.Location = new System.Drawing.Point(445, 89);
            this.txtbEntero.Name = "txtbEntero";
            this.txtbEntero.Size = new System.Drawing.Size(100, 20);
            this.txtbEntero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entero";
            // 
            // txtbDouble
            // 
            this.txtbDouble.Location = new System.Drawing.Point(445, 131);
            this.txtbDouble.Name = "txtbDouble";
            this.txtbDouble.Size = new System.Drawing.Size(100, 20);
            this.txtbDouble.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Double";
            // 
            // cmtContextual
            // 
            this.cmtContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarCamposToolStripMenuItem});
            this.cmtContextual.Name = "cmtContextual";
            this.cmtContextual.Size = new System.Drawing.Size(181, 48);
            // 
            // limpiarCamposToolStripMenuItem
            // 
            this.limpiarCamposToolStripMenuItem.Name = "limpiarCamposToolStripMenuItem";
            this.limpiarCamposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limpiarCamposToolStripMenuItem.Text = "Limpiar Campos";
            this.limpiarCamposToolStripMenuItem.Click += new System.EventHandler(this.limpiarCamposToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbDouble);
            this.Controls.Add(this.txtbEntero);
            this.Controls.Add(this.rtbNotas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmtContextual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbNotas;
        private System.Windows.Forms.TextBox txtbEntero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDouble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmtContextual;
        private System.Windows.Forms.ToolStripMenuItem limpiarCamposToolStripMenuItem;
    }
}

