namespace BeyondBastion
{
    partial class YesNoDialog
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
            this.MessageButtonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.MessageButtonsTable.SuspendLayout();
            this.ButtonTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageButtonsTable
            // 
            this.MessageButtonsTable.ColumnCount = 1;
            this.MessageButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MessageButtonsTable.Controls.Add(this.MessageLabel, 0, 0);
            this.MessageButtonsTable.Controls.Add(this.ButtonTable, 0, 1);
            this.MessageButtonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageButtonsTable.Location = new System.Drawing.Point(0, 0);
            this.MessageButtonsTable.Name = "MessageButtonsTable";
            this.MessageButtonsTable.RowCount = 2;
            this.MessageButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MessageButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.MessageButtonsTable.Size = new System.Drawing.Size(462, 183);
            this.MessageButtonsTable.TabIndex = 0;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(3, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.MessageLabel.Size = new System.Drawing.Size(456, 113);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "An example of a yes or no question to be answered by the player using the buttons" +
    " below.";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonTable
            // 
            this.ButtonTable.ColumnCount = 2;
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.Controls.Add(this.NoButton, 0, 0);
            this.ButtonTable.Controls.Add(this.YesButton, 0, 0);
            this.ButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTable.Location = new System.Drawing.Point(3, 116);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowCount = 1;
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.Size = new System.Drawing.Size(456, 64);
            this.ButtonTable.TabIndex = 1;
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.NoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.NoButton.Location = new System.Drawing.Point(253, 15);
            this.NoButton.Margin = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(178, 34);
            this.NoButton.TabIndex = 13;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.YesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YesButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.YesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.YesButton.Location = new System.Drawing.Point(25, 15);
            this.YesButton.Margin = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(178, 34);
            this.YesButton.TabIndex = 12;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // YesNoDialog
            // 
            this.AcceptButton = this.YesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CancelButton = this.NoButton;
            this.ClientSize = new System.Drawing.Size(462, 183);
            this.ControlBox = false;
            this.Controls.Add(this.MessageButtonsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "YesNoDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.MessageButtonsTable.ResumeLayout(false);
            this.MessageButtonsTable.PerformLayout();
            this.ButtonTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MessageButtonsTable;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
    }
}