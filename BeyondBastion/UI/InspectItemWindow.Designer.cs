namespace BeyondBastion.UI
{
    partial class InspectItemWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsBox = new System.Windows.Forms.GroupBox();
            this.ItemDetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.ItemDescriptionLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.DetailsStatsTable = new System.Windows.Forms.TableLayoutPanel();
            this.BlessingDescriptionLabel = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Value10 = new System.Windows.Forms.Label();
            this.Value9 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Value8 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Value7 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Value6 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Value5 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Value4 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Value3 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Value1 = new System.Windows.Forms.Label();
            this.ItemQualityLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.DetailsBox.SuspendLayout();
            this.ItemDetailsTable.SuspendLayout();
            this.DetailsStatsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CloseButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DetailsBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.69725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30275F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 654);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DetailsBox
            // 
            this.DetailsBox.Controls.Add(this.ItemDetailsTable);
            this.DetailsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsBox.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBox.ForeColor = System.Drawing.Color.White;
            this.DetailsBox.Location = new System.Drawing.Point(3, 3);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(615, 561);
            this.DetailsBox.TabIndex = 4;
            this.DetailsBox.TabStop = false;
            this.DetailsBox.Text = "Details";
            // 
            // ItemDetailsTable
            // 
            this.ItemDetailsTable.ColumnCount = 1;
            this.ItemDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemDetailsTable.Controls.Add(this.ItemDescriptionLabel, 0, 2);
            this.ItemDetailsTable.Controls.Add(this.ItemNameLabel, 0, 0);
            this.ItemDetailsTable.Controls.Add(this.DetailsStatsTable, 0, 3);
            this.ItemDetailsTable.Controls.Add(this.ItemQualityLabel, 0, 1);
            this.ItemDetailsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDetailsTable.Location = new System.Drawing.Point(3, 26);
            this.ItemDetailsTable.Name = "ItemDetailsTable";
            this.ItemDetailsTable.RowCount = 4;
            this.ItemDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ItemDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ItemDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ItemDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemDetailsTable.Size = new System.Drawing.Size(609, 532);
            this.ItemDetailsTable.TabIndex = 0;
            // 
            // ItemDescriptionLabel
            // 
            this.ItemDescriptionLabel.AutoSize = true;
            this.ItemDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDescriptionLabel.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionLabel.Location = new System.Drawing.Point(3, 40);
            this.ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            this.ItemDescriptionLabel.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.ItemDescriptionLabel.Size = new System.Drawing.Size(603, 46);
            this.ItemDescriptionLabel.TabIndex = 0;
            this.ItemDescriptionLabel.Text = "This is a lore-heavy description of the item, that is, the item which the player " +
    "selected through the menu on the right. This text isn\'t real text, though.";
            this.ItemDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemNameLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(603, 20);
            this.ItemNameLabel.TabIndex = 1;
            this.ItemNameLabel.Text = "Name of Item";
            this.ItemNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.DetailsStatsTable.Location = new System.Drawing.Point(3, 89);
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
            this.DetailsStatsTable.Size = new System.Drawing.Size(603, 370);
            this.DetailsStatsTable.TabIndex = 2;
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
            this.BlessingDescriptionLabel.Size = new System.Drawing.Size(597, 188);
            this.BlessingDescriptionLabel.TabIndex = 20;
            this.BlessingDescriptionLabel.Text = "This describes in detail the effects of the Blessings upon this piece of equipmen" +
    "t";
            this.BlessingDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label10.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(3, 162);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(295, 20);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Label10";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value10
            // 
            this.Value10.AutoSize = true;
            this.Value10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value10.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value10.Location = new System.Drawing.Point(304, 162);
            this.Value10.Name = "Value10";
            this.Value10.Size = new System.Drawing.Size(296, 20);
            this.Value10.TabIndex = 18;
            this.Value10.Text = "Value10";
            this.Value10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Value9
            // 
            this.Value9.AutoSize = true;
            this.Value9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value9.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value9.Location = new System.Drawing.Point(304, 144);
            this.Value9.Name = "Value9";
            this.Value9.Size = new System.Drawing.Size(296, 18);
            this.Value9.TabIndex = 17;
            this.Value9.Text = "Value9";
            this.Value9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label9.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(3, 144);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(295, 18);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "Label9";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value8
            // 
            this.Value8.AutoSize = true;
            this.Value8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value8.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value8.Location = new System.Drawing.Point(304, 126);
            this.Value8.Name = "Value8";
            this.Value8.Size = new System.Drawing.Size(296, 18);
            this.Value8.TabIndex = 15;
            this.Value8.Text = "Value8";
            this.Value8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label8.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(3, 126);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(295, 18);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Label8";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value7
            // 
            this.Value7.AutoSize = true;
            this.Value7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value7.Location = new System.Drawing.Point(304, 108);
            this.Value7.Name = "Value7";
            this.Value7.Size = new System.Drawing.Size(296, 18);
            this.Value7.TabIndex = 13;
            this.Value7.Text = "Value7";
            this.Value7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(3, 108);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(295, 18);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Label7";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value6
            // 
            this.Value6.AutoSize = true;
            this.Value6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value6.Location = new System.Drawing.Point(304, 90);
            this.Value6.Name = "Value6";
            this.Value6.Size = new System.Drawing.Size(296, 18);
            this.Value6.TabIndex = 11;
            this.Value6.Text = "Value6";
            this.Value6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(3, 90);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(295, 18);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Label6";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value5
            // 
            this.Value5.AutoSize = true;
            this.Value5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value5.Location = new System.Drawing.Point(304, 72);
            this.Value5.Name = "Value5";
            this.Value5.Size = new System.Drawing.Size(296, 18);
            this.Value5.TabIndex = 9;
            this.Value5.Text = "Value5";
            this.Value5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(3, 72);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(295, 18);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Label5";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value4
            // 
            this.Value4.AutoSize = true;
            this.Value4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value4.Location = new System.Drawing.Point(304, 54);
            this.Value4.Name = "Value4";
            this.Value4.Size = new System.Drawing.Size(296, 18);
            this.Value4.TabIndex = 7;
            this.Value4.Text = "Value4";
            this.Value4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(3, 54);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(295, 18);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Label4";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value3
            // 
            this.Value3.AutoSize = true;
            this.Value3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value3.Location = new System.Drawing.Point(304, 36);
            this.Value3.Name = "Value3";
            this.Value3.Size = new System.Drawing.Size(296, 18);
            this.Value3.TabIndex = 5;
            this.Value3.Text = "Value3";
            this.Value3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(3, 36);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(295, 18);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Label3";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value2.Location = new System.Drawing.Point(304, 18);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(296, 18);
            this.Value2.TabIndex = 3;
            this.Value2.Text = "Value2";
            this.Value2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(3, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(295, 18);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Label2";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(295, 18);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Label1";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value1.Location = new System.Drawing.Point(304, 0);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(296, 18);
            this.Value1.TabIndex = 0;
            this.Value1.Text = "Value1";
            this.Value1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemQualityLabel
            // 
            this.ItemQualityLabel.AutoSize = true;
            this.ItemQualityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemQualityLabel.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.ItemQualityLabel.Location = new System.Drawing.Point(3, 20);
            this.ItemQualityLabel.Name = "ItemQualityLabel";
            this.ItemQualityLabel.Size = new System.Drawing.Size(603, 20);
            this.ItemQualityLabel.TabIndex = 3;
            this.ItemQualityLabel.Text = "Quality";
            this.ItemQualityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CloseButton.Location = new System.Drawing.Point(200, 587);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(200, 20, 200, 20);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(221, 47);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InspectItemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(621, 654);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InspectItemWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.DetailsBox.ResumeLayout(false);
            this.ItemDetailsTable.ResumeLayout(false);
            this.ItemDetailsTable.PerformLayout();
            this.DetailsStatsTable.ResumeLayout(false);
            this.DetailsStatsTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox DetailsBox;
        private System.Windows.Forms.TableLayoutPanel ItemDetailsTable;
        private System.Windows.Forms.Label ItemDescriptionLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TableLayoutPanel DetailsStatsTable;
        private System.Windows.Forms.Label BlessingDescriptionLabel;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Value10;
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
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Label ItemQualityLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}