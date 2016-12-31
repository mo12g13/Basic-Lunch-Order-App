namespace Lunch_Order
{
    partial class frmLunchOrderForm
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
            this.grpBoxText = new System.Windows.Forms.GroupBox();
            this.chkadd_On_OnOne = new System.Windows.Forms.CheckBox();
            this.chkAdd_On_Three = new System.Windows.Forms.CheckBox();
            this.chkadd_On_Two = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSalad = new System.Windows.Forms.CheckBox();
            this.chkPizza = new System.Windows.Forms.CheckBox();
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOrToal = new System.Windows.Forms.Label();
            this.lbltX = new System.Windows.Forms.Label();
            this.lblSubTo = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.lboxOrderSummary = new System.Windows.Forms.ListBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnTexFont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxText.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxText
            // 
            this.grpBoxText.Controls.Add(this.chkadd_On_OnOne);
            this.grpBoxText.Controls.Add(this.chkAdd_On_Three);
            this.grpBoxText.Controls.Add(this.chkadd_On_Two);
            this.grpBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpBoxText.Location = new System.Drawing.Point(193, 42);
            this.grpBoxText.Name = "grpBoxText";
            this.grpBoxText.Size = new System.Drawing.Size(231, 114);
            this.grpBoxText.TabIndex = 4;
            this.grpBoxText.TabStop = false;
            // 
            // chkadd_On_OnOne
            // 
            this.chkadd_On_OnOne.AutoSize = true;
            this.chkadd_On_OnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkadd_On_OnOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkadd_On_OnOne.Location = new System.Drawing.Point(19, 21);
            this.chkadd_On_OnOne.Name = "chkadd_On_OnOne";
            this.chkadd_On_OnOne.Size = new System.Drawing.Size(15, 14);
            this.chkadd_On_OnOne.TabIndex = 0;
            this.chkadd_On_OnOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkadd_On_OnOne.UseVisualStyleBackColor = true;
            this.chkadd_On_OnOne.Visible = false;
            this.chkadd_On_OnOne.Click += new System.EventHandler(this.addOnItems);
            // 
            // chkAdd_On_Three
            // 
            this.chkAdd_On_Three.AutoSize = true;
            this.chkAdd_On_Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdd_On_Three.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAdd_On_Three.Location = new System.Drawing.Point(19, 76);
            this.chkAdd_On_Three.Name = "chkAdd_On_Three";
            this.chkAdd_On_Three.Size = new System.Drawing.Size(15, 14);
            this.chkAdd_On_Three.TabIndex = 6;
            this.chkAdd_On_Three.UseVisualStyleBackColor = true;
            this.chkAdd_On_Three.Visible = false;
            this.chkAdd_On_Three.Click += new System.EventHandler(this.addOnItems);
            // 
            // chkadd_On_Two
            // 
            this.chkadd_On_Two.AutoSize = true;
            this.chkadd_On_Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkadd_On_Two.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkadd_On_Two.Location = new System.Drawing.Point(19, 50);
            this.chkadd_On_Two.Name = "chkadd_On_Two";
            this.chkadd_On_Two.Size = new System.Drawing.Size(15, 14);
            this.chkadd_On_Two.TabIndex = 5;
            this.chkadd_On_Two.Tag = "";
            this.chkadd_On_Two.UseVisualStyleBackColor = true;
            this.chkadd_On_Two.Visible = false;
            this.chkadd_On_Two.Click += new System.EventHandler(this.addOnItems);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSalad);
            this.groupBox1.Controls.Add(this.chkPizza);
            this.groupBox1.Controls.Add(this.chkHamburger);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Course";
            // 
            // chkSalad
            // 
            this.chkSalad.AutoSize = true;
            this.chkSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalad.Location = new System.Drawing.Point(13, 78);
            this.chkSalad.Name = "chkSalad";
            this.chkSalad.Size = new System.Drawing.Size(109, 22);
            this.chkSalad.TabIndex = 2;
            this.chkSalad.Text = "Salad -$4.95";
            this.chkSalad.UseVisualStyleBackColor = true;
            this.chkSalad.Click += new System.EventHandler(this.itemSelected);
            // 
            // chkPizza
            // 
            this.chkPizza.AutoSize = true;
            this.chkPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPizza.Location = new System.Drawing.Point(13, 45);
            this.chkPizza.Name = "chkPizza";
            this.chkPizza.Size = new System.Drawing.Size(109, 22);
            this.chkPizza.TabIndex = 1;
            this.chkPizza.Text = "Pizza -$5.95";
            this.chkPizza.UseVisualStyleBackColor = true;
            this.chkPizza.Click += new System.EventHandler(this.itemSelected);
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHamburger.Location = new System.Drawing.Point(13, 19);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(146, 22);
            this.chkHamburger.TabIndex = 0;
            this.chkHamburger.Text = "Hamburger -$6.95";
            this.chkHamburger.UseVisualStyleBackColor = true;
            this.chkHamburger.Click += new System.EventHandler(this.itemSelected);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(299, 174);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 27);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Place Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.placeOrder_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.Location = new System.Drawing.Point(120, 16);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(100, 23);
            this.lblSubTotal.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOrToal);
            this.groupBox2.Controls.Add(this.lbltX);
            this.groupBox2.Controls.Add(this.lblSubTo);
            this.groupBox2.Controls.Add(this.lblOrderTotal);
            this.groupBox2.Controls.Add(this.lblTax);
            this.groupBox2.Controls.Add(this.lblSubTotal);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 120);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Total";
            // 
            // lblOrToal
            // 
            this.lblOrToal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrToal.Location = new System.Drawing.Point(34, 71);
            this.lblOrToal.Name = "lblOrToal";
            this.lblOrToal.Size = new System.Drawing.Size(80, 23);
            this.lblOrToal.TabIndex = 10;
            this.lblOrToal.Text = "Order Total:";
            // 
            // lbltX
            // 
            this.lbltX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltX.Location = new System.Drawing.Point(36, 48);
            this.lbltX.Name = "lbltX";
            this.lbltX.Size = new System.Drawing.Size(78, 23);
            this.lbltX.TabIndex = 10;
            this.lbltX.Text = "Tax(7.75%):";
            // 
            // lblSubTo
            // 
            this.lblSubTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTo.Location = new System.Drawing.Point(47, 16);
            this.lblSubTo.Name = "lblSubTo";
            this.lblSubTo.Size = new System.Drawing.Size(67, 23);
            this.lblSubTo.TabIndex = 10;
            this.lblSubTo.Text = "SubTotal:";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(120, 70);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(100, 23);
            this.lblOrderTotal.TabIndex = 9;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(120, 43);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(100, 23);
            this.lblTax.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(299, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.Location = new System.Drawing.Point(299, 210);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(111, 27);
            this.btnClearOrder.TabIndex = 4;
            this.btnClearOrder.Text = "New Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.newOrders_Click);
            // 
            // lboxOrderSummary
            // 
            this.lboxOrderSummary.FormattingEnabled = true;
            this.lboxOrderSummary.Location = new System.Drawing.Point(450, 46);
            this.lboxOrderSummary.Name = "lboxOrderSummary";
            this.lboxOrderSummary.Size = new System.Drawing.Size(188, 238);
            this.lboxOrderSummary.TabIndex = 6;
            // 
            // btnTexFont
            // 
            this.btnTexFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTexFont.Location = new System.Drawing.Point(299, 277);
            this.btnTexFont.Name = "btnTexFont";
            this.btnTexFont.Size = new System.Drawing.Size(111, 26);
            this.btnTexFont.TabIndex = 13;
            this.btnTexFont.Text = "Change Text Font";
            this.btnTexFont.UseVisualStyleBackColor = true;
            this.btnTexFont.Visible = false;
            this.btnTexFont.Click += new System.EventHandler(this.btnTexFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Momo Johnson Project 10-2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Receipt Summary";
            // 
            // frmLunchOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTexFont);
            this.Controls.Add(this.lboxOrderSummary);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLunchOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.grpBoxText.ResumeLayout(false);
            this.grpBoxText.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxText;
        private System.Windows.Forms.CheckBox chkadd_On_OnOne;
        private System.Windows.Forms.CheckBox chkadd_On_Two;
        private System.Windows.Forms.CheckBox chkAdd_On_Three;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSubTo;
        private System.Windows.Forms.Label lbltX;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblOrToal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkSalad;
        private System.Windows.Forms.CheckBox chkPizza;
        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.ListBox lboxOrderSummary;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnTexFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

