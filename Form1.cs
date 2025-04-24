namespace Calculator
{
    public partial class Calculator : Form
    {
        double resultValue = 0; // stores the intermediate or final result
        string operationPerformed = ""; // stores the current operator (+, -, *, /)
        bool isOperationPerformed = false; // indicates if an operator was just clicked (used to clear textbox)
        string expressionHistory = ""; // keeps track of the entire input expression for display
        bool isEqualPressed = false; // flag to know if '=' was just pressed (used to reset history if needed)

        public Calculator()
        {
            InitializeComponent(); // sets up all controls on the form
        }

        // Handles number and decimal button clicks
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Clear the display if it's starting fresh
            if (NameBox_result.Text == "0" || isOperationPerformed)
            {
                NameBox_result.Clear();
            }

            isOperationPerformed = false;

            // Handle decimal point input
            if (button.Text == ".")
            {
                if (!NameBox_result.Text.Contains("."))
                {
                    NameBox_result.Text += button.Text;
                }
            }
            else // Append number to the textbox
            {
                NameBox_result.Text += button.Text;
            }
        }

        // Handles operator (+, -, *, /) button click
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Reset history if '=' was pressed before
            if (isEqualPressed)
            {
                expressionHistory = NameBox_result.Text + " " + button.Text + " ";
                isEqualPressed = false;
            }
            else
            {
                expressionHistory += NameBox_result.Text + " " + button.Text + " ";
            }

            resultValue = double.Parse(NameBox_result.Text);
            operationPerformed = button.Text;
            isOperationPerformed = true;

            labelCurrentOperation.Text = expressionHistory; // update live expression
        }

        // Handles "=" button click, performs the actual calculation
        private void Equal_operator(object sender, EventArgs e)
        {
            double currentValue = double.Parse(NameBox_result.Text);
            double finalResult = 0;

            switch (operationPerformed)
            {
                case "+":
                    finalResult = resultValue + currentValue;
                    break;
                case "-":
                    finalResult = resultValue - currentValue;
                    break;
                case "*":
                    finalResult = resultValue * currentValue;
                    break;
                case "/":
                    if (currentValue != 0)
                    {
                        finalResult = resultValue / currentValue;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    break;
            }

            // Complete the expression with result
            expressionHistory += NameBox_result.Text + " = " + finalResult;
            labelCurrentOperation.Text = expressionHistory;

            NameBox_result.Text = finalResult.ToString(); // update result on screen

            resultValue = finalResult;
            operationPerformed = "";
            expressionHistory = ""; // reset for next expression
            isEqualPressed = true;  // flag to start new expression if operator pressed next
        }

        // Clears only the current textbox value
        private void CE_Click(object sender, EventArgs e)
        {
            NameBox_result.Text = "0";
        }

        // Clears everything: result, history, and display
        private void ClearEntry_Click(object sender, EventArgs e)
        {
            NameBox_result.Text = "0";
            resultValue = 0;
            expressionHistory = "";
            labelCurrentOperation.Text = "";
        }

        // Optional: run logic when form loads
        private void Calculator_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Calculator");
        }
    }
}
