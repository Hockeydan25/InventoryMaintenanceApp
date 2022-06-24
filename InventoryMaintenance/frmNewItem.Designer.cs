namespace InventoryMaintenance
{
    partial class frmNewItem
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
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbManu = new System.Windows.Forms.ComboBox();
            this.rdoPlant = new System.Windows.Forms.RadioButton();
            this.rdoSupply = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item no:";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(153, 68);
            this.txtItemNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(121, 26);
            this.txtItemNo.TabIndex = 1;
            this.txtItemNo.Tag = "Item no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(153, 126);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(293, 26);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Tag = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(153, 224);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 26);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 286);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 286);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Manufacturer:";
            // 
            // cbManu
            // 
            this.cbManu.FormattingEnabled = true;
            this.cbManu.Items.AddRange(new object[] {
            "Scotts",
            "EverGreen",
            "Ortho",
            ""});
            this.cbManu.Location = new System.Drawing.Point(153, 175);
            this.cbManu.Name = "cbManu";
            this.cbManu.Size = new System.Drawing.Size(139, 27);
            this.cbManu.TabIndex = 9;
            this.cbManu.Tag = "txtPlantOrSupply";
            // 
            // rdoPlant
            // 
            this.rdoPlant.AutoSize = true;
            this.rdoPlant.Location = new System.Drawing.Point(153, 25);
            this.rdoPlant.Name = "rdoPlant";
            this.rdoPlant.Size = new System.Drawing.Size(58, 23);
            this.rdoPlant.TabIndex = 10;
            this.rdoPlant.TabStop = true;
            this.rdoPlant.Tag = "txtPlantOrSupply";
            this.rdoPlant.Text = "Plant";
            this.rdoPlant.UseVisualStyleBackColor = true;
            // 
            // rdoSupply
            // 
            this.rdoSupply.AutoSize = true;
            this.rdoSupply.Location = new System.Drawing.Point(301, 25);
            this.rdoSupply.Name = "rdoSupply";
            this.rdoSupply.Size = new System.Drawing.Size(68, 23);
            this.rdoSupply.TabIndex = 11;
            this.rdoSupply.TabStop = true;
            this.rdoSupply.Tag = "txtPlantOrSupply";
            this.rdoSupply.Text = "Supply";
            this.rdoSupply.UseVisualStyleBackColor = true;
            // 
            // frmNewItem
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(482, 342);
            this.ControlBox = false;
            this.Controls.Add(this.rdoSupply);
            this.Controls.Add(this.rdoPlant);
            this.Controls.Add(this.cbManu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "txtPlantOrSupply";
            this.Text = "New Inventory Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbManu;
        private System.Windows.Forms.RadioButton rdoPlant;
        private System.Windows.Forms.RadioButton rdoSupply;
    }
}