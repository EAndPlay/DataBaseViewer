using System.Windows.Forms;

namespace DataBaseViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aquaparkDataSet = new DataBaseViewer.AquaparkDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.braceletIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minuteCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.braceletIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.BraceletsLabel = new System.Windows.Forms.Label();
            this.ServicesLabel = new System.Windows.Forms.Label();
            this.TransactionsLabel = new System.Windows.Forms.Label();
            this.ZonesLabel = new System.Windows.Forms.Label();
            this.ZonesVisitsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquaparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.aquaparkDataSet;
            this.bindingSource1.Position = 0;
            // 
            // aquaparkDataSet
            // 
            this.aquaparkDataSet.DataSetName = "AquaparkDataSet";
            this.aquaparkDataSet.Namespace = "http://tempuri.org/AquaparkDataSet.xsd";
            this.aquaparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idDataGridViewTextBoxColumn, this.depositDataGridViewTextBoxColumn, this.dailyPaidDataGridViewCheckBoxColumn });
            this.dataGridView1.DataMember = "Bracelets";
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(368, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depositDataGridViewTextBoxColumn
            // 
            this.depositDataGridViewTextBoxColumn.DataPropertyName = "Deposit";
            this.depositDataGridViewTextBoxColumn.HeaderText = "Deposit";
            this.depositDataGridViewTextBoxColumn.Name = "depositDataGridViewTextBoxColumn";
            this.depositDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dailyPaidDataGridViewCheckBoxColumn
            // 
            this.dailyPaidDataGridViewCheckBoxColumn.DataPropertyName = "DailyPaid";
            this.dailyPaidDataGridViewCheckBoxColumn.HeaderText = "DailyPaid";
            this.dailyPaidDataGridViewCheckBoxColumn.Name = "dailyPaidDataGridViewCheckBoxColumn";
            this.dailyPaidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idDataGridViewTextBoxColumn1, this.nameDataGridViewTextBoxColumn, this.costDataGridViewTextBoxColumn });
            this.dataGridView2.DataMember = "Services";
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(386, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(370, 300);
            this.dataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idDataGridViewTextBoxColumn2, this.braceletIdDataGridViewTextBoxColumn, this.serviceIdDataGridViewTextBoxColumn, this.statusDataGridViewTextBoxColumn });
            this.dataGridView3.DataMember = "Transactions";
            this.dataGridView3.DataSource = this.bindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(762, 35);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(450, 300);
            this.dataGridView3.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // braceletIdDataGridViewTextBoxColumn
            // 
            this.braceletIdDataGridViewTextBoxColumn.DataPropertyName = "BraceletId";
            this.braceletIdDataGridViewTextBoxColumn.HeaderText = "BraceletId";
            this.braceletIdDataGridViewTextBoxColumn.Name = "braceletIdDataGridViewTextBoxColumn";
            this.braceletIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idDataGridViewTextBoxColumn3, this.nameDataGridViewTextBoxColumn1, this.minuteCostDataGridViewTextBoxColumn, this.dailyCostDataGridViewTextBoxColumn });
            this.dataGridView4.DataMember = "Zones";
            this.dataGridView4.DataSource = this.bindingSource1;
            this.dataGridView4.Location = new System.Drawing.Point(12, 370);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(450, 300);
            this.dataGridView4.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // minuteCostDataGridViewTextBoxColumn
            // 
            this.minuteCostDataGridViewTextBoxColumn.DataPropertyName = "MinuteCost";
            this.minuteCostDataGridViewTextBoxColumn.HeaderText = "MinuteCost";
            this.minuteCostDataGridViewTextBoxColumn.Name = "minuteCostDataGridViewTextBoxColumn";
            this.minuteCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dailyCostDataGridViewTextBoxColumn
            // 
            this.dailyCostDataGridViewTextBoxColumn.DataPropertyName = "DailyCost";
            this.dailyCostDataGridViewTextBoxColumn.HeaderText = "DailyCost";
            this.dailyCostDataGridViewTextBoxColumn.Name = "dailyCostDataGridViewTextBoxColumn";
            this.dailyCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idDataGridViewTextBoxColumn4, this.zoneIdDataGridViewTextBoxColumn, this.braceletIdDataGridViewTextBoxColumn1, this.enterTimeDataGridViewTextBoxColumn, this.exitTimeDataGridViewTextBoxColumn });
            this.dataGridView5.DataMember = "ZoneVisits";
            this.dataGridView5.DataSource = this.bindingSource1;
            this.dataGridView5.Location = new System.Drawing.Point(468, 370);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(550, 300);
            this.dataGridView5.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // zoneIdDataGridViewTextBoxColumn
            // 
            this.zoneIdDataGridViewTextBoxColumn.DataPropertyName = "ZoneId";
            this.zoneIdDataGridViewTextBoxColumn.HeaderText = "ZoneId";
            this.zoneIdDataGridViewTextBoxColumn.Name = "zoneIdDataGridViewTextBoxColumn";
            this.zoneIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // braceletIdDataGridViewTextBoxColumn1
            // 
            this.braceletIdDataGridViewTextBoxColumn1.DataPropertyName = "BraceletId";
            this.braceletIdDataGridViewTextBoxColumn1.HeaderText = "BraceletId";
            this.braceletIdDataGridViewTextBoxColumn1.Name = "braceletIdDataGridViewTextBoxColumn1";
            this.braceletIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // enterTimeDataGridViewTextBoxColumn
            // 
            this.enterTimeDataGridViewTextBoxColumn.DataPropertyName = "EnterTime";
            this.enterTimeDataGridViewTextBoxColumn.HeaderText = "EnterTime";
            this.enterTimeDataGridViewTextBoxColumn.Name = "enterTimeDataGridViewTextBoxColumn";
            this.enterTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exitTimeDataGridViewTextBoxColumn
            // 
            this.exitTimeDataGridViewTextBoxColumn.DataPropertyName = "ExitTime";
            this.exitTimeDataGridViewTextBoxColumn.HeaderText = "ExitTime";
            this.exitTimeDataGridViewTextBoxColumn.Name = "exitTimeDataGridViewTextBoxColumn";
            this.exitTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1064, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReloadButtonClick);
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddServiceButton.Location = new System.Drawing.Point(683, 9);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(73, 28);
            this.AddServiceButton.TabIndex = 6;
            this.AddServiceButton.Text = "Add";
            this.AddServiceButton.UseVisualStyleBackColor = true;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButtonClick);
            // 
            // BraceletsLabel
            // 
            this.BraceletsLabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BraceletsLabel.Location = new System.Drawing.Point(12, 9);
            this.BraceletsLabel.Name = "BraceletsLabel";
            this.BraceletsLabel.Size = new System.Drawing.Size(123, 23);
            this.BraceletsLabel.TabIndex = 7;
            this.BraceletsLabel.Text = "Bracelets";
            // 
            // ServicesLabel
            // 
            this.ServicesLabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicesLabel.Location = new System.Drawing.Point(386, 9);
            this.ServicesLabel.Name = "ServicesLabel";
            this.ServicesLabel.Size = new System.Drawing.Size(99, 23);
            this.ServicesLabel.TabIndex = 8;
            this.ServicesLabel.Text = "Services";
            // 
            // TransactionsLabel
            // 
            this.TransactionsLabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransactionsLabel.Location = new System.Drawing.Point(762, 9);
            this.TransactionsLabel.Name = "TransactionsLabel";
            this.TransactionsLabel.Size = new System.Drawing.Size(158, 23);
            this.TransactionsLabel.TabIndex = 9;
            this.TransactionsLabel.Text = "Transactions";
            // 
            // ZonesLabel
            // 
            this.ZonesLabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZonesLabel.Location = new System.Drawing.Point(12, 344);
            this.ZonesLabel.Name = "ZonesLabel";
            this.ZonesLabel.Size = new System.Drawing.Size(110, 23);
            this.ZonesLabel.TabIndex = 10;
            this.ZonesLabel.Text = "Zones";
            // 
            // ZonesVisitsLabel
            // 
            this.ZonesVisitsLabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZonesVisitsLabel.Location = new System.Drawing.Point(468, 344);
            this.ZonesVisitsLabel.Name = "ZonesVisitsLabel";
            this.ZonesVisitsLabel.Size = new System.Drawing.Size(146, 23);
            this.ZonesVisitsLabel.TabIndex = 11;
            this.ZonesVisitsLabel.Text = "ZonesVisits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.ZonesVisitsLabel);
            this.Controls.Add(this.ZonesLabel);
            this.Controls.Add(this.TransactionsLabel);
            this.Controls.Add(this.ServicesLabel);
            this.Controls.Add(this.BraceletsLabel);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DataBaseViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquaparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label BraceletsLabel;
        private System.Windows.Forms.Label ServicesLabel;
        private System.Windows.Forms.Label TransactionsLabel;
        private System.Windows.Forms.Label ZonesLabel;

        private System.Windows.Forms.Label ZonesVisitsLabel;

        private System.Windows.Forms.Button AddServiceButton;

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private AquaparkDataSet aquaparkDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dailyPaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn braceletIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuteCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn braceletIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

