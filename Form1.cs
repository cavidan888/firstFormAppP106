using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudOperation
{
    public partial class Form1 : Form
    {
        public int count = 1;

        public Form1()
        {
            InitializeComponent();
            Result.Enabled = false;
            idContainer.DropDownStyle = ComboBoxStyle.DropDownList;
            YourName.ForeColor = Color.Red;
            YourSurName.ForeColor = Color.Red;
            YourAge.ForeColor = Color.Red;
            this.Width = 804;
            this.Height = 500;
            
        }

        private void crt_Click_1(object sender, EventArgs e)
        {

        
            if (YourName.Text == "" || YourSurName.Text == "" || YourAge.Text == "")
            {
                MessageBox.Show("Bowluqlari Doldurun");
            }
            else
            {

                var name = YourName.Text;
                var surname = YourSurName.Text;
                var age = Convert.ToInt32(YourAge.Text);

                User user = new User(name, surname, age);
                user.ID = count;
                YourName.Text = "";
                YourSurName.Text = "";
                YourAge.Text = "";
                count++;

                idContainer.Items.Clear();

                foreach (var item in User.userList)
                {
                    idContainer.Items.Add(item.ID);
                }
            }
        }

        private void ReadData_Click_1(object sender, EventArgs e)
        {

        


        Result.Text = "";

            foreach (var item in User.userList)
            {
                Result.Text += item.ID + "." + item.Ad + " - " + item.Soyad + " - " + item.age + "\r\n";
            }
        }

        private void dlt_Click(object sender, EventArgs e)
        {
            var secilmisDeyer = idContainer.SelectedItem;
            foreach (var item in User.userList)
            {
                if (item.ID ==Convert.ToInt32(secilmisDeyer))
                {
                    User.userList.Remove(item);
                    idContainer.Items.Remove(item.ID);
                    break;
                }
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            var secdiyimIdUpdate = idContainer.SelectedItem;

            foreach (var item in User.userList)
            {
                if (item.ID ==Convert.ToInt32(secdiyimIdUpdate))
                {
                    item.Ad = YourName.Text;
                    item.Soyad = YourSurName.Text;
                    item.age =Convert.ToInt32(YourAge.Text);
                }
            }

            
           
        }
    }
           

            
   }
    

    class User
    {
        public static List<User> userList = new List<User>();

        public int ID;
        public string Ad;
        public string Soyad;
        public int age;

    

    public User(string _ad , string _soyad , int _age)
        {
            this.Ad = _ad;
            this.Soyad = _soyad;
            this.age = _age;
            userList.Add(this);
        }
    }
