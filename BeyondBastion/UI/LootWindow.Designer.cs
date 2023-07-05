namespace BeyondBastion.UI
{
    partial class LootWindow
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
            this.PartyMember1InspectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.InventoryList = new System.Windows.Forms.ListView();
            this.ItemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InspectButton = new System.Windows.Forms.Button();
            this.TakeReturnAllButton = new System.Windows.Forms.Button();
            this.TakeReturnOneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TakeLabel = new System.Windows.Forms.Label();
            this.WindowLayoutTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowLayoutTable
            // 
            this.WindowLayoutTable.ColumnCount = 1;
            this.WindowLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WindowLayoutTable.Controls.Add(this.PartyMember1InspectButton, 0, 1);
            this.WindowLayoutTable.Controls.Add(this.groupBox1, 0, 0);
            this.WindowLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.WindowLayoutTable.Name = "WindowLayoutTable";
            this.WindowLayoutTable.RowCount = 2;
            this.WindowLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.WindowLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.WindowLayoutTable.Size = new System.Drawing.Size(1336, 925);
            this.WindowLayoutTable.TabIndex = 0;
            // 
            // PartyMember1InspectButton
            // 
            this.PartyMember1InspectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PartyMember1InspectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartyMember1InspectButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.PartyMember1InspectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PartyMember1InspectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PartyMember1InspectButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyMember1InspectButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.PartyMember1InspectButton.Location = new System.Drawing.Point(240, 810);
            this.PartyMember1InspectButton.Margin = new System.Windows.Forms.Padding(240, 40, 240, 40);
            this.PartyMember1InspectButton.Name = "PartyMember1InspectButton";
            this.PartyMember1InspectButton.Size = new System.Drawing.Size(856, 75);
            this.PartyMember1InspectButton.TabIndex = 7;
            this.PartyMember1InspectButton.Text = "Accept";
            this.PartyMember1InspectButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Felix Titling", 18F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1330, 764);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.TakeLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TakeReturnOneButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TakeReturnAllButton, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.InspectButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.listView1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.InventoryList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1324, 715);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // InventoryList
            // 
            this.InventoryList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.InventoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.InventoryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemColumn,
            this.QuantityColumn,
            this.WeightColumn,
            this.ValueColumn});
            this.InventoryList.Cursor = System.Windows.Forms.Cursors.Default;
            this.InventoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryList.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryList.ForeColor = System.Drawing.Color.Goldenrod;
            this.InventoryList.FullRowSelect = true;
            this.InventoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.InventoryList.HideSelection = false;
            this.InventoryList.LabelWrap = false;
            this.InventoryList.Location = new System.Drawing.Point(4, 47);
            this.InventoryList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InventoryList.MultiSelect = false;
            this.InventoryList.Name = "InventoryList";
            this.tableLayoutPanel2.SetRowSpan(this.InventoryList, 4);
            this.InventoryList.ShowItemToolTips = true;
            this.InventoryList.Size = new System.Drawing.Size(521, 663);
            this.InventoryList.TabIndex = 1;
            this.InventoryList.UseCompatibleStateImageBehavior = false;
            this.InventoryList.View = System.Windows.Forms.View.Details;
            // 
            // ItemColumn
            // 
            this.ItemColumn.Text = "Item";
            this.ItemColumn.Width = 240;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.Text = "Quantity";
            this.QuantityColumn.Width = 111;
            // 
            // WeightColumn
            // 
            this.WeightColumn.Text = "Weight";
            this.WeightColumn.Width = 95;
            // 
            // ValueColumn
            // 
            this.ValueColumn.Text = "Value";
            this.ValueColumn.Width = 72;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Goldenrod;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(797, 47);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.tableLayoutPanel2.SetRowSpan(this.listView1, 4);
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(523, 663);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // InspectButton
            // 
            this.InspectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.InspectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.InspectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InspectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InspectButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspectButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.InspectButton.Location = new System.Drawing.Point(564, 601);
            this.InspectButton.Margin = new System.Windows.Forms.Padding(35, 55, 35, 55);
            this.InspectButton.Name = "InspectButton";
            this.InspectButton.Size = new System.Drawing.Size(194, 59);
            this.InspectButton.TabIndex = 8;
            this.InspectButton.Text = "Inspect";
            this.InspectButton.UseVisualStyleBackColor = false;
            // 
            // TakeReturnAllButton
            // 
            this.TakeReturnAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TakeReturnAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TakeReturnAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.TakeReturnAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TakeReturnAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeReturnAllButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeReturnAllButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.TakeReturnAllButton.Location = new System.Drawing.Point(564, 388);
            this.TakeReturnAllButton.Margin = new System.Windows.Forms.Padding(35, 10, 35, 100);
            this.TakeReturnAllButton.Name = "TakeReturnAllButton";
            this.TakeReturnAllButton.Size = new System.Drawing.Size(194, 58);
            this.TakeReturnAllButton.TabIndex = 9;
            this.TakeReturnAllButton.Text = "TakeReturnAll";
            this.TakeReturnAllButton.UseVisualStyleBackColor = false;
            // 
            // TakeReturnOneButton
            // 
            this.TakeReturnOneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TakeReturnOneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TakeReturnOneButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.TakeReturnOneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TakeReturnOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeReturnOneButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeReturnOneButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.TakeReturnOneButton.Location = new System.Drawing.Point(564, 265);
            this.TakeReturnOneButton.Margin = new System.Windows.Forms.Padding(35, 55, 35, 55);
            this.TakeReturnOneButton.Name = "TakeReturnOneButton";
            this.TakeReturnOneButton.Size = new System.Drawing.Size(194, 58);
            this.TakeReturnOneButton.TabIndex = 10;
            this.TakeReturnOneButton.Text = "TakeReturnOne";
            this.TakeReturnOneButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Leave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TakeLabel
            // 
            this.TakeLabel.AutoSize = true;
            this.TakeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TakeLabel.Location = new System.Drawing.Point(796, 0);
            this.TakeLabel.Name = "TakeLabel";
            this.TakeLabel.Size = new System.Drawing.Size(525, 42);
            this.TakeLabel.TabIndex = 12;
            this.TakeLabel.Text = "Take";
            this.TakeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LootWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1336, 925);
            this.ControlBox = false;
            this.Controls.Add(this.WindowLayoutTable);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LootWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowLayoutTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel WindowLayoutTable;
        private System.Windows.Forms.Button PartyMember1InspectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button TakeReturnOneButton;
        private System.Windows.Forms.Button TakeReturnAllButton;
        private System.Windows.Forms.Button InspectButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView InventoryList;
        private System.Windows.Forms.ColumnHeader ItemColumn;
        private System.Windows.Forms.ColumnHeader QuantityColumn;
        private System.Windows.Forms.ColumnHeader WeightColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.Label TakeLabel;
        private System.Windows.Forms.Label label1;
    }
}