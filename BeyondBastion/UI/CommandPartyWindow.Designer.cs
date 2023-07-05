namespace BeyondBastion.UI
{
    partial class CommandPartyWindow
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
            this.CommandButtonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CommandPartyBox = new System.Windows.Forms.GroupBox();
            this.ActionsOptionsTable = new System.Windows.Forms.TableLayoutPanel();
            this.ActionsListView = new System.Windows.Forms.ListView();
            this.PartyMember = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Target = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModifyActionBox = new System.Windows.Forms.GroupBox();
            this.ModifyActionTable = new System.Windows.Forms.TableLayoutPanel();
            this.TargetSelector = new System.Windows.Forms.ListBox();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.PartyMemberName = new System.Windows.Forms.Label();
            this.PartyMemberLabel = new System.Windows.Forms.Label();
            this.ActionSelector = new System.Windows.Forms.ListBox();
            this.CommandButtonsTable.SuspendLayout();
            this.CommandPartyBox.SuspendLayout();
            this.ActionsOptionsTable.SuspendLayout();
            this.ModifyActionBox.SuspendLayout();
            this.ModifyActionTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandButtonsTable
            // 
            this.CommandButtonsTable.ColumnCount = 2;
            this.CommandButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CommandButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CommandButtonsTable.Controls.Add(this.AcceptButton, 0, 1);
            this.CommandButtonsTable.Controls.Add(this.CommandPartyBox, 0, 0);
            this.CommandButtonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandButtonsTable.Location = new System.Drawing.Point(0, 0);
            this.CommandButtonsTable.Name = "CommandButtonsTable";
            this.CommandButtonsTable.RowCount = 2;
            this.CommandButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CommandButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.CommandButtonsTable.Size = new System.Drawing.Size(1122, 698);
            this.CommandButtonsTable.TabIndex = 0;
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CommandButtonsTable.SetColumnSpan(this.AcceptButton, 2);
            this.AcceptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.AcceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.AcceptButton.Location = new System.Drawing.Point(260, 603);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(260, 45, 260, 45);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(602, 50);
            this.AcceptButton.TabIndex = 8;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CommandPartyBox
            // 
            this.CommandButtonsTable.SetColumnSpan(this.CommandPartyBox, 2);
            this.CommandPartyBox.Controls.Add(this.ActionsOptionsTable);
            this.CommandPartyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandPartyBox.Font = new System.Drawing.Font("Felix Titling", 18F);
            this.CommandPartyBox.ForeColor = System.Drawing.Color.White;
            this.CommandPartyBox.Location = new System.Drawing.Point(3, 3);
            this.CommandPartyBox.Name = "CommandPartyBox";
            this.CommandPartyBox.Size = new System.Drawing.Size(1116, 552);
            this.CommandPartyBox.TabIndex = 0;
            this.CommandPartyBox.TabStop = false;
            this.CommandPartyBox.Text = "Command Party";
            // 
            // ActionsOptionsTable
            // 
            this.ActionsOptionsTable.ColumnCount = 2;
            this.ActionsOptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.ActionsOptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ActionsOptionsTable.Controls.Add(this.ActionsListView, 0, 0);
            this.ActionsOptionsTable.Controls.Add(this.ModifyActionBox, 1, 0);
            this.ActionsOptionsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsOptionsTable.Location = new System.Drawing.Point(3, 46);
            this.ActionsOptionsTable.Name = "ActionsOptionsTable";
            this.ActionsOptionsTable.RowCount = 1;
            this.ActionsOptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ActionsOptionsTable.Size = new System.Drawing.Size(1110, 503);
            this.ActionsOptionsTable.TabIndex = 0;
            // 
            // ActionsListView
            // 
            this.ActionsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ActionsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ActionsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PartyMember,
            this.Action,
            this.Target});
            this.ActionsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsListView.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsListView.ForeColor = System.Drawing.Color.Goldenrod;
            this.ActionsListView.FullRowSelect = true;
            this.ActionsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ActionsListView.HideSelection = false;
            this.ActionsListView.LabelWrap = false;
            this.ActionsListView.Location = new System.Drawing.Point(4, 5);
            this.ActionsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActionsListView.MultiSelect = false;
            this.ActionsListView.Name = "ActionsListView";
            this.ActionsListView.ShowItemToolTips = true;
            this.ActionsListView.Size = new System.Drawing.Size(713, 493);
            this.ActionsListView.TabIndex = 1;
            this.ActionsListView.UseCompatibleStateImageBehavior = false;
            this.ActionsListView.View = System.Windows.Forms.View.Details;
            this.ActionsListView.SelectedIndexChanged += new System.EventHandler(this.ActionsListView_SelectedIndexChanged);
            // 
            // PartyMember
            // 
            this.PartyMember.Text = "Party Member";
            this.PartyMember.Width = 187;
            // 
            // Action
            // 
            this.Action.Text = "Action";
            this.Action.Width = 176;
            // 
            // Target
            // 
            this.Target.Text = "Target";
            this.Target.Width = 266;
            // 
            // ModifyActionBox
            // 
            this.ModifyActionBox.Controls.Add(this.ModifyActionTable);
            this.ModifyActionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifyActionBox.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyActionBox.ForeColor = System.Drawing.Color.White;
            this.ModifyActionBox.Location = new System.Drawing.Point(724, 3);
            this.ModifyActionBox.Name = "ModifyActionBox";
            this.ModifyActionBox.Size = new System.Drawing.Size(383, 497);
            this.ModifyActionBox.TabIndex = 2;
            this.ModifyActionBox.TabStop = false;
            this.ModifyActionBox.Text = "Modify Action";
            // 
            // ModifyActionTable
            // 
            this.ModifyActionTable.ColumnCount = 2;
            this.ModifyActionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ModifyActionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ModifyActionTable.Controls.Add(this.TargetSelector, 0, 4);
            this.ModifyActionTable.Controls.Add(this.TargetLabel, 0, 3);
            this.ModifyActionTable.Controls.Add(this.ActionLabel, 0, 1);
            this.ModifyActionTable.Controls.Add(this.PartyMemberName, 1, 0);
            this.ModifyActionTable.Controls.Add(this.PartyMemberLabel, 0, 0);
            this.ModifyActionTable.Controls.Add(this.ActionSelector, 0, 2);
            this.ModifyActionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifyActionTable.Location = new System.Drawing.Point(3, 32);
            this.ModifyActionTable.Name = "ModifyActionTable";
            this.ModifyActionTable.RowCount = 5;
            this.ModifyActionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ModifyActionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ModifyActionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ModifyActionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ModifyActionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ModifyActionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ModifyActionTable.Size = new System.Drawing.Size(377, 462);
            this.ModifyActionTable.TabIndex = 0;
            // 
            // TargetSelector
            // 
            this.TargetSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TargetSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModifyActionTable.SetColumnSpan(this.TargetSelector, 2);
            this.TargetSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetSelector.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.TargetSelector.ForeColor = System.Drawing.Color.Goldenrod;
            this.TargetSelector.FormattingEnabled = true;
            this.TargetSelector.ItemHeight = 23;
            this.TargetSelector.Location = new System.Drawing.Point(3, 228);
            this.TargetSelector.Name = "TargetSelector";
            this.TargetSelector.Size = new System.Drawing.Size(371, 231);
            this.TargetSelector.TabIndex = 5;
            // 
            // TargetLabel
            // 
            this.TargetLabel.AutoSize = true;
            this.ModifyActionTable.SetColumnSpan(this.TargetLabel, 2);
            this.TargetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.TargetLabel.Location = new System.Drawing.Point(3, 199);
            this.TargetLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.TargetLabel.Size = new System.Drawing.Size(371, 26);
            this.TargetLabel.TabIndex = 4;
            this.TargetLabel.Text = "Target:";
            this.TargetLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ModifyActionTable.SetColumnSpan(this.ActionLabel, 2);
            this.ActionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.ActionLabel.Location = new System.Drawing.Point(3, 56);
            this.ActionLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ActionLabel.Size = new System.Drawing.Size(371, 26);
            this.ActionLabel.TabIndex = 2;
            this.ActionLabel.Text = "Action:";
            this.ActionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PartyMemberName
            // 
            this.PartyMemberName.AutoSize = true;
            this.PartyMemberName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartyMemberName.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.PartyMemberName.Location = new System.Drawing.Point(191, 0);
            this.PartyMemberName.Name = "PartyMemberName";
            this.PartyMemberName.Size = new System.Drawing.Size(183, 41);
            this.PartyMemberName.TabIndex = 1;
            this.PartyMemberName.Text = "Name";
            this.PartyMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PartyMemberLabel
            // 
            this.PartyMemberLabel.AutoSize = true;
            this.PartyMemberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartyMemberLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.PartyMemberLabel.Location = new System.Drawing.Point(3, 9);
            this.PartyMemberLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.PartyMemberLabel.Name = "PartyMemberLabel";
            this.PartyMemberLabel.Size = new System.Drawing.Size(182, 23);
            this.PartyMemberLabel.TabIndex = 0;
            this.PartyMemberLabel.Text = "Party Member:";
            this.PartyMemberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActionSelector
            // 
            this.ActionSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ActionSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModifyActionTable.SetColumnSpan(this.ActionSelector, 2);
            this.ActionSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionSelector.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.ActionSelector.ForeColor = System.Drawing.Color.Goldenrod;
            this.ActionSelector.FormattingEnabled = true;
            this.ActionSelector.ItemHeight = 23;
            this.ActionSelector.Items.AddRange(new object[] {
            "Attack",
            "Defend",
            "Use Item"});
            this.ActionSelector.Location = new System.Drawing.Point(3, 85);
            this.ActionSelector.Name = "ActionSelector";
            this.ActionSelector.Size = new System.Drawing.Size(371, 96);
            this.ActionSelector.TabIndex = 3;
            this.ActionSelector.SelectedIndexChanged += new System.EventHandler(this.ActionSelector_SelectedIndexChanged);
            // 
            // CommandPartyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1122, 698);
            this.ControlBox = false;
            this.Controls.Add(this.CommandButtonsTable);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CommandPartyWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.CommandButtonsTable.ResumeLayout(false);
            this.CommandPartyBox.ResumeLayout(false);
            this.ActionsOptionsTable.ResumeLayout(false);
            this.ModifyActionBox.ResumeLayout(false);
            this.ModifyActionTable.ResumeLayout(false);
            this.ModifyActionTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CommandButtonsTable;
        private System.Windows.Forms.GroupBox CommandPartyBox;
        private System.Windows.Forms.TableLayoutPanel ActionsOptionsTable;
        private System.Windows.Forms.ListView ActionsListView;
        private System.Windows.Forms.ColumnHeader PartyMember;
        private System.Windows.Forms.ColumnHeader Action;
        private System.Windows.Forms.ColumnHeader Target;
        private System.Windows.Forms.GroupBox ModifyActionBox;
        private System.Windows.Forms.TableLayoutPanel ModifyActionTable;
        private System.Windows.Forms.Label PartyMemberLabel;
        private System.Windows.Forms.Label PartyMemberName;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.ListBox ActionSelector;
        private System.Windows.Forms.ListBox TargetSelector;
        private System.Windows.Forms.Label TargetLabel;
        private System.Windows.Forms.Button AcceptButton;
    }
}