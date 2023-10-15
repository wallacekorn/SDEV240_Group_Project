/*
    Group: Group 2
    Date: 10/14/2023
    Program Title: Group Project - Materials List Estimator
    Purpose: Inputs data from the user for building materials for houses. 
    Calculates the total cost of the list, on button press. 
    Also can save entered data into a CSV file, change the font, enter darkmode, 
    and clear the datagridview using included form functionality. 
*/

using System.Globalization;


namespace Materials_List_Estimator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                // Get the selected font
                Font selectedFont = fontDialog.Font;

                // Set constraints for the font size
                float minFontSize = 8.0f;
                float maxFontSize = 14.0f;

                // Apply constraints to font size
                float constrainedFontSize = Math.Max(minFontSize, Math.Min(selectedFont.Size, maxFontSize));
                selectedFont = new Font(selectedFont.FontFamily, constrainedFontSize, selectedFont.Style);

                this.Font = selectedFont;
            }
        }


        private bool isDarkMode = false; // Initialize with light mode

        private void DarkModeToggle_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            ApplyDarkMode();
        }

        private void ApplyDarkMode()
        {
            if (isDarkMode)
            {
                // Dark Mode
                this.BackColor = Color.FromArgb(80, 80, 80); // Set the background color to a dark shade
                this.ForeColor = Color.White; // Set text and foreground color to a light color
                theDataGridView.BackgroundColor = Color.FromArgb(50, 50, 50);
                theDataGridView.ForeColor = Color.LightSlateGray;
            }
            else
            {
                // Light Mode
                this.BackColor = Color.White; // Set the background color back to light
                this.ForeColor = Color.Black; // Set text and foreground color back to dark
                theDataGridView.BackgroundColor = this.BackColor;
                theDataGridView.ForeColor = this.ForeColor;
            }
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
            for (int i = 0; i < theDataGridView.Rows.Count; ++i)
            {
                accumulatedTotal += Convert.ToDouble(theDataGridView.Rows[i].Cells["entryCostColumn"].Value);
            }
            calcTotalTextBox.Text = accumulatedTotal.ToString("C", CultureInfo.CurrentCulture); // Assigns the value to the output box in currency 
        }
    }
}