using System;
using System.Windows.Forms;
using RemoveDuplicates;
using FindMissingNumber;

namespace Runner
{
    public partial class MainForm : Form
    {
        private DuplicatesAnalyzer _duplicateAnalyzer;
        private MissingNumberAnalyzer _missingAnalyzer;

        public string ErrorText
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = value;
                }
            }
        }

        public string ResultText
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    resultLabel.ForeColor = System.Drawing.Color.Green;
                    resultLabel.Text = value;
                }
            }
        }
        private void inputTextBox_Enter(object sender, EventArgs e)
        {
            inputTextBox.Text = string.Empty;
            resultLabel.Text = string.Empty;
        }
        public MainForm()
        {
            InitializeComponent();
            _duplicateAnalyzer = new DuplicatesAnalyzer();
            _missingAnalyzer = new MissingNumberAnalyzer();
        }

        

        private void FindMissing_BTN_Click(object sender, EventArgs e)
        {


            var output = _missingAnalyzer.Analyze(inputTextBox.Text);
            var outResult = _missingAnalyzer.MissingFinder(output).ToString();
            //  if (!(output?.Length > 0))
            if (string.IsNullOrEmpty(outResult))
            {
                this.ResultText = "duplicate error";
            }

            this.ResultText = outResult;
        }

        private void RemoveDuplicate_BTN_Click(object sender, EventArgs e)
        {

            var output = _duplicateAnalyzer.Analyze(inputTextBox.Text);
            var outResult = _duplicateAnalyzer.RemoveDuplicates(output);
             if (!(outResult?.Length > 0))
            //if (string.IsNullOrEmpty(outResult))
            {
                this.ResultText = "Given string !!";
            }

            this.ResultText =  string.Join(",", outResult); ;


        }
    }
}
