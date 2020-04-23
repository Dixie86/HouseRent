namespace HouseRent
{
    partial class FillForm
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
            this.lvHouses = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvHouses = new System.Windows.Forms.DataGridView();
            this.houseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCountryFilter = new System.Windows.Forms.ComboBox();
            this.lbCountryName = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouses)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvHouses
            // 
            this.lvHouses.HideSelection = false;
            this.lvHouses.Location = new System.Drawing.Point(33, 478);
            this.lvHouses.Name = "lvHouses";
            this.lvHouses.Size = new System.Drawing.Size(642, 264);
            this.lvHouses.TabIndex = 29;
            this.lvHouses.UseCompatibleStateImageBehavior = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnExit.Location = new System.Drawing.Point(746, 618);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Kilép";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.PowderBlue;
            this.btnFilter.Location = new System.Drawing.Point(344, 23);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 35);
            this.btnFilter.TabIndex = 27;
            this.btnFilter.Text = "Szűkít";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvHouses
            // 
            this.dgvHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseId,
            this.houseName,
            this.countryId,
            this.countryName,
            this.ownerId,
            this.ownerName,
            this.OwnerEmail,
            this.capacity,
            this.price});
            this.dgvHouses.Location = new System.Drawing.Point(33, 170);
            this.dgvHouses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHouses.Name = "dgvHouses";
            this.dgvHouses.ReadOnly = true;
            this.dgvHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouses.Size = new System.Drawing.Size(825, 277);
            this.dgvHouses.TabIndex = 26;
            // 
            // houseId
            // 
            this.houseId.HeaderText = "Id";
            this.houseId.Name = "houseId";
            this.houseId.ReadOnly = true;
            this.houseId.Visible = false;
            // 
            // houseName
            // 
            this.houseName.HeaderText = "Nev";
            this.houseName.Name = "houseName";
            this.houseName.ReadOnly = true;
            // 
            // countryId
            // 
            this.countryId.HeaderText = "OrszagID";
            this.countryId.Name = "countryId";
            this.countryId.ReadOnly = true;
            this.countryId.Visible = false;
            // 
            // countryName
            // 
            this.countryName.HeaderText = "Orszag";
            this.countryName.Name = "countryName";
            this.countryName.ReadOnly = true;
            // 
            // ownerId
            // 
            this.ownerId.HeaderText = "TulajID";
            this.ownerId.Name = "ownerId";
            this.ownerId.ReadOnly = true;
            this.ownerId.Visible = false;
            // 
            // ownerName
            // 
            this.ownerName.HeaderText = "Tulajdonos";
            this.ownerName.Name = "ownerName";
            this.ownerName.ReadOnly = true;
            // 
            // OwnerEmail
            // 
            this.OwnerEmail.HeaderText = "TulajEmail";
            this.OwnerEmail.Name = "OwnerEmail";
            this.OwnerEmail.ReadOnly = true;
            this.OwnerEmail.Visible = false;
            // 
            // capacity
            // 
            this.capacity.HeaderText = "Ferohely";
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Ar";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // cbCountryFilter
            // 
            this.cbCountryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountryFilter.FormattingEnabled = true;
            this.cbCountryFilter.Location = new System.Drawing.Point(150, 27);
            this.cbCountryFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCountryFilter.Name = "cbCountryFilter";
            this.cbCountryFilter.Size = new System.Drawing.Size(170, 28);
            this.cbCountryFilter.TabIndex = 25;
            // 
            // lbCountryName
            // 
            this.lbCountryName.AutoSize = true;
            this.lbCountryName.Location = new System.Drawing.Point(6, 30);
            this.lbCountryName.Name = "lbCountryName";
            this.lbCountryName.Size = new System.Drawing.Size(98, 20);
            this.lbCountryName.TabIndex = 32;
            this.lbCountryName.Text = "Ország neve";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.lbCountryName);
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.cbCountryFilter);
            this.gbFilter.Location = new System.Drawing.Point(32, 38);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(483, 104);
            this.gbFilter.TabIndex = 65;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Szűrés";
            // 
            // FillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(907, 755);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lvHouses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvHouses);
            this.Name = "FillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FillForm";
            this.Load += new System.EventHandler(this.FillForm_Load);
            this.Shown += new System.EventHandler(this.FillForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouses)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHouses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvHouses;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.ComboBox cbCountryFilter;
        private System.Windows.Forms.Label lbCountryName;
        private System.Windows.Forms.GroupBox gbFilter;
    }
}