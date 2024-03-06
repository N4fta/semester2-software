namespace Week12_Day1___Constant_keyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class PrintLog
        {
            private int pagesPrinted;
            private const double costPerPage = 0.07;

            public PrintLog()
            { this.pagesPrinted = 0; }

            // Increase count of printed pages and return the print cost
            public double PrintPage()
            {
                this.pagesPrinted++;
                return costPerPage;
            }
            // Increase count of printed pages and return the print cost
            public double PrintPage(int pageCount)
            {
                this.pagesPrinted += pageCount;
                return costPerPage * pageCount;
            }
            // Calculate total revenue based on total printed pages
            public double GetCurrentRevenue()
            { return costPerPage * this.pagesPrinted; }
        }

    }
}