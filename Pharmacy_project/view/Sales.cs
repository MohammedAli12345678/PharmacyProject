using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_project.view
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FilterContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchPichtureClicke(object sender, EventArgs e)
        {
            this.SearchText.Focus();
        }
        
        private void UpdateTable()
        {
            using(var db = new database_pharmacyEntities1())
            {
                List<sale> datalist = db.sales.ToList();
                DataTable data = new DataTable();
                //initialize table headers and data types of table
                data.Columns.Add("اسم العميل", typeof(string));
                data.Columns.Add("الوثيقة الطبية", typeof(Image));
                data.Columns.Add("المبيعات", typeof(Panel));
                data.Columns.Add("الاجمالي", typeof(float));
                data.Columns.Add("تاريخ البيع", typeof(DateTime));
                data.Columns.Add("الحالة", typeof(string));

                DateTime dt = new DateTime();
                //data.Rows.Add(ToRowOfSale(datalist[0]));

            }
        }

        //private DataRow ToRowOfSale(sale s)
        //{
        //    return new DataRow();
        //}
    }
}
