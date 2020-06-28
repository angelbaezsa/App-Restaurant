namespace Restaurant
{
    partial class frmMesa4
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
            this.lbxPedidosMesa4 = new System.Windows.Forms.ListBox();
            this.tlpMesa = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoClientes = new System.Windows.Forms.Label();
            this.lblNumPersonas = new System.Windows.Forms.Label();
            this.cbxNumeroPersonasMesa4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstadoMesa4 = new System.Windows.Forms.TextBox();
            this.btnOrdenar4 = new System.Windows.Forms.Button();
            this.tlpMesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxPedidosMesa4
            // 
            this.tlpMesa.SetColumnSpan(this.lbxPedidosMesa4, 2);
            this.lbxPedidosMesa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPedidosMesa4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPedidosMesa4.FormattingEnabled = true;
            this.lbxPedidosMesa4.ItemHeight = 25;
            this.lbxPedidosMesa4.Location = new System.Drawing.Point(3, 161);
            this.lbxPedidosMesa4.Name = "lbxPedidosMesa4";
            this.lbxPedidosMesa4.Size = new System.Drawing.Size(446, 174);
            this.lbxPedidosMesa4.TabIndex = 6;
            // 
            // tlpMesa
            // 
            this.tlpMesa.ColumnCount = 2;
            this.tlpMesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.73973F));
            this.tlpMesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.26027F));
            this.tlpMesa.Controls.Add(this.lblNoClientes, 0, 0);
            this.tlpMesa.Controls.Add(this.lblNumPersonas, 0, 1);
            this.tlpMesa.Controls.Add(this.cbxNumeroPersonasMesa4, 1, 1);
            this.tlpMesa.Controls.Add(this.label1, 0, 2);
            this.tlpMesa.Controls.Add(this.txtEstadoMesa4, 1, 2);
            this.tlpMesa.Controls.Add(this.btnOrdenar4, 1, 4);
            this.tlpMesa.Controls.Add(this.lbxPedidosMesa4, 0, 3);
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
            this.tlpMesa.Size = new System.Drawing.Size(452, 450);
            this.tlpMesa.TabIndex = 2;
            // 
            // lblNoClientes
            // 
            this.lblNoClientes.AutoSize = true;
            this.tlpMesa.SetColumnSpan(this.lblNoClientes, 2);
            this.lblNoClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoClientes.Location = new System.Drawing.Point(3, 0);
            this.lblNoClientes.Name = "lblNoClientes";
            this.lblNoClientes.Size = new System.Drawing.Size(446, 71);
            this.lblNoClientes.TabIndex = 0;
            this.lblNoClientes.Text = "Informacion de la Mesa 4";
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumPersonas.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPersonas.Location = new System.Drawing.Point(3, 71);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(232, 41);
            this.lblNumPersonas.TabIndex = 1;
            this.lblNumPersonas.Text = "Numero de personas";
            // 
            // cbxNumeroPersonasMesa4
            // 
            this.cbxNumeroPersonasMesa4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumeroPersonasMesa4.FormattingEnabled = true;
            this.cbxNumeroPersonasMesa4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxNumeroPersonasMesa4.Location = new System.Drawing.Point(241, 74);
            this.cbxNumeroPersonasMesa4.Name = "cbxNumeroPersonasMesa4";
            this.cbxNumeroPersonasMesa4.Size = new System.Drawing.Size(178, 29);
            this.cbxNumeroPersonasMesa4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estado Mesa";
            // 
            // txtEstadoMesa4
            // 
            this.txtEstadoMesa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstadoMesa4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoMesa4.Location = new System.Drawing.Point(241, 115);
            this.txtEstadoMesa4.Name = "txtEstadoMesa4";
            this.txtEstadoMesa4.ReadOnly = true;
            this.txtEstadoMesa4.Size = new System.Drawing.Size(208, 33);
            this.txtEstadoMesa4.TabIndex = 4;
            // 
            // btnOrdenar4
            // 
            this.btnOrdenar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdenar4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar4.Location = new System.Drawing.Point(241, 341);
            this.btnOrdenar4.Name = "btnOrdenar4";
            this.btnOrdenar4.Size = new System.Drawing.Size(208, 106);
            this.btnOrdenar4.TabIndex = 5;
            this.btnOrdenar4.Text = "Nueva Orden";
            this.btnOrdenar4.UseVisualStyleBackColor = true;
            // 
            // frmMesa4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.tlpMesa);
            this.Name = "frmMesa4";
            this.Text = "frmMesa4";
            this.tlpMesa.ResumeLayout(false);
            this.tlpMesa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPedidosMesa4;
        private System.Windows.Forms.TableLayoutPanel tlpMesa;
        private System.Windows.Forms.Label lblNoClientes;
        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.ComboBox cbxNumeroPersonasMesa4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstadoMesa4;
        private System.Windows.Forms.Button btnOrdenar4;
    }
}