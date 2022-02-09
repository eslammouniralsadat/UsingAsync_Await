namespace AppUsingAsync_Await
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Code Don't Using (Async && Await)
        //private int CountCharcters()
        //{
        //    int count = 0;  
        //    using(StreamReader reader = new StreamReader(@"C:\Users\AL Sadat\Desktop\Data.txt"))
        //    {
        //        string content = reader.ReadLine();
        //        count = content.Length;
        //        Thread.Sleep(5000);
        //    }
        //    return count;
        //}
        //private void BtnProcess_Click(object sender, EventArgs e)
        //{
        //    lbltext.Text = "Processing File. Please Wait ....";
        //    int count = CountCharcters();   
        //    lbltext.Text = count.ToString() + " Characters in File";    
        //}
        #endregion

        #region Code Using (Async && Await)
        private int CountCharcters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(@"C:\Users\AL Sadat\Desktop\Data.txt"))
            {
                string content = reader.ReadLine();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private async void BtnProcess_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharcters);
            task.Start();

            lbltext.Text = "Processing File. Please Wait ....";
            int count = await task;
            lbltext.Text = count.ToString() + " Characters in File";
        }
        #endregion
    }
}
