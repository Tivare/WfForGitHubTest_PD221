namespace WfForGitHubTest_PD221
{
    public partial class Form1 : Form
    {
        List<string> quots;
        Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new();
           
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            lblData.Text = quots[rand.Next(quots.Count)];
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                quots = (await File.ReadAllLinesAsync("quotes.txt")).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}