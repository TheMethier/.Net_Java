using Lab1;
using System.Text.RegularExpressions;

namespace Lab1GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                int numberOfItems = int.Parse(textBox1.Text);
                int seed = int.Parse(textBox2.Text);
                int capacity = int.Parse(textBox3.Text);
                Problem problem = new Problem(seed, numberOfItems);
                Result result = problem.Solve(capacity);
                results.Text = result.ToString();
                instance.Text = problem.ToString();
            }


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                vlabel1.Visible = true;
                vlabel1.Text = "Field is empty";
            }
            else if (!Regex.IsMatch(textBox1.Text, "^[0-9]+"))
            {
                e.Cancel = true;
                vlabel1.Visible = true;
                vlabel1.Text = "Input must be number";
            }
            else
            {
                e.Cancel = false;
                vlabel1.Visible = false;
            }
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text)|| textBox2.Text=="")
            {
                e.Cancel = true;
                vlabel2.Visible = true;
                vlabel2.Text = "Field is empty";
            }
            else if (!Regex.IsMatch(textBox2.Text, "^[0-9]+"))
            {
                e.Cancel = true;
                vlabel2.Visible = true;
                vlabel2.Text = "Input must be number";
            }
            else
            {
                vlabel2.Visible = false;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                vlabel3.Visible = true;
                vlabel3.Text = "Field is empty";
            }
            else if (!Regex.IsMatch(textBox3.Text, "^[0-9]+"))
            {
                e.Cancel = true;
                vlabel3.Visible = true;
                vlabel3.Text = "Input must be number";
            }
            else
            {
                vlabel3.Visible = false;
            }
        }

 
    }
}
