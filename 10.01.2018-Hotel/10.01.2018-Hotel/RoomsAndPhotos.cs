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
    public partial class RoomsAndPhotos : Form
    {
        HotelDBEntities db = new HotelDBEntities();
        int photoId;
        public RoomsAndPhotos()
        {
            InitializeComponent();
            this.fillCmb();
            this.fillPhotos();
            this.fillDgw();
        }

        private void fillPhotos()
        {
           List<Photo> photos = db.Photos.ToList();
            foreach (Photo item in photos)
            {
                PictureBox pctb = new PictureBox();
                pctb.Width = 175;
                pctb.Height = 175;
                pctb.SizeMode = PictureBoxSizeMode.StretchImage;
                pctb.Image = Image.FromFile(item.image_src + item.image_name);
                pctb.Name = item.id.ToString();
                pctb.Click += takeImageId;
                this.flwpRoomPhoto.Controls.Add(pctb);
            }
        }

        private void fillCmb()
        {
            this.cmbRoomNumber.Items.Clear();
            List<Room> roomsNumbers = db.Rooms.ToList();
            foreach (Room item in roomsNumbers)
            {
                this.cmbRoomNumber.Items.Add(item.room_number);
            }
        }

        private void fillDgw()
        {
            List<Rooms_Photos> rooms_and_photos = db.Rooms_Photos.ToList();
            this.dgwRoomAndPhotos.Rows.Clear();
            for(int i = 0; i < rooms_and_photos.Count; i++)
            {
                this.dgwRoomAndPhotos.Rows.Add();
                this.dgwRoomAndPhotos.Rows[i].Cells[0].Value=rooms_and_photos[i].Room.room_number;
                this.dgwRoomAndPhotos.Rows[i].Cells[1].Value=rooms_and_photos[i].photo_id;
            }
        }

        private void takeImageId(object sender, EventArgs e)
        {
            PictureBox pct = sender as PictureBox;
            photoId =  Convert.ToInt32(pct.Name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
            if (this.cmbRoomNumber.Text!="" && photoId > 0)
            {
                int number = Convert.ToInt32(this.cmbRoomNumber.Text);
                int roomId = db.Rooms.Where(r => r.room_number == number).First().id;


                Rooms_Photos rom_phot = new Rooms_Photos();
                rom_phot.room_id = roomId;
                rom_phot.photo_id = photoId;
                db.Rooms_Photos.Add(rom_phot);
                db.SaveChanges();
                this.cmbRoomNumber.Text = "";
                this.fillDgw();
            }
            else
            {
                MessageBox.Show("Sekil ve room nomresi secin.");
            }
        }
    }
}
