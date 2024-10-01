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
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxContactName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.btnInsertarT = new System.Windows.Forms.Button();
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
            this.groupBox1.Size = new System.Drawing.Size(262, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet No Tipado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar Cliente";
            // 
            // tboxBusquedaNt
            // 
            this.tboxBusquedaNt.Location = new System.Drawing.Point(105, 254);
            this.tboxBusquedaNt.Name = "tboxBusquedaNt";
            this.tboxBusquedaNt.Size = new System.Drawing.Size(100, 20);
            this.tboxBusquedaNt.TabIndex = 6;
            // 
            // btnBuscarNt
            // 
            this.btnBuscarNt.Location = new System.Drawing.Point(17, 290);
            this.btnBuscarNt.Name = "btnBuscarNt";
            this.btnBuscarNt.Size = new System.Drawing.Size(234, 23);
            this.btnBuscarNt.TabIndex = 5;
            this.btnBuscarNt.Text = "Buscar Cliente";
            this.btnBuscarNt.UseVisualStyleBackColor = true;
            this.btnBuscarNt.Click += new System.EventHandler(this.btnBuscarNt_Click);
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(9, 185);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(242, 29);
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
            this.gridNoTipado.Size = new System.Drawing.Size(245, 150);
            this.gridNoTipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInsertarT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tboxBuscarTipado);
            this.groupBox2.Controls.Add(this.btnBuscarTipado);
            this.groupBox2.Controls.Add(this.btnObtenerTipado);
            this.groupBox2.Controls.Add(this.gridTipado);
            this.groupBox2.Location = new System.Drawing.Point(280, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(6, 185);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(283, 29);
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
            this.gridTipado.Size = new System.Drawing.Size(283, 150);
            this.gridTipado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar Cliente";
            // 
            // tboxBuscarTipado
            // 
            this.tboxBuscarTipado.Location = new System.Drawing.Point(133, 250);
            this.tboxBuscarTipado.Name = "tboxBuscarTipado";
            this.tboxBuscarTipado.Size = new System.Drawing.Size(100, 20);
            this.tboxBuscarTipado.TabIndex = 9;
            // 
            // btnBuscarTipado
            // 
            this.btnBuscarTipado.Location = new System.Drawing.Point(19, 290);
            this.btnBuscarTipado.Name = "btnBuscarTipado";
            this.btnBuscarTipado.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarTipado.TabIndex = 8;
            this.btnBuscarTipado.Text = "Buscar Cliente";
            this.btnBuscarTipado.UseVisualStyleBackColor = true;
            this.btnBuscarTipado.Click += new System.EventHandler(this.btnBuscarTipado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer ID";
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(688, 43);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.tboxCustomerID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Company Name";
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new System.Drawing.Point(688, 82);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(100, 20);
            this.tboxCompanyName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Contact Title";
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.Location = new System.Drawing.Point(688, 158);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(100, 20);
            this.tboxContactTitle.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Contact Name";
            // 
            // tboxContactName
            // 
            this.tboxContactName.Location = new System.Drawing.Point(688, 119);
            this.tboxContactName.Name = "tboxContactName";
            this.tboxContactName.Size = new System.Drawing.Size(100, 20);
            this.tboxContactName.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address";
            // 
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(688, 197);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(100, 20);
            this.tboxAddress.TabIndex = 19;
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(610, 255);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(161, 23);
            this.btnInsertarCliente.TabIndex = 11;
            this.btnInsertarCliente.Text = "Insertar Cliente";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // btnInsertarT
            // 
            this.btnInsertarT.Location = new System.Drawing.Point(146, 290);
            this.btnInsertarT.Name = "btnInsertarT";
            this.btnInsertarT.Size = new System.Drawing.Size(108, 23);
            this.btnInsertarT.TabIndex = 11;
            this.btnInsertarT.Text = "Insertar";
            this.btnInsertarT.UseVisualStyleBackColor = true;
            this.btnInsertarT.Click += new System.EventHandler(this.btnInsertarT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertarCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxContactName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxCustomerID);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxContactName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.Button btnInsertarT;
    }
}

