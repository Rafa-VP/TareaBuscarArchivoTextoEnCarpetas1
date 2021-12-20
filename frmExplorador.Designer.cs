
namespace TareaBuscarArchivoTextoEnCarpetas
{
    partial class frmExplorador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExplorador));
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lstCarpetas = new System.Windows.Forms.ListBox();
            this.btnCarpetas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRuta.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.ForeColor = System.Drawing.Color.Black;
            this.txtRuta.Location = new System.Drawing.Point(12, 12);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(687, 25);
            this.txtRuta.TabIndex = 0;
            this.txtRuta.TextChanged += new System.EventHandler(this.txtRuta_TextChanged);
            this.txtRuta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRuta_KeyDown);
            // 
            // lstCarpetas
            // 
            this.lstCarpetas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstCarpetas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCarpetas.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarpetas.FormattingEnabled = true;
            this.lstCarpetas.HorizontalScrollbar = true;
            this.lstCarpetas.ItemHeight = 20;
            this.lstCarpetas.Location = new System.Drawing.Point(15, 76);
            this.lstCarpetas.Name = "lstCarpetas";
            this.lstCarpetas.ScrollAlwaysVisible = true;
            this.lstCarpetas.Size = new System.Drawing.Size(302, 182);
            this.lstCarpetas.TabIndex = 1;
            this.lstCarpetas.SelectedIndexChanged += new System.EventHandler(this.lstCarpetas_SelectedIndexChanged);
            this.lstCarpetas.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // btnCarpetas
            // 
            this.btnCarpetas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCarpetas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCarpetas.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarpetas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCarpetas.Location = new System.Drawing.Point(536, 40);
            this.btnCarpetas.Name = "btnCarpetas";
            this.btnCarpetas.Size = new System.Drawing.Size(163, 32);
            this.btnCarpetas.TabIndex = 2;
            this.btnCarpetas.Text = "Buscar carpetas";
            this.btnCarpetas.UseVisualStyleBackColor = false;
            this.btnCarpetas.Visible = false;
            this.btnCarpetas.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta de la carpeta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstArchivos
            // 
            this.lstArchivos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstArchivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstArchivos.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.HorizontalScrollbar = true;
            this.lstArchivos.ItemHeight = 20;
            this.lstArchivos.Location = new System.Drawing.Point(323, 78);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.ScrollAlwaysVisible = true;
            this.lstArchivos.Size = new System.Drawing.Size(302, 182);
            this.lstArchivos.TabIndex = 4;
            this.lstArchivos.SelectedIndexChanged += new System.EventHandler(this.lstArchivos_SelectedIndexChanged);
            this.lstArchivos.DoubleClick += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnArchivos
            // 
            this.btnArchivos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArchivos.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnArchivos.Location = new System.Drawing.Point(15, 264);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(163, 32);
            this.btnArchivos.TabIndex = 5;
            this.btnArchivos.Text = "Buscar archivos";
            this.btnArchivos.UseVisualStyleBackColor = false;
            this.btnArchivos.Visible = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrir.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAbrir.Location = new System.Drawing.Point(323, 266);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(255, 32);
            this.btnAbrir.TabIndex = 7;
            this.btnAbrir.Text = "Abrir Archivo Seleccionado";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Visible = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Location = new System.Drawing.Point(15, 315);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultado.Size = new System.Drawing.Size(610, 159);
            this.txtResultado.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "PRESIONE ENTER";
            // 
            // frmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnArchivos);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarpetas);
            this.Controls.Add(this.lstCarpetas);
            this.Controls.Add(this.txtRuta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExplorador";
            this.Text = "Explorador de archivos de texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.ListBox lstCarpetas;
        private System.Windows.Forms.Button btnCarpetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstArchivos;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
    }
}

