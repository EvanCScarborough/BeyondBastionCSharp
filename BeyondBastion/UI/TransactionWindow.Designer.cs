namespace BeyondBastion.UI
{
    partial class TransactionWindow
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
            this.WindowLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SellerBox = new System.Windows.Forms.GroupBox();
            this.SellerInventoryBox = new System.Windows.Forms.ListView();
            this.ItemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BuyerBox = new System.Windows.Forms.GroupBox();
            this.BuyerInventoryBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SwapButton = new System.Windows.Forms.Button();
            this.InspectButton = new System.Windows.Forms.Button();
            this.GirnLabel = new System.Windows.Forms.Label();
            this.WindowLayoutTable.SuspendLayout();
            this.ButtonTable.SuspendLayout();
            this.TitleBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SellerBox.SuspendLayout();
            this.BuyerBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowLayoutTable
            // 
            this.WindowLayoutTable.ColumnCount = 1;
            this.WindowLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WindowLayoutTable.Controls.Add(this.ButtonTable, 0, 1);
            this.WindowLayoutTable.Controls.Add(this.TitleBox, 0, 0);
            this.WindowLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.WindowLayoutTable.Name = "WindowLayoutTable";
            this.WindowLayoutTable.RowCount = 2;
            this.WindowLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WindowLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.WindowLayoutTable.Size = new System.Drawing.Size(1136, 664);
            this.WindowLayoutTable.TabIndex = 0;
            // 
            // ButtonTable
            // 
            this.ButtonTable.ColumnCount = 2;
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.Controls.Add(this.AcceptButton, 1, 0);
            this.ButtonTable.Controls.Add(this.CancelButton, 0, 0);
            this.ButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTable.Location = new System.Drawing.Point(3, 577);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowCount = 1;
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonTable.Size = new System.Drawing.Size(1130, 84);
            this.ButtonTable.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.CancelButton.Location = new System.Drawing.Point(90, 22);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(90, 22, 90, 22);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(385, 40);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.AcceptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.AcceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.AcceptButton.Location = new System.Drawing.Point(655, 22);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(90, 22, 90, 22);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(385, 40);
            this.AcceptButton.TabIndex = 9;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = false;
            // 
            // TitleBox
            // 
            this.TitleBox.Controls.Add(this.tableLayoutPanel1);
            this.TitleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleBox.Font = new System.Drawing.Font("Felix Titling", 16F);
            this.TitleBox.ForeColor = System.Drawing.Color.White;
            this.TitleBox.Location = new System.Drawing.Point(3, 3);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(1130, 568);
            this.TitleBox.TabIndex = 1;
            this.TitleBox.TabStop = false;
            this.TitleBox.Text = "Window Title";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.51864F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.96272F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.51864F));
            this.tableLayoutPanel1.Controls.Add(this.BuyerBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SellerBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1124, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SellerBox
            // 
            this.SellerBox.Controls.Add(this.SellerInventoryBox);
            this.SellerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellerBox.Font = new System.Drawing.Font("Bookman Old Style", 16F);
            this.SellerBox.ForeColor = System.Drawing.Color.White;
            this.SellerBox.Location = new System.Drawing.Point(3, 3);
            this.SellerBox.Name = "SellerBox";
            this.SellerBox.Size = new System.Drawing.Size(449, 531);
            this.SellerBox.TabIndex = 0;
            this.SellerBox.TabStop = false;
            this.SellerBox.Text = "Seller";
            // 
            // SellerInventoryBox
            // 
            this.SellerInventoryBox.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.SellerInventoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SellerInventoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SellerInventoryBox.CausesValidation = false;
            this.SellerInventoryBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemColumn,
            this.QuantityColumn,
            this.WeightColumn,
            this.ValueColumn});
            this.SellerInventoryBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SellerInventoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellerInventoryBox.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerInventoryBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.SellerInventoryBox.FullRowSelect = true;
            this.SellerInventoryBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SellerInventoryBox.HideSelection = false;
            this.SellerInventoryBox.LabelWrap = false;
            this.SellerInventoryBox.Location = new System.Drawing.Point(3, 29);
            this.SellerInventoryBox.MultiSelect = false;
            this.SellerInventoryBox.Name = "SellerInventoryBox";
            this.SellerInventoryBox.ShowItemToolTips = true;
            this.SellerInventoryBox.Size = new System.Drawing.Size(443, 499);
            this.SellerInventoryBox.TabIndex = 1;
            this.SellerInventoryBox.UseCompatibleStateImageBehavior = false;
            this.SellerInventoryBox.View = System.Windows.Forms.View.Details;
            this.SellerInventoryBox.SelectedIndexChanged += new System.EventHandler(this.SellerInventoryBox_SelectedIndexChanged);
            // 
            // ItemColumn
            // 
            this.ItemColumn.Text = "Item";
            this.ItemColumn.Width = 240;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.Text = "Quantity";
            this.QuantityColumn.Width = 70;
            // 
            // WeightColumn
            // 
            this.WeightColumn.Text = "Weight";
            // 
            // ValueColumn
            // 
            this.ValueColumn.Text = "Value";
            this.ValueColumn.Width = 50;
            // 
            // BuyerBox
            // 
            this.BuyerBox.Controls.Add(this.BuyerInventoryBox);
            this.BuyerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuyerBox.Font = new System.Drawing.Font("Bookman Old Style", 16F);
            this.BuyerBox.ForeColor = System.Drawing.Color.White;
            this.BuyerBox.Location = new System.Drawing.Point(671, 3);
            this.BuyerBox.Name = "BuyerBox";
            this.BuyerBox.Size = new System.Drawing.Size(450, 531);
            this.BuyerBox.TabIndex = 1;
            this.BuyerBox.TabStop = false;
            this.BuyerBox.Text = "Buyer";
            // 
            // BuyerInventoryBox
            // 
            this.BuyerInventoryBox.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.BuyerInventoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BuyerInventoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuyerInventoryBox.CausesValidation = false;
            this.BuyerInventoryBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.BuyerInventoryBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.BuyerInventoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuyerInventoryBox.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyerInventoryBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.BuyerInventoryBox.FullRowSelect = true;
            this.BuyerInventoryBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.BuyerInventoryBox.HideSelection = false;
            this.BuyerInventoryBox.LabelWrap = false;
            this.BuyerInventoryBox.Location = new System.Drawing.Point(3, 29);
            this.BuyerInventoryBox.MultiSelect = false;
            this.BuyerInventoryBox.Name = "BuyerInventoryBox";
            this.BuyerInventoryBox.ShowItemToolTips = true;
            this.BuyerInventoryBox.Size = new System.Drawing.Size(444, 499);
            this.BuyerInventoryBox.TabIndex = 1;
            this.BuyerInventoryBox.UseCompatibleStateImageBehavior = false;
            this.BuyerInventoryBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Weight";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 50;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.InspectButton, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.SwapButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.GirnLabel, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(458, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(207, 531);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // SwapButton
            // 
            this.SwapButton.AutoSize = true;
            this.SwapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SwapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwapButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.SwapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwapButton.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.SwapButton.Location = new System.Drawing.Point(55, 191);
            this.SwapButton.Margin = new System.Windows.Forms.Padding(55, 15, 55, 15);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.SwapButton.Size = new System.Drawing.Size(97, 58);
            this.SwapButton.TabIndex = 11;
            this.SwapButton.Text = "⇄";
            this.SwapButton.UseVisualStyleBackColor = false;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // InspectButton
            // 
            this.InspectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.InspectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.InspectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InspectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InspectButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspectButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.InspectButton.Location = new System.Drawing.Point(55, 465);
            this.InspectButton.Margin = new System.Windows.Forms.Padding(55, 25, 55, 25);
            this.InspectButton.Name = "InspectButton";
            this.InspectButton.Size = new System.Drawing.Size(97, 41);
            this.InspectButton.TabIndex = 12;
            this.InspectButton.Text = "Inspect";
            this.InspectButton.UseVisualStyleBackColor = false;
            this.InspectButton.Click += new System.EventHandler(this.InspectButton_Click);
            // 
            // GirnLabel
            // 
            this.GirnLabel.AutoSize = true;
            this.GirnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GirnLabel.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.GirnLabel.Location = new System.Drawing.Point(3, 264);
            this.GirnLabel.Name = "GirnLabel";
            this.tableLayoutPanel2.SetRowSpan(this.GirnLabel, 2);
            this.GirnLabel.Size = new System.Drawing.Size(201, 176);
            this.GirnLabel.TabIndex = 13;
            this.GirnLabel.Text = "Buying: -100gr\r\nSelling: +50gr\r\n\r\nTotal: -50gr";
            this.GirnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1136, 664);
            this.ControlBox = false;
            this.Controls.Add(this.WindowLayoutTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TransactionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowLayoutTable.ResumeLayout(false);
            this.ButtonTable.ResumeLayout(false);
            this.TitleBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SellerBox.ResumeLayout(false);
            this.BuyerBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel WindowLayoutTable;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox TitleBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox SellerBox;
        private System.Windows.Forms.GroupBox BuyerBox;
        private System.Windows.Forms.ListView BuyerInventoryBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView SellerInventoryBox;
        private System.Windows.Forms.ColumnHeader ItemColumn;
        private System.Windows.Forms.ColumnHeader QuantityColumn;
        private System.Windows.Forms.ColumnHeader WeightColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button InspectButton;
        private System.Windows.Forms.Button SwapButton;
        private System.Windows.Forms.Label GirnLabel;
    }
}