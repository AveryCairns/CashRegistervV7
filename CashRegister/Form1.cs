using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

// Cash Register by: Avery, Oct 13, 2017

namespace CashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Constant declaring
        const double BURGER_COST = 2.49;
        const double FRIES_COST = 1.89;
        const double DRINK_COST = 0.99;
        const double TAX = 0.13;

        // Variables declaring
        int burgers;
        int fries;
        int drinks;
        double subTotal;
        double taxTotal;
        double totalTotal;
        double tenderedTotal;
        double changeTotal;

        // Graphics set up
        Graphics recieptGraphics;

        // Calculate Totals
        private void totalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                burgers = Convert.ToInt16(burgerInput.Text);
            }
            catch
            {
                burgerInput.Text = "0";
            }
            try
            {
                fries = Convert.ToInt16(friesInput.Text);
            }
            catch
            {
                friesInput.Text = "0";
            }
            try
            {
                drinks = Convert.ToInt16(drinksInput.Text);
            }
            catch
            {
                drinksInput.Text = "0";
            }

            subTotal = (burgers * BURGER_COST) + (fries * FRIES_COST) + (drinks * DRINK_COST);
            taxTotal = subTotal * TAX;
            totalTotal = subTotal + taxTotal;
            subtotalMoneyLabel.Text = subTotal.ToString("0.00");
            taxMoneyLabel.Text = taxTotal.ToString("0.00");
            totalMoneyLabel.Text = totalTotal.ToString("0.00");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tenderedTotal = Convert.ToDouble(tenderedInput.Text);
            }
            catch
            {
                tenderedInput.Text = "Insert Number";
            }
            changeTotal = tenderedTotal - totalTotal;
            changeMoneyLabel.Text = changeTotal.ToString("0.00");
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.register);
            player.Play();
            Thread.Sleep(1000);

            // Graphics set up and reciept writing
            recieptGraphics = CreateGraphics();
            Pen borderPen = new Pen(Color.Black, 1);
            SolidBrush textBrush = new SolidBrush(Color.Black);
            Font recieptFont = new Font("Consolas", 9, FontStyle.Regular);

            recieptGraphics.DrawRectangle(borderPen, 183, 50, 158, 270);
            recieptGraphics.DrawString("Casually Burger", recieptFont, textBrush, 210, 60);
            recieptGraphics.DrawString("Order Number 1013", recieptFont, textBrush, 190, 75);
            recieptGraphics.DrawString("October 16, 2017", recieptFont, textBrush, 190, 90);
            recieptGraphics.DrawString("Hamburgers x" + burgers + " @ " + BURGER_COST, recieptFont, textBrush, 190, 120);
            recieptGraphics.DrawString("Fries      x" + fries + " @ " + FRIES_COST, recieptFont, textBrush, 190, 135);
            recieptGraphics.DrawString("Drinks     x" + drinks + " @ " + DRINK_COST, recieptFont, textBrush, 190, 150);
            recieptGraphics.DrawString("Subtotal   $" + subTotal.ToString("0.00"), recieptFont, textBrush, 190, 180);
            recieptGraphics.DrawString("Tax        $" + taxTotal.ToString("0.00"), recieptFont, textBrush, 190, 195);
            recieptGraphics.DrawString("Total      $" + totalTotal.ToString("0.00"), recieptFont, textBrush, 190, 210);
            recieptGraphics.DrawString("Tendered   $" + tenderedTotal.ToString("0.00"), recieptFont, textBrush, 190, 240);
            recieptGraphics.DrawString("Change     $" + changeTotal.ToString("0.00"), recieptFont, textBrush, 190, 255);
            recieptGraphics.DrawString("Have a nice day!", recieptFont, textBrush, 190, 270);
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            recieptGraphics.Clear(Color.WhiteSmoke);
            subtotalMoneyLabel.Text = "";
            taxMoneyLabel.Text = "";
            totalMoneyLabel.Text = "";
            burgerInput.Text = "";
            friesInput.Text = "";
            drinksInput.Text = "";
            tenderedInput.Text = "";
            changeMoneyLabel.Text = "";
        }
    }
}
