using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greens
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtCustomer.Text = "Mads";
            txtApples.Text = "0";
            txtBananas.Text = "0";
            txtOranges.Text = "0";

            using (var db = new EntityDataModel())
            {
                var applePrice = db.Greens.Where(x => x.name.Trim() == "Apple").Single();
                lblApplePrice.Text = applePrice.price.ToString();

                if(db.Greens.Where(x => x.name.Trim() == "Banana").Count() == 0)
                {
                    Green banana = new Green();
                    banana.name = "Banana";
                    banana.type = "Fruit";
                    banana.price = 3;

                    db.Greens.Add(banana);
                    db.SaveChanges();
                }
                else
                {
                    db.Greens.Single(x => x.name.Trim() == "Apple").price = 3;
                    db.Greens.Single(x => x.name.Trim() == "Banana").price = 2;
                    db.SaveChanges();

                    lblApplePrice.Text = db.Greens.Single(x => x.name.Trim() == "Apple").price.ToString();
                }

                if (db.Greens.Where(x => x.name.Trim() == "Orange").Count() == 0)
                {
                    Green banana = new Green();
                    banana.name = "Orange";
                    banana.type = "Fruit";
                    banana.price = 4;

                    db.Greens.Add(banana);
                    db.SaveChanges();
                }

                if (db.Greens.All(x => x.name.Trim() != "Appple"))
                {
                    foreach (var green in db.Greens.Where(x4 => x4.name.Trim() != "Apple"))
                    {
                        switch (green.name.Trim())
                        {
                            case "Banana":
                                lblBananasPrice.Text = green.price.ToString();
                                break;
                            case "Orange":
                                lblOrangesPrice.Text = green.price.ToString();
                                break;
                            default:
                                throw new NotImplementedException();
                        }
                    }
                }

                var purchases_with_details = from p in db.Purchases
                                            join pd in db.Purchases_details on p.Id equals pd.purchase_id
                                            group new { p, pd } by pd.purchase_id into pdg
                                            select new { id = pdg.Select(m => m.p.Id), customer = pdg.Select(n => n.p.customer), totalPrice = pdg.Sum(o => o.pd.total_price) };

                StringBuilder sb = new StringBuilder();
                foreach(var purchase_with_details in purchases_with_details)
                {
                    sb.AppendLine("Purchase #" + purchase_with_details.id + " by " + purchase_with_details.customer + ", total price: " + purchase_with_details.totalPrice);
                }

                txtPurchases.Text = sb.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
