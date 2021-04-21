
namespace APP_Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.cboxCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.rbtnBonoPorPresentismoVariable = new System.Windows.Forms.RadioButton();
            this.rbtnBonoPorPresentismoFijo = new System.Windows.Forms.RadioButton();
            this.rbtnBonoPorPresentismoNADA = new System.Windows.Forms.RadioButton();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreDelEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.Location = new System.Drawing.Point(117, 351);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(153, 23);
            this.btnCalcularSueldo.TabIndex = 0;
            this.btnCalcularSueldo.Text = "Calcular Sueldo";
            this.btnCalcularSueldo.UseVisualStyleBackColor = true;
            this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);
            // 
            // cboxCategorias
            // 
            this.cboxCategorias.FormattingEnabled = true;
            this.cboxCategorias.Items.AddRange(new object[] {
            "1 - Cadete",
            "2 - Gerente"});
            this.cboxCategorias.Location = new System.Drawing.Point(149, 68);
            this.cboxCategorias.Name = "cboxCategorias";
            this.cboxCategorias.Size = new System.Drawing.Size(121, 23);
            this.cboxCategorias.TabIndex = 1;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(68, 71);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(63, 15);
            this.lblCategorias.TabIndex = 2;
            this.lblCategorias.Text = "Categorias";
            // 
            // rbtnBonoPorPresentismoVariable
            // 
            this.rbtnBonoPorPresentismoVariable.AutoSize = true;
            this.rbtnBonoPorPresentismoVariable.Location = new System.Drawing.Point(91, 168);
            this.rbtnBonoPorPresentismoVariable.Name = "rbtnBonoPorPresentismoVariable";
            this.rbtnBonoPorPresentismoVariable.Size = new System.Drawing.Size(93, 19);
            this.rbtnBonoPorPresentismoVariable.TabIndex = 3;
            this.rbtnBonoPorPresentismoVariable.TabStop = true;
            this.rbtnBonoPorPresentismoVariable.Text = "10% del neto";
            this.rbtnBonoPorPresentismoVariable.UseVisualStyleBackColor = true;
            // 
            // rbtnBonoPorPresentismoFijo
            // 
            this.rbtnBonoPorPresentismoFijo.AutoSize = true;
            this.rbtnBonoPorPresentismoFijo.Location = new System.Drawing.Point(91, 204);
            this.rbtnBonoPorPresentismoFijo.Name = "rbtnBonoPorPresentismoFijo";
            this.rbtnBonoPorPresentismoFijo.Size = new System.Drawing.Size(65, 19);
            this.rbtnBonoPorPresentismoFijo.TabIndex = 4;
            this.rbtnBonoPorPresentismoFijo.TabStop = true;
            this.rbtnBonoPorPresentismoFijo.Text = "Fijo $80";
            this.rbtnBonoPorPresentismoFijo.UseVisualStyleBackColor = true;
            // 
            // rbtnBonoPorPresentismoNADA
            // 
            this.rbtnBonoPorPresentismoNADA.AutoSize = true;
            this.rbtnBonoPorPresentismoNADA.Location = new System.Drawing.Point(91, 242);
            this.rbtnBonoPorPresentismoNADA.Name = "rbtnBonoPorPresentismoNADA";
            this.rbtnBonoPorPresentismoNADA.Size = new System.Drawing.Size(179, 19);
            this.rbtnBonoPorPresentismoNADA.TabIndex = 5;
            this.rbtnBonoPorPresentismoNADA.TabStop = true;
            this.rbtnBonoPorPresentismoNADA.Text = "No aplica bono por resultado";
            this.rbtnBonoPorPresentismoNADA.UseVisualStyleBackColor = true;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(149, 108);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(121, 23);
            this.txtNombreEmpleado.TabIndex = 6;
            // 
            // lblNombreDelEmpleado
            // 
            this.lblNombreDelEmpleado.AutoSize = true;
            this.lblNombreDelEmpleado.Location = new System.Drawing.Point(68, 111);
            this.lblNombreDelEmpleado.Name = "lblNombreDelEmpleado";
            this.lblNombreDelEmpleado.Size = new System.Drawing.Size(51, 15);
            this.lblNombreDelEmpleado.TabIndex = 7;
            this.lblNombreDelEmpleado.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.lblNombreDelEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.rbtnBonoPorPresentismoNADA);
            this.Controls.Add(this.rbtnBonoPorPresentismoFijo);
            this.Controls.Add(this.rbtnBonoPorPresentismoVariable);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.cboxCategorias);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Name = "Form1";
            this.Text = "El sueldo de Don Pepe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularSueldo;
        private System.Windows.Forms.ComboBox cboxCategorias;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.RadioButton rbtnBonoPorPresentismoVariable;
        private System.Windows.Forms.RadioButton rbtnBonoPorPresentismoFijo;
        private System.Windows.Forms.RadioButton rbtnBonoPorPresentismoNADA;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblNombreDelEmpleado;
    }
}

