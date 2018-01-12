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
    public partial class Form1 : Form
    {
        HotelDBEntities db = new HotelDBEntities();
      
        public Form1()
        {
            InitializeComponent();
            this.fillCmb();
            this.fillDgw();
        }

    
        
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (checking())
            {
                int typeId = db.Room_Types.Where(r => r.room_type_name == this.cmbRoomType.Text).First().id;

                Room rom = new Room();
                rom.room_number = Convert.ToInt32(this.txtRoomNumber.Text);
                rom.room_type_id = typeId;
                rom.bed_count = Convert.ToInt32(this.txtBedCount.Text);
                rom.room_price = Convert.ToInt32(this.txtRoomPrice.Text);
                rom.room_reservation_status = this.ckbRoomReserv.Checked;
                rom.room_cleaning_status = this.ckbRoomClear.Checked;
                rom.room_status = this.ckbStatus.Checked;
                db.Rooms.Add(rom);
                db.SaveChanges();
                this.clearing();
                this.fillDgw();
            }
            else
            {
                this.lblError.Text = "Boshlug olmaz";
            }
            
        }

        private void searchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDetailsForm form = new SearchDetailsForm();
            form.ShowDialog();
        }

        private void addDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsForm dtl = new DetailsForm();
            dtl.ShowDialog();
        }

        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeForm typfrm = new TypeForm();
            typfrm.ShowDialog();
        }

        private void addPhotoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhotoForm phtForm = new PhotoForm();
            phtForm.ShowDialog();
        }

        private void roomAndDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RoomsAndDetailsForm frm = new RoomsAndDetailsForm();
            frm.ShowDialog();
        }

        private void roomAndPhotosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RoomsAndPhotos form = new RoomsAndPhotos();
            form.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm usrForm = new UserForm();
            usrForm.ShowDialog();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingForm bkForm = new BookingForm();
            bkForm.ShowDialog();
        }

        private void fillCmb()
        {
            this.cmbRoomType.Items.Clear();
            List<Room_Types> types = db.Room_Types.ToList();
            for (int i = 0; i < types.Count; i++)
            {
                this.cmbRoomType.Items.Add(types[i].room_type_name);
            }

        }

        private void clearing()
        {
            this.txtBedCount.Text = "";
            this.txtRoomNumber.Text = "";
            this.txtRoomPrice.Text = "";
            this.cmbRoomType.Text = "";
            this.ckbRoomClear.Checked = false;
            this.ckbRoomReserv.Checked = false;
            this.ckbStatus.Checked = false;
            this.lblError.Text = "";
        }

        private void fillDgw()
        {
            this.dgwRoomData.Rows.Clear();
            List<Room> rooms = db.Rooms.ToList();
            for (int i = 0; i < rooms.Count; i++)
            {
                this.dgwRoomData.Rows.Add();
                this.dgwRoomData.Rows[i].Cells[0].Value = rooms[i].room_number;
                this.dgwRoomData.Rows[i].Cells[1].Value = rooms[i].Room_Types.room_type_name;
                this.dgwRoomData.Rows[i].Cells[2].Value = rooms[i].bed_count;
                this.dgwRoomData.Rows[i].Cells[3].Value = rooms[i].room_price;
                this.dgwRoomData.Rows[i].Cells[4].Value = rooms[i].room_reservation_status;
                this.dgwRoomData.Rows[i].Cells[5].Value = rooms[i].room_cleaning_status;
                this.dgwRoomData.Rows[i].Cells[6].Value = rooms[i].room_status;

            }
        }

        private bool checking()
        {
            if (txtBedCount.Text == "" || txtRoomNumber.Text == "" || txtRoomPrice.Text == "" || cmbRoomType.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void employerTypeAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployerTypeForm form = new EmployerTypeForm();
            form.ShowDialog();
        }

        private void addExpencesTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpencesTypeForm form = new ExpencesTypeForm();
            form.ShowDialog();
        }

        private void addPaymentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentTypeForm frm = new PaymentTypeForm();
            frm.ShowDialog();
        }
    }
}
