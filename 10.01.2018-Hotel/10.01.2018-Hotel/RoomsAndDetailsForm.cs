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
    public partial class RoomsAndDetailsForm : Form
    {
        HotelDBEntities db = new HotelDBEntities();
        public RoomsAndDetailsForm()
        {
            InitializeComponent();
            this.fillCmb();
            this.fillDgw();
        }


       
        private void btnSave_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(this.cmbRoomNumber.Text);
            int roomId = db.Rooms.Where(r => r.room_number == number).First().id;
            int detailId = db.Room_Details.Where(d => d.detail_name == this.cmbRoomDetail.Text).First().id;


            Rooms_Details room_and_details = new Rooms_Details();
            room_and_details.room_id = roomId;
            room_and_details.detail_id = detailId;
            db.Rooms_Details.Add(room_and_details);
            db.SaveChanges();
            this.cmbRoomDetail.Text = "";
            this.cmbRoomNumber.Text = "";
            this.fillDgw();
        }

        private void fillDgw()
        {
            this.dgwData.Rows.Clear();
            List<Rooms_Details> rooms_and_details = db.Rooms_Details.ToList();
            for(int i = 0; i < rooms_and_details.Count; i++)
            {
                this.dgwData.Rows.Add();
                this.dgwData.Rows[i].Cells[0].Value = rooms_and_details[i].Room.room_number;
                this.dgwData.Rows[i].Cells[1].Value = rooms_and_details[i].Room_Details.detail_name;
            }
        }

        private void fillCmb()
        {
            this.cmbRoomDetail.Items.Clear();
            this.cmbRoomNumber.Items.Clear();
            List<Room> rooms = db.Rooms.ToList();
            List<Room_Details> details = db.Room_Details.ToList();
            foreach (Room item in rooms)
            {
                this.cmbRoomNumber.Items.Add(item.room_number);
            }
            foreach (Room_Details item in details)
            {
                this.cmbRoomDetail.Items.Add(item.detail_name);
            }
        }

    }
}
