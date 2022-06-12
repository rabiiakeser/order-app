using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mySecondCustmControl1.Hide();
            menuControl1.Hide();
            firstCustomControl1.Show();


            SidePanel.Height = button6.Height;
            firstCustomControl1.BringToFront();

            SidePanel.Height = button7.Height;
            mySecondCustmControl1.BringToFront();
           
           SidePanel.Height = button9.Height;
            menuControl1.BringToFront();

            SidePanel.Height = button10.Height;
           


           SidePanel.Height = button1.Height;
         
           SidePanel.Top = button1.Top;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

   

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            firstCustomControl1.BringToFront();
            SidePanel.Top = button6.Top;

            mySecondCustmControl1.Hide();
            menuControl1.Hide();
          
            firstCustomControl1.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            mySecondCustmControl1.BringToFront();
            SidePanel.Top = button7.Top;

            mySecondCustmControl1.Show();
            menuControl1.Hide();
          
            firstCustomControl1.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
           SidePanel.Height = button9.Height;
           menuControl1.BringToFront();
            SidePanel.Top=button9.Top;

            mySecondCustmControl1.Hide();
            menuControl1.Show();
            
            firstCustomControl1.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button10.Height;
            drinks1.BringToFront();
            SidePanel.Top=button10.Top;

            mySecondCustmControl1.Hide();
            menuControl1.Hide();
            drinks1.Show();
            firstCustomControl1.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            tatlılar1.BringToFront();
            SidePanel.Top=button1.Top;

            mySecondCustmControl1.Hide();
            menuControl1.Hide();
            drinks1.Hide();
            tatlılar1.Show();
            firstCustomControl1.Hide();
        }

        private void firstCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void ödeme2_Load(object sender, EventArgs e)
        {

        }
    }
}
