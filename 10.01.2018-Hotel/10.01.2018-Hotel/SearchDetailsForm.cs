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
    public partial class SearchDetailsForm : Form
    {
        HotelDBEntities db = new HotelDBEntities();
        public SearchDetailsForm()
        {
            InitializeComponent();
            this.fillCmb();
        }

        private void fillCmb()
        {
            List<Room_Types> types = db.Room_Types.ToList();
            foreach (Room_Types item in types)
            {
                this.cmbRoomType.Items.Add(item.room_type_name);
            }
        }

        private void clearing()
        {
            this.txtBedCount.Text = "";
            this.txtMin.Text = "";
            this.txtMax.Text = "";
            this.txtRoomNumber.Text = "";
            this.cmbRoomType.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text == "" && txtMin.Text == "" && txtMax.Text == "" && txtBedCount.Text == "" && cmbRoomType.Text == "")
            {
                List<Room> rooms = db.Rooms.ToList();
                this.fillDgw(rooms);
            }
            else
            {
                int r_number = txtRoomNumber.Text == "" ? 0 : Convert.ToInt32(txtRoomNumber.Text);
                int r_type = cmbRoomType.Text == "" ? 0 : db.Room_Types.Where(t => t.room_type_name == cmbRoomType.Text).First().id;
                int r_bed_count = txtBedCount.Text == "" ? 0 : Convert.ToInt32(txtBedCount.Text);
                int r_min = txtMin.Text == "" ? 0 : Convert.ToInt32(txtMin.Text);
                int r_max = txtMax.Text == "" ? 0 : Convert.ToInt32(txtMax.Text);
                List<Room> rooms = db.Rooms.Where(r => r.room_number == r_number || r.room_type_id == r_type || r.bed_count == r_bed_count || r.room_price >= r_min && r.room_price <= r_max).ToList();
                this.fillDgw(rooms);
            }
            this.clearing();
        }

        private void fillDgw(List<Room> _rooms)
        {
            this.dgwData.Rows.Clear();
            for (int i = 0; i < _rooms.Count; i++)
            {
                this.dgwData.Rows.Add();
                this.dgwData.Rows[i].Cells[0].Value = _rooms[i].id;
                this.dgwData.Rows[i].Cells[1].Value = _rooms[i].room_number;
                this.dgwData.Rows[i].Cells[2].Value = _rooms[i].Room_Types.room_type_name;
                this.dgwData.Rows[i].Cells[3].Value = _rooms[i].bed_count;
                this.dgwData.Rows[i].Cells[4].Value = _rooms[i].room_price+" AZN";
                this.dgwData.Rows[i].Cells[5].Value = _rooms[i].room_reservation_status;
                this.dgwData.Rows[i].Cells[6].Value = _rooms[i].room_cleaning_status;
                this.dgwData.Rows[i].Cells[7].Value = _rooms[i].room_status;
            }
        }

        private void room_info(object sender, DataGridViewCellMouseEventArgs e)
        {
            RoomInfoForm form = new RoomInfoForm(); 
            int roomId = (int)this.dgwData.Rows[e.RowIndex].Cells[0].Value;
            Room room = db.Rooms.Where(r => r.id == roomId).First();
            form.lblRoomNumber.Text = room.room_number.ToString();
            form.lblRoomType.Text = room.Room_Types.room_type_name;
            form.lblRoomPrice.Text = room.room_price.ToString();
            form.lblBedCount.Text = room.bed_count.ToString();
            form.lblCleaning.Text = room.room_cleaning_status == true ? "Temiz" : "Kirli";
            form.lblReservation.Text = room.room_reservation_status == true ? "Bos" : "Dolu";
            form.lblStatus.Text = room.room_status == true ? "Islekdir" : "Temirde";
         
            List<Rooms_Photos> photos = db.Rooms_Photos.Where(r => r.room_id == roomId).ToList();

            for(int  i=0; i < photos.Count; i++)
            {
                PictureBox pc = new PictureBox();
                pc.Width = 475;
                pc.Height = 255;
                pc.Image = Image.FromFile(photos[i].Photo.image_src + photos[i].Photo.image_name);
                pc.SizeMode = PictureBoxSizeMode.StretchImage;
                form.lfwpPhotos.Controls.Add(pc);
            }

            form.ShowDialog();
        }
    }
}
