namespace Materials_List_Estimator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FileCategory_Click(object sender, EventArgs e)
        {

        }
        private void ViewCategory_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog anOpenFileDialog = new OpenFileDialog(); // opens the 'select a file' window

            if (anOpenFileDialog.ShowDialog() == DialogResult.OK) // if something is entered
            {
                string openedFileName = anOpenFileDialog.FileName; // assigns its filename to a var
                // call a method that sorts the files data to the data grid
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            // convert data in the datagrid to a csv file
        }

        private void ClearGrid_Click(object sender, EventArgs e)
        {
            // clear table values
        }

        private void FontMenuSubgroup_Click(object sender, EventArgs e)
        {
            FontDialog aFontDialog = new FontDialog(); // Creates/Opens the font selection menu

            if (aFontDialog.ShowDialog() != DialogResult.Cancel)  // If operation is not cancelled
            {
                this.Font = aFontDialog.Font; // then it assigns the font to the form
                //need to add constraints to change the font to a maximum number so the layout doesnt break
            }

        }
        private void DarkModeToggle_Click(object sender, EventArgs e)
        {

        }
    }
}