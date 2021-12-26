
namespace OrderAutomation
{
    partial class CustomerUI
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxTax = new System.Windows.Forms.TextBox();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbllDate = new System.Windows.Forms.Label();
            this.gbxItem = new System.Windows.Forms.GroupBox();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxShippingWeight = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblShippingWeight = new System.Windows.Forms.Label();
            this.lblPayType = new System.Windows.Forms.Label();
            this.cbxPayType = new System.Windows.Forms.ComboBox();
            this.lblCashTendered = new System.Windows.Forms.Label();
            this.tbxCashTendered = new System.Windows.Forms.TextBox();
            this.gbxCash = new System.Windows.Forms.GroupBox();
            this.gbxCheck = new System.Windows.Forms.GroupBox();
            this.tbxCheckAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxCheckBankID = new System.Windows.Forms.TextBox();
            this.lblBankId = new System.Windows.Forms.Label();
            this.tbxCheckName = new System.Windows.Forms.TextBox();
            this.lblCheckName = new System.Windows.Forms.Label();
            this.gbxCredit = new System.Windows.Forms.GroupBox();
            this.cbxCreditType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tbxCreditAmount = new System.Windows.Forms.TextBox();
            this.lblCreditAmount = new System.Windows.Forms.Label();
            this.tbxCreditDate = new System.Windows.Forms.TextBox();
            this.tbxCreditNumber = new System.Windows.Forms.TextBox();
            this.lblExData = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.dgwItem = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnGiveanOrder = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxItem.SuspendLayout();
            this.gbxCash.SuspendLayout();
            this.gbxCheck.SuspendLayout();
            this.gbxCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(158, 40);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(138, 26);
            this.tbxName.TabIndex = 0;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(158, 237);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(570, 26);
            this.tbxAddress.TabIndex = 1;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(158, 89);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(138, 26);
            this.tbxQuantity.TabIndex = 2;
            this.tbxQuantity.TextChanged += new System.EventHandler(this.tbxQuantity_TextChanged);
            // 
            // tbxTax
            // 
            this.tbxTax.Enabled = false;
            this.tbxTax.Location = new System.Drawing.Point(158, 144);
            this.tbxTax.Name = "tbxTax";
            this.tbxTax.Size = new System.Drawing.Size(138, 26);
            this.tbxTax.TabIndex = 3;
            // 
            // tbxStatus
            // 
            this.tbxStatus.Location = new System.Drawing.Point(186, 566);
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.Size = new System.Drawing.Size(100, 26);
            this.tbxStatus.TabIndex = 4;
            this.tbxStatus.Text = "Hazırlanıyor";
            this.tbxStatus.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(75, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(62, 240);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(62, 92);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 20);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(92, 147);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(42, 20);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "Tax :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(70, 569);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 20);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status :";
            this.lblStatus.Visible = false;
            // 
            // lbllDate
            // 
            this.lbllDate.AutoSize = true;
            this.lbllDate.Location = new System.Drawing.Point(82, 621);
            this.lbllDate.Name = "lbllDate";
            this.lbllDate.Size = new System.Drawing.Size(52, 20);
            this.lbllDate.TabIndex = 14;
            this.lbllDate.Text = "Date :";
            this.lbllDate.Visible = false;
            // 
            // gbxItem
            // 
            this.gbxItem.Controls.Add(this.tbxItemName);
            this.gbxItem.Controls.Add(this.lblItemName);
            this.gbxItem.Controls.Add(this.tbxPrice);
            this.gbxItem.Controls.Add(this.tbxDescription);
            this.gbxItem.Controls.Add(this.tbxShippingWeight);
            this.gbxItem.Controls.Add(this.lblPrice);
            this.gbxItem.Controls.Add(this.lblDescription);
            this.gbxItem.Controls.Add(this.lblShippingWeight);
            this.gbxItem.Location = new System.Drawing.Point(338, 29);
            this.gbxItem.Name = "gbxItem";
            this.gbxItem.Size = new System.Drawing.Size(390, 197);
            this.gbxItem.TabIndex = 18;
            this.gbxItem.TabStop = false;
            this.gbxItem.Text = "Lütfen Listeden Ürün Seçiniz";
            // 
            // tbxItemName
            // 
            this.tbxItemName.Location = new System.Drawing.Point(198, 36);
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(170, 26);
            this.tbxItemName.TabIndex = 7;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(71, 39);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(95, 20);
            this.lblItemName.TabIndex = 6;
            this.lblItemName.Text = "Item Name :";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(198, 158);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(170, 26);
            this.tbxPrice.TabIndex = 5;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(198, 118);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(170, 26);
            this.tbxDescription.TabIndex = 4;
            // 
            // tbxShippingWeight
            // 
            this.tbxShippingWeight.Location = new System.Drawing.Point(198, 77);
            this.tbxShippingWeight.Name = "tbxShippingWeight";
            this.tbxShippingWeight.Size = new System.Drawing.Size(170, 26);
            this.tbxShippingWeight.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(116, 161);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(71, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description :";
            // 
            // lblShippingWeight
            // 
            this.lblShippingWeight.AutoSize = true;
            this.lblShippingWeight.Location = new System.Drawing.Point(12, 80);
            this.lblShippingWeight.Name = "lblShippingWeight";
            this.lblShippingWeight.Size = new System.Drawing.Size(156, 20);
            this.lblShippingWeight.TabIndex = 0;
            this.lblShippingWeight.Text = "ShippingWeight(kg) :";
            // 
            // lblPayType
            // 
            this.lblPayType.AutoSize = true;
            this.lblPayType.Location = new System.Drawing.Point(752, 40);
            this.lblPayType.Name = "lblPayType";
            this.lblPayType.Size = new System.Drawing.Size(81, 20);
            this.lblPayType.TabIndex = 19;
            this.lblPayType.Text = "Pay Type :";
            // 
            // cbxPayType
            // 
            this.cbxPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayType.FormattingEnabled = true;
            this.cbxPayType.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Credit"});
            this.cbxPayType.Location = new System.Drawing.Point(856, 40);
            this.cbxPayType.Name = "cbxPayType";
            this.cbxPayType.Size = new System.Drawing.Size(145, 28);
            this.cbxPayType.TabIndex = 20;
            this.cbxPayType.SelectedIndexChanged += new System.EventHandler(this.cbxPayType_SelectedIndexChanged);
            // 
            // lblCashTendered
            // 
            this.lblCashTendered.AutoSize = true;
            this.lblCashTendered.Location = new System.Drawing.Point(6, 45);
            this.lblCashTendered.Name = "lblCashTendered";
            this.lblCashTendered.Size = new System.Drawing.Size(126, 20);
            this.lblCashTendered.TabIndex = 21;
            this.lblCashTendered.Text = "Cash Tendered :";
            // 
            // tbxCashTendered
            // 
            this.tbxCashTendered.Enabled = false;
            this.tbxCashTendered.Location = new System.Drawing.Point(145, 42);
            this.tbxCashTendered.Name = "tbxCashTendered";
            this.tbxCashTendered.Size = new System.Drawing.Size(121, 26);
            this.tbxCashTendered.TabIndex = 22;
            // 
            // gbxCash
            // 
            this.gbxCash.Controls.Add(this.lblCashTendered);
            this.gbxCash.Controls.Add(this.tbxCashTendered);
            this.gbxCash.Location = new System.Drawing.Point(756, 76);
            this.gbxCash.Name = "gbxCash";
            this.gbxCash.Size = new System.Drawing.Size(330, 94);
            this.gbxCash.TabIndex = 23;
            this.gbxCash.TabStop = false;
            this.gbxCash.Text = "Cash";
            // 
            // gbxCheck
            // 
            this.gbxCheck.Controls.Add(this.tbxCheckAmount);
            this.gbxCheck.Controls.Add(this.lblAmount);
            this.gbxCheck.Controls.Add(this.tbxCheckBankID);
            this.gbxCheck.Controls.Add(this.lblBankId);
            this.gbxCheck.Controls.Add(this.tbxCheckName);
            this.gbxCheck.Controls.Add(this.lblCheckName);
            this.gbxCheck.Location = new System.Drawing.Point(756, 173);
            this.gbxCheck.Name = "gbxCheck";
            this.gbxCheck.Size = new System.Drawing.Size(330, 170);
            this.gbxCheck.TabIndex = 24;
            this.gbxCheck.TabStop = false;
            this.gbxCheck.Text = "Check";
            // 
            // tbxCheckAmount
            // 
            this.tbxCheckAmount.Enabled = false;
            this.tbxCheckAmount.Location = new System.Drawing.Point(145, 126);
            this.tbxCheckAmount.Name = "tbxCheckAmount";
            this.tbxCheckAmount.Size = new System.Drawing.Size(121, 26);
            this.tbxCheckAmount.TabIndex = 22;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(59, 129);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(73, 20);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Amount :";
            // 
            // tbxCheckBankID
            // 
            this.tbxCheckBankID.Location = new System.Drawing.Point(145, 81);
            this.tbxCheckBankID.Name = "tbxCheckBankID";
            this.tbxCheckBankID.Size = new System.Drawing.Size(121, 26);
            this.tbxCheckBankID.TabIndex = 20;
            // 
            // lblBankId
            // 
            this.lblBankId.AutoSize = true;
            this.lblBankId.Location = new System.Drawing.Point(57, 84);
            this.lblBankId.Name = "lblBankId";
            this.lblBankId.Size = new System.Drawing.Size(75, 20);
            this.lblBankId.TabIndex = 19;
            this.lblBankId.Text = "Bank ID :";
            // 
            // tbxCheckName
            // 
            this.tbxCheckName.Location = new System.Drawing.Point(145, 37);
            this.tbxCheckName.Name = "tbxCheckName";
            this.tbxCheckName.Size = new System.Drawing.Size(121, 26);
            this.tbxCheckName.TabIndex = 18;
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.Location = new System.Drawing.Point(73, 40);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(59, 20);
            this.lblCheckName.TabIndex = 16;
            this.lblCheckName.Text = "Name :";
            // 
            // gbxCredit
            // 
            this.gbxCredit.Controls.Add(this.cbxCreditType);
            this.gbxCredit.Controls.Add(this.lblType);
            this.gbxCredit.Controls.Add(this.tbxCreditAmount);
            this.gbxCredit.Controls.Add(this.lblCreditAmount);
            this.gbxCredit.Controls.Add(this.tbxCreditDate);
            this.gbxCredit.Controls.Add(this.tbxCreditNumber);
            this.gbxCredit.Controls.Add(this.lblExData);
            this.gbxCredit.Controls.Add(this.lblnumber);
            this.gbxCredit.Location = new System.Drawing.Point(756, 348);
            this.gbxCredit.Name = "gbxCredit";
            this.gbxCredit.Size = new System.Drawing.Size(330, 189);
            this.gbxCredit.TabIndex = 25;
            this.gbxCredit.TabStop = false;
            this.gbxCredit.Text = "Credit";
            // 
            // cbxCreditType
            // 
            this.cbxCreditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCreditType.FormattingEnabled = true;
            this.cbxCreditType.Items.AddRange(new object[] {
            "PayPal",
            "MasterCard"});
            this.cbxCreditType.Location = new System.Drawing.Point(145, 106);
            this.cbxCreditType.Name = "cbxCreditType";
            this.cbxCreditType.Size = new System.Drawing.Size(121, 28);
            this.cbxCreditType.TabIndex = 25;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(58, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(51, 20);
            this.lblType.TabIndex = 24;
            this.lblType.Text = "Type :";
            // 
            // tbxCreditAmount
            // 
            this.tbxCreditAmount.Enabled = false;
            this.tbxCreditAmount.Location = new System.Drawing.Point(145, 147);
            this.tbxCreditAmount.Name = "tbxCreditAmount";
            this.tbxCreditAmount.Size = new System.Drawing.Size(121, 26);
            this.tbxCreditAmount.TabIndex = 23;
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.AutoSize = true;
            this.lblCreditAmount.Location = new System.Drawing.Point(39, 150);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(73, 20);
            this.lblCreditAmount.TabIndex = 22;
            this.lblCreditAmount.Text = "Amount :";
            // 
            // tbxCreditDate
            // 
            this.tbxCreditDate.Location = new System.Drawing.Point(145, 64);
            this.tbxCreditDate.Name = "tbxCreditDate";
            this.tbxCreditDate.Size = new System.Drawing.Size(121, 26);
            this.tbxCreditDate.TabIndex = 3;
            // 
            // tbxCreditNumber
            // 
            this.tbxCreditNumber.Location = new System.Drawing.Point(145, 23);
            this.tbxCreditNumber.Name = "tbxCreditNumber";
            this.tbxCreditNumber.Size = new System.Drawing.Size(121, 26);
            this.tbxCreditNumber.TabIndex = 2;
            // 
            // lblExData
            // 
            this.lblExData.AutoSize = true;
            this.lblExData.Location = new System.Drawing.Point(57, 67);
            this.lblExData.Name = "lblExData";
            this.lblExData.Size = new System.Drawing.Size(52, 20);
            this.lblExData.TabIndex = 1;
            this.lblExData.Text = "Date :";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(36, 24);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(73, 20);
            this.lblnumber.TabIndex = 0;
            this.lblnumber.Text = "Number :";
            // 
            // dgwItem
            // 
            this.dgwItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItem.Location = new System.Drawing.Point(62, 279);
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.ReadOnly = true;
            this.dgwItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwItem.Size = new System.Drawing.Size(666, 258);
            this.dgwItem.TabIndex = 26;
            this.dgwItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwItem_CellClick);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(186, 618);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 27;
            this.dtpDate.Visible = false;
            // 
            // btnGiveanOrder
            // 
            this.btnGiveanOrder.Location = new System.Drawing.Point(589, 558);
            this.btnGiveanOrder.Name = "btnGiveanOrder";
            this.btnGiveanOrder.Size = new System.Drawing.Size(139, 43);
            this.btnGiveanOrder.TabIndex = 28;
            this.btnGiveanOrder.Text = "Give an Order";
            this.btnGiveanOrder.UseVisualStyleBackColor = true;
            this.btnGiveanOrder.Click += new System.EventHandler(this.btnGiveanOrder_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(65, 193);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(69, 20);
            this.lblToplam.TabIndex = 29;
            this.lblToplam.Text = "Toplam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "____________";
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 685);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnGiveanOrder);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.gbxCheck);
            this.Controls.Add(this.dgwItem);
            this.Controls.Add(this.gbxCredit);
            this.Controls.Add(this.gbxCash);
            this.Controls.Add(this.cbxPayType);
            this.Controls.Add(this.lblPayType);
            this.Controls.Add(this.gbxItem);
            this.Controls.Add(this.lbllDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxStatus);
            this.Controls.Add(this.tbxTax);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerUI";
            this.Text = "CustomerUI";
            this.Load += new System.EventHandler(this.CustomerUI_Load);
            this.gbxItem.ResumeLayout(false);
            this.gbxItem.PerformLayout();
            this.gbxCash.ResumeLayout(false);
            this.gbxCash.PerformLayout();
            this.gbxCheck.ResumeLayout(false);
            this.gbxCheck.PerformLayout();
            this.gbxCredit.ResumeLayout(false);
            this.gbxCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxTax;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbllDate;
        private System.Windows.Forms.GroupBox gbxItem;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxShippingWeight;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblShippingWeight;
        private System.Windows.Forms.Label lblPayType;
        private System.Windows.Forms.ComboBox cbxPayType;
        private System.Windows.Forms.Label lblCashTendered;
        private System.Windows.Forms.TextBox tbxCashTendered;
        private System.Windows.Forms.GroupBox gbxCash;
        private System.Windows.Forms.GroupBox gbxCheck;
        private System.Windows.Forms.TextBox tbxCheckAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbxCheckBankID;
        private System.Windows.Forms.Label lblBankId;
        private System.Windows.Forms.TextBox tbxCheckName;
        private System.Windows.Forms.Label lblCheckName;
        private System.Windows.Forms.GroupBox gbxCredit;
        private System.Windows.Forms.TextBox tbxCreditDate;
        private System.Windows.Forms.TextBox tbxCreditNumber;
        private System.Windows.Forms.Label lblExData;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.ComboBox cbxCreditType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbxCreditAmount;
        private System.Windows.Forms.Label lblCreditAmount;
        private System.Windows.Forms.DataGridView dgwItem;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnGiveanOrder;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label2;
    }
}