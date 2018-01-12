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
    public partial class ExpencesTypeForm : Form
    {
        HotelDBEntities db = new HotelDBEntities();
        public ExpencesTypeForm()
        {
            InitializeComponent();
            this.fillDgw();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtExpencesTypeName.Text == "")
            {
                this.lblError.Text = "Bosluq olmaz";
            }
            else
            {
                Expences_Types typ = new Expences_Types();
                typ.expences_type_name = this.txtExpencesTypeName.Text;
                db.Expences_Types.Add(typ);
                db.SaveChanges();
                this.txtExpencesTypeName.Text = "";
                this.lblError.Text = "";
                this.fillDgw();
            }
        }

        private void fillDgw()
        {
            this.dgwExpencesTypeData.Rows.Clear();
            List<Expences_Types> types = db.Expences_Types.ToList();

            for(int i = 0; i < types.Count; i++)
            {
                this.dgwExpencesTypeData.Rows.Add();
                this.dgwExpencesTypeData.Rows[i].Cells[0].Value = types[i].expences_type_name;
            }
        }
    }
}
