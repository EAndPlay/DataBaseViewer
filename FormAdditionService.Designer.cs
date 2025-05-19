using System.ComponentModel;
using System.Windows.Forms;

namespace DataBaseViewer
{
    partial class FormAdditionService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdditionService));
            this.ServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.ServiceNameLabel = new System.Windows.Forms.Label();
            this.ServiceCostLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ServiceCostTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServiceNameTextBox
            // 
            this.ServiceNameTextBox.Location = new System.Drawing.Point(80, 9);
            this.ServiceNameTextBox.Name = "ServiceNameTextBox";
            this.ServiceNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.ServiceNameTextBox.TabIndex = 0;
            // 
            // ServiceNameLabel
            // 
            this.ServiceNameLabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceNameLabel.Location = new System.Drawing.Point(8, 2);
            this.ServiceNameLabel.Name = "ServiceNameLabel";
            this.ServiceNameLabel.Size = new System.Drawing.Size(66, 23);
            this.ServiceNameLabel.TabIndex = 8;
            this.ServiceNameLabel.Text = "Name";
            // 
            // ServiceCostLabel
            // 
            this.ServiceCostLabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceCostLabel.Location = new System.Drawing.Point(8, 25);
            this.ServiceCostLabel.Name = "ServiceCostLabel";
            this.ServiceCostLabel.Size = new System.Drawing.Size(66, 23);
            this.ServiceCostLabel.TabIndex = 9;
            this.ServiceCostLabel.Text = "Cost";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(80, 58);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(111, 35);
            this.ApplyButton.TabIndex = 10;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButtonClick);
            // 
            // ServiceCostTextBox
            // 
            this.ServiceCostTextBox.Location = new System.Drawing.Point(80, 32);
            this.ServiceCostTextBox.Name = "ServiceCostTextBox";
            this.ServiceCostTextBox.Size = new System.Drawing.Size(167, 20);
            this.ServiceCostTextBox.TabIndex = 11;
            this.ServiceCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServiceCostTextBoxKeyPress);
            // 
            // FormAdditionService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 100);
            this.Controls.Add(this.ServiceCostTextBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ServiceCostLabel);
            this.Controls.Add(this.ServiceNameLabel);
            this.Controls.Add(this.ServiceNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdditionService";
            this.Text = "Add Service";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox ServiceCostTextBox;

        private System.Windows.Forms.Label ServiceCostLabel;

        private System.Windows.Forms.Label ServiceNameLabel;

        private System.Windows.Forms.TextBox ServiceNameTextBox;

        #endregion
    }
}