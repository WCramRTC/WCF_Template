namespace CharClient
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRetrieveCharacter = new System.Windows.Forms.Button();
            this.grpRetrieve = new System.Windows.Forms.GroupBox();
            this.txtRetrieveName = new System.Windows.Forms.TextBox();
            this.btnListOfCharacters = new System.Windows.Forms.Button();
            this.grpRetrieve.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(683, 208);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnRetrieveCharacter
            // 
            this.btnRetrieveCharacter.Location = new System.Drawing.Point(12, 19);
            this.btnRetrieveCharacter.Name = "btnRetrieveCharacter";
            this.btnRetrieveCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieveCharacter.TabIndex = 1;
            this.btnRetrieveCharacter.Text = "Retrieve Character";
            this.btnRetrieveCharacter.UseVisualStyleBackColor = true;
            this.btnRetrieveCharacter.Click += new System.EventHandler(this.btnRetrieveCharacter_Click);
            // 
            // grpRetrieve
            // 
            this.grpRetrieve.Controls.Add(this.txtRetrieveName);
            this.grpRetrieve.Controls.Add(this.btnRetrieveCharacter);
            this.grpRetrieve.Location = new System.Drawing.Point(13, 219);
            this.grpRetrieve.Name = "grpRetrieve";
            this.grpRetrieve.Size = new System.Drawing.Size(276, 59);
            this.grpRetrieve.TabIndex = 2;
            this.grpRetrieve.TabStop = false;
            this.grpRetrieve.Text = "Retrieve Character";
            // 
            // txtRetrieveName
            // 
            this.txtRetrieveName.Location = new System.Drawing.Point(106, 21);
            this.txtRetrieveName.Name = "txtRetrieveName";
            this.txtRetrieveName.Size = new System.Drawing.Size(164, 20);
            this.txtRetrieveName.TabIndex = 2;
            this.txtRetrieveName.Text = "Name";
            // 
            // btnListOfCharacters
            // 
            this.btnListOfCharacters.Location = new System.Drawing.Point(562, 360);
            this.btnListOfCharacters.Name = "btnListOfCharacters";
            this.btnListOfCharacters.Size = new System.Drawing.Size(107, 23);
            this.btnListOfCharacters.TabIndex = 3;
            this.btnListOfCharacters.Text = "List Characters";
            this.btnListOfCharacters.UseVisualStyleBackColor = true;
            this.btnListOfCharacters.Click += new System.EventHandler(this.btnListOfCharacters_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 396);
            this.Controls.Add(this.btnListOfCharacters);
            this.Controls.Add(this.grpRetrieve);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.grpRetrieve.ResumeLayout(false);
            this.grpRetrieve.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRetrieveCharacter;
        private System.Windows.Forms.GroupBox grpRetrieve;
        private System.Windows.Forms.TextBox txtRetrieveName;
        private System.Windows.Forms.Button btnListOfCharacters;
    }
}

