using System;
using System.Windows.Forms;
using Guestbook_Web_Service_Tester.GuestbookServiceReference;


namespace Guestbook_Web_Service_Tester
{


    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            var soapClient = new Service1SoapClient();

            soapClient.SignGuestBook( userNametextBox.Text, userMessageTextBox.Text );





        }



        private void button2_Click(object sender, EventArgs e)
        {

            var soapClient = new Service1SoapClient();



            guestbookDataGridView.DataSource = soapClient.RetrieveGuestBookData();




        }




    }



}
