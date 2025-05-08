namespace GroceryApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 0;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F); // Changed font
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Added border
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke; // Background color
            this.txtName.ForeColor = System.Drawing.Color.DarkSlateGray; // Text color

            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(15, 85);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 23);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F); // Changed font
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Added border
            this.txtPrice.BackColor = System.Drawing.Color.WhiteSmoke; // Background color
            this.txtPrice.ForeColor = System.Drawing.Color.DarkSlateGray; // Text color

            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(15, 120);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(200, 40);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Font style
            this.btnAddItem.ForeColor = System.Drawing.Color.White; // Button text color
            this.btnAddItem.BackColor = System.Drawing.Color.Teal; // Button background color
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Flat style for modern look
            this.btnAddItem.FlatAppearance.BorderSize = 0; // Remove border around button
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";

            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(15, 65);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 15);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price:";

            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(230, 180); // Increased form size
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Name = "Form2";
            this.Text = "Add Grocery Item";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
