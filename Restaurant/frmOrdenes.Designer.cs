namespace Restaurant
{
    partial class frmOrdenes
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
            this.tlpMesa = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoClientes = new System.Windows.Forms.Label();
            this.lblNumPersonas = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstadoMesa = new System.Windows.Forms.TextBox();
            this.tlpMesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMesa
            // 
            this.tlpMesa.ColumnCount = 2;
            this.tlpMesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.73973F));
            this.tlpMesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.26027F));
            this.tlpMesa.Controls.Add(this.lblNoClientes, 0, 0);
            this.tlpMesa.Controls.Add(this.lblNumPersonas, 0, 1);
            this.tlpMesa.Controls.Add(this.comboBox1, 1, 1);
            this.tlpMesa.Controls.Add(this.label1, 0, 2);
            this.tlpMesa.Controls.Add(this.txtEstadoMesa, 1, 2);
            this.tlpMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMesa.Location = new System.Drawing.Point(0, 0);
            this.tlpMesa.Name = "tlpMesa";
            this.tlpMesa.RowCount = 4;
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.90887F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.31175F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.393286F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.90647F));
            this.tlpMesa.Size = new System.Drawing.Size(438, 417);
            this.tlpMesa.TabIndex = 0;
            // 
            // lblNoClientes
            // 
            this.lblNoClientes.AutoSize = true;
            this.tlpMesa.SetColumnSpan(this.lblNoClientes, 2);
            this.lblNoClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoClientes.Location = new System.Drawing.Point(3, 0);
            this.lblNoClientes.Name = "lblNoClientes";
            this.lblNoClientes.Size = new System.Drawing.Size(432, 58);
            this.lblNoClientes.TabIndex = 0;
            this.lblNoClientes.Text = "Informacion de la Mesa";
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumPersonas.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPersonas.Location = new System.Drawing.Point(3, 58);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(225, 43);
            this.lblNumPersonas.TabIndex = 1;
            this.lblNumPersonas.Text = "Numero de personas";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estado Mesa";
            // 
            // txtEstadoMesa
            // 
            this.txtEstadoMesa.Location = new System.Drawing.Point(234, 104);
            this.txtEstadoMesa.Name = "txtEstadoMesa";
            this.txtEstadoMesa.ReadOnly = true;
            this.txtEstadoMesa.Size = new System.Drawing.Size(178, 20);
            this.txtEstadoMesa.TabIndex = 4;
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 417);
            this.Controls.Add(this.tlpMesa);
            this.MaximizeBox = false;
            this.Name = "frmOrdenes";
            this.Opacity = 0.5D;
            this.Text = "Mesa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrdenes_FormClosed);
            this.Load += new System.EventHandler(this.frmOrdenes_Load);
            this.tlpMesa.ResumeLayout(false);
            this.tlpMesa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMesa;
        private System.Windows.Forms.Label lblNoClientes;
        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstadoMesa;
    }
}