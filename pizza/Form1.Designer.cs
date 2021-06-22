namespace pizza
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
            this.btnShowBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.mnubar = new System.Windows.Forms.MenuStrip();
            this.mnuhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPeperoni = new System.Windows.Forms.CheckBox();
            this.chkSpicyChicken = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkSweetCorn = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkBeef = new System.Windows.Forms.CheckBox();
            this.lstPizzaSize = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDelNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblborder1 = new System.Windows.Forms.Label();
            this.lblVATandTotal = new System.Windows.Forms.Label();
            this.btnOrdering = new System.Windows.Forms.Button();
            this.lblOrderConfirmed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mnubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowBill
            // 
            this.btnShowBill.Location = new System.Drawing.Point(142, 654);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(76, 47);
            this.btnShowBill.TabIndex = 0;
            this.btnShowBill.Text = "Show Bill";
            this.btnShowBill.UseVisualStyleBackColor = true;
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Superior Mario Pizza Order Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slect Size";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(485, 116);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(24, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // mnubar
            // 
            this.mnubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mnubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhelp});
            this.mnubar.Location = new System.Drawing.Point(0, 0);
            this.mnubar.Name = "mnubar";
            this.mnubar.Size = new System.Drawing.Size(731, 24);
            this.mnubar.TabIndex = 5;
            this.mnubar.Text = "menuStrip1";
            // 
            // mnuhelp
            // 
            this.mnuhelp.Name = "mnuhelp";
            this.mnuhelp.Size = new System.Drawing.Size(44, 20);
            this.mnuhelp.Text = "Help";
            this.mnuhelp.Click += new System.EventHandler(this.mnuhelp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order Summary";
            // 
            // chkPeperoni
            // 
            this.chkPeperoni.AutoSize = true;
            this.chkPeperoni.Location = new System.Drawing.Point(126, 166);
            this.chkPeperoni.Name = "chkPeperoni";
            this.chkPeperoni.Size = new System.Drawing.Size(92, 17);
            this.chkPeperoni.TabIndex = 2;
            this.chkPeperoni.Text = "Peporoni .50p";
            this.chkPeperoni.UseVisualStyleBackColor = true;
            // 
            // chkSpicyChicken
            // 
            this.chkSpicyChicken.AutoSize = true;
            this.chkSpicyChicken.Location = new System.Drawing.Point(126, 207);
            this.chkSpicyChicken.Name = "chkSpicyChicken";
            this.chkSpicyChicken.Size = new System.Drawing.Size(118, 17);
            this.chkSpicyChicken.TabIndex = 2;
            this.chkSpicyChicken.Text = "Spicy Chicken .50p";
            this.chkSpicyChicken.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(252, 166);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(72, 17);
            this.chkHam.TabIndex = 2;
            this.chkHam.Text = "Ham .45p";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkSweetCorn
            // 
            this.chkSweetCorn.AutoSize = true;
            this.chkSweetCorn.Location = new System.Drawing.Point(252, 207);
            this.chkSweetCorn.Name = "chkSweetCorn";
            this.chkSweetCorn.Size = new System.Drawing.Size(101, 17);
            this.chkSweetCorn.TabIndex = 2;
            this.chkSweetCorn.Text = "Sweetcorn .25p";
            this.chkSweetCorn.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(355, 166);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(89, 17);
            this.chkChicken.TabIndex = 2;
            this.chkChicken.Text = "Chicken .40p";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(355, 207);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(99, 17);
            this.chkMushroom.TabIndex = 2;
            this.chkMushroom.Text = "Mushroom .35p";
            this.chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkBeef
            // 
            this.chkBeef.AutoSize = true;
            this.chkBeef.Location = new System.Drawing.Point(471, 166);
            this.chkBeef.Name = "chkBeef";
            this.chkBeef.Size = new System.Drawing.Size(72, 17);
            this.chkBeef.TabIndex = 2;
            this.chkBeef.Text = "Beef .30p";
            this.chkBeef.UseVisualStyleBackColor = true;
            // 
            // lstPizzaSize
            // 
            this.lstPizzaSize.FormattingEnabled = true;
            this.lstPizzaSize.Items.AddRange(new object[] {
            "Large £3.00",
            "Medium £2.50",
            "Small £2.00"});
            this.lstPizzaSize.Location = new System.Drawing.Point(277, 103);
            this.lstPizzaSize.Name = "lstPizzaSize";
            this.lstPizzaSize.Size = new System.Drawing.Size(123, 43);
            this.lstPizzaSize.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 654);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 47);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(444, 654);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 47);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 412);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 20);
            this.txtName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(205, 447);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 87);
            this.txtAddress.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Address";
            // 
            // txtDelNotes
            // 
            this.txtDelNotes.Location = new System.Drawing.Point(205, 550);
            this.txtDelNotes.Multiline = true;
            this.txtDelNotes.Name = "txtDelNotes";
            this.txtDelNotes.Size = new System.Drawing.Size(205, 87);
            this.txtDelNotes.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Delivery notes";
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(471, 207);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(86, 17);
            this.chkCheese.TabIndex = 10;
            this.chkCheese.Text = "Cheese .20p";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Location = new System.Drawing.Point(252, 247);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(122, 17);
            this.chkDelivery.TabIndex = 10;
            this.chkDelivery.Text = "Request Delivery £2";
            this.chkDelivery.UseVisualStyleBackColor = true;
            // 
            // lblSummary
            // 
            this.lblSummary.BackColor = System.Drawing.Color.White;
            this.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSummary.Location = new System.Drawing.Point(200, 284);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(208, 113);
            this.lblSummary.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(542, 287);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(153, 33);
            this.lblTotal.TabIndex = 11;
            // 
            // lblVAT
            // 
            this.lblVAT.BackColor = System.Drawing.Color.White;
            this.lblVAT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVAT.Location = new System.Drawing.Point(542, 342);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(153, 33);
            this.lblVAT.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(0, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(731, 2);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(0, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(731, 2);
            this.label9.TabIndex = 12;
            // 
            // lblborder1
            // 
            this.lblborder1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblborder1.Location = new System.Drawing.Point(0, 640);
            this.lblborder1.Name = "lblborder1";
            this.lblborder1.Size = new System.Drawing.Size(731, 2);
            this.lblborder1.TabIndex = 12;
            // 
            // lblVATandTotal
            // 
            this.lblVATandTotal.BackColor = System.Drawing.Color.White;
            this.lblVATandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVATandTotal.Location = new System.Drawing.Point(542, 402);
            this.lblVATandTotal.Name = "lblVATandTotal";
            this.lblVATandTotal.Size = new System.Drawing.Size(153, 33);
            this.lblVATandTotal.TabIndex = 11;
            // 
            // btnOrdering
            // 
            this.btnOrdering.Location = new System.Drawing.Point(291, 709);
            this.btnOrdering.Name = "btnOrdering";
            this.btnOrdering.Size = new System.Drawing.Size(75, 47);
            this.btnOrdering.TabIndex = 13;
            this.btnOrdering.Text = "Order";
            this.btnOrdering.UseVisualStyleBackColor = true;
            this.btnOrdering.Click += new System.EventHandler(this.btnOrdering_Click);
            // 
            // lblOrderConfirmed
            // 
            this.lblOrderConfirmed.AutoSize = true;
            this.lblOrderConfirmed.Location = new System.Drawing.Point(464, 468);
            this.lblOrderConfirmed.Name = "lblOrderConfirmed";
            this.lblOrderConfirmed.Size = new System.Drawing.Size(0, 13);
            this.lblOrderConfirmed.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(0, 704);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(731, 2);
            this.label10.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(492, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "VAT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(472, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Final Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 768);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblOrderConfirmed);
            this.Controls.Add(this.btnOrdering);
            this.Controls.Add(this.lblborder1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVATandTotal);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.chkDelivery);
            this.Controls.Add(this.chkCheese);
            this.Controls.Add(this.txtDelNotes);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPizzaSize);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkBeef);
            this.Controls.Add(this.chkMushroom);
            this.Controls.Add(this.chkChicken);
            this.Controls.Add(this.chkSweetCorn);
            this.Controls.Add(this.chkHam);
            this.Controls.Add(this.chkSpicyChicken);
            this.Controls.Add(this.chkPeperoni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowBill);
            this.Controls.Add(this.mnubar);
            this.MainMenuStrip = this.mnubar;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnubar.ResumeLayout(false);
            this.mnubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.MenuStrip mnubar;
        private System.Windows.Forms.ToolStripMenuItem mnuhelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPeperoni;
        private System.Windows.Forms.CheckBox chkSpicyChicken;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkSweetCorn;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkBeef;
        private System.Windows.Forms.ListBox lstPizzaSize;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDelNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblborder1;
        private System.Windows.Forms.Label lblVATandTotal;
        private System.Windows.Forms.Button btnOrdering;
        private System.Windows.Forms.Label lblOrderConfirmed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

