using System;
using System.Data; //Needed to use DataTable for evaluating expressions
namespace Calci
{
    public partial class Form1 : Form
    {
        private string currentcalculation;
        public Form1()
        {
            InitializeComponent();//Initializes the UI components (buttons, textbox, etc.) defined in the Designer file.
        }

        private void button_click(object sender, EventArgs e)
        {
            //Appends the clicked button’s text to the expression(currentcalculation)
            //and updates textBox1.
            currentcalculation += (sender as Button).Text; //– Holds the current math expression as a string 
            textBox1.Text = currentcalculation;
        }

        // Equal = Button Handler

        private void button_equals_click(object sender, EventArgs e)
        {
            String formatedtext = currentcalculation;
            try
            {
                //Evaluates the expression using DataTable().Compute().
                textBox1.Text = new DataTable().Compute(formatedtext, null).ToString();
                currentcalculation = textBox1.Text;
            }
            catch (Exception ex)
            {
                textBox1.Text = "ERROR";
                currentcalculation = "";
            }
        }
        //Clears everything and resets the display.
        private void button_clear_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            currentcalculation = "";
        }

        //Deletes the last entered character from the current expression. Like a backspace.
        private void button_clearentery_click(object sender, EventArgs e)
        {
            if (currentcalculation.Length > 0)
            {
                //remove from back so len-1 by 1 digit
                //eg remove recent entered nuum 12348 wanted to remove 8
                currentcalculation = currentcalculation.Remove(currentcalculation.Length - 1, 1);

            }
            textBox1.Text = currentcalculation;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
