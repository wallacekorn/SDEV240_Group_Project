/*
Still need to add header comments


*/
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


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



                // still need to call a method that sorts the files data to the data grid - or remove this option
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog theSaveFileDialog = new SaveFileDialog(); // opens save dialog
            theSaveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"; // suggested file format - we want csv
            theSaveFileDialog.Title = "Save Materials List"; // title for the window
            theSaveFileDialog.FileName = "Materials_Estimate.csv"; // sets a suggested filename
            theSaveFileDialog.FilterIndex = 1; // sets it so the csv option is selected first


            if (theSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = theSaveFileDialog.FileName;
                SaveToCSV(theDataGridView, fileName);
            }

        }

        private void ClearGrid_Click(object sender, EventArgs e)
        {
            // clear table values
            this.theDataGridView.Rows.Clear();
        }

        private void FontMenuSubgroup_Click(object sender, EventArgs e)
        {
            FontDialog aFontDialog = new FontDialog(); // Creates/Opens the font selection menu

            if (aFontDialog.ShowDialog() != DialogResult.Cancel)  // If operation is not cancelled
            {
                this.Font = aFontDialog.Font; // then it assigns the font to the form


                //need to add constraints to change the font to a maximum number so the layout doesnt break - or remove the option
            }

        }
        private void DarkModeToggle_Click(object sender, EventArgs e)
        {

        }

        public static void SaveToCSV(DataGridView theDataGridView, string fileName)
        {

            StreamWriter streamWriter = new StreamWriter(fileName);

            // This loop processes the headers of the datagridview columns
            for (int i = 0; i < theDataGridView.Columns.Count; ++i) 
            {
                streamWriter.Write(theDataGridView.Columns[i].HeaderText); // Writes the column headers to the stream
                if (i != theDataGridView.Columns.Count - 1) // this prevents the last column from getting a comma
                {
                    streamWriter.Write(","); // adds comma delimiter
                }
            }
            streamWriter.Write(streamWriter.NewLine); // breaks the entry to the next line


            // This loop processes the body of the datagridview columns
            for (int iRows = 0; iRows < theDataGridView.Rows.Count; ++iRows)
            {
                if (theDataGridView.Rows[iRows].IsNewRow) // this makes it so the last (and always blank) row isn't entered as all commas
                    continue;
                for (int iCells = 0; iCells < theDataGridView.Columns.Count; ++iCells)
                {
                    streamWriter.Write(theDataGridView.Rows[iRows].Cells[iCells].Value);
                    if (iCells != theDataGridView.Columns.Count - 1) // this prevents the last column from getting a comma
                    {
                        streamWriter.Write(","); // adds comma delimiter
                    }
                }
                streamWriter.Write(streamWriter.NewLine); //Breaks the entry to the next line
            }
            streamWriter.Close();
        }


        // This method adds the "Cost" column and grand totals the value into the calTotalTextBox.
        private void CalcTotal_Click(object sender, EventArgs e)
        {
            double accumulatedTotal = 0;
            for (int i = 0; i<theDataGridView.Rows.Count; ++i)
            {
                accumulatedTotal += Convert.ToDouble(theDataGridView.Rows[i].Cells["entryCostColumn"].Value);
            }
            calcTotalTextBox.Text = accumulatedTotal.ToString("C", CultureInfo.CurrentCulture); // Assigns the value to the output box in currency 
        }
    }
}