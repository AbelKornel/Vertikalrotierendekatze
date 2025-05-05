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
            button1 = new Button();
            listBox1 = new ListBox();
            productsToOrderBindingSource = new BindingSource(components);
            label1 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            hccSearchQueryBindingSource = new BindingSource(components);
            orderedProductsBindingSource = new BindingSource(components);
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)productsToOrderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hccSearchQueryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderedProductsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(632, 38);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Hozzáadás";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
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
            label1.Location = new Point(36, 105);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 2;
            label1.Text = "Megrendelendő termékek:";
            // 
            // button2
            // 
            button2.Location = new Point(401, 282);
            button2.Name = "button2";
            button2.Size = new Size(103, 97);
            button2.TabIndex = 3;
            button2.Text = "-->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dataGridView1.DataSource = orderedProductsBindingSource;
            dataGridView1.Location = new Point(570, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 404);
            dataGridView1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(973, 285);
            button3.Name = "button3";
            button3.Size = new Size(166, 90);
            button3.TabIndex = 5;
            button3.Text = "Raktárra vétel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 38);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 6;
            label2.Text = "Keresési előzmények:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 105);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 7;
            label3.Text = "Megrendelt termékek:";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = hccSearchQueryBindingSource;
            comboBox1.DisplayMember = "QueryPhrase";
            comboBox1.DropDownHeight = 300;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(220, 40);
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
            // orderedProductsBindingSource
            // 
            orderedProductsBindingSource.DataSource = typeof(Models.OrderedProducts);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)productsToOrderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hccSearchQueryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderedProductsBindingSource).EndInit();
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
