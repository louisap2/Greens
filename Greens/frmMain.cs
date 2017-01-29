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

                RefreshPurchasesList();
            }
        }

        private void RefreshPurchasesList()
        {
            using (var db = new EntityDataModel())
            {
                var purchases_with_details = from pd in db.Purchases_details
                                             group pd by pd.purchase_id into pdg
                                             //join *after* group
                                             join p in db.Purchases on pdg.Key equals p.Id
                                             select new
                                             {
                                                 Id = p.Id,
                                                 Cust = p.customer,
                                                 TotalPrice = pdg.Sum(y => y.total_price)
                                             };

                StringBuilder sb = new StringBuilder();
                foreach (var purchase_with_details in purchases_with_details)
                {
                    sb.AppendLine("Purchase #" + purchase_with_details.Id + " by " + purchase_with_details.Cust.Trim() + ", total price: " + purchase_with_details.TotalPrice);
                }

                txtPurchases.Text = sb.ToString();
            }
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            int apples = Convert.ToInt32(txtApples.Text);
            int bananas = Convert.ToInt32(txtBananas.Text);
            int oranges = Convert.ToInt32(txtOranges.Text);

            if (apples > 0 && bananas > 0 && oranges > 0)
            {
                using (var db = new EntityDataModel())
                {
                    Purchase purchase = new Purchase();
                    purchase.customer = txtCustomer.Text;
                    purchase.timestamp = DateTime.Now;

                    db.Purchases.Add(purchase);
                    db.SaveChanges();
                    
                    int grandTotal = 0;

                    if(apples > 0)
                    {
                        Purchases_details pd = new Purchases_details();
                        pd.greens_id = db.Greens.Single(x => x.name == "Apple").Id;
                        pd.amount = apples;
                        pd.total_price = db.Greens.Single(x => x.name == "Apple").price * apples;
                        grandTotal += pd.total_price;
                        pd.purchase_id = purchase.Id;

                        db.Purchases_details.Add(pd);
                    }

                    if (bananas > 0)
                    {
                        Purchases_details pd = new Purchases_details();
                        pd.greens_id = db.Greens.Single(x => x.name == "Banana").Id;
                        pd.amount = bananas;
                        pd.total_price = db.Greens.Single(x => x.name == "Banana").price * bananas;
                        grandTotal += pd.total_price;
                        pd.purchase_id = purchase.Id;

                        db.Purchases_details.Add(pd);
                    }

                    if (oranges > 0)
                    {
                        Purchases_details pd = new Purchases_details();
                        pd.greens_id = db.Greens.Single(x => x.name == "Orange").Id;
                        pd.amount = oranges;
                        pd.total_price = db.Greens.Single(x => x.name == "Orange").price * oranges;
                        grandTotal += pd.total_price;
                        pd.purchase_id = purchase.Id;

                        db.Purchases_details.Add(pd);
                    }

                    db.SaveChanges();

                    MessageBox.Show("Purchase done. Grand total: " + grandTotal + ",-");

                    RefreshPurchasesList();
                }
            }
        }
    }
}
