using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUsingAsync_Await
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Code Don't (Async && Await)
        private int CountCharcters()
        {
            int count = 0;  
            using(StreamReader reader = new StreamReader(@"C:\Users\AL Sadat\Desktop\Data.txt"))
            {
                string content = reader.ReadLine();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            lbltext.Text = "Processing File. Please Wait ....";
            int count = CountCharcters();   
            lbltext.Text = count.ToString() + " Characters in File";    
        }
        #endregion
    }
}
