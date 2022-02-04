using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Solumina_Export_Formatter_ON
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void sourceBrowseButton_Click(object sender, EventArgs e)
        {
            //let user select source path
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                //set source text box to user selected file
                string sourcePath = ofd.FileName;
                sourceTextBox.Text = sourcePath;
                //naviagate to Roaming AppData folder and check if backup text file exists
                string BaseFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string FolderPath = Path.Combine(BaseFolder, "Solumina Formatter");
                string FilePath = Path.Combine(FolderPath, "Backup.txt");
                //if it doesnt exist, create the file and write the path to it
                if (!File.Exists(FilePath))
                {
                    using (StreamWriter sw = new StreamWriter(FilePath))
                    {
                        sw.WriteLine("Source," + sourcePath);
                    }
                }
                //if it does exist
                else if (File.Exists(FilePath))
                {
                    string outputPath = "";
                    Boolean pathFound = false;
                    //read each line and save the output path if it exists
                    using (StreamReader sr = new StreamReader(FilePath))
                    {
                        string line;
                        string[] typePath;
                        while ((line = sr.ReadLine()) != null)
                        {
                            typePath = line.Split(',');
                            if (typePath[0].Equals("Output"))
                            {
                                outputPath = typePath[1];
                                pathFound = true;
                            }
                        }
                    }
                    //delete the backup file and create a new one with the new source path and old output path
                    File.Delete(FilePath);
                    using (StreamWriter sr = new StreamWriter(FilePath))
                    {
                        sr.WriteLine("Source," + sourcePath);
                        if (pathFound)
                        {
                            sr.WriteLine("Output," + outputPath);
                        }
                    }
                }
            }
        }

        private void outputBrowseButton_Click(object sender, EventArgs e)
        {
            //let user select output path
            string outputFileName = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = outputFileName;
            //file will be saved as .xlsx to keep formatting we will apply to it
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.AddExtension = true;
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                //set output text box to user selected name/path
                string outputPath = sfd.FileName;
                outputTextBox.Text = outputPath;
                //naviagate to Roaming AppData folder and check if backup text file exists
                string BaseFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string FolderPath = Path.Combine(BaseFolder, "Solumina Formatter");
                string FilePath = Path.Combine(FolderPath, "Backup.txt");

                //if the backup file doesn't exist, create the file and write the path to it
                if (!File.Exists(FilePath))
                {
                    using (StreamWriter sw = new StreamWriter(FilePath))
                    {
                        sw.WriteLine("Output," + outputPath);
                    }
                }

                //if the backup file does exist
                else if (File.Exists(FilePath))
                {
                    string sourcePath = "";
                    Boolean pathFound = false;
                    //read each line and save the source path if it exists
                    using (StreamReader sr = new StreamReader(FilePath))
                    {
                        string line;
                        string[] typePath;
                        while ((line = sr.ReadLine()) != null)
                        {
                            typePath = line.Split(',');
                            if (typePath[0].Equals("Source"))
                            {
                                sourcePath = typePath[1];
                                pathFound = true;
                            }
                        }
                    }

                    //delete the backup file and create a new one with the new source path and old output path
                    File.Delete(FilePath);
                    using (StreamWriter sr = new StreamWriter(FilePath))
                    {
                        if (pathFound)
                        {
                            sr.WriteLine("Source," + sourcePath);
                        }
                        sr.WriteLine("Output," + outputPath);
                    }
                }
            }
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            //double check file exists before trying to format it
            if (!File.Exists(sourceTextBox.Text))
            {
                MessageBox.Show("File not found, choose a new Solumina Export file");
                return;
            }

            //open the user selected file
            Excel.Application xl = new Excel.Application();
            Workbook wb = xl.Workbooks.Open(@sourceTextBox.Text, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel.Worksheet sheet1 = wb.ActiveSheet;

            //find the number of populated rows
            int lastRow = sheet1.Cells.Find("*", System.Reflection.Missing.Value,
                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                               Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

            //proper formatting for a RWK WO
            if (reworkWTFCheckBox.Checked)
            {
                //check column D of each row, if its not closed delete the name and date from the row
                for (int i = 2; i <= lastRow; i++)
                {
                    if (!((string)(sheet1.Cells[i, 8] as Excel.Range).Value).Equals("CLOSE"))
                    {
                        sheet1.Cells[i, 13] = "";
                        sheet1.Cells[i, 14] = "";
                    }
                }

                //delete columns we don't need for rwk WO
                sheet1.get_Range("A1:B1, E1:L1").EntireColumn.Delete();

            }
            //otherwise use the generic WO formatting
            else
            {
                //check column D of each row, if its not closed delete the name and date from the row
                for (int i = 2; i <= lastRow; i++)
                {
                    if (!((string)(sheet1.Cells[i, 4] as Excel.Range).Value).Equals("CLOSE"))
                    {
                        sheet1.Cells[i, 14] = "";
                        sheet1.Cells[i, 15] = "";
                    }
                }
                //delete columns we don't need
                sheet1.get_Range("B1, D1:M1").EntireColumn.Delete();

            }

            //Self-explanatory formatting stuff
            sheet1.Cells[1, 3] = "Technician Name";
            sheet1.Cells[1, 4] = "Completed Date";
            sheet1.get_Range("A1").EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            sheet1.get_Range("D1").EntireColumn.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            sheet1.get_Range("D1").EntireColumn.NumberFormat = "mm/dd/yyyy";
            sheet1.get_Range("A1:D1").EntireColumn.AutoFit();

            //Apply borders to cells the are/will be populated
            string borderEnd = "D" + lastRow;
            Excel.Range borderRange;
            borderRange = sheet1.get_Range("A1", borderEnd);
            foreach (Excel.Range cell in borderRange.Cells)
            {
                cell.BorderAround2();
            }

            //catching exception where user selects no to replace output file when saving
            object misValue = System.Reflection.Missing.Value;
            try
            {
                //save the new .xlsx file and close it
                wb.SaveAs(@outputTextBox.Text, XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing,
                                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                wb.Close();
                xl.Quit();
            }
            catch (Exception ex)
            {
                wb.Close(false, misValue, misValue);
                xl.Quit();
                MessageBox.Show("Error saving file. Do not save changes to CSV file. Returning to main menu.\n" + ex);
                return;
            }

            //if the delete original text box is checked then delete the original file
            if (delOGCheckBox.Checked)
            {
                File.Delete(sourceTextBox.Text);
            }

            //Basic message box to show it finished doing its thang
            MessageBox.Show("Formatting completed successfully!");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //On load, check if the backup file exists in the AppData\Roaming folder
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string FolderPath = Path.Combine(appDataFolder, "Solumina Formatter");
            Directory.CreateDirectory(FolderPath);
            string FilePath = Path.Combine(FolderPath, "Backup.txt");

            //if found populate the text boxes with the last used paths saved in the file
            if (File.Exists(FilePath))
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    string[] typePath;
                    //read each line of backup file
                    while ((line = sr.ReadLine()) != null)
                    {
                        typePath = line.Split(',');
                        //find "Source" to find the source path
                        if (typePath[0].Equals("Source"))
                        {
                            //check if the file exists before setting the text box
                            if (File.Exists(typePath[1]))
                            {
                                sourceTextBox.Text = typePath[1];
                            }
                        }

                        //find "Output" to find the output path
                        else if (typePath[0].Equals("Output"))
                        {
                            //check if the file exists before setting the text box
                            if (File.Exists(typePath[1]))
                            {
                                outputTextBox.Text = typePath[1];
                            }
                        }
                    }
                }
            }
        }
        private void rwkToolTip(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip rwkToolTip = new ToolTip();

            // Set up the delays for the ToolTip.
            rwkToolTip.AutoPopDelay = 5000;
            rwkToolTip.InitialDelay = 1000;
            rwkToolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            rwkToolTip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            rwkToolTip.SetToolTip(this.reworkWTFCheckBox, "Check this box if the WO is a RWK for proper formatting");
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Jared Deaton");
        }
    }
}
