using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._01._2018_Hotel
{
    public partial class UserForm : Form
    {
        HotelDBEntities db = new HotelDBEntities();
        public UserForm()
        {
            InitializeComponent();
            this.cleaning();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.checking())
            {
                User usr = new User();
                usr.user_full_name = this.txtUserFullName.Text;
                usr.user_email = this.txtUserEmail.Text;
                usr.user_phone = this.txtUserPhone.Text;
                db.Users.Add(usr);
                db.SaveChanges();
                this.cleaning();
            }
            else
            {
                this.lblError.Text = "Bosluq olmaz";
            }
        }


        private bool checking()
        {
            if (this.txtUserFullName.Text == "" || this.txtUserEmail.Text == "" || this.txtUserPhone.Text == "") 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cleaning()
        {
            this.txtUserFullName.Text = "";
            this.txtUserEmail.Text = "";
            this.txtUserPhone.Text = "";
            this.lblError.Text = "";
            this.fillDgw();
        }

        private void fillDgw()
        {
            this.dgwUserData.Rows.Clear();
            List<User> users = db.Users.ToList();
            for(int i = 0; i < users.Count; i++)
            {
                this.dgwUserData.Rows.Add();
                this.dgwUserData.Rows[i].Cells[0].Value = users[i].id;
                this.dgwUserData.Rows[i].Cells[1].Value = users[i].user_full_name;
                this.dgwUserData.Rows[i].Cells[2].Value = users[i].user_email;
                this.dgwUserData.Rows[i].Cells[3].Value = users[i].user_phone;
            }
        }
    }
}
