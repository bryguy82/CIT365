namespace MegaDesk
{
    partial class SearchQuotes
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
            this.searchMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchMainMenu
            // 
            this.searchMainMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMainMenu.Location = new System.Drawing.Point(472, 329);
            this.searchMainMenu.Name = "searchMainMenu";
            this.searchMainMenu.Size = new System.Drawing.Size(110, 30);
            this.searchMainMenu.TabIndex = 22;
            this.searchMainMenu.Text = "&Main Menu";
            this.searchMainMenu.UseVisualStyleBackColor = true;
            this.searchMainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.searchMainMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchMainMenu;
    }
}