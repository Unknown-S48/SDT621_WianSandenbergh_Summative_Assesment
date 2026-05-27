namespace Question1._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtBoxName = new TextBox();
            btnGreeting = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(240, 190);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Enter your name:";
            lblName.Click += lblName_Click;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(343, 187);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PlaceholderText = "Enter Name";
            txtBoxName.Size = new Size(151, 23);
            txtBoxName.TabIndex = 1;
            txtBoxName.TextChanged += txtBoxName_TextChanged;
            // 
            // btnGreeting
            // 
            btnGreeting.Location = new Point(396, 216);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(98, 39);
            btnGreeting.TabIndex = 2;
            btnGreeting.Text = "Greeting";
            btnGreeting.UseVisualStyleBackColor = true;
            btnGreeting.Click += btnGreeting_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGreeting);
            Controls.Add(txtBoxName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtBoxName;
        private Button btnGreeting;
    }
}
