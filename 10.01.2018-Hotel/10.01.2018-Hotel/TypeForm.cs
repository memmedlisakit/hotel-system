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
    public partial class TypeForm : Form
    {
        HotelDBEntities db = new HotelDBEntities();
        public TypeForm()
        {
            InitializeComponent();
            this.fillDgw();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtTypeName.Text != "")
            {
                Room_Types rmtype = new Room_Types();
                rmtype.room_type_name = this.txtTypeName.Text;
                db.Room_Types.Add(rmtype);
                db.SaveChanges();
                this.txtTypeName.Text = "";
                this.fillDgw();
            }

        }

        private void fillDgw()
        {
            this.dgwData.Rows.Clear();
            List<Room_Types> roomTypies = db.Room_Types.ToList();
            int i = 0;
            foreach (Room_Types item in roomTypies)
            {
                this.dgwData.Rows.Add();
                this.dgwData.Rows[i].Cells[0].Value = item.room_type_name;
                i++;
            }
        }
    }
}
