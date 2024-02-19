namespace CoffeShop
{
    partial class HomePage
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.todaySell = new System.Windows.Forms.Label();
            this.totalSale = new System.Windows.Forms.Label();
            this.adminLabel = new System.Windows.Forms.Label();
            this.uC_UpdateItem1 = new CoffeShop.AllUserControls.UC_UpdateItem();
            this.uC_RemoveItem1 = new CoffeShop.AllUserControls.UC_RemoveItem();
            this.uC_additems1 = new CoffeShop.AllUserControls.UC_additems();
            this.uC_welcome1 = new CoffeShop.AllUserControls.UC_welcome();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(32, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(119, 40);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label2";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(32, 28);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(170, 35);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "emailLabel";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRemove.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(54, 345);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(184, 54);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(54, 249);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 54);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddItems.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(54, 157);
            this.btnAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(184, 54);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Item";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.LinkColor = System.Drawing.Color.Red;
            this.Logout.Location = new System.Drawing.Point(784, 13);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(95, 29);
            this.Logout.TabIndex = 6;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(917, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "×";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // todaySell
            // 
            this.todaySell.AutoSize = true;
            this.todaySell.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaySell.Location = new System.Drawing.Point(326, 62);
            this.todaySell.Name = "todaySell";
            this.todaySell.Size = new System.Drawing.Size(176, 38);
            this.todaySell.TabIndex = 12;
            this.todaySell.Text = "Today sell";
            // 
            // totalSale
            // 
            this.totalSale.AutoSize = true;
            this.totalSale.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSale.Location = new System.Drawing.Point(628, 62);
            this.totalSale.Name = "totalSale";
            this.totalSale.Size = new System.Drawing.Size(174, 38);
            this.totalSale.TabIndex = 17;
            this.totalSale.Text = "Total Sale";
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.Location = new System.Drawing.Point(74, 37);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(119, 38);
            this.adminLabel.TabIndex = 18;
            this.adminLabel.Text = "Admin";
            // 
            // uC_UpdateItem1
            // 
            this.uC_UpdateItem1.Location = new System.Drawing.Point(338, 123);
            this.uC_UpdateItem1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_UpdateItem1.Name = "uC_UpdateItem1";
            this.uC_UpdateItem1.Size = new System.Drawing.Size(830, 450);
            this.uC_UpdateItem1.TabIndex = 21;
            // 
            // uC_RemoveItem1
            // 
            this.uC_RemoveItem1.Location = new System.Drawing.Point(339, 128);
            this.uC_RemoveItem1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(830, 450);
            this.uC_RemoveItem1.TabIndex = 20;
            // 
            // uC_additems1
            // 
            this.uC_additems1.Location = new System.Drawing.Point(339, 128);
            this.uC_additems1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_additems1.Name = "uC_additems1";
            this.uC_additems1.Size = new System.Drawing.Size(830, 450);
            this.uC_additems1.TabIndex = 19;
            // 
            // uC_welcome1
            // 
            this.uC_welcome1.AutoSize = true;
            this.uC_welcome1.Location = new System.Drawing.Point(160, 66);
            this.uC_welcome1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_welcome1.Name = "uC_welcome1";
            this.uC_welcome1.Size = new System.Drawing.Size(1106, 823);
            this.uC_welcome1.TabIndex = 16;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 554);
            this.Controls.Add(this.uC_UpdateItem1);
            this.Controls.Add(this.uC_RemoveItem1);
            this.Controls.Add(this.uC_additems1);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.totalSale);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.uC_welcome1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.todaySell);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.Label todaySell;
        private AllUserControls.UC_welcome uC_welcome1;
        private System.Windows.Forms.Label totalSale;
        private System.Windows.Forms.Label adminLabel;
        private AllUserControls.UC_additems uC_additems1;
        private AllUserControls.UC_RemoveItem uC_RemoveItem1;
        private AllUserControls.UC_UpdateItem uC_UpdateItem1;
    }
}