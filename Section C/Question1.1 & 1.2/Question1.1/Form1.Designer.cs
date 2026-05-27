namespace Question1._1
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
            lblOutput = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            lblMblCode = new Label();
            lblMake = new Label();
            lblQuantity = new Label();
            tblMobilePhones = new TableLayoutPanel();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(94, 77);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(38, 15);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "label1";
            lblOutput.Click += lblOutput_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(258, 125);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(123, 23);
            txtCode.TabIndex = 1;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(258, 154);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(123, 23);
            txtMake.TabIndex = 2;
            txtMake.TextChanged += txtMake_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(258, 183);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(123, 23);
            txtQuantity.TabIndex = 3;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(80, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(207, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "button2";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(337, 230);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 6;
            btnFind.Text = "button3";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // lblMblCode
            // 
            lblMblCode.AutoSize = true;
            lblMblCode.Location = new Point(117, 128);
            lblMblCode.Name = "lblMblCode";
            lblMblCode.Size = new Size(38, 15);
            lblMblCode.TabIndex = 7;
            lblMblCode.Text = "label1";
            lblMblCode.Click += lblMblCode_Click;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(117, 157);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(38, 15);
            lblMake.TabIndex = 8;
            lblMake.Text = "label1";
            lblMake.Click += lblMake_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(117, 186);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(38, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "label1";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // tblMobilePhones
            // 
            tblMobilePhones.ColumnCount = 3;
            tblMobilePhones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMobilePhones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMobilePhones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tblMobilePhones.Location = new Point(463, 77);
            tblMobilePhones.Name = "tblMobilePhones";
            tblMobilePhones.RowCount = 2;
            tblMobilePhones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMobilePhones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMobilePhones.Size = new Size(327, 176);
            tblMobilePhones.TabIndex = 10;
            tblMobilePhones.Paint += tblMobilePhones_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 316);
            Controls.Add(tblMobilePhones);
            Controls.Add(lblQuantity);
            Controls.Add(lblMake);
            Controls.Add(lblMblCode);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private Label lblMblCode;
        private Label lblMake;
        private Label lblQuantity;
        private TableLayoutPanel tblMobilePhones;
    }
}
