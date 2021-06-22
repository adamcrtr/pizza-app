using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 helpform = new Form2();//new form
        private void mnuhelp_Click(object sender, EventArgs e)
        {
            helpform.Show(); //show form when clicked
        }

        private void btnExit_Click(object sender, EventArgs e) 
        {
            Application.Exit(); //exits application
        }
        private string Gettinginfo(string name, string address, string delnotes) //Method used for getting the users information.
        {
            string answer;

            answer = "Name: " + name  + "\n" + "Address: " + address + "\n" + "Delivery Notes: " + delnotes; //gets the various strings and putts them together.
            

            return answer;
        }
        private double VATMethod(double total) //VAT method used to calculate VAT
        {
            double answer;

            answer = (total * 20 / 100); //vat calulation
            

            return answer;
            
        }
        private double VATandTotalMethod(double total, double VAT) //method used to calculatae VATandTotal
        {
            double VATandTotalANSWER;

            VATandTotalANSWER = (total + VAT); //total and vat calculation

            return VATandTotalANSWER;


        }
        private void btnShowBill_Click(object sender, EventArgs e)
        {

            double size = 0; //variables used for the program
            double Quantity = 0;
            double QuantyandSize = 0;
            double total = 0;
            double topping = 0;
            double VAT = 0;
            double VATandTotal = 0;
            

            lblSummary.Text = "";
            switch (lstPizzaSize.SelectedIndex) //switch for pizza size selection.
            {
                case 0:
                    size = 3.00; //value for large pizza 
                    lblSummary.Text = lblSummary.Text + ("Large Pizza \n"); //when case is selected adds text to summary
                    break;
                case 1:
                    size = 2.50; //value for medium pizza
                    lblSummary.Text = lblSummary.Text + ("Medium Pizza \n");
                    break;
                case 2:
                    size = 2.00; //value for small pizza
                    lblSummary.Text = lblSummary.Text + ("Small Pizza \n");
                    break;
                default:
                    MessageBox.Show("You have not selected a size"); //messagbox if no pizza size is selected
                    break;
            }
            if (double.TryParse(txtQuantity.Text, out Quantity)) //if statement for quantity 
            {
                QuantyandSize = size * Quantity; //quantity and size calculation
                total = +QuantyandSize; //creating total of quantity and size
                lblTotal.Text = QuantyandSize.ToString("C2"); //converts variable to string outputs to label
            }
            else
            {
                MessageBox.Show("Please Enter Quantity"); //message box if quantity isnt entered. 
            }
            if (chkBeef.Checked == true) //if certain check box is ticked
            {
                lblSummary.Text = lblSummary.Text + "Topping: Beef \n";//adds topping to summary list
                topping = Quantity * .30 + topping; //topping calculation
                total = topping + QuantyandSize; //adds topping to total           
                lblTotal.Text = total.ToString("C2"); //converts new total to string outputs in label
                
            }
            if (chkCheese.Checked == true) //if certain check box is ticked
            {
                lblSummary.Text = lblSummary.Text + ("Topping: Cheese \n");//adds topping to summary list
                topping = Quantity * .20 + topping;//topping calculation
                total = topping + QuantyandSize;//total clculation adding topping
                lblTotal.Text = total.ToString("C2");//converts new total to string outputs in label
            }
            if (chkChicken.Checked == true) //if certain check box is ticked
            {
                lblSummary.Text = lblSummary.Text + ("Topping: Chicken \n");//adds topping to summary list
                topping = Quantity * .40 + topping;//topping calculation
                total = topping + QuantyandSize;//total clculation adding topping
                lblTotal.Text = total.ToString("C2");//converts new total to string outputs in label

            }
            if (chkHam.Checked == true) //if certain check box is ticked
            {
                lblSummary.Text = lblSummary.Text + ("Topping: Ham \n");//adds topping to summary list
                topping = Quantity * .45 + topping;//topping calculation
                total = topping + QuantyandSize;//total clculation adding topping
                lblTotal.Text = total.ToString("C2");//converts new total to string outputs in label
            }
            if (chkMushroom.Checked == true) //if certain check box is ticked
            {
                lblSummary.Text = lblSummary.Text + ("Topping: Mushroom \n");//adds topping to summary list
                topping = Quantity * .35 + topping;//topping calculation
                total = topping + QuantyandSize;//total clculation adding topping
                lblTotal.Text = total.ToString("C2");//converts new total to string outputs in label
            }
            if (chkPeperoni.Checked == true) //if certain check box is ticked
            {
                lblSummary.Text = lblSummary.Text + ("Topping: Peperoni \n");//adds topping to summary list
                topping = Quantity * .50 + topping;//topping calculation
                total = topping + QuantyandSize;//total clculation adding topping
                lblTotal.Text = total.ToString("C2");//converts new total to string outputs in label
            }
            if (chkSpicyChicken.Checked == true) //if certain check box is ticked
            {
                lblSummary.Text = lblSummary.Text + ("Topping: Spicy Chicken \n");//adds topping to summary list
                topping = Quantity * .50 + topping;//topping calculation
                total = topping + QuantyandSize;//total clculation adding topping
                lblTotal.Text = total.ToString("C2");//converts new total to string outputs in label
            }
            if (chkSweetCorn.Checked == true) //if certain check box is ticked
            {
                lblSummary.Text = lblSummary.Text + ("Topping: Sweetcorn  \n"); //adds topping to summary list
                topping = Quantity * .25 + topping;//topping calculation
                total = topping + QuantyandSize; //total clculation adding topping
                lblTotal.Text = total.ToString("C2");//converts new total to string outputs in label
            }
            if (chkDelivery.Checked == true) //if delivery check box is ticked
            {
                lblSummary.Text = lblSummary.Text + ("Delivery \n");//adds delivery to summary
                total = topping + QuantyandSize + 2;//delivery calculation
                lblTotal.Text = total.ToString("C2");//converts total to string outputs in total field 

            }
            

            VAT = VATMethod(total); //Method for VAT
            lblVAT.Text = VAT.ToString("C2"); //once value returned from method outputs to label

            VATandTotal = VATandTotalMethod(total, VAT); //Method for VAT and Total
            lblVATandTotal.Text = VATandTotal.ToString("C2"); //once value returned from method outputs to label


            

        }

        private void btnOrdering_Click(object sender, EventArgs e)
        {
            string name; //string variables for text boxes 
            string address; //variables
            string delnotes; //variables
            string returnvalue; //variables
            if (txtAddress.Text == "") //if text box address is equal to nothing show message box 
            {
                MessageBox.Show("You need to enter a delivery address"); //display message if address field is nothing

            }
            else //else if text box has an address
            {
                name = txtName.Text; //variables for text boxes used in method.
                address = txtAddress.Text;
                delnotes = txtDelNotes.Text;

                returnvalue = Gettinginfo(name , address, delnotes); //return value from method

                MessageBox.Show("Your delivery details: \n" + returnvalue.ToString()); //converts return method to string adds to message box

            }
            

        }

        private void btnClear_Click(object sender, EventArgs e) //clears all fields so user can start again
        {
            lblTotal.Text = ""; //"" represents nothing inside the box meaning clears it
            lblVAT.Text = "";
            lblVATandTotal.Text = "";
            lblSummary.Text = "";
            lblOrderConfirmed.Text = "";
            txtQuantity.Text = "";
            chkBeef.Checked = false; //clears the checked box so user can re check what they want
            chkCheese.Checked = false;
            chkChicken.Checked = false;
            chkDelivery.Checked = false;
            chkHam.Checked = false;
            chkMushroom.Checked = false;
            chkPeperoni.Checked = false;
            chkSpicyChicken.Checked = false;
            chkSweetCorn.Checked = false;
            txtAddress.Text = "";
            txtDelNotes.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            
        }

        
    }
}
