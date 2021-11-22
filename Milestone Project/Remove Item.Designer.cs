
namespace Milestone_Project
{
    partial class Remove_Item
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rdbUPC = new System.Windows.Forms.RadioButton();
            this.rdbSKU = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Remove Item";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Location = new System.Drawing.Point(50, 90);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(173, 29);
            this.txtInput.TabIndex = 14;
            // 
            // rdbUPC
            // 
            this.rdbUPC.AutoSize = true;
            this.rdbUPC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbUPC.Location = new System.Drawing.Point(50, 145);
            this.rdbUPC.Name = "rdbUPC";
            this.rdbUPC.Size = new System.Drawing.Size(58, 25);
            this.rdbUPC.TabIndex = 15;
            this.rdbUPC.TabStop = true;
            this.rdbUPC.Text = "UPC";
            this.rdbUPC.UseVisualStyleBackColor = true;
            // 
            // rdbSKU
            // 
            this.rdbSKU.AutoSize = true;
            this.rdbSKU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbSKU.Location = new System.Drawing.Point(166, 145);
            this.rdbSKU.Name = "rdbSKU";
            this.rdbSKU.Size = new System.Drawing.Size(57, 25);
            this.rdbSKU.TabIndex = 16;
            this.rdbSKU.TabStop = true;
            this.rdbSKU.Text = "SKU";
            this.rdbSKU.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(89, 349);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 34);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Remove_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 395);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdbSKU);
            this.Controls.Add(this.rdbUPC);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Remove_Item";
            this.Text = "Inventory - Remove Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rdbUPC;
        private System.Windows.Forms.RadioButton rdbSKU;
        private System.Windows.Forms.Button btnSubmit;
    }
}