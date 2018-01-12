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
    public partial class EmployerTypeForm : Form
    {
        HotelDBEntities db = new HotelDBEntities();
        public EmployerTypeForm()
        {
            InitializeComponent();
            this.fillDgw();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtEmloyerTypeName.Text == "")
            {
                this.lblError.Text = "Bosluq olmaz";
            }
            else
            {
                Employer_Types type = new Employer_Types();
                type.employer_type_name = this.txtEmloyerTypeName.Text;
                db.Employer_Types.Add(type);
                db.SaveChanges();
                this.txtEmloyerTypeName.Text = "";
                this.lblError.Text = "";
                this.fillDgw();
            }
            

        }

        private void fillDgw()
        {
            List<Employer_Types> types = db.Employer_Types.ToList();
            this.dgwEmployerTypeData.Rows.Clear();
            for(int i=0; i<types.Count;i++)
            {
                this.dgwEmployerTypeData.Rows.Add();
                this.dgwEmployerTypeData.Rows[i].Cells[0].Value = types[i].employer_type_name;
            }
        }
    }
}
