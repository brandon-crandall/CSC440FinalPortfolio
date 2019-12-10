/// <summary>
/// SOURCE: https://www.youtube.com/watch?v=l66AAoBf6yE
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Create a functional web browser.
/// </summary>
/// 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //when the forward button is clicked it will go forward a page
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }
        //allows text in the textbox
        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                webBrowser.Navigate(txtUrl.Text);
        }
        //goes back a page
        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }
        //refreshes the page
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }
        //as long as the textbox isn't empty it navigates to the page
        private void btnGo_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUrl.Text))
                webBrowser.Navigate(txtUrl.Text);
        }
    }
}
//MODIFICATIONS: Followed along with the video. 

//ANALYSIS: Functional web browser with forward, back and refresh buttons.

/* Sample Output
Simple web browser window.
 */
