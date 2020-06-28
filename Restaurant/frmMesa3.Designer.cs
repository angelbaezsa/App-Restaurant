namespace Restaurant
{
    partial class frmMesa3
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
            this.lbxPedidosMesa3 = new System.Windows.Forms.ListBox();
            this.tlpMesa = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoClientes = new System.Windows.Forms.Label();
            this.lblNumPersonas = new System.Windows.Forms.Label();
            this.cbxNumeroPersonasMesa3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstadoMesa3 = new System.Windows.Forms.TextBox();
            this.btnOrdenar3 = new System.Windows.Forms.Button();
            this.tlpMesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxPedidosMesa3
            // 
            this.tlpMesa.SetColumnSpan(this.lbxPedidosMesa3, 2);
            this.lbxPedidosMesa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPedidosMesa3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPedidosMesa3.FormattingEnabled = true;
            this.lbxPedidosMesa3.ItemHeight = 25;
            this.lbxPedidosMesa3.Location = new System.Drawing.Point(3, 161);
            this.lbxPedidosMesa3.Name = "lbxPedidosMesa3";
            this.lbxPedidosMesa3.Size = new System.Drawing.Size(458, 174);
            this.lbxPedidosMesa3.TabIndex = 6;
            // 
            // tlpMesa
            // 
            this.tlpMesa.ColumnCount = 2;
            this.tlpMesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.73973F));
            this.tlpMesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.26027F));
            this.tlpMesa.Controls.Add(this.lblNoClientes, 0, 0);
            this.tlpMesa.Controls.Add(this.lblNumPersonas, 0, 1);
            this.tlpMesa.Controls.Add(this.cbxNumeroPersonasMesa3, 1, 1);
            this.tlpMesa.Controls.Add(this.label1, 0, 2);
            this.tlpMesa.Controls.Add(this.txtEstadoMesa3, 1, 2);
            this.tlpMesa.Controls.Add(this.btnOrdenar3, 1, 4);
            this.tlpMesa.Controls.Add(this.lbxPedidosMesa3, 0, 3);
            this.tlpMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMesa.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMesa.Location = new System.Drawing.Point(0, 0);
            this.tlpMesa.Name = "tlpMesa";
            this.tlpMesa.RowCount = 5;
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.82734F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.11271F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.31175F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.80816F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.46043F));
            this.tlpMesa.Size = new System.Drawing.Size(464, 450);
            this.tlpMesa.TabIndex = 1;
            // 
            // lblNoClientes
            // 
            this.lblNoClientes.AutoSize = true;
            this.tlpMesa.SetColumnSpan(this.lblNoClientes, 2);
            this.lblNoClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoClientes.Location = new System.Drawing.Point(3, 0);
            this.lblNoClientes.Name = "lblNoClientes";
            this.lblNoClientes.Size = new System.Drawing.Size(458, 71);
            this.lblNoClientes.TabIndex = 0;
            this.lblNoClientes.Text = "Informacion de la Mesa 3";
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumPersonas.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPersonas.Location = new System.Drawing.Point(3, 71);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(238, 41);
            this.lblNumPersonas.TabIndex = 1;
            this.lblNumPersonas.Text = "Numero de personas";
            // 
            // cbxNumeroPersonasMesa3
            // 
            this.cbxNumeroPersonasMesa3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumeroPersonasMesa3.FormattingEnabled = true;
            this.cbxNumeroPersonasMesa3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxNumeroPersonasMesa3.Location = new System.Drawing.Point(247, 74);
            this.cbxNumeroPersonasMesa3.Name = "cbxNumeroPersonasMesa3";
            this.cbxNumeroPersonasMesa3.Size = new System.Drawing.Size(178, 29);
            this.cbxNumeroPersonasMesa3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estado Mesa";
            // 
            // txtEstadoMesa3
            // 
            this.txtEstadoMesa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstadoMesa3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoMesa3.Location = new System.Drawing.Point(247, 115);
            this.txtEstadoMesa3.Name = "txtEstadoMesa3";
            this.txtEstadoMesa3.ReadOnly = true;
            this.txtEstadoMesa3.Size = new System.Drawing.Size(214, 33);
            this.txtEstadoMesa3.TabIndex = 4;
            // 
            // btnOrdenar3
            // 
            this.btnOrdenar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdenar3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar3.Location = new System.Drawing.Point(247, 341);
            this.btnOrdenar3.Name = "btnOrdenar3";
            this.btnOrdenar3.Size = new System.Drawing.Size(214, 106);
            this.btnOrdenar3.TabIndex = 5;
            this.btnOrdenar3.Text = "Nueva Orden";
            this.btnOrdenar3.UseVisualStyleBackColor = true;
            // 
            // frmMesa3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.tlpMesa);
            this.Name = "frmMesa3";
            this.Text = "Mesa";
            this.tlpMesa.ResumeLayout(false);
            this.tlpMesa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPedidosMesa3;
        private System.Windows.Forms.TableLayoutPanel tlpMesa;
        private System.Windows.Forms.Label lblNoClientes;
        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.ComboBox cbxNumeroPersonasMesa3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstadoMesa3;
        private System.Windows.Forms.Button btnOrdenar3;
    }
}