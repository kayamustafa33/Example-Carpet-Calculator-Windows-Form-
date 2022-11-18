namespace CarpetCalculatorApp
{
    public partial class Form1 : Form
    {

        const int SQ_FT_PER_SQ_YARD = 9;
        const int INCHES_PER_FOOT = 12;


        int roomLengthFeet = 12, roomLengthInches = 2,
                        roomWidthFeet = 14, roomWidthInches = 7;

        private void bestCalculate_Click(object sender, EventArgs e)
        {

            calculate(27.95, label1,"Berber Price: ");
        }

        private void economyCalculate_Click(object sender, EventArgs e)
        {
            calculate(15.95, label1, "Pile Price: ");
        }

        double roomLength, roomWidth,
                    numOfSquareFeet,
                    numOfSquareYards, totalCost;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(double price, Label text, string text2)
        {
            label1.Visible = true;
            roomLength = roomLengthFeet + roomLengthInches / INCHES_PER_FOOT;
            roomWidth = roomWidthFeet + roomWidthInches / INCHES_PER_FOOT;
            numOfSquareFeet = roomLength * roomWidth;
            numOfSquareYards = numOfSquareFeet / SQ_FT_PER_SQ_YARD;

            totalCost = numOfSquareYards * price;
            text.Text = text2 + "$" + totalCost.ToString("F2");
        }
    }
}