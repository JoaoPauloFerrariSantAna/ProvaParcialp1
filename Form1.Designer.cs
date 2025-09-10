namespace ProvaParcialP1
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 24);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 0;
            label1.Text = "Adicionar produto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 61);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Insira um nome";
            textBox1.Size = new Size(138, 25);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(421, 61);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Insira a quantidade";
            textBox2.Size = new Size(138, 25);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(328, 121);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 4;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 196);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 5;
            label2.Text = "Remover produto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(304, 253);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nome do produto";
            textBox3.Size = new Size(138, 25);
            textBox3.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(328, 323);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 7;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 414);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(0, 17);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 165);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(304, 386);
            button3.Name = "button3";
            button3.Size = new Size(138, 25);
            button3.TabIndex = 10;
            button3.Text = "Mostrar estoque";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(662, 64);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(304, 434);
            button4.Name = "button4";
            button4.Size = new Size(138, 25);
            button4.TabIndex = 12;
            button4.Text = "Esconder estoque";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private TextBox textBox3;
        private Button button2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Label label5;
        private Button button4;
    }
}
