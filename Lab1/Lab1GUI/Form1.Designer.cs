
namespace Lab1GUI
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
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            results = new TextBox();
            instance = new TextBox();
            runButton = new Button();
            vlabel1 = new Label();
            vlabel2 = new Label();
            vlabel3 = new Label();
            result = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 36);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "number of items";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.Validating += textBox1_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "seed";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.Validating += textBox2_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 142);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "capacity";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Validating += textBox3_Validating;
            // 
            // results
            // 
            results.Location = new Point(44, 276);
            results.Multiline = true;
            results.Name = "results";
            results.ReadOnly = true;
            results.ScrollBars = ScrollBars.Vertical;
            results.Size = new Size(341, 162);
            results.TabIndex = 6;
            // 
            // instance
            // 
            instance.Location = new Point(391, 36);
            instance.Multiline = true;
            instance.Name = "instance";
            instance.ReadOnly = true;
            instance.ScrollBars = ScrollBars.Vertical;
            instance.Size = new Size(397, 402);
            instance.TabIndex = 7;
            // 
            // runButton
            // 
            runButton.Location = new Point(44, 221);
            runButton.Name = "runButton";
            runButton.Size = new Size(125, 29);
            runButton.TabIndex = 8;
            runButton.Text = "run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += button1_Click;
            // 
            // vlabel1
            // 
            vlabel1.AutoSize = true;
            vlabel1.ForeColor = Color.Red;
            vlabel1.Location = new Point(175, 62);
            vlabel1.Name = "vlabel1";
            vlabel1.Size = new Size(50, 20);
            vlabel1.TabIndex = 9;
            vlabel1.Text = "label4";
            vlabel1.Visible = false;
            // 
            // vlabel2
            // 
            vlabel2.AutoSize = true;
            vlabel2.ForeColor = Color.Red;
            vlabel2.Location = new Point(175, 115);
            vlabel2.Name = "vlabel2";
            vlabel2.Size = new Size(50, 20);
            vlabel2.TabIndex = 10;
            vlabel2.Text = "label5";
            vlabel2.Visible = false;
            // 
            // vlabel3
            // 
            vlabel3.AutoSize = true;
            vlabel3.ForeColor = Color.Red;
            vlabel3.Location = new Point(175, 168);
            vlabel3.Name = "vlabel3";
            vlabel3.Size = new Size(50, 20);
            vlabel3.TabIndex = 11;
            vlabel3.Text = "label6";
            vlabel3.Visible = false;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(335, 253);
            result.Name = "result";
            result.Size = new Size(51, 20);
            result.TabIndex = 12;
            result.Text = "results";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(725, 13);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 13;
            label7.Text = "instance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(result);
            Controls.Add(vlabel3);
            Controls.Add(vlabel2);
            Controls.Add(vlabel1);
            Controls.Add(runButton);
            Controls.Add(instance);
            Controls.Add(results);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox results;
        private TextBox instance;
        private Button runButton;
        private Label vlabel1;
        private Label vlabel2;
        private Label vlabel3;
        private Label result;
        private Label label7;
    }
}
