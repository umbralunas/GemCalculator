using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Whether the user is calculating for a target value of tokens or tickets.
        /// <para>
        /// <b>False:</b> the user is calculating for a <b>Ticket</b> target value.
        /// <b>True:</b> the user is calculating for a <b>Token</b> target value.<br/>
        /// </para>
        /// This variable is true by default because I personally believe that the only reason one would go as far as to use an actual calculator app to optimize expenditures would be to calculate for a worst-case scenario with L2D costume ceilings.
        /// </summary>
        private bool targetingTickets = true;
        /// <summary>
        /// Whether the user is calculating for the global server or the Korean server.
        /// <para>
        /// <b>True:</b> the user is calculating for the <b>global</b> server.<br/>
        /// <b>False:</b> the user is calculating for the <b>Korean</b> server.
        /// </para>
        /// This variable is true by default because I'm playing on the global server myself.
        /// </summary>
        private bool serverGl = true;
        /// <summary>
        /// The number of tokens the user has entered is within their possession. This value is subtracted from the target to determine the net amount of tokens required.
        /// </summary>
        private int myTokens;
        /// <summary>
        /// The number of gems the user has entered is within their possession. This value is subtracted from the quoted price to determine the net amount of gems required.
        /// </summary>
        private int myGems;
        /// <summary>
        /// The target the user wishes to achieve. Depending on the setting, this value can refer to either:
        /// <para>
        /// <b>Tokens:</b> the number of tokens the user wishes to reach, or<br/>
        /// <b>Tickets:</b> the number of exchange tickes the user wishes to reach.
        /// </para>
        /// </summary>
        private int target;
        /// <summary>
        /// An array containing the quantities of gems available from each package, as well as their price in USD.<br/>
        /// This array is only used when the selected server is <b>Global.</b><br/>
        /// The array is in descending order of gem quantity because of the algorithm I am employing for efficient packing.
        /// </summary>
        private readonly int[,] glGemArray = new int[,] { { 8000, 100 }, { 4000, 50 }, { 2000, 26 }, { 800, 10 }, { 330, 5 }, { 60, 1 } };
        /// <summary>
        /// An array containing the quantities of gems available from each package, as well as their price in KRW.<br/>
        /// This array is only used when the selected server is <b>Korea.</b><br/>
        /// The array is in descending order of gem quantity because of the algorithm I am employing for efficient packing.
        /// </summary>
        private readonly int[,] krGemArray = new int[,] { { 7224, 119000 }, { 3983, 69000 }, { 2350, 41000 }, { 1118, 20000 }, { 535, 9900 }, { 315, 5900 }, { 63, 1200 } };
        /// <summary>
        /// An array containing the names of each gem package purchaseable on the Korean server.<br/>
        /// Funnily enough, KR has names for each packages, while on global it's just the number.
        /// </summary>
        private readonly string[] krGemName = new string[] { "보석 트럭(대)", "보석 트럭(소)", "보석 상자(대)", "보석 상자(소)", "보석 주머니(대)", "보석 주머니(중)", "보석 주머니(소)" };
        /// <summary>
        /// The number of each package the user is expected to purchase to achieve their target using the efficient strategy.. If global, the last element is not used.
        /// </summary>
        private int[] efficientPackage = new int[7];
        /// <summary>
        /// The number of gems left if following the efficient strategy.
        /// </summary>
        private int efficientGemsLeft = 0;
        /// <summary>
        /// The string output for the efficient strategy.
        /// </summary>
        private string efficientOutput = "";
        /// <summary>
        /// The final quote, in real currency, that the user is expected to pay for the cheapest strategy.
        /// </summary>
        private int efficientQuote = 0;
        /// <summary>
        /// An auxiliary boolean variable used to determine if the user is actively calculating a strategy.<br/>
        /// While this variable is <b>true,</b> any changes to myTokens, myGems, or target will also trigger a recalculation.
        /// </summary>
        private bool calcSet = false;
        /// <summary>
        /// A boolean to keep track of if the first time purchase bonuses are to be applied or not.<br/>
        /// First time purchases receive an "extra gift" that doubles the gems granted per package.<br/>
        /// Although I could just use the checkbox status... I figured this was better practice.
        /// </summary>
        private bool dubGems = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// A method to check which of the two options (Token or Ticket) has been selected. Will be called every time the option is toggled.<br/>
        /// Because there are only two options (and therefore only two radioboxes) a second <i>CheckedChanged</i> method on the tickets radiobox is redundant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateTickets_CheckedChanged(object sender, EventArgs e)
        {
            targetingTickets = calculateTickets.Checked;
            ClearCalc();
            if (calcSet)
                Calculate();
        }

        private void myTokensUpDown_ValueChanged(object sender, EventArgs e)
        {
            myTokens = (int)myTokensUpDown.Value;
            ClearCalc();
            if (calcSet)
                Calculate();
        }

        private void TargetUpDown_ValueChanged(object sender, EventArgs e)
        {
            target = (int)TargetUpDown.Value;
            ClearCalc();
            if (calcSet)
                Calculate();
        }
        /// <summary>
        /// A method to check which of the two servers (global or Korean) has been selected. Will be called every time the option is toggled.<br/>
        /// This is because, surprisingly, global and Korea differs quite dramatically in both gems per package and price per package. Personally I prefer global a lot more. Better rounded.<br/>
        /// Because there are only two options (and therefore only two radioboxes) a second <i>CheckedChanged</i> method on the Korean radiobox is redundant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverGLRadio_CheckedChanged(object sender, EventArgs e)
        {
            serverGl = serverGLRadio.Checked;
            ClearCalc();
            if (calcSet)
                Calculate();
        }

        private void myGemsUpDown_ValueChanged(object sender, EventArgs e)
        {
            myGems = (int)myGemsUpDown.Value;
            ClearCalc();
            if (calcSet)
                Calculate();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            ClearCalc();
            Calculate();
            calcSet = true;
        }
        /// <summary>
        /// A method to determine the "optimal" purchasing strategy for the user with <b>myTokens</b> tokens to reach <b>target</b> number of tokens or exchange tickets.<br/>
        /// Note that "optimal" here follows two definitions, as made evident by the fork within this method:<para>
        /// <b>1.</b> The strategy that results in the minimum amount of real life currency spent, or the <b>"cheapest"</b> strategy.<br/>
        /// <b>2.</b> The strategy that allows for some additional expenditure to obtain leftover gems at a higher rate than usually possible, or the <b>"efficient"</b> strategy.
        /// </para>
        /// The cheapest strategy will allow for the user to attain their goal at the lowest price tag theoretically possible, while the efficient strategy will allow the user to gain a few gems (at most 800) at a very low additional cost (at most 10 dollars).<br/>
        /// Unless the user is brinking on a life-or-death situation where they are forced to choose between a sandwich that will feed them for the rest of the day or a raifu costume, I personally recommend the efficient strategy.<br/>
        /// This is because stockpiling a few more gems will contribute towards any potential future purchases as well, and although the cheapest strategy may indeed be the cheapest possible strategy at this time, the efficient strategy will grant leverage on any future purchases.<br/><br/>
        /// 
        /// Note that this distinction is only realistically significant on global because the cost efficiency on the Korean servers is so gradual that the most efficient strategy is basically the cheapest strategy.<br/>
        /// On global there is a distinction because the 8000, 4000, and 800 gem packages all share the highest cost efficiency of 80 gems per USD, which dips at the 2000 gem package at 76.92 gems per USD and severely drops with the 330 gem package to 66 gems per USD.<br/>
        /// This is what allows for a maximum of 800 gems more for a maximum of 10 USD spent on global (more than 80 leftover gems per USD spent)<br/>
        /// On the Korean server, all packages are priced within 5% of the rate of the immediately larger package, compared to the 800-330 drop of 17.5% in rate on global.
        /// </summary>
        private void Calculate()
        {
            //Calculate token goal if using tickets
            int netToken;
            if (targetingTickets)
            {
                int elevenx = target / 11;
                int single = target % 11;
                netToken = elevenx * 100 + single * 10 - myTokens;
            }
            else
                netToken = target - myTokens;
            //Calculate gem cost for reaching target value
            int hundPack = netToken / 100;
            int tenPack = (int)Math.Ceiling((netToken % 100) / 10.0);
            int gemCost = (hundPack * 600 + tenPack * 80)-myGems;
            //Trivial case where net gem cost is negative (the user already has enough resources to fund their target)
            if (gemCost <= 0)
            {
                efficientOutputLabel.Text = "You already have enough tokens and gems to reach your goal.";
                return;
            }
            //Set temporary array for calculation depending on server
            int[,] gems = new int[0,0];
            if (serverGl)
                gems = (int[,]) glGemArray.Clone();
            else
                gems = (int[,]) krGemArray.Clone();
            if(dubGems) //double gems if applying bonuses
                for(int i = 0; i < gems.Length / 2; i++)
                {
                    gems[i, 0] *= 2;
                }
            //Assess strategy
            int count = 0;  //how many packages can you buy without going over the target
            int remainder = 0;  //how many gems do you have left after filling count
            EfficientOutputCalc(gemCost, gems, count, remainder);
            FormatEfficientOutput();
            //packageNum holds information on which packages to buy, and bestRateIndex should tell us which package gives us more figurative bang for the literal buck
        }
        /// <summary>
        /// A helper method used to calculate the most efficient strategy available to the user.
        /// </summary>
        /// <param name="gemCost">The net cost in gems the user has to meet.</param>
        /// <param name="gems">The array of gem packages used by the method, depending on the server selected.</param>
        /// <param name="count">The number of each package the user is expected to purchase.</param>
        /// <param name="remainder">The remaining gem cost the user has to pay after purchasing packages.</param>
        private void EfficientOutputCalc(int gemCost, int[,] gems, int count, int remainder)
        {
            for (int i = 0; i < gems.Length / 2; i++)    //for the efficient strategy,
            {
                //assign values for this package
                count = gemCost / gems[i, 0];
                remainder = gemCost % gems[i, 0];
                //In the efficient strategy,
                if ((remainder > 0 &&   //if there is a non-zero leftover that we still need to take care of
                    i < gems.Length/2 - 1 &&  //and this is not the last package
                    Math.Ceiling((double)remainder / gems[i, 0]) * gems[i, 1] //and the expenditure to cover the remainder with this package
                    <= Math.Ceiling((double)remainder / gems[i + 1, 0]) * gems[i + 1, 1]) //is less than the expenditure to cover the remainder with the next, smaller package
                    || i == gems.Length/2 - 1)  //or if this happens to be the last package available, and this is the only way to clean up the leftover
                {
                    //then buy this package since it's more efficient than buying multiple of the next package (or there is no next package to buy)
                    //In this case we will not purchase any further packages and we can break out of the loop
                    efficientPackage[i] = count + 1;
                    efficientGemsLeft = gems[i, 0] - remainder;
                    break;
                }
                //otherwise wrap it up and move on to the next package
                efficientPackage[i] = count;
                gemCost -= gems[i, 0] * count;
            }
        }
        /// <summary>
        /// A helper method used to format the string output for the efficient strategy.
        /// </summary>
        private void FormatEfficientOutput()
        {
            string output;
            output = "The most efficient strategy is: \n\n";
            //global servers require no package names
            if (serverGl)
            {
                for (int i = (glGemArray.Length / 2) - 1; i >= 0; i--)
                {
                    if (efficientPackage[i] != 0)
                    {
                        output += efficientPackage[i] + "x " + glGemArray[i, 0] + " Gems package\n";
                        efficientQuote += glGemArray[i, 1] * efficientPackage[i];
                    }
                }
                output += "\nCosting a net "+efficientQuote +" USD\n"+
                "and "+efficientGemsLeft+" additional gems left over";
            }
            else
            {
                for (int i = (krGemArray.Length / 2) - 1; i >= 0; i--)
                {
                    if (efficientPackage[i] != 0)
                    {
                        output += efficientPackage[i] + "x " + krGemName[i]+"\n";
                        efficientQuote += krGemArray[i, 1] * efficientPackage[i];
                    }
                }
                output += "\nCosting a net " + efficientQuote + " KRW\n" +
                "and " + efficientGemsLeft + " additional gems left over";
            }
            efficientOutputLabel.Text = output;
            Console.WriteLine(dubGems);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        /// <summary>
        /// A method that reconfigures all variables to their default settings. Excluding readonly objects, of course.<br/>
        /// </summary>
        private void ClearAll()
        {
            //Class variables
            targetingTickets = true;
            serverGl = true;
            myTokens = 0;
            myGems = 0;
            target = 0;
            efficientPackage = new int[7];
            efficientGemsLeft = 0;
            efficientOutput = "";
            efficientQuote = 0;
            calcSet = false;
            //Winforms
            calculateTickets.Checked = true;
            myTokensUpDown.Value = 0;
            TargetUpDown.Value = 0;
            serverGLRadio.Checked = true;
            myGemsUpDown.Value = 0;
            efficientOutputLabel.Text = "";
        }
        /// <summary>
        /// A method that reconfigures some variables to their default settings. Only the numerical variables that work internally (not user input) are affected.
        /// </summary>
        private void ClearCalc()
        {
            efficientPackage = new int[7];
            efficientGemsLeft = 0;
            efficientOutput = "";
            efficientQuote = 0;
        }

        private void doubleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dubGems = doubleCheckBox.Checked;
            ClearCalc();
            if (calcSet)
                Calculate();
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Did you know that there is a 30% chance that you would hit the ceiling rolling for a L2D costume without hitting the costume?\n" +
                 "That's 600 failed attempts that would set you back at least 5,455 tokens!\n\n" +
                 "If you didn't know, that's ok. I didn't know until I had to trade in a month's worth of food for R93's Holiday Lucky Star costume myself.\n" +
                 "But now with this tool available, we can all make educated decisions on how long we have to go without food to clothe (or in my case, unclothe) our raifus.\n\n" +
                 "HKM4 best waifu tho.", "About GFL Gems Calculator Ver.α");
        }

    }

}
