namespace GroceryApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOpenAddForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOpenAddForm = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(40, 20); // Adjusted position
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 199); // Made the list bigger
            this.listBox1.TabIndex = 0;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10F); // Changed font
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Added border
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke; // Changed background color
            this.listBox1.ForeColor = System.Drawing.Color.DarkSlateGray; // Changed text color

            // 
            // btnOpenAddForm
            // 
            this.btnOpenAddForm.Location = new System.Drawing.Point(40, 230); // Adjusted position
            this.btnOpenAddForm.Name = "btnOpenAddForm";
            this.btnOpenAddForm.Size = new System.Drawing.Size(320, 40);
            this.btnOpenAddForm.TabIndex = 1;
            this.btnOpenAddForm.Text = "Add Item";
            this.btnOpenAddForm.UseVisualStyleBackColor = true;
            this.btnOpenAddForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Font style
            this.btnOpenAddForm.ForeColor = System.Drawing.Color.White; // Button text color
            this.btnOpenAddForm.BackColor = System.Drawing.Color.Teal; // Button background color
            this.btnOpenAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Flat style for a modern look
            this.btnOpenAddForm.FlatAppearance.BorderSize = 0; // Remove border around button
            this.btnOpenAddForm.Click += new System.EventHandler(this.btnOpenAddForm_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300); // Increased form size
            this.Controls.Add(this.btnOpenAddForm);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Grocery List";
            this.ResumeLayout(false);
        }
    }
}
