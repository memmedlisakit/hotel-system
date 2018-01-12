using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._01._2018_Hotel
{
    public partial class PhotoForm : Form
    {
        OpenFileDialog file = new OpenFileDialog();
        HotelDBEntities db = new HotelDBEntities();
        public PhotoForm()
        {
            InitializeComponent();
        }

        private void btnUload_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            this.pctRoom.Image = Image.FromFile(file.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string imageName = DateTime.Now.ToString("yyyyMMddHHssmm")+ file.SafeFileName;
            string path = @"C:\Users\Sakit\source\repos\10.01.2018-Hotel\10.01.2018-Hotel\Uploads\";

            Photo phot = new Photo();
            phot.image_name = imageName;
            phot.image_src = path;
            db.Photos.Add(phot);
            db.SaveChanges();
            this.pctRoom.Image = null;
            path += imageName;
            WebClient webclient = new WebClient();
            webclient.DownloadFile(file.FileName, path);
        }
    }
}
