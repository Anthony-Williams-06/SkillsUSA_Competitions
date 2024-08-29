using System.Collections;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Nationals_Project_1_1126
{
    public partial class Skills_USA_Payroll : Form
    {
        //Create Global Variables to store CSV string data, and other important information
        private ArrayList rows = new ArrayList();
        private string path = string.Empty;
        private ArrayList paths = new ArrayList();

        public Skills_USA_Payroll()
        {
            InitializeComponent();
        }

        //Events
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (path != string.Empty)
            {
                UpdateGrid();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open CSV File";
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.CheckFileExists = true;
            openFileDialog.InitialDirectory = path == String.Empty ? "C:\\" : path;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName.ToString();
            }

            UpdateGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            paths = new ArrayList();
            path = string.Empty;
            UpdateGrid();
        }

        //Update Functions
        private void UpdateGrid()
        {

            rows = new ArrayList();

            while (dgvOutput.Rows.Count > 0)
            {
                dgvOutput.Rows.Remove(dgvOutput.Rows[0]);
            }

            if (paths.IndexOf(path) == -1 && path != String.Empty)
            {
                paths.Add(path);
            }

            if (paths.Count != 0)
            {
                foreach (string curpath in paths)
                {
                    var payrollFile = new Microsoft.VisualBasic.FileIO.TextFieldParser(curpath);
                    payrollFile.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                    payrollFile.SetDelimiters(new string[] { " " });

                    while (!payrollFile.EndOfData)
                    {
                        rows.Add(payrollFile.ReadFields());
                    }
                    payrollFile.Close();

                }

                //Setup the DataGridView for output
                SetupDataGridView();
                PopulateData();
                //Test if the above code is adding all CSV rows into an ArrayList
                //MessageBox.Show(rows.Count.ToString(), "Test Output");
            }
        }

        private void SetupDataGridView()
        {

            //Populate Headers
            dgvOutput.ColumnCount = 10;

            //Make Headers bold for readability
            dgvOutput.ColumnHeadersDefaultCellStyle.Font = new Font(dgvOutput.Font, FontStyle.Bold);

            //Assign Column Names
            dgvOutput.Columns[0].Name = "Name";
            dgvOutput.Columns[1].Name = "SS#";
            dgvOutput.Columns[2].Name = "Wage";
            dgvOutput.Columns[3].Name = "Reg Hours";
            dgvOutput.Columns[4].Name = "Reg Pay";
            dgvOutput.Columns[5].Name = "OT Hours";
            dgvOutput.Columns[6].Name = "OT Pay";
            dgvOutput.Columns[7].Name = "Taxes";
            dgvOutput.Columns[8].Name = "Insurance";
            dgvOutput.Columns[9].Name = "Total";

        }

        private void PopulateData()
        {
            double[] payCodeAmount = new double[] { 15.0, 17.5, 20.0, 22.25, 25.0 };

            foreach (string[] rowRaw in rows)
            {
                string row = rowRaw[0];
                string[] outputRow = new string[10];
                string[] seperatedValues = row.Split(',');

                double insurance = 12.0; //Create insurance variable for easy change if necissary

                //check if valid
                if (isValid(row))
                {
                    //Parse Necissary Parts
                    int payCode = Int32.Parse(seperatedValues[3]) - 1;
                    int hours = Int32.Parse(seperatedValues[4]);
                    //Assign All Calculated Values
                    outputRow[0] = seperatedValues[0] + " " + seperatedValues[1];
                    outputRow[1] = seperatedValues[2];
                    outputRow[2] = payCodeAmount[payCode].ToString("C");
                    outputRow[3] = hours.ToString();
                    outputRow[4] = CalculateNormalWage(hours, payCodeAmount[payCode]).ToString("C");
                    outputRow[5] = OvertimeHours(hours).ToString();
                    outputRow[6] = CalculateOvertimeWage(hours, payCodeAmount[payCode]).ToString("C");
                    outputRow[7] = CalculateTaxes(hours, payCodeAmount[payCode]).ToString("C");
                    outputRow[8] = insurance.ToString("C"); //Use Currency Format for ease of use
                    outputRow[9] = CalculateTotal(hours, payCodeAmount[payCode], insurance).ToString("C");

                    dgvOutput.Rows.Add(outputRow);
                }


            }
        }

        //Calculate Functions
        private double CalculateTotal(int hours, double payCodeAmount, double insurance)
        {
            double total = 0;
            total += CalculateNormalWage(hours, payCodeAmount);
            total += CalculateOvertimeWage(hours, payCodeAmount);
            total -= CalculateTaxes(hours, payCodeAmount);
            total -= insurance;
            return total;
        }

        private double CalculateTaxes(int hours, double payCodeAmount)
        {
            return (CalculateNormalWage(hours, payCodeAmount) + CalculateOvertimeWage(hours, payCodeAmount)) * .10;
        }

        private double CalculateNormalWage(int hours, double wage)
        {
            if (hours <= 40)
            {
                return hours * wage;
            }
            else
            {
                return hours * 40;
            }
        }

        private int OvertimeHours(int hours)
        {
            if (hours > 40)
            {
                return hours - 40;
            }
            else
            {
                return 0;
            }
        }

        private double CalculateOvertimeWage(int hours, double wage)
        {
            if (hours <= 40)
            {
                return 0;
            }
            else
            {
                return (hours - 40) * (wage * 1.5);
            }
        }

        //Validation
        private bool isValid(string row)
        {
            string[] seperatedValues = row.Split(',');
            string errors = string.Empty;
            if (seperatedValues.Length == 5)
            {
                //check valid data
                bool isValid = true;
                if (seperatedValues[0].Equals("") || seperatedValues[1].Equals(""))
                {
                    errors += "First and Last name must not be blank.\n";
                    isValid = false;
                }
                if (seperatedValues[2].Equals("") || seperatedValues[2].Length != 4)
                {
                    errors += "SSN must be 4 digits.\n";
                    isValid = false;
                }
                if (!Int32.TryParse(seperatedValues[3], out _) || Int32.Parse(seperatedValues[3]) < 0 || Int32.Parse(seperatedValues[3]) > 5)
                {
                    errors += "Pay Code must be 1-5.\n";
                    isValid = false;
                }
                if (!Int32.TryParse(seperatedValues[4], out _) || Int32.Parse(seperatedValues[4]) < 0)
                {
                    errors += "Hours must be a valid positive integer.\n";
                    isValid = false;
                }

                //Add row if valid
                if (isValid)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(errors + "\nin row " + row);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Record must be in following format: first,last,ssn,paycode,hours for: " + row);
                return false;
            }
        }

        
    }
}
