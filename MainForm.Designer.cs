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
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            darkModeLightModeToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            itemColumn = new DataGridViewTextBoxColumn();
            materialColumn = new DataGridViewTextBoxColumn();
            sizeColumn = new DataGridViewTextBoxColumn();
            quantColumn = new DataGridViewTextBoxColumn();
            unitCostColumn = new DataGridViewTextBoxColumn();
            entryCostColumn = new DataGridViewTextBoxColumn();
            noteColumn = new DataGridViewTextBoxColumn();
            button2 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(945, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip";
            menuStrip1.ItemClicked += MenuStrip_ItemClicked;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1, saveToolStripMenuItem, clearToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(37, 20);
            openToolStripMenuItem.Text = "File";
            openToolStripMenuItem.Click += FileCategory_Click;
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(103, 22);
            openToolStripMenuItem1.Text = "Open";
            openToolStripMenuItem1.Click += OpenFile_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveFile_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(103, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += ClearGrid_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, darkModeLightModeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += ViewCategory_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += FontMenuSubgroup_Click;
            // 
            // darkModeLightModeToolStripMenuItem
            // 
            darkModeLightModeToolStripMenuItem.Checked = true;
            darkModeLightModeToolStripMenuItem.CheckState = CheckState.Checked;
            darkModeLightModeToolStripMenuItem.Name = "darkModeLightModeToolStripMenuItem";
            darkModeLightModeToolStripMenuItem.Size = new Size(180, 22);
            darkModeLightModeToolStripMenuItem.Text = "Dark Mode Toggle";
            darkModeLightModeToolStripMenuItem.Click += DarkModeToggle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Category, itemColumn, materialColumn, sizeColumn, quantColumn, unitCostColumn, entryCostColumn, noteColumn });
            dataGridView1.Location = new Point(32, 38);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(878, 343);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            // 
            // Category
            // 
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
            // button2
            // 
            button2.Location = new Point(674, 397);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 33);
            button2.TabIndex = 3;
            button2.Text = "Calculate Total";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(811, 404);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(32, 402);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 6;
            button4.Text = "Compare";
            button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 439);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Materials List Estimator";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn itemColumn;
        private DataGridViewTextBoxColumn materialColumn;
        private DataGridViewTextBoxColumn sizeColumn;
        private DataGridViewTextBoxColumn quantColumn;
        private DataGridViewTextBoxColumn unitCostColumn;
        private DataGridViewTextBoxColumn entryCostColumn;
        private DataGridViewTextBoxColumn noteColumn;
        private Button button2;
        private TextBox textBox1;
        private Button button4;
    }
}