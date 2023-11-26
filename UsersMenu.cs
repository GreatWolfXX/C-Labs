using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class UsersMenu : Form
    {

        private List<SelfCheckoutClass> listSelfCheckouts;
        private int tempListSelfCheckoutPosition = 0;
        private int userMoney = 10000;

        public UsersMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            lbUserMoney.Text = userMoney.ToString();

            listSelfCheckouts = new List<SelfCheckoutClass>();

            List<Product> products = new List<Product>()
            {
                new Product ("Tomato","0001",16.99m),
                new Product ("Potato","0002",15.97m),
                new Product ("Milk","0003",33.15m),
                new Product ("Bread","0004",11.99m),
                new Product ("Banana","0005",55m),
                new Product ("Cucumber","0006",34.99m),
                new Product ("Beans","0007",15.99m),
                new Product ("Orange","0008",22m),
                new Product ("Bear","0009",99.99m),
                new Product ("Cheese","0010",14.88m),
                new Product ("Chocolate","0011",1.01m)
            };

            var Checkout1 = new SelfCheckoutClass("Checkout1", "XEA-123", "address", true, true, true);
            Checkout1.AddListProducts(products);
            listSelfCheckouts.Add(Checkout1);

            foreach (var checkout in listSelfCheckouts)
            {
                AddItemToSelfCheckoutListView(checkout.Name, checkout.Model, checkout.LocationAddress);
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminPanel.Visible = true;
            usersPanel.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            usersPanel.Visible = false;
            userPanel.Visible = true;
        }

        private void btnBackAdminPanel_Click(object sender, EventArgs e)
        {
            adminPanel.Visible = false;
            usersPanel.Visible = true;
        }

        private void btnBackUser_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            usersPanel.Visible = true;
        }

        private void btnCreateSelfCheckout_Click(object sender, EventArgs e)
        {
            lbError.Text = "";

            if (tbName.Text != "" && tbModel.Text != "" && tbAddress.Text != "")
            {
                var checkout = new SelfCheckoutClass(
                tbName.Text,
                tbModel.Text,
                tbAddress.Text,
                cbCardPayment.Checked,
                cbOnlinOrder.Checked,
                cbOnlineOrderDelivery.Checked,
                cbOnlineOrderDeliveryCash.Checked
                );

                listSelfCheckouts.Add(checkout);
                AddItemToSelfCheckoutListView(checkout.Name, checkout.Model, checkout.LocationAddress);

                tbName.Text = "";
                tbModel.Text = "";
                tbAddress.Text = "";
                cbCardPayment.Checked = false;
                cbOnlinOrder.Checked = false;
                cbOnlineOrderDelivery.Checked = false;
                cbOnlineOrderDeliveryCash.Checked = false;
            }
            else
            {
                lbError.Text = "Поля не повинні бути пустими!";
            }
            
        }

        private void btnChangeSelfCheckout_Click(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            
            if (listSelfCheckout.SelectedItems.Count > 0)
            {

                var selfCheckout = listSelfCheckouts[tempListSelfCheckoutPosition];
                foreach (var product in selfCheckout.GetListProducts())
                {
                    AddItemToProductsListView(product.Name, product.Code, product.Price + "");
                }


                editProductPanel.Visible = true;
                adminPanel.Visible = false;
            }
        }

        private void btnBackProducts_Click(object sender, EventArgs e)
        {
            editProductPanel.Visible = false;
            adminPanel.Visible = true;
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            lbErrorProducts.Text = "";

            if (tbNameProduct.Text != "" && tbCodeProduct.Text != "" && tbPriceProduct.Text != "")
            {
                var product = new Product(
                tbNameProduct.Text,
                tbCodeProduct.Text,
                decimal.Parse(tbPriceProduct.Text)
                );

                try
                {
                    listSelfCheckouts[tempListSelfCheckoutPosition].AddProduct(product);
                    AddItemToProductsListView(product.Name, product.Code, product.Price + "");

                    tbNameProduct.Text = "";
                    tbCodeProduct.Text = "";
                    tbPriceProduct.Text = "";
                } catch (InvalidOperationException ex)
                {
                    lbErrorProducts.Text = "Код товару повинен бути унікальним";
                }
            }
            else
            {
                lbErrorProducts.Text = "Поля не повинні бути пустими!";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            lbErrorCash.Text = "";
            if (listSelfCheckout.SelectedItems.Count > 0)
            {
                try
                {
                    if (tbCash.Text != "")
                    {
                        var selfCheckout = listSelfCheckouts[tempListSelfCheckoutPosition];
                        selfCheckout.WithdrawCash(decimal.Parse(tbCash.Text));
                        lbCashBalance.Text = selfCheckout.CashBalance.ToString();
                    }
                    else
                    {
                        lbErrorCash.Text = "Поля не повинні бути пустими!";
                    }
                } catch (InvalidOperationException ex)
                {
                    lbErrorCash.Text = "Сумма зняття готівки не повинна перевищювати доступну!";
                }
            }
            else
            {
                lbErrorCash.Text = "Потрібно вибрати касу зі списку!";
            }
        }

        private void btnUploadCash_Click(object sender, EventArgs e)
        {
            lbErrorCash.Text = "";
            if (listSelfCheckout.SelectedItems.Count > 0)
            {
                if(tbCash.Text != "")
                {
                    var selfCheckout = listSelfCheckouts[tempListSelfCheckoutPosition];
                    selfCheckout.TopUpCash(decimal.Parse(tbCash.Text));
                    lbCashBalance.Text = selfCheckout.CashBalance.ToString();
                } else
                {
                    lbErrorCash.Text = "Поля не повинні бути пустими!";
                }
               
            } else
            {
                lbErrorCash.Text = "Потрібно вибрати касу зі списку!";
            }
        }


        private void listSelfCheckout_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listSelfCheckout.SelectedItems.Count > 0)
            {
                tempListSelfCheckoutPosition = listSelfCheckout.Items.IndexOf(listSelfCheckout.SelectedItems[0]);
            }

            lbCashBalance.Text = listSelfCheckouts[tempListSelfCheckoutPosition].CashBalance.ToString();

            lvTransactions.Items.Clear();

            var selfCheckout = listSelfCheckouts[tempListSelfCheckoutPosition];
            foreach(Transaction transaction in selfCheckout.Transactions)
            {
                AddItemToTransactionListView(transaction.TransactionDateTime.Date + "", transaction.TransactionType + "", transaction.User + "", transaction.Amount + "");
            }
        }

        private void AddItemToSelfCheckoutListView(string name, string model, string locationAddress)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(model);
            item.SubItems.Add(locationAddress);
            listSelfCheckout.Items.Add(item);
        }

        private void AddItemToProductsListView(string name, string model, string locationAddress)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(model);
            item.SubItems.Add(locationAddress);
            lvProducts.Items.Add(item);
        }

        private void AddItemToTransactionListView(string time, string type, string user, string amount)
        {
            ListViewItem item = new ListViewItem(time);
            item.SubItems.Add(type);
            item.SubItems.Add(user);
            item.SubItems.Add(amount);
            lvTransactions.Items.Add(item);
        }
    }
}
