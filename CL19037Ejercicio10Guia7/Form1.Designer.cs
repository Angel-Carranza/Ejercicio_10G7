namespace CL19037Ejercicio10Guia7
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
            this.components = new System.ComponentModel.Container();
            this.dgvTotalesMaiz = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPedido = new System.Windows.Forms.ListBox();
            this.btnOrdenarMiaz = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.dgvTotalesArroz = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalesBebidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdenarArroz = new System.Windows.Forms.Button();
            this.btnOrdenarBebidas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalesMaiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalesArroz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalesBebidas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTotalesMaiz
            // 
            this.dgvTotalesMaiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalesMaiz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8});
            this.dgvTotalesMaiz.Location = new System.Drawing.Point(13, 21);
            this.dgvTotalesMaiz.Name = "dgvTotalesMaiz";
            this.dgvTotalesMaiz.RowTemplate.Height = 24;
            this.dgvTotalesMaiz.Size = new System.Drawing.Size(586, 94);
            this.dgvTotalesMaiz.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FQ ($0.50 c/u)";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RV ($0.75 c/u)";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QL ($1.00 c/u)";
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total";
            this.Column8.Name = "Column8";
            // 
            // lbPedido
            // 
            this.lbPedido.FormattingEnabled = true;
            this.lbPedido.ItemHeight = 16;
            this.lbPedido.Location = new System.Drawing.Point(15, 94);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(242, 132);
            this.lbPedido.TabIndex = 1;
            // 
            // btnOrdenarMiaz
            // 
            this.btnOrdenarMiaz.Location = new System.Drawing.Point(15, 26);
            this.btnOrdenarMiaz.Name = "btnOrdenarMiaz";
            this.btnOrdenarMiaz.Size = new System.Drawing.Size(132, 31);
            this.btnOrdenarMiaz.TabIndex = 2;
            this.btnOrdenarMiaz.Text = "Masa de maiz";
            this.btnOrdenarMiaz.UseVisualStyleBackColor = true;
            this.btnOrdenarMiaz.Click += new System.EventHandler(this.btnOrdenarMiaz_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(263, 94);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 31);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Nuevo Pedido";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(668, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 31);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar Todo";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pedido";
            // 
            // dgvTotalesArroz
            // 
            this.dgvTotalesArroz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalesArroz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvTotalesArroz.Location = new System.Drawing.Point(13, 21);
            this.dgvTotalesArroz.Name = "dgvTotalesArroz";
            this.dgvTotalesArroz.RowTemplate.Height = 24;
            this.dgvTotalesArroz.Size = new System.Drawing.Size(586, 94);
            this.dgvTotalesArroz.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "FQ ($0.50 c/u)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "RV ($0.75 c/u)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "QL ($1.00 c/u)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dgvTotalesBebidas
            // 
            this.dgvTotalesBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalesBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column4});
            this.dgvTotalesBebidas.Location = new System.Drawing.Point(6, 21);
            this.dgvTotalesBebidas.Name = "dgvTotalesBebidas";
            this.dgvTotalesBebidas.RowTemplate.Height = 24;
            this.dgvTotalesBebidas.Size = new System.Drawing.Size(707, 94);
            this.dgvTotalesBebidas.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Agua ($0.35 c/u)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Soda ($0.60 c/u)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Chocolate ($0.75 c/u)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Cafe ($0.50 c/u)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // btnOrdenarArroz
            // 
            this.btnOrdenarArroz.Location = new System.Drawing.Point(153, 26);
            this.btnOrdenarArroz.Name = "btnOrdenarArroz";
            this.btnOrdenarArroz.Size = new System.Drawing.Size(132, 31);
            this.btnOrdenarArroz.TabIndex = 8;
            this.btnOrdenarArroz.Text = "Masa de arroz";
            this.btnOrdenarArroz.UseVisualStyleBackColor = true;
            this.btnOrdenarArroz.Click += new System.EventHandler(this.btnOrdenarArroz_Click);
            // 
            // btnOrdenarBebidas
            // 
            this.btnOrdenarBebidas.Location = new System.Drawing.Point(291, 26);
            this.btnOrdenarBebidas.Name = "btnOrdenarBebidas";
            this.btnOrdenarBebidas.Size = new System.Drawing.Size(132, 31);
            this.btnOrdenarBebidas.TabIndex = 9;
            this.btnOrdenarBebidas.Text = "Bebidas";
            this.btnOrdenarBebidas.UseVisualStyleBackColor = true;
            this.btnOrdenarBebidas.Click += new System.EventHandler(this.btnOrdenarBebidas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total A Pagar";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(775, 513);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 17);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(753, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTotalesMaiz);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 126);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pupusas de Maiz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTotalesArroz);
            this.groupBox2.Location = new System.Drawing.Point(12, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 126);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pupusas de Arroz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTotalesBebidas);
            this.groupBox3.Location = new System.Drawing.Point(12, 496);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 126);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bebidas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrdenarBebidas);
            this.Controls.Add(this.btnOrdenarArroz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOrdenarMiaz);
            this.Controls.Add(this.lbPedido);
            this.Name = "Form1";
            this.Text = "Restaurante La Pupusa Loca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalesMaiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalesArroz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalesBebidas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotalesMaiz;
        private System.Windows.Forms.ListBox lbPedido;
        private System.Windows.Forms.Button btnOrdenarMiaz;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView dgvTotalesArroz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvTotalesBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnOrdenarArroz;
        private System.Windows.Forms.Button btnOrdenarBebidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

