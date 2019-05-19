namespace LibraryApp
{
    partial class Order
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.fullnameCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullnameA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrturnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(80, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 30);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameCl,
            this.FullnameA,
            this.OrderD,
            this.RrturnD});
            this.dgvOrder.Location = new System.Drawing.Point(80, 157);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(738, 269);
            this.dgvOrder.TabIndex = 2;
            // 
            // fullnameCl
            // 
            this.fullnameCl.HeaderText = "Client Fullname";
            this.fullnameCl.Name = "fullnameCl";
            this.fullnameCl.ReadOnly = true;
            // 
            // FullnameA
            // 
            this.FullnameA.HeaderText = "Author Fullname";
            this.FullnameA.Name = "FullnameA";
            this.FullnameA.ReadOnly = true;
            // 
            // OrderD
            // 
            this.OrderD.HeaderText = "Order Date";
            this.OrderD.Name = "OrderD";
            this.OrderD.ReadOnly = true;
            // 
            // RrturnD
            // 
            this.RrturnD.HeaderText = "Return Date";
            this.RrturnD.Name = "RrturnD";
            this.RrturnD.ReadOnly = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 632);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullnameA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderD;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrturnD;
    }
}