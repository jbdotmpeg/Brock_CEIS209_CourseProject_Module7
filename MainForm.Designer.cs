namespace Brock_CourseProject_Part2
{
    partial class MainForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 16);
            this.addButton.Margin = new System.Windows.Forms.Padding(7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 51);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(177, 16);
            this.removeButton.Margin = new System.Windows.Forms.Padding(7);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(136, 51);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(327, 16);
            this.displayButton.Margin = new System.Windows.Forms.Padding(7);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(140, 51);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(481, 16);
            this.printButton.Margin = new System.Windows.Forms.Padding(7);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(199, 51);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print  Paychecks";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.ItemHeight = 29;
            this.EmployeesListBox.Location = new System.Drawing.Point(16, 81);
            this.EmployeesListBox.Margin = new System.Windows.Forms.Padding(7);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(1020, 526);
            this.EmployeesListBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 627);
            this.Controls.Add(this.EmployeesListBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainForm";
            this.Text = "Payroll System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.ListBox EmployeesListBox;
    }
}

