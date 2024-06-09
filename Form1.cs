namespace Error_Make
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string errorText = ERRORTEXT.Text;
            string errorTitle = ERRORTITLE.Text;
            MessageBoxIcon iconType = MessageBoxIcon.None;
            MessageBoxButtons buttonsType = MessageBoxButtons.OK;
            if (RB1.Checked)
            {
                iconType = MessageBoxIcon.None;
            }
            else if (RB2.Checked)
            {
                iconType = MessageBoxIcon.Error;
            }
            else if (RB3.Checked)
            {
                iconType = MessageBoxIcon.Question;
            }
            else if (RB4.Checked)
            {
                iconType = MessageBoxIcon.Warning;
            }
            else if (RB5.Checked)
            {
                iconType = MessageBoxIcon.Information;
            }
            if (RB6.Checked)
            {
                buttonsType = MessageBoxButtons.OK;
            }
            else if (RB7.Checked)
            {
                buttonsType = MessageBoxButtons.OKCancel;
            }
            else if (RB8.Checked)
            {
                buttonsType = MessageBoxButtons.AbortRetryIgnore;
            }
            else if (RB9.Checked)
            {
                buttonsType = MessageBoxButtons.YesNoCancel;
            }
            else if (RB10.Checked)
            {
                buttonsType = MessageBoxButtons.YesNo;
            }
            else if (RB11.Checked)
            {
                buttonsType = MessageBoxButtons.RetryCancel;
            }
            MessageBox.Show(errorText, errorTitle, buttonsType, iconType);
        }

    }
}
