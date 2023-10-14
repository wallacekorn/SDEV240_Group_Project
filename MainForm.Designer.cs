namespace Materials_List_Estimator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            darkModeLightModeToolStripMenuItem = new ToolStripMenuItem();
            theDataGridView = new DataGridView();
            button2 = new Button();
            calcTotalTextBox = new TextBox();
            button4 = new Button();
            Category = new DataGridViewTextBoxColumn();
            itemColumn = new DataGridViewTextBoxColumn();
            materialColumn = new DataGridViewTextBoxColumn();
            sizeColumn = new DataGridViewTextBoxColumn();
            quantColumn = new DataGridViewTextBoxColumn();
            unitCostColumn = new DataGridViewTextBoxColumn();
            entryCostColumn = new DataGridViewTextBoxColumn();
            noteColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)theDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1062, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip";
            menuStrip1.ItemClicked += MenuStrip_ItemClicked;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1, saveToolStripMenuItem, clearToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(46, 24);
            openToolStripMenuItem.Text = "File";
            openToolStripMenuItem.Click += FileCategory_Click;
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(128, 26);
            openToolStripMenuItem1.Text = "Open";
            openToolStripMenuItem1.Click += OpenFile_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveFile_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(128, 26);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += ClearGrid_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, darkModeLightModeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += ViewCategory_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(216, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += FontMenuSubgroup_Click;
            // 
            // darkModeLightModeToolStripMenuItem
            // 
            darkModeLightModeToolStripMenuItem.Checked = true;
            darkModeLightModeToolStripMenuItem.CheckState = CheckState.Checked;
            darkModeLightModeToolStripMenuItem.Name = "darkModeLightModeToolStripMenuItem";
            darkModeLightModeToolStripMenuItem.Size = new Size(216, 26);
            darkModeLightModeToolStripMenuItem.Text = "Dark Mode Toggle";
            darkModeLightModeToolStripMenuItem.Click += DarkModeToggle_Click;
            // 
            // theDataGridView
            // 
            theDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            theDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            theDataGridView.ColumnHeadersHeight = 29;
            theDataGridView.Columns.AddRange(new DataGridViewColumn[] { Category, itemColumn, materialColumn, sizeColumn, quantColumn, unitCostColumn, entryCostColumn, noteColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Georgia", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            theDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            theDataGridView.Location = new Point(38, 73);
            theDataGridView.Name = "theDataGridView";
            theDataGridView.RowHeadersVisible = false;
            theDataGridView.RowHeadersWidth = 51;
            theDataGridView.RowTemplate.Height = 29;
            theDataGridView.Size = new Size(988, 429);
            theDataGridView.TabIndex = 1;
            theDataGridView.CellContentClick += DataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(646, 520);
            button2.Name = "button2";
            button2.Size = new Size(123, 44);
            button2.TabIndex = 3;
            button2.Text = "Calculate Total";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CalcTotal_Click;
            // 
            // calcTotalTextBox
            // 
            calcTotalTextBox.Location = new Point(786, 529);
            calcTotalTextBox.Name = "calcTotalTextBox";
            calcTotalTextBox.Size = new Size(114, 27);
            calcTotalTextBox.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(51, 528);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Compare";
            button4.UseVisualStyleBackColor = true;
            // 
            // Category
            // 
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Category.DefaultCellStyle = dataGridViewCellStyle1;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // itemColumn
            // 
            itemColumn.HeaderText = "Item";
            itemColumn.MinimumWidth = 6;
            itemColumn.Name = "itemColumn";
            // 
            // materialColumn
            // 
            materialColumn.HeaderText = "Material";
            materialColumn.MinimumWidth = 6;
            materialColumn.Name = "materialColumn";
            // 
            // sizeColumn
            // 
            sizeColumn.HeaderText = "Size";
            sizeColumn.MinimumWidth = 6;
            sizeColumn.Name = "sizeColumn";
            // 
            // quantColumn
            // 
            quantColumn.HeaderText = "Quantity";
            quantColumn.MinimumWidth = 6;
            quantColumn.Name = "quantColumn";
            // 
            // unitCostColumn
            // 
            unitCostColumn.HeaderText = "Unit Cost";
            unitCostColumn.MinimumWidth = 6;
            unitCostColumn.Name = "unitCostColumn";
            // 
            // entryCostColumn
            // 
            dataGridViewCellStyle2.BackColor = Color.Snow;
            entryCostColumn.DefaultCellStyle = dataGridViewCellStyle2;
            entryCostColumn.HeaderText = "Cost";
            entryCostColumn.MinimumWidth = 6;
            entryCostColumn.Name = "entryCostColumn";
            // 
            // noteColumn
            // 
            noteColumn.HeaderText = "Notes";
            noteColumn.MinimumWidth = 6;
            noteColumn.Name = "noteColumn";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 585);
            Controls.Add(button4);
            Controls.Add(calcTotalTextBox);
            Controls.Add(button2);
            Controls.Add(theDataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Materials List Estimator";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)theDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem darkModeLightModeToolStripMenuItem;
        private DataGridView theDataGridView;
        private Button button2;
        private TextBox calcTotalTextBox;
        private Button button4;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn itemColumn;
        private DataGridViewTextBoxColumn materialColumn;
        private DataGridViewTextBoxColumn sizeColumn;
        private DataGridViewTextBoxColumn quantColumn;
        private DataGridViewTextBoxColumn unitCostColumn;
        private DataGridViewTextBoxColumn entryCostColumn;
        private DataGridViewTextBoxColumn noteColumn;
    }
}