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
            this.btnProcesarOrden = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tlpMesa.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tlpMesa.Controls.Add(this.btnProcesarOrden, 1, 4);
            this.tlpMesa.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tlpMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMesa.Location = new System.Drawing.Point(0, 0);
            this.tlpMesa.Name = "tlpMesa";
            this.tlpMesa.RowCount = 5;
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.27273F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76596F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98176F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.28701F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpMesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.lblNoClientes.Size = new System.Drawing.Size(432, 57);
            this.lblNoClientes.TabIndex = 0;
            this.lblNoClientes.Text = "Informacion de la Mesa";
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumPersonas.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPersonas.Location = new System.Drawing.Point(3, 57);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(225, 42);
            this.lblNumPersonas.TabIndex = 1;
            this.lblNumPersonas.Text = "Numero de personas";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estado Mesa";
            // 
            // txtEstadoMesa
            // 
            this.txtEstadoMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstadoMesa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoMesa.Location = new System.Drawing.Point(234, 102);
            this.txtEstadoMesa.Name = "txtEstadoMesa";
            this.txtEstadoMesa.ReadOnly = true;
            this.txtEstadoMesa.Size = new System.Drawing.Size(201, 29);
            this.txtEstadoMesa.TabIndex = 4;
            this.txtEstadoMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnProcesarOrden
            // 
            this.btnProcesarOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcesarOrden.Location = new System.Drawing.Point(234, 332);
            this.btnProcesarOrden.Name = "btnProcesarOrden";
            this.btnProcesarOrden.Size = new System.Drawing.Size(201, 82);
            this.btnProcesarOrden.TabIndex = 5;
            this.btnProcesarOrden.Text = "Procesar Orden";
            this.btnProcesarOrden.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tlpMesa.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 178);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 172);
            this.listBox1.TabIndex = 0;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMesa;
        private System.Windows.Forms.Label lblNoClientes;
        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstadoMesa;
        private System.Windows.Forms.Button btnProcesarOrden;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}