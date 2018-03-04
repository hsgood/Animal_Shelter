using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        Customer[] CustomerArray = new Customer[10];
        int CustomerArrayIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerArray[CustomerArrayIndex]= new Customer(CusNewFirstName.Text, CusNewLastName.Text
                , DateTime.Parse(CusNewBirthday.Text));
            CustomerArray[CustomerArrayIndex].Address = CusNewAddress.Text;
            CustomerArray[CustomerArrayIndex].Description = CusNewDescription.Text;

            CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FirstName);
            CustomerArrayIndex++;

            //DateTime birthday = new DateTime(2001, 1, 1);
            //Customer cus = new Customer("Ian", "Na", birthday);
            //cus.Address = "123 Wilshire Blvd.";

           
            /**
            cus1.Address = CusNewAddress.Text;
            //CusFullName.Text = cus.GetFullName();
            CusFullName.Text = cus1.FullName;
            CusLastName.Text = cus1.LastName;
            //CusAge.Text = cus.GetAge().ToString();
            CusAge.Text = cus1.Age.ToString();
            CusAddress.Text = cus1.Address;
            CusDescription.Text = cus1.Description;
            CusIsQualified.Text = cus1.IsQualified.ToString();
            //bool test = cus.GetIsQualified();

            DateTime date = new DateTime(2017, 2, 27);    //DateTime은 구조체이고 클래스 처럼 선언한다
            DateTime current = DateTime.Now;            //현재의 날짜와 시간 
            **/
        }

        void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusLastName.Text = cus.LastName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstname = CustomerList.SelectedItem.ToString();

            for (int index=0;index<CustomerArrayIndex;index++)
            {
               if( CustomerArray[index].FirstName==firstname)
                {
                    ShowDetails(CustomerArray[index]);
                    break;
                }
            }
        }
    }
}
