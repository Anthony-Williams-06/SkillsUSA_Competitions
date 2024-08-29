namespace Nationals_1126_DiceRoll
{
    public partial class frmDiceRoll : Form
    {
        public frmDiceRoll()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            string errors = isValid(txtQuantity.Text);
            if (errors == string.Empty)
            {
                int size = Int32.Parse(txtQuantity.Text);
                //Get a roll of the dice
                int lastRoll = RollDice(size);
                lblLastRoll.Text = "Last Roll: " + lastRoll.ToString();
                addToFile(lastRoll.ToString(), size.ToString());
            }
            else
            {
                MessageBox.Show(errors);
            }

        }

        private string isValid(string textInput)
        {
            //use else if so we don't get two errors meaning the same thing, but only the specialzed errors
            string errors = string.Empty;
            if (textInput == null || textInput == String.Empty)
            {
                errors += "Sides must not be empty.\n";
            }
            else if (!Int32.TryParse(textInput, out _))
            {
                errors += "Sides must be an integer value.\n";
            }
            else
            {
                //use nesting if, to make sure that the sides is an integer, preventing a typeError
                if (Int32.Parse(textInput) < 4)
                {
                    errors += "Sides must be a valid dice size (Greater than 4)";
                }

            }

            return errors;


        }

        private int RollDice(int size)
        {
            Random dice = new Random();
            return dice.Next(1, size + 1); //get value between 1 and size
        }

        private void addToFile(string input, string faceQuantity)
        {
            string path = "./roll_history.log";
            StreamWriter streamWriter = new(path, true); //choose to append
            if (!File.Exists(path))
            {
                streamWriter = File.CreateText(path);
            }

            DateTime date = DateTime.Now;
            streamWriter.WriteLine(date.ToString() + ": Faces:" + faceQuantity + " | Roll: " + input);
            streamWriter.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
