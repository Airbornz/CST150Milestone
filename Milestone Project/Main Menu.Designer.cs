
namespace Milestone_Project
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
            this.navbar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.invTable = new System.Windows.Forms.TableLayoutPanel();
            this.navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.AutoSize = true;
            this.navbar.Controls.Add(this.btnAdd);
            this.navbar.Controls.Add(this.btnEdit);
            this.navbar.Controls.Add(this.btnRemove);
            this.navbar.Controls.Add(this.txtSearch);
            this.navbar.Controls.Add(this.btnSearch);
            this.navbar.Location = new System.Drawing.Point(12, 12);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(776, 50);
            this.navbar.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Location = new System.Drawing.Point(99, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 44);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Location = new System.Drawing.Point(195, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 44);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(291, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(378, 23);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(675, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 44);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // invTable
            // 
            this.invTable.AutoScroll = true;
            this.invTable.ColumnCount = 5;
            this.invTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.invTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.invTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.invTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.invTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.invTable.Location = new System.Drawing.Point(12, 80);
            this.invTable.Name = "invTable";
            this.invTable.RowCount = 1;
            this.invTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.invTable.Size = new System.Drawing.Size(776, 358);
            this.invTable.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invTable);
            this.Controls.Add(this.navbar);
            this.Name = "Form1";
            this.Text = "Inventory - Main Menu";
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel navbar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel invTable;
    }
}

