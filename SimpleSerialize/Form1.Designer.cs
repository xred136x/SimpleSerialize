namespace SimpleSerialize
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAddNewDish = new System.Windows.Forms.Label();
            this.btnSaveDish = new System.Windows.Forms.Button();
            this.lbListOfDish = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(14, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 43);
            this.textBox1.TabIndex = 0;
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(231, 53);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(75, 72);
            this.btnAddDish.TabIndex = 2;
            this.btnAddDish.Text = "Добавить";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(91, 112);
            this.maskedTextBox1.Mask = "0000.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(123, 43);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbAddNewDish);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSaveDish);
            this.panel1.Controls.Add(this.btnAddDish);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 213);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            // 
            // lbAddNewDish
            // 
            this.lbAddNewDish.AutoSize = true;
            this.lbAddNewDish.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddNewDish.Location = new System.Drawing.Point(3, 10);
            this.lbAddNewDish.Name = "lbAddNewDish";
            this.lbAddNewDish.Size = new System.Drawing.Size(355, 30);
            this.lbAddNewDish.TabIndex = 2;
            this.lbAddNewDish.Text = "Новое блюдо (запись по dbl_clck)";
            // 
            // btnSaveDish
            // 
            this.btnSaveDish.Location = new System.Drawing.Point(231, 131);
            this.btnSaveDish.Name = "btnSaveDish";
            this.btnSaveDish.Size = new System.Drawing.Size(75, 72);
            this.btnSaveDish.TabIndex = 3;
            this.btnSaveDish.Text = "Записать";
            this.btnSaveDish.UseVisualStyleBackColor = true;
            this.btnSaveDish.Click += new System.EventHandler(this.btnSaveDish_Click);
            // 
            // lbListOfDish
            // 
            this.lbListOfDish.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbListOfDish.FormattingEnabled = true;
            this.lbListOfDish.ItemHeight = 30;
            this.lbListOfDish.Location = new System.Drawing.Point(408, 31);
            this.lbListOfDish.Name = "lbListOfDish";
            this.lbListOfDish.Size = new System.Drawing.Size(175, 154);
            this.lbListOfDish.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 326);
            this.Controls.Add(this.lbListOfDish);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox1;
        private Button btnAddDish;
        private MaskedTextBox maskedTextBox1;
        private Panel panel1;
        private Label lbAddNewDish;
        private ListBox lbListOfDish;
        private Button btnSaveDish;
    }
}