namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.viewAllMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewAllMainMenu
            // 
            this.viewAllMainMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllMainMenu.Location = new System.Drawing.Point(472, 339);
            this.viewAllMainMenu.Name = "viewAllMainMenu";
            this.viewAllMainMenu.Size = new System.Drawing.Size(120, 30);
            this.viewAllMainMenu.TabIndex = 0;
            this.viewAllMainMenu.Text = "&Main Menu";
            this.viewAllMainMenu.UseVisualStyleBackColor = true;
            this.viewAllMainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.viewAllMainMenu);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewAllMainMenu;
    }
}