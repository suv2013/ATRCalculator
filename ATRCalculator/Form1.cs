using System.Data;
using System.Numerics;

namespace ATRCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double atr = 30;
            double highPrice = 100;
            double lowPrice = 100;
            if (btn_Calculate.Enabled)
            {
                atr = Convert.ToDouble(txt_inputArt.Text);
                highPrice = Convert.ToDouble(txt_HighPrice.Text);
                lowPrice = Convert.ToDouble(txt_LowPrice.Text);

                HighCalulation hp = new HighCalulation(highPrice, atr);
                LowCalulation lp = new LowCalulation(lowPrice, atr);

                val_High.Text = hp.highPrice.ToString();
                val_HighAbove.Text = hp.secondHighPrice.ToString();
                val_HighBelow.Text = hp.firstHighPrice.ToString();

                val_Low.Text = lp.lowPrice.ToString();
                val_LowAbove.Text = lp.firstLowPrice.ToString();
                val_LowBelow.Text = lp.secondLowPrice.ToString();
                EnableLabels();
            }
        }

        private void EnableLabels()
        {
            val_High.Visible = true;
            val_HighAbove.Visible = true;
            val_HighBelow.Visible = true;
            val_Low.Visible = true;
            val_LowAbove.Visible = true;
            val_LowBelow.Visible = true;

            lbl_High.Visible = true;
            lbl_HighAbove.Visible = true;
            lbl_HighBelow.Visible = true;
            lbl_Low.Visible = true;
            lbl_LowAbove.Visible = true;
            lbl_LowBelow.Visible = true;
        }
    }

    public class HighCalulation
    {
        public HighCalulation(double hp, double atr)
        {
            highPrice = hp;
            firstHighPrice = hp - ((double)(100 * atr) / hp);
            secondHighPrice = hp + ((double)(100 * atr) / hp);
        }
        public double firstHighPrice { get; set; }
        public double secondHighPrice { get; set; }
        public double highPrice { get; set; }
    }
    public class LowCalulation
    {
        public LowCalulation(double lp, double atr)
        {
            lowPrice = lp;
            firstLowPrice = lp - ((double)(100 * atr) / lp);
            secondLowPrice = lp + ((double)(100 * atr) / lp);
        }
        public double firstLowPrice { get; set; }
        public double secondLowPrice { get; set; }
        public double lowPrice { get; set; }
    }
}