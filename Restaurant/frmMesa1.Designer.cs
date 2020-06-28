namespace Restaurant
{
    partial class frmMesa1
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
            this.tlpMesa2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMesa2 = new System.Windows.Forms.Label();
            this.lblNumPersonas = new System.Windows.Forms.Label();
            this.cbxNumeroPersonasMesa1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstadoMesa1 = new System.Windows.Forms.TextBox();
            this.btnOrdenarMesa1 = new System.Windows.Forms.Button();
            this.lbxPedidosMesa1 = new System.Windows.Forms.ListBox();
            this.tlpMesa2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMesa2
            // 
            this.tlpMesa2.ColumnCount = 2;
            this.tlpMesa2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.73973F));
            this.tlpMesa2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.26027F));
            this.tlpMesa2.Controls.Add(this.lblMesa2, 0, 0);
            this.tlpMesa2.Controls.Add(this.lblNumPersonas, 0, 1);
            this.tlpMesa2.Controls.Add(this.cbxNumeroPersonasMesa1, 1, 1);
            this.tlpMesa2.Controls.Add(this.label1, 0, 2);
            this.tlpMesa2.Controls.Add(this.txtEstadoMesa1, 1, 2);
            this.tlpMesa2.Controls.Add(this.btnOrdenarMesa1, 1, 4);
            this.tlpMesa2.Controls.Add(this.lbxPedidosMesa1, 0, 3);
            this.tlpMesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMesa2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMesa2.Location = new System.Drawing.Point(0, 0);
            this.tlpMesa2.Name = "tlpMesa2";
            this.tlpMesa2.RowCount = 5;
            this.tlpMesa2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.82734F));
            this.tlpMesa2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.11271F));
            this.tlpMesa2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.31175F));
            this.tlpMesa2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.80816F));
            this.tlpMesa2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.46043F));
            this.tlpMesa2.Size = new System.Drawing.Size(438, 417);
            this.tlpMesa2.TabIndex = 0;
            // 
            // lblMesa2
            // 
            this.lblMesa2.AutoSize = true;
            this.tlpMesa2.SetColumnSpan(this.lblMesa2, 2);
            this.lblMesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesa2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa2.Location = new System.Drawing.Point(3, 0);
            this.lblMesa2.Name = "lblMesa2";
            this.lblMesa2.Size = new System.Drawing.Size(432, 66);
            this.lblMesa2.TabIndex = 0;
            this.lblMesa2.Text = "Informacion de la Mesa 1";
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
            // cbxNumeroPersonasMesa1
            // 
            this.cbxNumeroPersonasMesa1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumeroPersonasMesa1.FormattingEnabled = true;
            this.cbxNumeroPersonasMesa1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxNumeroPersonasMesa1.Location = new System.Drawing.Point(234, 69);
            this.cbxNumeroPersonasMesa1.Name = "cbxNumeroPersonasMesa1";
            this.cbxNumeroPersonasMesa1.Size = new System.Drawing.Size(178, 29);
            this.cbxNumeroPersonasMesa1.TabIndex = 2;
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
            // txtEstadoMesa1
            // 
            this.txtEstadoMesa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstadoMesa1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoMesa1.Location = new System.Drawing.Point(234, 107);
            this.txtEstadoMesa1.Name = "txtEstadoMesa1";
            this.txtEstadoMesa1.ReadOnly = true;
            this.txtEstadoMesa1.Size = new System.Drawing.Size(201, 33);
            this.txtEstadoMesa1.TabIndex = 4;
            // 
            // btnOrdenarMesa1
            // 
            this.btnOrdenarMesa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdenarMesa1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarMesa1.Location = new System.Drawing.Point(234, 316);
            this.btnOrdenarMesa1.Name = "btnOrdenarMesa1";
            this.btnOrdenarMesa1.Size = new System.Drawing.Size(201, 98);
            this.btnOrdenarMesa1.TabIndex = 5;
            this.btnOrdenarMesa1.Text = "Nueva Orden";
            this.btnOrdenarMesa1.UseVisualStyleBackColor = true;
            // 
            // lbxPedidosMesa1
            // 
            this.tlpMesa2.SetColumnSpan(this.lbxPedidosMesa1, 2);
            this.lbxPedidosMesa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPedidosMesa1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPedidosMesa1.FormattingEnabled = true;
            this.lbxPedidosMesa1.ItemHeight = 25;
            this.lbxPedidosMesa1.Location = new System.Drawing.Point(3, 150);
            this.lbxPedidosMesa1.Name = "lbxPedidosMesa1";
            this.lbxPedidosMesa1.Size = new System.Drawing.Size(432, 160);
            this.lbxPedidosMesa1.TabIndex = 6;
            // 
            // frmMesa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 417);
            this.Controls.Add(this.tlpMesa2);
            this.MaximizeBox = false;
            this.Name = "frmMesa1";
            this.Text = "Mesa";
            
            this.Load += new System.EventHandler(this.frmOrdenes_Load);
            this.tlpMesa2.ResumeLayout(false);
            this.tlpMesa2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMesa2;
        private System.Windows.Forms.Label lblMesa2;
        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.ComboBox cbxNumeroPersonasMesa1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstadoMesa1;
        private System.Windows.Forms.Button btnOrdenarMesa1;
        private System.Windows.Forms.ListBox lbxPedidosMesa1;
    }
}