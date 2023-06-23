namespace BeyondBastion
{
    partial class InspectWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Head");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Arms");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Torso");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Legs");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Main Hand");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Off Hand");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Head");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Left Arm");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Right Arm");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Torso");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Left Leg");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Right Leg");
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CharacterNameBox = new System.Windows.Forms.GroupBox();
            this.MainLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.InspectButton = new System.Windows.Forms.Button();
            this.UnequipButton = new System.Windows.Forms.Button();
            this.EquipmentTree = new System.Windows.Forms.TreeView();
            this.StatusBox = new System.Windows.Forms.GroupBox();
            this.StatusTable = new System.Windows.Forms.TableLayoutPanel();
            this.StaticSanityLabel = new System.Windows.Forms.Label();
            this.StaticEnergyLabel = new System.Windows.Forms.Label();
            this.StaticHealthLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InjuriesTree = new System.Windows.Forms.TreeView();
            this.SanityLabel = new System.Windows.Forms.Label();
            this.EnergyLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.AttributesBox = new System.Windows.Forms.GroupBox();
            this.BaseStatsTable = new System.Windows.Forms.TableLayoutPanel();
            this.CombatBox = new System.Windows.Forms.GroupBox();
            this.CombatTable = new System.Windows.Forms.TableLayoutPanel();
            this.FractureChanceLabel = new System.Windows.Forms.Label();
            this.WoundChanceLabel = new System.Windows.Forms.Label();
            this.StaticFractureChanceLabel = new System.Windows.Forms.Label();
            this.StaticKnockdownChanceLabel = new System.Windows.Forms.Label();
            this.StaticDismemberChanceLabel = new System.Windows.Forms.Label();
            this.StaticWoundChanceLabel = new System.Windows.Forms.Label();
            this.StaticBlockChanceLabel = new System.Windows.Forms.Label();
            this.StaticAttackSpeedLabel = new System.Windows.Forms.Label();
            this.StaticAttackDamageLabel = new System.Windows.Forms.Label();
            this.BlockChanceLabel = new System.Windows.Forms.Label();
            this.AttackSpeedLabel = new System.Windows.Forms.Label();
            this.AttackDamageLabel = new System.Windows.Forms.Label();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.FocusLabel = new System.Windows.Forms.Label();
            this.KnowledgeLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.VitalityLabel = new System.Windows.Forms.Label();
            this.DismemberChanceLabel = new System.Windows.Forms.Label();
            this.KnockdownChanceLabel = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.CloseButtonTable.SuspendLayout();
            this.CharacterNameBox.SuspendLayout();
            this.MainLayoutTable.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.StatusBox.SuspendLayout();
            this.StatusTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AttributesBox.SuspendLayout();
            this.BaseStatsTable.SuspendLayout();
            this.CombatBox.SuspendLayout();
            this.CombatTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Controls.Add(this.CloseButtonTable, 0, 1);
            this.MainTable.Controls.Add(this.CharacterNameBox, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.66666F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.33333F));
            this.MainTable.Size = new System.Drawing.Size(841, 561);
            this.MainTable.TabIndex = 0;
            // 
            // CloseButtonTable
            // 
            this.CloseButtonTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButtonTable.ColumnCount = 3;
            this.CloseButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CloseButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.CloseButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CloseButtonTable.Controls.Add(this.CloseButton, 1, 1);
            this.CloseButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButtonTable.Location = new System.Drawing.Point(3, 421);
            this.CloseButtonTable.Name = "CloseButtonTable";
            this.CloseButtonTable.RowCount = 3;
            this.CloseButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CloseButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.CloseButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CloseButtonTable.Size = new System.Drawing.Size(835, 137);
            this.CloseButtonTable.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.CloseButton.Location = new System.Drawing.Point(339, 48);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(156, 41);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CharacterNameBox
            // 
            this.CharacterNameBox.Controls.Add(this.MainLayoutTable);
            this.CharacterNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharacterNameBox.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterNameBox.ForeColor = System.Drawing.Color.White;
            this.CharacterNameBox.Location = new System.Drawing.Point(3, 3);
            this.CharacterNameBox.Name = "CharacterNameBox";
            this.CharacterNameBox.Size = new System.Drawing.Size(835, 412);
            this.CharacterNameBox.TabIndex = 1;
            this.CharacterNameBox.TabStop = false;
            this.CharacterNameBox.Text = "Character Name";
            // 
            // MainLayoutTable
            // 
            this.MainLayoutTable.ColumnCount = 3;
            this.MainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.94118F));
            this.MainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.21568F));
            this.MainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.84313F));
            this.MainLayoutTable.Controls.Add(this.groupBox3, 1, 0);
            this.MainLayoutTable.Controls.Add(this.StatusBox, 0, 0);
            this.MainLayoutTable.Controls.Add(this.AttributesBox, 1, 0);
            this.MainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutTable.Location = new System.Drawing.Point(3, 28);
            this.MainLayoutTable.Name = "MainLayoutTable";
            this.MainLayoutTable.RowCount = 1;
            this.MainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutTable.Size = new System.Drawing.Size(829, 381);
            this.MainLayoutTable.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(600, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(227, 377);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipment";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.InspectButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.UnequipButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.EquipmentTree, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.65741F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34259F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(223, 354);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.InspectButton.Location = new System.Drawing.Point(4, 318);
            this.InspectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InspectButton.Name = "InspectButton";
            this.InspectButton.Size = new System.Drawing.Size(103, 31);
            this.InspectButton.TabIndex = 9;
            this.InspectButton.Text = "Inspect";
            this.InspectButton.UseVisualStyleBackColor = false;
            // 
            // UnequipButton
            // 
            this.UnequipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.UnequipButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnequipButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.UnequipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UnequipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnequipButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnequipButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.UnequipButton.Location = new System.Drawing.Point(115, 318);
            this.UnequipButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UnequipButton.Name = "UnequipButton";
            this.UnequipButton.Size = new System.Drawing.Size(104, 31);
            this.UnequipButton.TabIndex = 8;
            this.UnequipButton.Text = "Unequip";
            this.UnequipButton.UseVisualStyleBackColor = false;
            this.UnequipButton.Click += new System.EventHandler(this.UnequipButton_Click);
            // 
            // EquipmentTree
            // 
            this.EquipmentTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.EquipmentTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel3.SetColumnSpan(this.EquipmentTree, 2);
            this.EquipmentTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentTree.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentTree.ForeColor = System.Drawing.Color.Goldenrod;
            this.EquipmentTree.HotTracking = true;
            this.EquipmentTree.Location = new System.Drawing.Point(3, 3);
            this.EquipmentTree.Name = "EquipmentTree";
            treeNode1.Name = "Head";
            treeNode1.Text = "Head";
            treeNode2.Name = "Arms";
            treeNode2.Text = "Arms";
            treeNode3.Name = "Torso";
            treeNode3.Text = "Torso";
            treeNode4.Name = "Legs";
            treeNode4.Text = "Legs";
            treeNode5.Name = "MainHand";
            treeNode5.Text = "Main Hand";
            treeNode6.Name = "OffHand";
            treeNode6.Text = "Off Hand";
            this.EquipmentTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.EquipmentTree.ShowNodeToolTips = true;
            this.EquipmentTree.ShowPlusMinus = false;
            this.EquipmentTree.ShowRootLines = false;
            this.EquipmentTree.Size = new System.Drawing.Size(217, 307);
            this.EquipmentTree.TabIndex = 7;
            this.EquipmentTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.EquipmentTree_BeforeSelect);
            this.EquipmentTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EquipmentTree_AfterSelect);
            this.EquipmentTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.EquipmentTree_NodeMouseClick);
            // 
            // StatusBox
            // 
            this.StatusBox.Controls.Add(this.StatusTable);
            this.StatusBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusBox.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.ForeColor = System.Drawing.Color.White;
            this.StatusBox.Location = new System.Drawing.Point(2, 2);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(2);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(269, 377);
            this.StatusBox.TabIndex = 1;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "Status";
            // 
            // StatusTable
            // 
            this.StatusTable.AutoSize = true;
            this.StatusTable.ColumnCount = 2;
            this.StatusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.StatusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StatusTable.Controls.Add(this.StaticSanityLabel, 0, 2);
            this.StatusTable.Controls.Add(this.StaticEnergyLabel, 0, 1);
            this.StatusTable.Controls.Add(this.StaticHealthLabel, 0, 0);
            this.StatusTable.Controls.Add(this.groupBox1, 0, 3);
            this.StatusTable.Controls.Add(this.SanityLabel, 1, 2);
            this.StatusTable.Controls.Add(this.EnergyLabel, 1, 1);
            this.StatusTable.Controls.Add(this.HealthLabel, 1, 0);
            this.StatusTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusTable.Location = new System.Drawing.Point(3, 22);
            this.StatusTable.Name = "StatusTable";
            this.StatusTable.RowCount = 4;
            this.StatusTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.StatusTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.StatusTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.StatusTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StatusTable.Size = new System.Drawing.Size(263, 352);
            this.StatusTable.TabIndex = 0;
            // 
            // StaticSanityLabel
            // 
            this.StaticSanityLabel.AutoSize = true;
            this.StaticSanityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticSanityLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticSanityLabel.Location = new System.Drawing.Point(3, 50);
            this.StaticSanityLabel.Name = "StaticSanityLabel";
            this.StaticSanityLabel.Size = new System.Drawing.Size(62, 25);
            this.StaticSanityLabel.TabIndex = 9;
            this.StaticSanityLabel.Text = "Sanity:";
            this.StaticSanityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticEnergyLabel
            // 
            this.StaticEnergyLabel.AutoSize = true;
            this.StaticEnergyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticEnergyLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticEnergyLabel.Location = new System.Drawing.Point(3, 25);
            this.StaticEnergyLabel.Name = "StaticEnergyLabel";
            this.StaticEnergyLabel.Size = new System.Drawing.Size(62, 25);
            this.StaticEnergyLabel.TabIndex = 8;
            this.StaticEnergyLabel.Text = "Energy:";
            this.StaticEnergyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticHealthLabel
            // 
            this.StaticHealthLabel.AutoSize = true;
            this.StaticHealthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticHealthLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticHealthLabel.Location = new System.Drawing.Point(3, 0);
            this.StaticHealthLabel.Name = "StaticHealthLabel";
            this.StaticHealthLabel.Size = new System.Drawing.Size(62, 25);
            this.StaticHealthLabel.TabIndex = 7;
            this.StaticHealthLabel.Text = "Health:";
            this.StaticHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.StatusTable.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.InjuriesTree);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(263, 275);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Injuries";
            // 
            // InjuriesTree
            // 
            this.InjuriesTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.InjuriesTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InjuriesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InjuriesTree.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InjuriesTree.ForeColor = System.Drawing.Color.Goldenrod;
            this.InjuriesTree.HotTracking = true;
            this.InjuriesTree.Location = new System.Drawing.Point(2, 21);
            this.InjuriesTree.Name = "InjuriesTree";
            treeNode7.Name = "Head";
            treeNode7.Text = "Head";
            treeNode8.Name = "LeftArm";
            treeNode8.Text = "Left Arm";
            treeNode9.Name = "RightArm";
            treeNode9.Text = "Right Arm";
            treeNode10.Name = "Torso";
            treeNode10.Text = "Torso";
            treeNode11.Name = "LeftLeg";
            treeNode11.Text = "Left Leg";
            treeNode12.Name = "RightLeg";
            treeNode12.Text = "Right Leg";
            this.InjuriesTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.InjuriesTree.ShowNodeToolTips = true;
            this.InjuriesTree.ShowPlusMinus = false;
            this.InjuriesTree.ShowRootLines = false;
            this.InjuriesTree.Size = new System.Drawing.Size(259, 252);
            this.InjuriesTree.TabIndex = 6;
            this.InjuriesTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.InjuriesTree_AfterSelect);
            // 
            // SanityLabel
            // 
            this.SanityLabel.AutoSize = true;
            this.SanityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SanityLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanityLabel.Location = new System.Drawing.Point(71, 50);
            this.SanityLabel.Name = "SanityLabel";
            this.SanityLabel.Size = new System.Drawing.Size(189, 25);
            this.SanityLabel.TabIndex = 5;
            this.SanityLabel.Text = "100/100";
            this.SanityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnergyLabel
            // 
            this.EnergyLabel.AutoSize = true;
            this.EnergyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnergyLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyLabel.Location = new System.Drawing.Point(71, 25);
            this.EnergyLabel.Name = "EnergyLabel";
            this.EnergyLabel.Size = new System.Drawing.Size(189, 25);
            this.EnergyLabel.TabIndex = 2;
            this.EnergyLabel.Text = "100/100";
            this.EnergyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HealthLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.Location = new System.Drawing.Point(71, 0);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(189, 25);
            this.HealthLabel.TabIndex = 0;
            this.HealthLabel.Text = "100/100";
            this.HealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AttributesBox
            // 
            this.AttributesBox.Controls.Add(this.BaseStatsTable);
            this.AttributesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributesBox.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributesBox.ForeColor = System.Drawing.Color.White;
            this.AttributesBox.Location = new System.Drawing.Point(275, 2);
            this.AttributesBox.Margin = new System.Windows.Forms.Padding(2);
            this.AttributesBox.Name = "AttributesBox";
            this.AttributesBox.Size = new System.Drawing.Size(321, 377);
            this.AttributesBox.TabIndex = 2;
            this.AttributesBox.TabStop = false;
            this.AttributesBox.Text = "Attributes";
            // 
            // BaseStatsTable
            // 
            this.BaseStatsTable.ColumnCount = 2;
            this.BaseStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BaseStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BaseStatsTable.Controls.Add(this.CombatBox, 0, 3);
            this.BaseStatsTable.Controls.Add(this.CharismaLabel, 1, 2);
            this.BaseStatsTable.Controls.Add(this.FocusLabel, 0, 2);
            this.BaseStatsTable.Controls.Add(this.KnowledgeLabel, 1, 1);
            this.BaseStatsTable.Controls.Add(this.EnduranceLabel, 0, 1);
            this.BaseStatsTable.Controls.Add(this.StrengthLabel, 1, 0);
            this.BaseStatsTable.Controls.Add(this.VitalityLabel, 0, 0);
            this.BaseStatsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseStatsTable.Location = new System.Drawing.Point(3, 22);
            this.BaseStatsTable.Name = "BaseStatsTable";
            this.BaseStatsTable.RowCount = 4;
            this.BaseStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.BaseStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.BaseStatsTable.Size = new System.Drawing.Size(315, 352);
            this.BaseStatsTable.TabIndex = 0;
            // 
            // CombatBox
            // 
            this.BaseStatsTable.SetColumnSpan(this.CombatBox, 2);
            this.CombatBox.Controls.Add(this.CombatTable);
            this.CombatBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CombatBox.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatBox.ForeColor = System.Drawing.Color.White;
            this.CombatBox.Location = new System.Drawing.Point(0, 77);
            this.CombatBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.CombatBox.Name = "CombatBox";
            this.CombatBox.Padding = new System.Windows.Forms.Padding(2);
            this.CombatBox.Size = new System.Drawing.Size(315, 275);
            this.CombatBox.TabIndex = 7;
            this.CombatBox.TabStop = false;
            this.CombatBox.Text = "Combat";
            // 
            // CombatTable
            // 
            this.CombatTable.ColumnCount = 2;
            this.CombatTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CombatTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CombatTable.Controls.Add(this.KnockdownChanceLabel, 1, 6);
            this.CombatTable.Controls.Add(this.DismemberChanceLabel, 1, 5);
            this.CombatTable.Controls.Add(this.FractureChanceLabel, 1, 4);
            this.CombatTable.Controls.Add(this.WoundChanceLabel, 1, 3);
            this.CombatTable.Controls.Add(this.StaticFractureChanceLabel, 0, 4);
            this.CombatTable.Controls.Add(this.StaticKnockdownChanceLabel, 0, 6);
            this.CombatTable.Controls.Add(this.StaticDismemberChanceLabel, 0, 5);
            this.CombatTable.Controls.Add(this.StaticWoundChanceLabel, 0, 3);
            this.CombatTable.Controls.Add(this.StaticBlockChanceLabel, 0, 2);
            this.CombatTable.Controls.Add(this.StaticAttackSpeedLabel, 0, 1);
            this.CombatTable.Controls.Add(this.StaticAttackDamageLabel, 0, 0);
            this.CombatTable.Controls.Add(this.BlockChanceLabel, 1, 2);
            this.CombatTable.Controls.Add(this.AttackSpeedLabel, 1, 1);
            this.CombatTable.Controls.Add(this.AttackDamageLabel, 1, 0);
            this.CombatTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CombatTable.Location = new System.Drawing.Point(2, 21);
            this.CombatTable.Name = "CombatTable";
            this.CombatTable.RowCount = 8;
            this.CombatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CombatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CombatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CombatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CombatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CombatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CombatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CombatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.CombatTable.Size = new System.Drawing.Size(311, 252);
            this.CombatTable.TabIndex = 1;
            // 
            // FractureChanceLabel
            // 
            this.FractureChanceLabel.AutoSize = true;
            this.FractureChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FractureChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FractureChanceLabel.Location = new System.Drawing.Point(158, 100);
            this.FractureChanceLabel.Name = "FractureChanceLabel";
            this.FractureChanceLabel.Size = new System.Drawing.Size(150, 25);
            this.FractureChanceLabel.TabIndex = 11;
            this.FractureChanceLabel.Text = "10%";
            this.FractureChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WoundChanceLabel
            // 
            this.WoundChanceLabel.AutoSize = true;
            this.WoundChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WoundChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WoundChanceLabel.Location = new System.Drawing.Point(158, 75);
            this.WoundChanceLabel.Name = "WoundChanceLabel";
            this.WoundChanceLabel.Size = new System.Drawing.Size(150, 25);
            this.WoundChanceLabel.TabIndex = 10;
            this.WoundChanceLabel.Text = "10%";
            this.WoundChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticFractureChanceLabel
            // 
            this.StaticFractureChanceLabel.AutoSize = true;
            this.StaticFractureChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticFractureChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticFractureChanceLabel.Location = new System.Drawing.Point(3, 100);
            this.StaticFractureChanceLabel.Name = "StaticFractureChanceLabel";
            this.StaticFractureChanceLabel.Size = new System.Drawing.Size(149, 25);
            this.StaticFractureChanceLabel.TabIndex = 9;
            this.StaticFractureChanceLabel.Text = "Fracture:";
            this.StaticFractureChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticKnockdownChanceLabel
            // 
            this.StaticKnockdownChanceLabel.AutoSize = true;
            this.StaticKnockdownChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticKnockdownChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticKnockdownChanceLabel.Location = new System.Drawing.Point(3, 150);
            this.StaticKnockdownChanceLabel.Name = "StaticKnockdownChanceLabel";
            this.StaticKnockdownChanceLabel.Size = new System.Drawing.Size(149, 25);
            this.StaticKnockdownChanceLabel.TabIndex = 8;
            this.StaticKnockdownChanceLabel.Text = "Knockdown:";
            this.StaticKnockdownChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticDismemberChanceLabel
            // 
            this.StaticDismemberChanceLabel.AutoSize = true;
            this.StaticDismemberChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticDismemberChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticDismemberChanceLabel.Location = new System.Drawing.Point(3, 125);
            this.StaticDismemberChanceLabel.Name = "StaticDismemberChanceLabel";
            this.StaticDismemberChanceLabel.Size = new System.Drawing.Size(149, 25);
            this.StaticDismemberChanceLabel.TabIndex = 7;
            this.StaticDismemberChanceLabel.Text = "Dismember:";
            this.StaticDismemberChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticWoundChanceLabel
            // 
            this.StaticWoundChanceLabel.AutoSize = true;
            this.StaticWoundChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticWoundChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticWoundChanceLabel.Location = new System.Drawing.Point(3, 75);
            this.StaticWoundChanceLabel.Name = "StaticWoundChanceLabel";
            this.StaticWoundChanceLabel.Size = new System.Drawing.Size(149, 25);
            this.StaticWoundChanceLabel.TabIndex = 6;
            this.StaticWoundChanceLabel.Text = "Wound:";
            this.StaticWoundChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticBlockChanceLabel
            // 
            this.StaticBlockChanceLabel.AutoSize = true;
            this.StaticBlockChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticBlockChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticBlockChanceLabel.Location = new System.Drawing.Point(3, 50);
            this.StaticBlockChanceLabel.Name = "StaticBlockChanceLabel";
            this.StaticBlockChanceLabel.Size = new System.Drawing.Size(149, 25);
            this.StaticBlockChanceLabel.TabIndex = 5;
            this.StaticBlockChanceLabel.Text = "Block:";
            this.StaticBlockChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticAttackSpeedLabel
            // 
            this.StaticAttackSpeedLabel.AutoSize = true;
            this.StaticAttackSpeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticAttackSpeedLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticAttackSpeedLabel.Location = new System.Drawing.Point(3, 25);
            this.StaticAttackSpeedLabel.Name = "StaticAttackSpeedLabel";
            this.StaticAttackSpeedLabel.Size = new System.Drawing.Size(149, 25);
            this.StaticAttackSpeedLabel.TabIndex = 4;
            this.StaticAttackSpeedLabel.Text = "Attack Speed:";
            this.StaticAttackSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticAttackDamageLabel
            // 
            this.StaticAttackDamageLabel.AutoSize = true;
            this.StaticAttackDamageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticAttackDamageLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticAttackDamageLabel.Location = new System.Drawing.Point(3, 0);
            this.StaticAttackDamageLabel.Name = "StaticAttackDamageLabel";
            this.StaticAttackDamageLabel.Size = new System.Drawing.Size(149, 25);
            this.StaticAttackDamageLabel.TabIndex = 3;
            this.StaticAttackDamageLabel.Text = "Attack Damage:";
            this.StaticAttackDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BlockChanceLabel
            // 
            this.BlockChanceLabel.AutoSize = true;
            this.BlockChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlockChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockChanceLabel.Location = new System.Drawing.Point(158, 50);
            this.BlockChanceLabel.Name = "BlockChanceLabel";
            this.BlockChanceLabel.Size = new System.Drawing.Size(150, 25);
            this.BlockChanceLabel.TabIndex = 2;
            this.BlockChanceLabel.Text = "10%";
            this.BlockChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AttackSpeedLabel
            // 
            this.AttackSpeedLabel.AutoSize = true;
            this.AttackSpeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttackSpeedLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackSpeedLabel.Location = new System.Drawing.Point(158, 25);
            this.AttackSpeedLabel.Name = "AttackSpeedLabel";
            this.AttackSpeedLabel.Size = new System.Drawing.Size(150, 25);
            this.AttackSpeedLabel.TabIndex = 1;
            this.AttackSpeedLabel.Text = "1 (2 - 1)";
            this.AttackSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AttackDamageLabel
            // 
            this.AttackDamageLabel.AutoSize = true;
            this.AttackDamageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttackDamageLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackDamageLabel.Location = new System.Drawing.Point(158, 0);
            this.AttackDamageLabel.Name = "AttackDamageLabel";
            this.AttackDamageLabel.Size = new System.Drawing.Size(150, 25);
            this.AttackDamageLabel.TabIndex = 0;
            this.AttackDamageLabel.Text = "2 (1 + 1)";
            this.AttackDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.AutoSize = true;
            this.CharismaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharismaLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaLabel.Location = new System.Drawing.Point(160, 50);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(152, 25);
            this.CharismaLabel.TabIndex = 5;
            this.CharismaLabel.Text = "Vitality: 25";
            this.CharismaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FocusLabel
            // 
            this.FocusLabel.AutoSize = true;
            this.FocusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FocusLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusLabel.Location = new System.Drawing.Point(3, 50);
            this.FocusLabel.Name = "FocusLabel";
            this.FocusLabel.Size = new System.Drawing.Size(151, 25);
            this.FocusLabel.TabIndex = 4;
            this.FocusLabel.Text = "Focus: 25";
            this.FocusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KnowledgeLabel
            // 
            this.KnowledgeLabel.AutoSize = true;
            this.KnowledgeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KnowledgeLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnowledgeLabel.Location = new System.Drawing.Point(160, 25);
            this.KnowledgeLabel.Name = "KnowledgeLabel";
            this.KnowledgeLabel.Size = new System.Drawing.Size(152, 25);
            this.KnowledgeLabel.TabIndex = 3;
            this.KnowledgeLabel.Text = "Knowledge: 25";
            this.KnowledgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.AutoSize = true;
            this.EnduranceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnduranceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnduranceLabel.Location = new System.Drawing.Point(3, 25);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(151, 25);
            this.EnduranceLabel.TabIndex = 2;
            this.EnduranceLabel.Text = "Endurance: 25";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StrengthLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthLabel.Location = new System.Drawing.Point(160, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(152, 25);
            this.StrengthLabel.TabIndex = 1;
            this.StrengthLabel.Text = "Strength: 25";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VitalityLabel
            // 
            this.VitalityLabel.AutoSize = true;
            this.VitalityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VitalityLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VitalityLabel.Location = new System.Drawing.Point(3, 0);
            this.VitalityLabel.Name = "VitalityLabel";
            this.VitalityLabel.Size = new System.Drawing.Size(151, 25);
            this.VitalityLabel.TabIndex = 0;
            this.VitalityLabel.Text = "Vitality: 25";
            this.VitalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DismemberChanceLabel
            // 
            this.DismemberChanceLabel.AutoSize = true;
            this.DismemberChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DismemberChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DismemberChanceLabel.Location = new System.Drawing.Point(158, 125);
            this.DismemberChanceLabel.Name = "DismemberChanceLabel";
            this.DismemberChanceLabel.Size = new System.Drawing.Size(150, 25);
            this.DismemberChanceLabel.TabIndex = 12;
            this.DismemberChanceLabel.Text = "10%";
            this.DismemberChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KnockdownChanceLabel
            // 
            this.KnockdownChanceLabel.AutoSize = true;
            this.KnockdownChanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KnockdownChanceLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnockdownChanceLabel.Location = new System.Drawing.Point(158, 150);
            this.KnockdownChanceLabel.Name = "KnockdownChanceLabel";
            this.KnockdownChanceLabel.Size = new System.Drawing.Size(150, 25);
            this.KnockdownChanceLabel.TabIndex = 13;
            this.KnockdownChanceLabel.Text = "10%";
            this.KnockdownChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InspectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(841, 561);
            this.ControlBox = false;
            this.Controls.Add(this.MainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InspectWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InspectWindow_Load);
            this.MainTable.ResumeLayout(false);
            this.CloseButtonTable.ResumeLayout(false);
            this.CharacterNameBox.ResumeLayout(false);
            this.MainLayoutTable.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.StatusBox.ResumeLayout(false);
            this.StatusBox.PerformLayout();
            this.StatusTable.ResumeLayout(false);
            this.StatusTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.AttributesBox.ResumeLayout(false);
            this.BaseStatsTable.ResumeLayout(false);
            this.BaseStatsTable.PerformLayout();
            this.CombatBox.ResumeLayout(false);
            this.CombatTable.ResumeLayout(false);
            this.CombatTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.TableLayoutPanel CloseButtonTable;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox CharacterNameBox;
        private System.Windows.Forms.TableLayoutPanel MainLayoutTable;
        private System.Windows.Forms.GroupBox StatusBox;
        private System.Windows.Forms.TableLayoutPanel StatusTable;
        private System.Windows.Forms.Label SanityLabel;
        private System.Windows.Forms.Label EnergyLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.TreeView InjuriesTree;
        private System.Windows.Forms.GroupBox AttributesBox;
        private System.Windows.Forms.TableLayoutPanel BaseStatsTable;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.Label FocusLabel;
        private System.Windows.Forms.Label KnowledgeLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label VitalityLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox CombatBox;
        private System.Windows.Forms.TableLayoutPanel CombatTable;
        private System.Windows.Forms.Label BlockChanceLabel;
        private System.Windows.Forms.Label AttackSpeedLabel;
        private System.Windows.Forms.Label AttackDamageLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button InspectButton;
        private System.Windows.Forms.Button UnequipButton;
        private System.Windows.Forms.TreeView EquipmentTree;
        private System.Windows.Forms.Label StaticHealthLabel;
        private System.Windows.Forms.Label StaticEnergyLabel;
        private System.Windows.Forms.Label StaticSanityLabel;
        private System.Windows.Forms.Label StaticAttackDamageLabel;
        private System.Windows.Forms.Label StaticAttackSpeedLabel;
        private System.Windows.Forms.Label StaticBlockChanceLabel;
        private System.Windows.Forms.Label StaticWoundChanceLabel;
        private System.Windows.Forms.Label StaticDismemberChanceLabel;
        private System.Windows.Forms.Label StaticKnockdownChanceLabel;
        private System.Windows.Forms.Label StaticFractureChanceLabel;
        private System.Windows.Forms.Label WoundChanceLabel;
        private System.Windows.Forms.Label FractureChanceLabel;
        private System.Windows.Forms.Label DismemberChanceLabel;
        private System.Windows.Forms.Label KnockdownChanceLabel;
    }
}