﻿namespace Restaurant
{
    partial class frmMesa2
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
            this.cbxNumeroPersonasMesa2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstadoMesa2 = new System.Windows.Forms.TextBox();
            this.btnOrdenar2 = new System.Windows.Forms.Button();
            this.lbxPedidosMesa2 = new System.Windows.Forms.ListBox();
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
            this.tlpMesa.Controls.Add(this.cbxNumeroPersonasMesa2, 1, 1);
            this.tlpMesa.Controls.Add(this.label1, 0, 2);
            this.tlpMesa.Controls.Add(this.txtEstadoMesa2, 1, 2);
            this.tlpMesa.Controls.Add(this.btnOrdenar2, 1, 4);
            this.tlpMesa.Controls.Add(this.lbxPedidosMesa2, 0, 3);
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
            this.lblNoClientes.Size = new System.Drawing.Size(432, 66);
            this.lblNoClientes.TabIndex = 0;
            this.lblNoClientes.Text = "Informacion de la Mesa 2";
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumPersonas.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPersonas.Location = new System.Drawing.Point(3, 66);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(225, 38);
            this.lblNumPersonas.TabIndex = 1;
            this.lblNumPersonas.Text = "Numero de personas";
            // 
            // cbxNumeroPersonasMesa2
            // 
            this.cbxNumeroPersonasMesa2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumeroPersonasMesa2.FormattingEnabled = true;
            this.cbxNumeroPersonasMesa2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxNumeroPersonasMesa2.Location = new System.Drawing.Point(234, 69);
            this.cbxNumeroPersonasMesa2.Name = "cbxNumeroPersonasMesa2";
            this.cbxNumeroPersonasMesa2.Size = new System.Drawing.Size(178, 29);
            this.cbxNumeroPersonasMesa2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estado Mesa";
            // 
            // txtEstadoMesa2
            // 
            this.txtEstadoMesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstadoMesa2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoMesa2.Location = new System.Drawing.Point(234, 107);
            this.txtEstadoMesa2.Name = "txtEstadoMesa2";
            this.txtEstadoMesa2.ReadOnly = true;
            this.txtEstadoMesa2.Size = new System.Drawing.Size(201, 33);
            this.txtEstadoMesa2.TabIndex = 4;
            // 
            // btnOrdenar2
            // 
            this.btnOrdenar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdenar2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar2.Location = new System.Drawing.Point(234, 316);
            this.btnOrdenar2.Name = "btnOrdenar2";
            this.btnOrdenar2.Size = new System.Drawing.Size(201, 98);
            this.btnOrdenar2.TabIndex = 5;
            this.btnOrdenar2.Text = "Nueva Orden";
            this.btnOrdenar2.UseVisualStyleBackColor = true;
            // 
            // lbxPedidosMesa2
            // 
            this.tlpMesa.SetColumnSpan(this.lbxPedidosMesa2, 2);
            this.lbxPedidosMesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPedidosMesa2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPedidosMesa2.FormattingEnabled = true;
            this.lbxPedidosMesa2.ItemHeight = 25;
            this.lbxPedidosMesa2.Location = new System.Drawing.Point(3, 150);
            this.lbxPedidosMesa2.Name = "lbxPedidosMesa2";
            this.lbxPedidosMesa2.Size = new System.Drawing.Size(432, 160);
            this.lbxPedidosMesa2.TabIndex = 6;
            // 
            // frmMesa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 417);
            this.Controls.Add(this.tlpMesa);
            this.MaximizeBox = false;
            this.Name = "frmMesa2";
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
        private System.Windows.Forms.ComboBox cbxNumeroPersonasMesa2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstadoMesa2;
        private System.Windows.Forms.Button btnOrdenar2;
        private System.Windows.Forms.ListBox lbxPedidosMesa2;
    }
}