namespace BeyondBastion
{
    partial class SelectFromListWithAmountDialog
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
            this.MessageBoxTable = new System.Windows.Forms.TableLayoutPanel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.HowManyTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountSelector = new System.Windows.Forms.NumericUpDown();
            this.MessageBoxTable.SuspendLayout();
            this.ButtonTable.SuspendLayout();
            this.HowManyTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageBoxTable
            // 
            this.MessageBoxTable.ColumnCount = 1;
            this.MessageBoxTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MessageBoxTable.Controls.Add(this.MessageLabel, 0, 0);
            this.MessageBoxTable.Controls.Add(this.ListBox, 0, 1);
            this.MessageBoxTable.Controls.Add(this.ButtonTable, 0, 3);
            this.MessageBoxTable.Controls.Add(this.HowManyTable, 0, 2);
            this.MessageBoxTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBoxTable.Location = new System.Drawing.Point(0, 0);
            this.MessageBoxTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MessageBoxTable.Name = "MessageBoxTable";
            this.MessageBoxTable.RowCount = 4;
            this.MessageBoxTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageBoxTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageBoxTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MessageBoxTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.MessageBoxTable.Size = new System.Drawing.Size(528, 490);
            this.MessageBoxTable.TabIndex = 1;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(3, 15);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.MessageLabel.Size = new System.Drawing.Size(522, 36);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Example text for the message box to display of incredibly verbose verbosity for e" +
    "xample\'s sake regarding formatting and text wrapping";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 20;
            this.ListBox.Location = new System.Drawing.Point(15, 69);
            this.ListBox.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(498, 298);
            this.ListBox.TabIndex = 1;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ButtonTable
            // 
            this.ButtonTable.ColumnCount = 2;
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.Controls.Add(this.CancelButton, 1, 0);
            this.ButtonTable.Controls.Add(this.SelectButton, 0, 0);
            this.ButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTable.Location = new System.Drawing.Point(3, 423);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowCount = 1;
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.Size = new System.Drawing.Size(522, 64);
            this.ButtonTable.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.CancelButton.Location = new System.Drawing.Point(316, 15);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(55, 15, 55, 15);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(151, 34);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectButton.Enabled = false;
            this.SelectButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.SelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.SelectButton.Location = new System.Drawing.Point(55, 15);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(55, 15, 55, 15);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(151, 34);
            this.SelectButton.TabIndex = 11;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // HowManyTable
            // 
            this.HowManyTable.ColumnCount = 2;
            this.HowManyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HowManyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HowManyTable.Controls.Add(this.label1, 0, 0);
            this.HowManyTable.Controls.Add(this.AmountSelector, 1, 0);
            this.HowManyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HowManyTable.Location = new System.Drawing.Point(3, 373);
            this.HowManyTable.Name = "HowManyTable";
            this.HowManyTable.RowCount = 1;
            this.HowManyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HowManyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HowManyTable.Size = new System.Drawing.Size(522, 44);
            this.HowManyTable.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountSelector
            // 
            this.AmountSelector.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AmountSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.AmountSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountSelector.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountSelector.ForeColor = System.Drawing.Color.Goldenrod;
            this.AmountSelector.Location = new System.Drawing.Point(276, 9);
            this.AmountSelector.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.AmountSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountSelector.Name = "AmountSelector";
            this.AmountSelector.Size = new System.Drawing.Size(120, 26);
            this.AmountSelector.TabIndex = 1;
            this.AmountSelector.ThousandsSeparator = true;
            this.AmountSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountSelector.ValueChanged += new System.EventHandler(this.AmountSelector_ValueChanged);
            // 
            // SelectFromListWithAmountDialog
            // 
            this.AcceptButton = this.SelectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(528, 490);
            this.ControlBox = false;
            this.Controls.Add(this.MessageBoxTable);
            this.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SelectFromListWithAmountDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectFromListWithAmountDialog_FormClosed);
            this.MessageBoxTable.ResumeLayout(false);
            this.MessageBoxTable.PerformLayout();
            this.ButtonTable.ResumeLayout(false);
            this.HowManyTable.ResumeLayout(false);
            this.HowManyTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MessageBoxTable;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.TableLayoutPanel HowManyTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AmountSelector;
    }
}