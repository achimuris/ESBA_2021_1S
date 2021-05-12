
namespace UI
{
    partial class Form1
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
            this.dgvTiposDeClientes = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombreTipoCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDeClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTiposDeClientes
            // 
            this.dgvTiposDeClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposDeClientes.Location = new System.Drawing.Point(100, 77);
            this.dgvTiposDeClientes.Name = "dgvTiposDeClientes";
            this.dgvTiposDeClientes.Size = new System.Drawing.Size(469, 225);
            this.dgvTiposDeClientes.TabIndex = 0;
            this.dgvTiposDeClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiposDeClientes_CellContentClick);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(134, 379);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear Tipo de Cliente";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNombreTipoCliente
            // 
            this.txtNombreTipoCliente.Location = new System.Drawing.Point(284, 379);
            this.txtNombreTipoCliente.Name = "txtNombreTipoCliente";
            this.txtNombreTipoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTipoCliente.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreTipoCliente);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvTiposDeClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDeClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiposDeClientes;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombreTipoCliente;
    }
}

