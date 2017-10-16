namespace CashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.totalsButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalMoneyLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxMoneyLabel = new System.Windows.Forms.Label();
            this.totalMoneyLabel = new System.Windows.Forms.Label();
            this.barLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeMoneyLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casually Burger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // burgerLabel
            // 
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(12, 52);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(120, 20);
            this.burgerLabel.TabIndex = 1;
            this.burgerLabel.Text = "Number of Burgers";
            // 
            // friesLabel
            // 
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(12, 79);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(120, 19);
            this.friesLabel.TabIndex = 2;
            this.friesLabel.Text = "Number of Fries";
            // 
            // drinksLabel
            // 
            this.drinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(12, 105);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(120, 19);
            this.drinksLabel.TabIndex = 3;
            this.drinksLabel.Text = "Number of Drinks";
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(139, 52);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(37, 20);
            this.burgerInput.TabIndex = 4;
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(139, 78);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(37, 20);
            this.friesInput.TabIndex = 5;
            // 
            // drinksInput
            // 
            this.drinksInput.Location = new System.Drawing.Point(139, 104);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(37, 20);
            this.drinksInput.TabIndex = 6;
            // 
            // totalsButton
            // 
            this.totalsButton.Location = new System.Drawing.Point(15, 130);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(161, 23);
            this.totalsButton.TabIndex = 7;
            this.totalsButton.Text = "Calculate Totals";
            this.totalsButton.UseVisualStyleBackColor = true;
            this.totalsButton.Click += new System.EventHandler(this.totalsButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(12, 156);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(84, 24);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // subtotalMoneyLabel
            // 
            this.subtotalMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalMoneyLabel.Location = new System.Drawing.Point(92, 156);
            this.subtotalMoneyLabel.Name = "subtotalMoneyLabel";
            this.subtotalMoneyLabel.Size = new System.Drawing.Size(84, 24);
            this.subtotalMoneyLabel.TabIndex = 9;
            this.subtotalMoneyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(12, 180);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(84, 24);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 204);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(84, 24);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // taxMoneyLabel
            // 
            this.taxMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxMoneyLabel.Location = new System.Drawing.Point(92, 180);
            this.taxMoneyLabel.Name = "taxMoneyLabel";
            this.taxMoneyLabel.Size = new System.Drawing.Size(84, 24);
            this.taxMoneyLabel.TabIndex = 12;
            this.taxMoneyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalMoneyLabel
            // 
            this.totalMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMoneyLabel.Location = new System.Drawing.Point(92, 204);
            this.totalMoneyLabel.Name = "totalMoneyLabel";
            this.totalMoneyLabel.Size = new System.Drawing.Size(84, 24);
            this.totalMoneyLabel.TabIndex = 13;
            this.totalMoneyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // barLabel
            // 
            this.barLabel.BackColor = System.Drawing.Color.Black;
            this.barLabel.Location = new System.Drawing.Point(15, 228);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(161, 17);
            this.barLabel.TabIndex = 14;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(12, 249);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(84, 24);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(102, 248);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(74, 20);
            this.tenderedInput.TabIndex = 16;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(15, 274);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(161, 23);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 306);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(84, 24);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change";
            // 
            // changeMoneyLabel
            // 
            this.changeMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMoneyLabel.Location = new System.Drawing.Point(92, 306);
            this.changeMoneyLabel.Name = "changeMoneyLabel";
            this.changeMoneyLabel.Size = new System.Drawing.Size(84, 24);
            this.changeMoneyLabel.TabIndex = 19;
            this.changeMoneyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(15, 333);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(161, 23);
            this.printButton.TabIndex = 20;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(182, 333);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(161, 23);
            this.newOrderButton.TabIndex = 21;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(357, 365);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeMoneyLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.totalMoneyLabel);
            this.Controls.Add(this.taxMoneyLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalMoneyLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label subtotalMoneyLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxMoneyLabel;
        private System.Windows.Forms.Label totalMoneyLabel;
        private System.Windows.Forms.Label barLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeMoneyLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button newOrderButton;
    }
}

