using Pharmacy_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.Viwes
{
    public partial class launcher : Form
    {
        private List<medicine> medicines;
        public launcher()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private System.Windows.Forms.Panel to_item_panel(medicine m)
        {
            System.Windows.Forms.Panel itemcontainer;
            System.Windows.Forms.Label name;
            System.Windows.Forms.TextBox nametb;
            System.Windows.Forms.TextBox genericnametb;
            System.Windows.Forms.PictureBox picbox;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.TextBox typetb;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.TextBox categorytb;
            System.Windows.Forms.Label label1;

            itemcontainer = new System.Windows.Forms.Panel();
            name = new System.Windows.Forms.Label();
            picbox = new System.Windows.Forms.PictureBox();
            nametb = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            categorytb = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            typetb = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            genericnametb = new System.Windows.Forms.TextBox();
            medicinescontainer.SuspendLayout();
            itemcontainer.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            SuspendLayout();

            // 
            // itemcontainer
            // 
            itemcontainer.Controls.Add(genericnametb);
            itemcontainer.Controls.Add(label3);
            itemcontainer.Controls.Add(typetb);
            itemcontainer.Controls.Add(label2);
            itemcontainer.Controls.Add(categorytb);
            itemcontainer.Controls.Add(label1);
            itemcontainer.Controls.Add(nametb);
            itemcontainer.Controls.Add(name);
            itemcontainer.Controls.Add(picbox);
            itemcontainer.Location = new System.Drawing.Point(3, 3);
            itemcontainer.Name = "itemcontainer";
            itemcontainer.Size = new System.Drawing.Size(202, 223);
            itemcontainer.TabIndex = 0;
            itemcontainer.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new System.Drawing.Point(4, 106);
            name.Name = "name";
            name.Size = new System.Drawing.Size(55, 17);
            name.TabIndex = 1;
            name.Text = "name : ";
            name.Click += new System.EventHandler(this.Label1_Click);
            // 
            // picbox
            // 
            picbox.Location = new System.Drawing.Point(38, 3);
            picbox.Name = "picbox";
            picbox.Size = new System.Drawing.Size(104, 92);
            picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picbox.TabIndex = 0;
            picbox.TabStop = false;
            // 
            // nametb
            // 
            nametb.Enabled = false;
            nametb.Location = new System.Drawing.Point(83, 106);
            nametb.Name = "nametb";
            nametb.Size = new System.Drawing.Size(100, 24);
            nametb.TabIndex = 2;
            nametb.Text = m.name;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 136);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 17);
            label1.TabIndex = 1;
            label1.Text = "G name : ";
            label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // categorytb
            // 
            categorytb.Enabled = false;
            categorytb.Location = new System.Drawing.Point(83, 166);
            categorytb.Name = "categorytb";
            categorytb.Size = new System.Drawing.Size(100, 24);
            categorytb.TabIndex = 2;
            categorytb.Text = m.category.name;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 166);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "category :";
            label2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // typetb
            // 
            typetb.Enabled = false;
            typetb.Location = new System.Drawing.Point(83, 193);
            typetb.Name = "typetb";
            typetb.Size = new System.Drawing.Size(100, 24);
            typetb.TabIndex = 2;
            typetb.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 196);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 17);
            label3.TabIndex = 1;
            label3.Text = "Type";
            label3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // genericnametb
            // 
            genericnametb.Enabled = false;
            genericnametb.Location = new System.Drawing.Point(83, 136);
            genericnametb.Name = "genericnametb";
            genericnametb.Size = new System.Drawing.Size(100, 24);
            genericnametb.TabIndex = 2;
            genericnametb.Text = "name";

            //itemcontainer.MouseClick +=  new MouseEventHandler()

            return  itemcontainer;
        }


        private void initialize(object sender, EventArgs e)
        {
            using(var db =  new database_pharmacyEntities1())
            {
                medicines = db.medicines.ToList();
                foreach(var med in medicines)
                {
                    this.medicinescontainer.Controls.Add(to_item_panel(med));
                }
            }



        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
