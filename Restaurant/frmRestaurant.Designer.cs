namespace Restaurant
{
    partial class frmRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestaurant));
            this.tlpRestaurant = new System.Windows.Forms.TableLayoutPanel();
            this.btnMesa4 = new System.Windows.Forms.Button();
            this.btnMesa3 = new System.Windows.Forms.Button();
            this.btnMesa2 = new System.Windows.Forms.Button();
            this.btnMesa1 = new System.Windows.Forms.Button();
            this.lblSeleccionMesa = new System.Windows.Forms.Label();
            this.tlpRestaurant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRestaurant
            // 
            this.tlpRestaurant.ColumnCount = 3;
            this.tlpRestaurant.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.40151F));
            this.tlpRestaurant.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.37864F));
            this.tlpRestaurant.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.3301F));
            this.tlpRestaurant.Controls.Add(this.btnMesa4, 1, 2);
            this.tlpRestaurant.Controls.Add(this.btnMesa3, 0, 2);
            this.tlpRestaurant.Controls.Add(this.btnMesa2, 1, 1);
            this.tlpRestaurant.Controls.Add(this.btnMesa1, 0, 1);
            this.tlpRestaurant.Controls.Add(this.lblSeleccionMesa, 0, 0);
            this.tlpRestaurant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRestaurant.Location = new System.Drawing.Point(0, 0);
            this.tlpRestaurant.Margin = new System.Windows.Forms.Padding(4);
            this.tlpRestaurant.Name = "tlpRestaurant";
            this.tlpRestaurant.RowCount = 3;
            this.tlpRestaurant.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.59147F));
            this.tlpRestaurant.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.7414F));
            this.tlpRestaurant.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.39202F));
            this.tlpRestaurant.Size = new System.Drawing.Size(901, 727);
            this.tlpRestaurant.TabIndex = 0;
            // 
            // btnMesa4
            // 
            this.btnMesa4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMesa4.BackgroundImage")));
            this.btnMesa4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa4.Location = new System.Drawing.Point(366, 398);
            this.btnMesa4.Name = "btnMesa4";
            this.btnMesa4.Size = new System.Drawing.Size(330, 326);
            this.btnMesa4.TabIndex = 3;
            this.btnMesa4.Text = "Mesa 4";
            this.btnMesa4.UseVisualStyleBackColor = true;
            this.btnMesa4.Click += new System.EventHandler(this.btnMesa4_Click_1);
            // 
            // btnMesa3
            // 
            this.btnMesa3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMesa3.BackgroundImage")));
            this.btnMesa3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa3.Location = new System.Drawing.Point(3, 398);
            this.btnMesa3.Name = "btnMesa3";
            this.btnMesa3.Size = new System.Drawing.Size(357, 326);
            this.btnMesa3.TabIndex = 2;
            this.btnMesa3.Text = "Mesa 3";
            this.btnMesa3.UseVisualStyleBackColor = true;
            this.btnMesa3.Click += new System.EventHandler(this.btnMesa3_Click_1);
            // 
            // btnMesa2
            // 
            this.btnMesa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMesa2.BackgroundImage")));
            this.btnMesa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa2.Location = new System.Drawing.Point(366, 80);
            this.btnMesa2.Name = "btnMesa2";
            this.btnMesa2.Size = new System.Drawing.Size(330, 312);
            this.btnMesa2.TabIndex = 1;
            this.btnMesa2.Text = "Mesa 2";
            this.btnMesa2.UseVisualStyleBackColor = true;
            this.btnMesa2.Click += new System.EventHandler(this.btnMesa2_Click);
            // 
            // btnMesa1
            // 
            this.btnMesa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMesa1.BackgroundImage")));
            this.btnMesa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa1.Location = new System.Drawing.Point(3, 80);
            this.btnMesa1.Name = "btnMesa1";
            this.btnMesa1.Size = new System.Drawing.Size(357, 312);
            this.btnMesa1.TabIndex = 0;
            this.btnMesa1.Text = "Mesa 1";
            this.btnMesa1.UseVisualStyleBackColor = true;
            this.btnMesa1.Click += new System.EventHandler(this.btnMesa1_Click);
            // 
            // lblSeleccionMesa
            // 
            this.lblSeleccionMesa.AutoSize = true;
            this.tlpRestaurant.SetColumnSpan(this.lblSeleccionMesa, 2);
            this.lblSeleccionMesa.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionMesa.Location = new System.Drawing.Point(3, 0);
            this.lblSeleccionMesa.Name = "lblSeleccionMesa";
            this.lblSeleccionMesa.Size = new System.Drawing.Size(360, 50);
            this.lblSeleccionMesa.TabIndex = 4;
            this.lblSeleccionMesa.Text = "Seleccionar Mesa";
            // 
            // frmRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 727);
            this.Controls.Add(this.tlpRestaurant);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRestaurant";
            this.Text = "Restaurant";
            this.tlpRestaurant.ResumeLayout(false);
            this.tlpRestaurant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRestaurant;
        private System.Windows.Forms.Button btnMesa1;
        private System.Windows.Forms.Button btnMesa4;
        private System.Windows.Forms.Button btnMesa3;
        private System.Windows.Forms.Button btnMesa2;
        private System.Windows.Forms.Label lblSeleccionMesa;
    }
}

