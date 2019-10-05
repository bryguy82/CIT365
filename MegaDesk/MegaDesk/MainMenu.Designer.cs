namespace MegaDesk
{
    partial class MainMenu
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
            this.new_quote = new System.Windows.Forms.Button();
            this.view_quotes = new System.Windows.Forms.Button();
            this.search_quotes = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // new_quote
            // 
            this.new_quote.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_quote.Location = new System.Drawing.Point(48, 56);
            this.new_quote.Name = "new_quote";
            this.new_quote.Size = new System.Drawing.Size(200, 50);
            this.new_quote.TabIndex = 0;
            this.new_quote.Text = "&Add New Quote";
            this.new_quote.UseVisualStyleBackColor = true;
            this.new_quote.Click += new System.EventHandler(this.new_quote_Click);
            // 
            // view_quotes
            // 
            this.view_quotes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_quotes.Location = new System.Drawing.Point(48, 130);
            this.view_quotes.Name = "view_quotes";
            this.view_quotes.Size = new System.Drawing.Size(200, 50);
            this.view_quotes.TabIndex = 1;
            this.view_quotes.Text = "&View Quotes";
            this.view_quotes.UseVisualStyleBackColor = true;
            this.view_quotes.Click += new System.EventHandler(this.view_quotes_Click);
            // 
            // search_quotes
            // 
            this.search_quotes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_quotes.Location = new System.Drawing.Point(48, 204);
            this.search_quotes.Name = "search_quotes";
            this.search_quotes.Size = new System.Drawing.Size(200, 50);
            this.search_quotes.TabIndex = 2;
            this.search_quotes.Text = "&Search Quotes";
            this.search_quotes.UseVisualStyleBackColor = true;
            this.search_quotes.Click += new System.EventHandler(this.search_quotes_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(48, 278);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(200, 50);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "E&xit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MegaDesk.Properties.Resources.office_desk_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(283, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.search_quotes);
            this.Controls.Add(this.view_quotes);
            this.Controls.Add(this.new_quote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button new_quote;
        private System.Windows.Forms.Button view_quotes;
        private System.Windows.Forms.Button search_quotes;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

