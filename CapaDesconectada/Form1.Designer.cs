namespace CapaDesconectada
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxBusquedaNt = new System.Windows.Forms.TextBox();
            this.btnBuscarNt = new System.Windows.Forms.Button();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.gridNoTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxBuscarTipado = new System.Windows.Forms.TextBox();
            this.btnBuscarTipado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxBusquedaNt);
            this.groupBox1.Controls.Add(this.btnBuscarNt);
            this.groupBox1.Controls.Add(this.btnObtenerNoTipado);
            this.groupBox1.Controls.Add(this.gridNoTipado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet No Tipado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar Cliente";
            // 
            // tboxBusquedaNt
            // 
            this.tboxBusquedaNt.Location = new System.Drawing.Point(160, 255);
            this.tboxBusquedaNt.Name = "tboxBusquedaNt";
            this.tboxBusquedaNt.Size = new System.Drawing.Size(100, 20);
            this.tboxBusquedaNt.TabIndex = 6;
            // 
            // btnBuscarNt
            // 
            this.btnBuscarNt.Location = new System.Drawing.Point(72, 291);
            this.btnBuscarNt.Name = "btnBuscarNt";
            this.btnBuscarNt.Size = new System.Drawing.Size(202, 23);
            this.btnBuscarNt.TabIndex = 5;
            this.btnBuscarNt.Text = "Buscar Cliente";
            this.btnBuscarNt.UseVisualStyleBackColor = true;
            this.btnBuscarNt.Click += new System.EventHandler(this.btnBuscarNt_Click);
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(9, 185);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(366, 29);
            this.btnObtenerNoTipado.TabIndex = 2;
            this.btnObtenerNoTipado.Text = "Obtener datos no tipados";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click);
            // 
            // gridNoTipado
            // 
            this.gridNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNoTipado.Location = new System.Drawing.Point(6, 19);
            this.gridNoTipado.Name = "gridNoTipado";
            this.gridNoTipado.Size = new System.Drawing.Size(372, 150);
            this.gridNoTipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tboxBuscarTipado);
            this.groupBox2.Controls.Add(this.btnBuscarTipado);
            this.groupBox2.Controls.Add(this.btnObtenerTipado);
            this.groupBox2.Controls.Add(this.gridTipado);
            this.groupBox2.Location = new System.Drawing.Point(402, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(6, 185);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(374, 29);
            this.btnObtenerTipado.TabIndex = 3;
            this.btnObtenerTipado.Text = "Obtener datos tipados";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            this.btnObtenerTipado.Click += new System.EventHandler(this.btnObtenerTipado_Click);
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(6, 19);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.Size = new System.Drawing.Size(374, 150);
            this.gridTipado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar Cliente";
            // 
            // tboxBuscarTipado
            // 
            this.tboxBuscarTipado.Location = new System.Drawing.Point(175, 258);
            this.tboxBuscarTipado.Name = "tboxBuscarTipado";
            this.tboxBuscarTipado.Size = new System.Drawing.Size(100, 20);
            this.tboxBuscarTipado.TabIndex = 9;
            // 
            // btnBuscarTipado
            // 
            this.btnBuscarTipado.Location = new System.Drawing.Point(87, 294);
            this.btnBuscarTipado.Name = "btnBuscarTipado";
            this.btnBuscarTipado.Size = new System.Drawing.Size(202, 23);
            this.btnBuscarTipado.TabIndex = 8;
            this.btnBuscarTipado.Text = "Buscar Cliente";
            this.btnBuscarTipado.UseVisualStyleBackColor = true;
            this.btnBuscarTipado.Click += new System.EventHandler(this.btnBuscarTipado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.DataGridView gridNoTipado;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxBusquedaNt;
        private System.Windows.Forms.Button btnBuscarNt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxBuscarTipado;
        private System.Windows.Forms.Button btnBuscarTipado;
    }
}

