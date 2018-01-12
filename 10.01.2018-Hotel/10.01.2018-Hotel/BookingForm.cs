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
    public partial class BookingForm : Form
    {
        HotelDBEntities db = new HotelDBEntities();
        public BookingForm()
        {
            InitializeComponent();
            this.fillCmb();
            this.cleaning();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Booking bking = new Booking();
            Random rnd = new Random();
            int code = rnd.Next(1000, 9999);
            int userId = db.Users.Where(u => u.user_full_name == this.cmbUser.Text).First().id;
            int typeId = db.Room_Types.Where(t => t.room_type_name == this.cmbRoomType.Text).First().id;
            bking.booking_code = code;
            bking.check_in_date = this.dtpCheckIn.Value;
            bking.check_out_date = this.dtpCheckOut.Value;
            bking.adult_count = this.txtAdulCount.Text == "" ? 0 : Convert.ToInt32(this.txtAdulCount.Text);
            bking.child_count = this.txtChildCount.Text == "" ? 0 : Convert.ToInt32(this.txtChildCount.Text);
            bking.booking_status = this.ckbStatus.Checked;
            bking.user_id = userId;
            bking.room_type_id = typeId;
            db.Bookings.Add(bking);
            db.SaveChanges();
            this.cleaning();
        }

        private void fillCmb()
        {
            List<User> users = db.Users.ToList();
            List<Room_Types> types = db.Room_Types.ToList();
            this.cmbRoomType.Items.Clear();
            this.cmbUser.Items.Clear();
            foreach (User item in users)
            {
                this.cmbUser.Items.Add(item.user_full_name);
            }
            foreach (Room_Types item in types)
            {
                this.cmbRoomType.Items.Add(item.room_type_name);
            }
        }

        private void cleaning()
        {
            this.txtAdulCount.Text = "";
            this.txtChildCount.Text = "";
            this.cmbRoomType.Text = "";
            this.cmbUser.Text = "";
            this.ckbStatus.Checked = false;
            this.dtpCheckIn.Value = DateTime.Now;
            this.dtpCheckOut.Value = DateTime.Now;
            this.fillDgw();
        }

        private void fillDgw()
        {
            this.dgwBookingData.Rows.Clear();
            List<Booking> bookings = db.Bookings.ToList();
            for(int i = 0; i < bookings.Count; i++)
            {
                this.dgwBookingData.Rows.Add();
                this.dgwBookingData.Rows[i].Cells[0].Value = bookings[i].id;
                this.dgwBookingData.Rows[i].Cells[1].Value = bookings[i].booking_code;
                this.dgwBookingData.Rows[i].Cells[2].Value = bookings[i].check_in_date.ToString("dd_MM_yyyy");
                this.dgwBookingData.Rows[i].Cells[3].Value = bookings[i].check_out_date.ToString("dd_MM_yyyy");
                this.dgwBookingData.Rows[i].Cells[4].Value = bookings[i].adult_count;
                this.dgwBookingData.Rows[i].Cells[5].Value = bookings[i].child_count;
                this.dgwBookingData.Rows[i].Cells[6].Value = bookings[i].Room_Types.room_type_name;
                this.dgwBookingData.Rows[i].Cells[7].Value = bookings[i].User.user_full_name;
                this.dgwBookingData.Rows[i].Cells[8].Value = bookings[i].booking_status == true ? "Active" : "Passive";
            }
        }
    }
}
