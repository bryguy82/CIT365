namespace MegaDesk
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.selectDrawersField = new System.Windows.Forms.NumericUpDown();
            this.displayQuoteForm = new System.Windows.Forms.Button();
            this.deskMaterialField = new System.Windows.Forms.ComboBox();
            this.RushOrderField = new System.Windows.Forms.ComboBox();
            this.dateField = new System.Windows.Forms.Label();
            this.addQuoteMain = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.selectWidthField = new System.Windows.Forms.NumericUpDown();
            this.selectDepthField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.selectDrawersField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectWidthField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDepthField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desk Width:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Drawers:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wood Material:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rush Order?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Today\'s Date:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameField
            // 
            this.firstNameField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameField.Location = new System.Drawing.Point(187, 69);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(200, 27);
            this.firstNameField.TabIndex = 3;
            this.firstNameField.Validating += new System.ComponentModel.CancelEventHandler(this.input_firstName_Validating);
            // 
            // lastNameField
            // 
            this.lastNameField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameField.Location = new System.Drawing.Point(187, 112);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(200, 27);
            this.lastNameField.TabIndex = 5;
            this.lastNameField.Validating += new System.ComponentModel.CancelEventHandler(this.input_lastName_Validating);
            // 
            // selectDrawersField
            // 
            this.selectDrawersField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDrawersField.Location = new System.Drawing.Point(187, 237);
            this.selectDrawersField.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.selectDrawersField.Name = "selectDrawersField";
            this.selectDrawersField.Size = new System.Drawing.Size(200, 27);
            this.selectDrawersField.TabIndex = 11;
            this.selectDrawersField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayQuoteForm
            // 
            this.displayQuoteForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.displayQuoteForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayQuoteForm.Location = new System.Drawing.Point(426, 322);
            this.displayQuoteForm.Name = "displayQuoteForm";
            this.displayQuoteForm.Size = new System.Drawing.Size(150, 27);
            this.displayQuoteForm.TabIndex = 16;
            this.displayQuoteForm.Text = "&Display Quote";
            this.displayQuoteForm.UseVisualStyleBackColor = true;
            this.displayQuoteForm.Click += new System.EventHandler(this.displayQuoteForm_Click);
            // 
            // deskMaterialField
            // 
            this.deskMaterialField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskMaterialField.FormattingEnabled = true;
            this.deskMaterialField.Location = new System.Drawing.Point(187, 280);
            this.deskMaterialField.Name = "deskMaterialField";
            this.deskMaterialField.Size = new System.Drawing.Size(200, 27);
            this.deskMaterialField.TabIndex = 13;
            this.deskMaterialField.Validating += new System.ComponentModel.CancelEventHandler(this.input_deskMaterial_Validating);
            // 
            // RushOrderField
            // 
            this.RushOrderField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderField.FormattingEnabled = true;
            this.RushOrderField.Location = new System.Drawing.Point(187, 323);
            this.RushOrderField.Name = "RushOrderField";
            this.RushOrderField.Size = new System.Drawing.Size(200, 27);
            this.RushOrderField.TabIndex = 15;
            this.RushOrderField.Validating += new System.ComponentModel.CancelEventHandler(this.input_rush_Validating);
            // 
            // dateField
            // 
            this.dateField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateField.Location = new System.Drawing.Point(187, 32);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(200, 27);
            this.dateField.TabIndex = 1;
            // 
            // addQuoteMain
            // 
            this.addQuoteMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addQuoteMain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteMain.Location = new System.Drawing.Point(426, 25);
            this.addQuoteMain.Name = "addQuoteMain";
            this.addQuoteMain.Size = new System.Drawing.Size(150, 27);
            this.addQuoteMain.TabIndex = 17;
            this.addQuoteMain.Text = "&Main Menu";
            this.addQuoteMain.UseVisualStyleBackColor = true;
            this.addQuoteMain.Click += new System.EventHandler(this.addQuoteMain_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Desk Depth:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectWidthField
            // 
            this.selectWidthField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectWidthField.Location = new System.Drawing.Point(187, 152);
            this.selectWidthField.Name = "selectWidthField";
            this.selectWidthField.Size = new System.Drawing.Size(200, 27);
            this.selectWidthField.TabIndex = 7;
            this.selectWidthField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectWidthField.Validating += new System.ComponentModel.CancelEventHandler(this.selectWidthField_Validating);
            // 
            // selectDepthField
            // 
            this.selectDepthField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDepthField.Location = new System.Drawing.Point(187, 195);
            this.selectDepthField.Name = "selectDepthField";
            this.selectDepthField.Size = new System.Drawing.Size(200, 27);
            this.selectDepthField.TabIndex = 9;
            this.selectDepthField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectDepthField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.selectDepthField_KeyUp);
            this.selectDepthField.Validating += new System.ComponentModel.CancelEventHandler(this.selectDepthField_Validating);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.selectDepthField);
            this.Controls.Add(this.selectWidthField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addQuoteMain);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.RushOrderField);
            this.Controls.Add(this.deskMaterialField);
            this.Controls.Add(this.displayQuoteForm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectDrawersField);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.selectDrawersField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectWidthField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDepthField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.NumericUpDown selectDrawersField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button displayQuoteForm;
        private System.Windows.Forms.ComboBox deskMaterialField;
        private System.Windows.Forms.ComboBox RushOrderField;
        private System.Windows.Forms.Label dateField;
        private System.Windows.Forms.Button addQuoteMain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown selectWidthField;
        private System.Windows.Forms.NumericUpDown selectDepthField;
    }
}