namespace KliensApp
{
    partial class Ordering
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordering));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Location = new Point(52, 277);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Brown;
            button2.CausesValidation = false;
            button2.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.White;
            button2.Location = new Point(260, 277);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(284, 25);
            label1.TabIndex = 2;
            label1.Text = "Megrendelt termék megnevezése:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(30, 154);
            label2.Name = "label2";
            label2.Size = new Size(200, 25);
            label2.TabIndex = 3;
            label2.Text = "Megrendelt mennyiség:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 31);
            textBox1.TabIndex = 4;
            textBox1.Validating += textBox1_Validating;
            textBox1.Validated += textBox1_Validated;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 31);
            textBox2.TabIndex = 5;
            textBox2.Validating += textBox2_Validating;
            textBox2.Validated += textBox2_Validated;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Ordering
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(459, 344);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ordering";
            Text = "Ordering";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ErrorProvider errorProvider1;
    }
}