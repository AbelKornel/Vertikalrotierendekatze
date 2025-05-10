namespace KliensApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            listBox1 = new ListBox();
            productsToOrderBindingSource = new BindingSource(components);
            label1 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderedProductsBindingSource = new BindingSource(components);
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            hccSearchQueryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)productsToOrderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderedProductsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hccSearchQueryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Location = new Point(651, 29);
            button1.Name = "button1";
            button1.Size = new Size(154, 56);
            button1.TabIndex = 0;
            button1.Text = "Hozzáadás";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Gainsboro;
            listBox1.DataSource = productsToOrderBindingSource;
            listBox1.DisplayMember = "Phrase";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(31, 148);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 404);
            listBox1.TabIndex = 1;
            listBox1.ValueMember = "id";
            // 
            // productsToOrderBindingSource
            // 
            productsToOrderBindingSource.DataSource = typeof(Models.ProductsToOrder);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(36, 105);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 2;
            label1.Text = "Megrendelendő termékek:";
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.arrow;
            button2.Location = new Point(399, 285);
            button2.Name = "button2";
            button2.Size = new Size(120, 120);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dataGridView1.DataSource = orderedProductsBindingSource;
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(570, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 404);
            dataGridView1.TabIndex = 4;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.Visible = false;
            orderIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderedProductsBindingSource
            // 
            orderedProductsBindingSource.DataSource = typeof(Models.OrderedProducts);
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.ForeColor = Color.White;
            button3.Location = new Point(966, 285);
            button3.Name = "button3";
            button3.Size = new Size(166, 120);
            button3.TabIndex = 5;
            button3.Text = "Raktárra vétel";
            button3.UseVisualStyleBackColor = false;
            //button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(36, 45);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 6;
            label2.Text = "Keresési előzmények:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(570, 105);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 7;
            label3.Text = "Megrendelt termékek:";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = hccSearchQueryBindingSource;
            comboBox1.DisplayMember = "QueryPhrase";
            comboBox1.DropDownHeight = 300;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(229, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(392, 33);
            comboBox1.TabIndex = 0;
            comboBox1.ValueMember = "Bvin";
            // 
            // hccSearchQueryBindingSource
            // 
            hccSearchQueryBindingSource.DataSource = typeof(Models.HccSearchQuery);
            hccSearchQueryBindingSource.CurrentChanged += hccSearchQueryBindingSource_CurrentChanged;
            // 
            // OrderManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 564);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrderManager";
            Text = "Order Manager";
            FormClosing += OrderManager_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)productsToOrderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderedProductsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hccSearchQueryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private BindingSource hccSearchQueryBindingSource;
        private BindingSource productsToOrderBindingSource;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private BindingSource orderedProductsBindingSource;
    }
}
