namespace BeyondBastion
{
    partial class InventoryWindow
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
            this.InventoryWindowTable = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.InventoryBox = new System.Windows.Forms.GroupBox();
            this.InventoryDetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.InventoryList = new System.Windows.Forms.ListView();
            this.ItemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.ConsumeButton = new System.Windows.Forms.Button();
            this.EquipButton = new System.Windows.Forms.Button();
            this.DetailsBox = new System.Windows.Forms.GroupBox();
            this.ItemDetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemDescriptionLabel = new System.Windows.Forms.Label();
            this.DetailsStatsTable = new System.Windows.Forms.TableLayoutPanel();
            this.Value1 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Value3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Value4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Value5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Value6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Value7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Value8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Value9 = new System.Windows.Forms.Label();
            this.Value10 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.BlessingDescriptionLabel = new System.Windows.Forms.Label();
            this.DestroyButton = new System.Windows.Forms.Button();
            this.InventoryWindowTable.SuspendLayout();
            this.InventoryBox.SuspendLayout();
            this.InventoryDetailsTable.SuspendLayout();
            this.ButtonsTable.SuspendLayout();
            this.DetailsBox.SuspendLayout();
            this.ItemDetailsTable.SuspendLayout();
            this.DetailsStatsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryWindowTable
            // 
            this.InventoryWindowTable.ColumnCount = 1;
            this.InventoryWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InventoryWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InventoryWindowTable.Controls.Add(this.CloseButton, 0, 1);
            this.InventoryWindowTable.Controls.Add(this.InventoryBox, 0, 0);
            this.InventoryWindowTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryWindowTable.Location = new System.Drawing.Point(0, 0);
            this.InventoryWindowTable.Name = "InventoryWindowTable";
            this.InventoryWindowTable.RowCount = 2;
            this.InventoryWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.InventoryWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.InventoryWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InventoryWindowTable.Size = new System.Drawing.Size(869, 700);
            this.InventoryWindowTable.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.CloseButton.Location = new System.Drawing.Point(320, 625);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(320, 30, 320, 30);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(229, 45);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InventoryBox
            // 
            this.InventoryBox.Controls.Add(this.InventoryDetailsTable);
            this.InventoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryBox.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryBox.ForeColor = System.Drawing.Color.White;
            this.InventoryBox.Location = new System.Drawing.Point(3, 3);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.Size = new System.Drawing.Size(863, 589);
            this.InventoryBox.TabIndex = 0;
            this.InventoryBox.TabStop = false;
            this.InventoryBox.Text = "Party Inventory";
            // 
            // InventoryDetailsTable
            // 
            this.InventoryDetailsTable.ColumnCount = 2;
            this.InventoryDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InventoryDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InventoryDetailsTable.Controls.Add(this.InventoryList, 0, 0);
            this.InventoryDetailsTable.Controls.Add(this.DetailsBox, 1, 0);
            this.InventoryDetailsTable.Controls.Add(this.ButtonsTable, 2, 1);
            this.InventoryDetailsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryDetailsTable.Location = new System.Drawing.Point(3, 28);
            this.InventoryDetailsTable.Name = "InventoryDetailsTable";
            this.InventoryDetailsTable.RowCount = 2;
            this.InventoryDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InventoryDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.InventoryDetailsTable.Size = new System.Drawing.Size(857, 558);
            this.InventoryDetailsTable.TabIndex = 0;
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
            this.InventoryList.Location = new System.Drawing.Point(3, 3);
            this.InventoryList.MultiSelect = false;
            this.InventoryList.Name = "InventoryList";
            this.InventoryDetailsTable.SetRowSpan(this.InventoryList, 2);
            this.InventoryList.ShowItemToolTips = true;
            this.InventoryList.Size = new System.Drawing.Size(422, 552);
            this.InventoryList.TabIndex = 0;
            this.InventoryList.UseCompatibleStateImageBehavior = false;
            this.InventoryList.View = System.Windows.Forms.View.Details;
            this.InventoryList.SelectedIndexChanged += new System.EventHandler(this.InventoryList_SelectedIndexChanged);
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
            // ButtonsTable
            // 
            this.ButtonsTable.ColumnCount = 3;
            this.ButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33167F));
            this.ButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33416F));
            this.ButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33417F));
            this.ButtonsTable.Controls.Add(this.DestroyButton, 2, 0);
            this.ButtonsTable.Controls.Add(this.ConsumeButton, 1, 0);
            this.ButtonsTable.Controls.Add(this.EquipButton, 0, 0);
            this.ButtonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsTable.Location = new System.Drawing.Point(431, 491);
            this.ButtonsTable.Name = "ButtonsTable";
            this.ButtonsTable.RowCount = 1;
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsTable.Size = new System.Drawing.Size(423, 64);
            this.ButtonsTable.TabIndex = 1;
            // 
            // ConsumeButton
            // 
            this.ConsumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ConsumeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsumeButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.ConsumeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConsumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsumeButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsumeButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.ConsumeButton.Location = new System.Drawing.Point(150, 10);
            this.ConsumeButton.Margin = new System.Windows.Forms.Padding(10);
            this.ConsumeButton.Name = "ConsumeButton";
            this.ConsumeButton.Size = new System.Drawing.Size(121, 44);
            this.ConsumeButton.TabIndex = 11;
            this.ConsumeButton.Text = "Consume";
            this.ConsumeButton.UseVisualStyleBackColor = false;
            // 
            // EquipButton
            // 
            this.EquipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.EquipButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.EquipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EquipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EquipButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.EquipButton.Location = new System.Drawing.Point(10, 10);
            this.EquipButton.Margin = new System.Windows.Forms.Padding(10);
            this.EquipButton.Name = "EquipButton";
            this.EquipButton.Size = new System.Drawing.Size(120, 44);
            this.EquipButton.TabIndex = 10;
            this.EquipButton.Text = "Equip";
            this.EquipButton.UseVisualStyleBackColor = false;
            this.EquipButton.Click += new System.EventHandler(this.EquipButton_Click);
            // 
            // DetailsBox
            // 
            this.DetailsBox.Controls.Add(this.ItemDetailsTable);
            this.DetailsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsBox.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBox.ForeColor = System.Drawing.Color.White;
            this.DetailsBox.Location = new System.Drawing.Point(431, 3);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(423, 482);
            this.DetailsBox.TabIndex = 2;
            this.DetailsBox.TabStop = false;
            this.DetailsBox.Text = "Details";
            // 
            // ItemDetailsTable
            // 
            this.ItemDetailsTable.ColumnCount = 1;
            this.ItemDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemDetailsTable.Controls.Add(this.ItemDescriptionLabel, 0, 1);
            this.ItemDetailsTable.Controls.Add(this.ItemNameLabel, 0, 0);
            this.ItemDetailsTable.Controls.Add(this.DetailsStatsTable, 0, 2);
            this.ItemDetailsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDetailsTable.Location = new System.Drawing.Point(3, 22);
            this.ItemDetailsTable.Name = "ItemDetailsTable";
            this.ItemDetailsTable.RowCount = 3;
            this.ItemDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ItemDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ItemDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ItemDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemDetailsTable.Size = new System.Drawing.Size(417, 457);
            this.ItemDetailsTable.TabIndex = 0;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(411, 20);
            this.ItemNameLabel.TabIndex = 1;
            this.ItemNameLabel.Text = "Name of Item";
            this.ItemNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ItemDescriptionLabel
            // 
            this.ItemDescriptionLabel.AutoSize = true;
            this.ItemDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDescriptionLabel.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionLabel.Location = new System.Drawing.Point(3, 20);
            this.ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            this.ItemDescriptionLabel.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.ItemDescriptionLabel.Size = new System.Drawing.Size(411, 61);
            this.ItemDescriptionLabel.TabIndex = 0;
            this.ItemDescriptionLabel.Text = "This is a lore-heavy description of the item, that is, the item which the player " +
    "selected through the menu on the right. This text isn\'t real text, though.";
            this.ItemDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailsStatsTable
            // 
            this.DetailsStatsTable.ColumnCount = 2;
            this.DetailsStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailsStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailsStatsTable.Controls.Add(this.BlessingDescriptionLabel, 0, 10);
            this.DetailsStatsTable.Controls.Add(this.Label10, 0, 9);
            this.DetailsStatsTable.Controls.Add(this.Value10, 0, 9);
            this.DetailsStatsTable.Controls.Add(this.Value9, 1, 8);
            this.DetailsStatsTable.Controls.Add(this.Label9, 0, 8);
            this.DetailsStatsTable.Controls.Add(this.Value8, 1, 7);
            this.DetailsStatsTable.Controls.Add(this.Label8, 0, 7);
            this.DetailsStatsTable.Controls.Add(this.Value7, 1, 6);
            this.DetailsStatsTable.Controls.Add(this.Label7, 0, 6);
            this.DetailsStatsTable.Controls.Add(this.Value6, 1, 5);
            this.DetailsStatsTable.Controls.Add(this.Label6, 0, 5);
            this.DetailsStatsTable.Controls.Add(this.Value5, 1, 4);
            this.DetailsStatsTable.Controls.Add(this.Label5, 0, 4);
            this.DetailsStatsTable.Controls.Add(this.Value4, 1, 3);
            this.DetailsStatsTable.Controls.Add(this.Label4, 0, 3);
            this.DetailsStatsTable.Controls.Add(this.Value3, 1, 2);
            this.DetailsStatsTable.Controls.Add(this.Label3, 0, 2);
            this.DetailsStatsTable.Controls.Add(this.Value2, 1, 1);
            this.DetailsStatsTable.Controls.Add(this.Label2, 0, 1);
            this.DetailsStatsTable.Controls.Add(this.Label1, 0, 0);
            this.DetailsStatsTable.Controls.Add(this.Value1, 1, 0);
            this.DetailsStatsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailsStatsTable.Location = new System.Drawing.Point(3, 84);
            this.DetailsStatsTable.Name = "DetailsStatsTable";
            this.DetailsStatsTable.RowCount = 11;
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DetailsStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DetailsStatsTable.Size = new System.Drawing.Size(411, 370);
            this.DetailsStatsTable.TabIndex = 2;
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value1.Location = new System.Drawing.Point(208, 0);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(200, 18);
            this.Value1.TabIndex = 0;
            this.Value1.Text = "Value1";
            this.Value1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(199, 18);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Label1";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(3, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(199, 18);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Label2";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value2.Location = new System.Drawing.Point(208, 18);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(200, 18);
            this.Value2.TabIndex = 3;
            this.Value2.Text = "Value2";
            this.Value2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(3, 36);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(199, 18);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Label3";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value3
            // 
            this.Value3.AutoSize = true;
            this.Value3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value3.Location = new System.Drawing.Point(208, 36);
            this.Value3.Name = "Value3";
            this.Value3.Size = new System.Drawing.Size(200, 18);
            this.Value3.TabIndex = 5;
            this.Value3.Text = "Value3";
            this.Value3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(3, 54);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(199, 18);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Label4";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value4
            // 
            this.Value4.AutoSize = true;
            this.Value4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value4.Location = new System.Drawing.Point(208, 54);
            this.Value4.Name = "Value4";
            this.Value4.Size = new System.Drawing.Size(200, 18);
            this.Value4.TabIndex = 7;
            this.Value4.Text = "Value4";
            this.Value4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(3, 72);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(199, 18);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Label5";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value5
            // 
            this.Value5.AutoSize = true;
            this.Value5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value5.Location = new System.Drawing.Point(208, 72);
            this.Value5.Name = "Value5";
            this.Value5.Size = new System.Drawing.Size(200, 18);
            this.Value5.TabIndex = 9;
            this.Value5.Text = "Value5";
            this.Value5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(3, 90);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(199, 18);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Label6";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value6
            // 
            this.Value6.AutoSize = true;
            this.Value6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value6.Location = new System.Drawing.Point(208, 90);
            this.Value6.Name = "Value6";
            this.Value6.Size = new System.Drawing.Size(200, 18);
            this.Value6.TabIndex = 11;
            this.Value6.Text = "Value6";
            this.Value6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(3, 108);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(199, 18);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Label7";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value7
            // 
            this.Value7.AutoSize = true;
            this.Value7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value7.Location = new System.Drawing.Point(208, 108);
            this.Value7.Name = "Value7";
            this.Value7.Size = new System.Drawing.Size(200, 18);
            this.Value7.TabIndex = 13;
            this.Value7.Text = "Value7";
            this.Value7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label8.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(3, 126);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(199, 18);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Label8";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value8
            // 
            this.Value8.AutoSize = true;
            this.Value8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value8.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value8.Location = new System.Drawing.Point(208, 126);
            this.Value8.Name = "Value8";
            this.Value8.Size = new System.Drawing.Size(200, 18);
            this.Value8.TabIndex = 15;
            this.Value8.Text = "Value8";
            this.Value8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label9.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(3, 144);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(199, 18);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "Label9";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value9
            // 
            this.Value9.AutoSize = true;
            this.Value9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value9.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value9.Location = new System.Drawing.Point(208, 144);
            this.Value9.Name = "Value9";
            this.Value9.Size = new System.Drawing.Size(200, 18);
            this.Value9.TabIndex = 17;
            this.Value9.Text = "Value9";
            this.Value9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Value10
            // 
            this.Value10.AutoSize = true;
            this.Value10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value10.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value10.Location = new System.Drawing.Point(208, 162);
            this.Value10.Name = "Value10";
            this.Value10.Size = new System.Drawing.Size(200, 20);
            this.Value10.TabIndex = 18;
            this.Value10.Text = "Value10";
            this.Value10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label10.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(3, 162);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(199, 20);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Label10";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BlessingDescriptionLabel
            // 
            this.BlessingDescriptionLabel.AutoSize = true;
            this.DetailsStatsTable.SetColumnSpan(this.BlessingDescriptionLabel, 2);
            this.BlessingDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlessingDescriptionLabel.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlessingDescriptionLabel.Location = new System.Drawing.Point(3, 182);
            this.BlessingDescriptionLabel.Name = "BlessingDescriptionLabel";
            this.BlessingDescriptionLabel.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BlessingDescriptionLabel.Size = new System.Drawing.Size(405, 188);
            this.BlessingDescriptionLabel.TabIndex = 20;
            this.BlessingDescriptionLabel.Text = "This describes in detail the effects of the Blessings upon this piece of equipmen" +
    "t";
            this.BlessingDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DestroyButton
            // 
            this.DestroyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DestroyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DestroyButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.DestroyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DestroyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DestroyButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestroyButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.DestroyButton.Location = new System.Drawing.Point(291, 10);
            this.DestroyButton.Margin = new System.Windows.Forms.Padding(10);
            this.DestroyButton.Name = "DestroyButton";
            this.DestroyButton.Size = new System.Drawing.Size(122, 44);
            this.DestroyButton.TabIndex = 12;
            this.DestroyButton.Text = "Destroy";
            this.DestroyButton.UseVisualStyleBackColor = false;
            // 
            // InventoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(869, 700);
            this.ControlBox = false;
            this.Controls.Add(this.InventoryWindowTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InventoryWindow_Load);
            this.InventoryWindowTable.ResumeLayout(false);
            this.InventoryBox.ResumeLayout(false);
            this.InventoryDetailsTable.ResumeLayout(false);
            this.ButtonsTable.ResumeLayout(false);
            this.DetailsBox.ResumeLayout(false);
            this.ItemDetailsTable.ResumeLayout(false);
            this.ItemDetailsTable.PerformLayout();
            this.DetailsStatsTable.ResumeLayout(false);
            this.DetailsStatsTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel InventoryWindowTable;
        private System.Windows.Forms.GroupBox InventoryBox;
        private System.Windows.Forms.TableLayoutPanel InventoryDetailsTable;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView InventoryList;
        private System.Windows.Forms.ColumnHeader ItemColumn;
        private System.Windows.Forms.ColumnHeader QuantityColumn;
        private System.Windows.Forms.ColumnHeader WeightColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.TableLayoutPanel ButtonsTable;
        private System.Windows.Forms.Button EquipButton;
        private System.Windows.Forms.Button ConsumeButton;
        private System.Windows.Forms.GroupBox DetailsBox;
        private System.Windows.Forms.TableLayoutPanel ItemDetailsTable;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemDescriptionLabel;
        private System.Windows.Forms.TableLayoutPanel DetailsStatsTable;
        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Value9;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Value8;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Value7;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Value6;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Value5;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Value4;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Value3;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Value2;
        private System.Windows.Forms.Label Value10;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label BlessingDescriptionLabel;
        private System.Windows.Forms.Button DestroyButton;
    }
}