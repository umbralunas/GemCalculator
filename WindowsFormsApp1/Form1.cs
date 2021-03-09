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
        private int[] solutionArray = new int[7];
        /// <summary>
        /// The number of gems left if following the efficient strategy.
        /// </summary>
        private int gemsRemaining = 0;
        /// <summary>
        /// The final quote, in real currency, that the user is expected to pay for the efficient strategy.
        /// </summary>
        private int finalQuote = 0;
        /// <summary>
        /// An auxiliary boolean variable used to determine if the user is actively calculating a strategy.<br/>
        /// While this variable is <b>true,</b> any changes to myTokens, myGems, or target will also trigger a recalculation.
        /// </summary>
        private bool calcSet = false;
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

        /// <summary>
        /// A method to determine the "optimal" purchasing strategy for the user with <b>myTokens</b> tokens to reach <b>target</b> number of tokens or exchange tickets.<br/>
        /// Note that EN has a weird dip in package effectiveness with the 2000 gem package, set at 76.92 gems per dollar compared to the 8000, 4000, and 800 dollar packages that give a rate of 80 gems per dollar.<br/>
        /// I do not believe this should be significant enough to incur major losses, but this is nonetheless a possible source of error.
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
            int gemCost = (hundPack * 600 + tenPack * 80) - myGems;
            //Trivial case where net gem cost is zero or negative (the user already has enough resources to fund their target)
            if (gemCost <= 0)
            {
                efficientOutputLabel.Text = "You already have enough tokens and gems to reach your goal.";
                return;
            }
            //Set temporary array for calculation depending on server
            int[,] gems;
            if (serverGl)
                gems = (int[,])glGemArray.Clone();
            else
                gems = (int[,])krGemArray.Clone();
            //Assess strategy
            EfficientOutputCalc(gemCost, gems);
            FormatEfficientOutput();
        }
        /// <summary>
        /// A helper method used to calculate the most efficient strategy available to the user.
        /// </summary>
        /// <param name="gemCost">The net cost in gems the user has to meet.</param>
        /// <param name="gems">The array of gem packages used by the method, depending on the server selected.</param>
        private void EfficientOutputCalc(int gemCost, int[,] gems)
        {
            int[,] solutionMatrix = new int[gems.Length / 2, gems.Length / 2];  //A matrix to store all viable solutions
            int[] modulo = new int[gems.Length / 2];
            int[] quoteArray = new int[gems.Length / 2];
            int cheapestIndex = 0;
            for (int i = 0; i < Math.Sqrt(solutionMatrix.Length); i++)
            {
                int tempCost = gemCost;
                for (int j = 0; j < Math.Sqrt(solutionMatrix.Length); j++)
                {
                    if (j == i) //and we are focusing on this particular package
                        solutionMatrix[j, i] = (int)Math.Ceiling((double)tempCost / gems[j, 0]);    //then fill up to the target with this package
                    else //if not
                        solutionMatrix[j, i] = (int)Math.Floor((double)tempCost / gems[j, 0]);  //move on to the next package
                    if (tempCost > 0)    //if there is still some amount to go for the target
                    {
                        tempCost -= solutionMatrix[j, i] * gems[j, 0];  //subtract from the current cost for the next package
                        if (tempCost <= 0)   //if this change allowed the user to reach the target
                        {
                            modulo[i] = Math.Abs(tempCost); //log the amount of leftover gems from this transaction
                            tempCost = 0;   //do not make any more purchases. We could break out of this loop, but for some reason it doesn't feel right.
                        }
                    }
                    quoteArray[i] += solutionMatrix[j, i] * gems[j, 1];
                }
                if (quoteArray[i] < quoteArray[cheapestIndex])   //if the quote from this solution is cheaper than our current "cheapest" solution
                    cheapestIndex = i;  //switch out the "cheapest" solution for this one
            }
            for (int i = 0; i < Math.Sqrt(solutionMatrix.Length); i++)
            {
                solutionArray[i] = solutionMatrix[i, cheapestIndex];
            }
            gemsRemaining = modulo[cheapestIndex];
        }
        /// <summary>
        /// A helper method used to format the string output for the efficient strategy.
        /// </summary>
        private void FormatEfficientOutput()
        {
            string output;
            output = "Your most efficient strategy is: \n\n";
            //global servers require no package names
            if (serverGl)
            {
                for (int i = (glGemArray.Length / 2) - 1; i >= 0; i--)
                {
                    if (solutionArray[i] != 0)
                    {
                        output += solutionArray[i] + "x " + glGemArray[i, 0] + " Gems package\n";
                        finalQuote += glGemArray[i, 1] * solutionArray[i];
                    }
                }
                output += "\nCosting a net " + finalQuote + " USD\n" +
                "and " + gemsRemaining + " additional gems left over";
            }
            else
            {
                for (int i = (krGemArray.Length / 2) - 1; i >= 0; i--)
                {
                    if (solutionArray[i] != 0)
                    {
                        output += solutionArray[i] + "x " + krGemName[i] + "\n";
                        finalQuote += krGemArray[i, 1] * solutionArray[i];
                    }
                }
                output += "\nCosting net " + finalQuote + " KRW\n" +
                "and " + gemsRemaining + " additional gems left over";
            }
            efficientOutputLabel.Text = output;
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
            solutionArray = new int[7];
            gemsRemaining = 0;
            finalQuote = 0;
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
            solutionArray = new int[7];
            gemsRemaining = 0;
            finalQuote = 0;
        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            ClearCalc();
            Calculate();
            calcSet = true;
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void myTokensUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            myTokens = (int)myTokensUpDown.Value;
            ClearCalc();
            if (calcSet)
                Calculate();
        }

        private void myGemsUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            myGems = (int)myGemsUpDown.Value;
            ClearCalc();
            if (calcSet)
                Calculate();
        }

        private void TargetUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            target = (int)TargetUpDown.Value;
            ClearCalc();
            if (calcSet)
                Calculate();
        }

        private void serverGLRadio_CheckedChanged(object sender, EventArgs e)
        {
            serverGl = serverGLRadio.Checked;
            ClearCalc();
            if (calcSet)
                Calculate();
        }

        private void calculateTickets_CheckedChanged_1(object sender, EventArgs e)
        {
            targetingTickets = calculateTickets.Checked;
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

    }

}
