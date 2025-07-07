namespace WinFormsApp2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;
        string expression = "";


        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtTotal.Text);
            option = "+";
            expression = num1 + " " + option + " ";
            txtTotal.Text = expression;
            txtTotal.SelectionStart = txtTotal.Text.Length;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtTotal.Text);
            option = "-";
            expression = num1 + " " + option + " ";
            txtTotal.Text = expression;
            txtTotal.SelectionStart = txtTotal.Text.Length;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtTotal.Text);
            option = "*";
            expression = num1 + " " + option + " ";
            txtTotal.Text = expression;
            txtTotal.SelectionStart = txtTotal.Text.Length;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtTotal.Text);
            option = "/";
            expression = num1 + " " + option + " ";
            txtTotal.Text = expression;
            txtTotal.SelectionStart = txtTotal.Text.Length;
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            try
            {
                // Extract second number from txtTotal.Text after the operator
                string[] parts = txtTotal.Text.Split(' '); 
                if (parts.Length == 3)
                {
                    num1 = int.Parse(parts[0]);
                    option = parts[1];
                    num2 = int.Parse(parts[2]);

                    switch (option)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num2 != 0 ? num1 / num2 : 0; // Avoid divide by zero
                            break;
                    }

                    txtTotal.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid expression format.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
