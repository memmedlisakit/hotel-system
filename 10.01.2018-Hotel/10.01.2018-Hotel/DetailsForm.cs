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
    public partial class DetailsForm : Form
    {
        HotelDBEntities db = new HotelDBEntities();
        public DetailsForm()
        {
            InitializeComponent();
            this.fillDgw();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtDetailName.Text != "")
            {
                Room_Details details = new Room_Details();
                details.detail_name = this.txtDetailName.Text;
                db.Room_Details.Add(details);
                db.SaveChanges();
                MessageBox.Show("Elave edildi.");
                this.txtDetailName.Text = "";
                this.fillDgw();
            }
            else
            {
                MessageBox.Show("Bosluq olmaz");
            }

           
        }

        private void fillDgw()
        {
            this.dgwData.Rows.Clear();
            int i = 0;
            List<Room_Details> details = db.Room_Details.ToList();
            foreach (Room_Details item in details)
            {
                this.dgwData.Rows.Add();
                this.dgwData.Rows[i].Cells[0].Value = item.detail_name;
                i++;
            }
        }
    }
}
