using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<CartItem> listCartItems;
        private int tempListSelfCheckoutPosition = 0;
        private int tempListSelfCheckoutUserPosition = 0;
        private int tempListProductUserPosition = 0;
        private decimal userMoney = 10000;
        private PaymentType paymentType = PaymentType.CardRetail;
        private Payment payment;

        public UsersMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            lbUserMoney.Text = userMoney.ToString();

            listSelfCheckouts = new List<SelfCheckoutClass>();
            listCartItems = new List<CartItem>();

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

            var Checkout1 = new SelfCheckoutClass("Checkout1", "XEA-123", "address", true, true, true, true);
            Checkout1.AddListProducts(products);
            listSelfCheckouts.Add(Checkout1);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminPanel.Visible = true;
            usersPanel.Visible = false;
            listSelfCheckout.Items.Clear();
            foreach (var checkout in listSelfCheckouts)
            {
                AddItemToSelfCheckoutListView(checkout.Name, checkout.Model, checkout.LocationAddress);
            }
            ShowTransactions();
        }


        private void btnUser_Click(object sender, EventArgs e)
        {
            usersPanel.Visible = false;
            userPanel.Visible = true;
            lvListSelfCheckoutUser.Items.Clear();
            lvCart.Items.Clear();
            foreach (var checkout in listSelfCheckouts)
            {
                AddItemToSelfCheckoutUserListView(checkout.Name, checkout.Model, checkout.LocationAddress);
            }
            ShowCartItems();
        }

        private void btnBackAdminPanel_Click(object sender, EventArgs e)
        {
            adminPanel.Visible = false;
            usersPanel.Visible = true;

            lbCashBalance.Text = "";
            lbErrorCash.Text = "";
            tbCash.Text = "";
            lvTransactions.Items.Clear();
        }

        private void btnBackUser_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            usersPanel.Visible = true;
        }

        private void btnBackProducts_Click(object sender, EventArgs e)
        {
            editProductPanel.Visible = false;
            adminPanel.Visible = true;
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

        private void btnCreateSelfCheckout_Click(object sender, EventArgs e)
        {
            lbError.Text = "";

            if (!string.IsNullOrEmpty(tbName.Text) &&
                !string.IsNullOrEmpty(tbModel.Text) &&
                !string.IsNullOrEmpty(tbAddress.Text))
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

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            lbErrorProducts.Text = "";

            if (!string.IsNullOrEmpty(tbNameProduct.Text) &&
                !string.IsNullOrEmpty(tbCodeProduct.Text) &&
                !string.IsNullOrEmpty(tbPriceProduct.Text))
            {
                var product = new Product(tbNameProduct.Text, tbCodeProduct.Text, decimal.Parse(tbPriceProduct.Text));

                try
                {
                    var selfCheckout = listSelfCheckouts[tempListSelfCheckoutPosition];
                    selfCheckout.AddProduct(product);
                    AddItemToProductsListView(product.Name, product.Code, product.Price.ToString());

                    tbNameProduct.Text = "";
                    tbCodeProduct.Text = "";
                    tbPriceProduct.Text = "";
                }
                catch (InvalidOperationException ex)
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
                var selfCheckout = listSelfCheckouts[tempListSelfCheckoutPosition];

                try
                {
                    if (!string.IsNullOrEmpty(tbCash.Text))
                    {
                        selfCheckout.WithdrawCash(decimal.Parse(tbCash.Text));
                        lbCashBalance.Text = selfCheckout.CashBalance.ToString();
                        ShowTransactions();
                    }
                    else
                    {
                        lbErrorCash.Text = "Поля не повинні бути пустими!";
                    }
                }
                catch (InvalidOperationException ex)
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
                var selfCheckout = listSelfCheckouts[tempListSelfCheckoutPosition];

                if (!string.IsNullOrEmpty(tbCash.Text))
                {
                    selfCheckout.TopUpCash(decimal.Parse(tbCash.Text));
                    lbCashBalance.Text = selfCheckout.CashBalance.ToString();
                    ShowTransactions();
                }
                else
                {
                    lbErrorCash.Text = "Поля не повинні бути пустими!";
                }
            }
            else
            {
                lbErrorCash.Text = "Потрібно вибрати касу зі списку!";
            }
        }

        private void btnAddProductToCart_Click(object sender, EventArgs e)
        {
            lbErrorProductsUser.Text = "";

            if (!string.IsNullOrEmpty(tbCountProducts.Text) && tbCountProducts.Text != "0")
            {
                var selfCheckout = listSelfCheckouts[tempListSelfCheckoutUserPosition];
                var product = selfCheckout.GetListProducts()[tempListProductUserPosition];
                var cartItem = new CartItem(product, int.Parse(tbCountProducts.Text));
                listCartItems.Add(cartItem);

                lvCart.Items.Clear();
                ShowCartItems();
                setTypePayment(cbPayType.SelectedIndex);
            }
            else
            {
                lbErrorProductsUser.Text = "Поле не повинно бути пустим або дорівнювати 0!";
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            lbErrorPay.Text = "";
            var selfCheckout = listSelfCheckouts[tempListSelfCheckoutUserPosition];
            decimal money = tbAmountUser.Visible ? decimal.Parse(tbAmountUser.Text) : payment.TotalPrice;

            if (money >= payment.TotalPrice)
            {
                if (payment.AmountPaid == 0)
                {
                    payment.AmountPaid = money;
                }

                payment = selfCheckout.CreateTransaction(payment, paymentType);
                userMoney -= money;
                userMoney += payment.Change;

                lbUserMoney.Text = userMoney.ToString();
                tbAmountUser.Text = "";
                cbLoyaltyCard.Checked = false;
                cbDeliveryCart.Checked = false;
                listCartItems.Clear();
                lbCartAmount.Text = "0";
                lvCart.Items.Clear();
                tbCountProducts.Text = "";
            }
            else
            {
                lbErrorPay.Text = "Не вистачає грошей!";
            }
        }

        private void btnSortByWithdrawCash_Click(object sender, EventArgs e)
        {
            ShowTransactionByType(TransactionType.WithdrawCash);
        }

        private void btnSortByBuyWithCard_Click(object sender, EventArgs e)
        {
            ShowTransactionByType(TransactionType.BuyWithCard);
        }

        private void btnSortByBuyWithCash_Click(object sender, EventArgs e)
        {
            ShowTransactionByType(TransactionType.BuyWithCash);
        }

        private void btnSortByCashTopUp_Click(object sender, EventArgs e)
        {
            ShowTransactionByType(TransactionType.CashTopUp);
        }

        private void btnSortByGiveChange_Click(object sender, EventArgs e)
        {
            ShowTransactionByType(TransactionType.GiveChange);
        }

        private void btnSortByAddProduct_Click(object sender, EventArgs e)
        {
            ShowTransactionByType(TransactionType.AddProduct);
        }

        private void btnSortAll_Click(object sender, EventArgs e)
        {
            ShowTransactions();
        }

        private void listSelfCheckout_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listSelfCheckout.SelectedItems.Count > 0)
            {
                tempListSelfCheckoutPosition = listSelfCheckout.Items.IndexOf(listSelfCheckout.SelectedItems[0]);
            }

            lbCashBalance.Text = listSelfCheckouts[tempListSelfCheckoutPosition].CashBalance.ToString();

            ShowTransactions();
        }

        private void lvListSelfCheckoutUser_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (lvListSelfCheckoutUser.SelectedItems.Count > 0)
            {
                tempListSelfCheckoutUserPosition = lvListSelfCheckoutUser.Items.IndexOf(lvListSelfCheckoutUser.SelectedItems[0]);
            }

            lvUserProducts.Items.Clear();
            cbPayType.Items.Clear();

            var selfCheckout = listSelfCheckouts[tempListSelfCheckoutUserPosition];
            foreach (Product product in selfCheckout.GetListProducts())
            {
                AddItemToProductsUserListView(product.Name, product.Code, product.Price.ToString());
            }

            setDefaultTypePayment();
        }

        private void lvUserProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUserProducts.SelectedItems.Count > 0)
            {
                tempListProductUserPosition = lvUserProducts.Items.IndexOf(lvUserProducts.SelectedItems[0]);
            }
        }

        private void cbPayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTypePayment(cbPayType.SelectedIndex);
        }

        private void cbDeliveryCart_CheckedChanged(object sender, EventArgs e)
        {
            cbPayType.Items.Clear();
            if (cbDeliveryCart.Checked)
            {
                setDefaultTypePayment();
                setDeliveryTypePayment();
            }
            else
            {
                setDefaultTypePayment();
            }
        }

        private void cbLoyaltyCard_CheckedChanged(object sender, EventArgs e)
        {
            setTypePayment(cbPayType.SelectedIndex);
        }

        private void AddItemToSelfCheckoutListView(string name, string model, string locationAddress)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(model);
            item.SubItems.Add(locationAddress);
            listSelfCheckout.Items.Add(item);
        }

        private void AddItemToSelfCheckoutUserListView(string name, string model, string locationAddress)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(model);
            item.SubItems.Add(locationAddress);
            lvListSelfCheckoutUser.Items.Add(item);
        }

        private void AddItemToProductsListView(string name, string code, string price)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(code);
            item.SubItems.Add(price);
            lvProducts.Items.Add(item);
        }

        private void AddItemToProductsUserListView(string name, string code, string price)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(code);
            item.SubItems.Add(price);
            lvUserProducts.Items.Add(item);
        }

        private void AddItemToTransactionListView(string time, string type, string user, string amount)
        {
            ListViewItem item = new ListViewItem(time);
            item.SubItems.Add(type);
            item.SubItems.Add(user);
            item.SubItems.Add(amount);
            lvTransactions.Items.Add(item);
        }


        private void AddItemToCartListView(string name, string code, string price, decimal count)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(code);
            item.SubItems.Add(price);
            item.SubItems.Add(count.ToString());
            lvCart.Items.Add(item);
        }

        private void setDefaultTypePayment()
        {
            var selfCheckout = listSelfCheckouts[tempListSelfCheckoutUserPosition];

            cbPayType.Items.Add("Готівкою");

            cbPayType.SelectedItem = cbPayType.Items[0];

            if (selfCheckout.CardPaymentAvailable)
            {
                cbPayType.Items.Add("Карткою");
            }

            if (selfCheckout.OnlineOrderAvailable)
            {
                cbPayType.Items.Add("Карткою онлайн");
                if (selfCheckout.OnlineOrderDeliveryAvailable)
                {
                    cbDeliveryCart.Visible = true;
                }
            }
        }

        private void setDeliveryTypePayment()
        {
            var selfCheckout = listSelfCheckouts[tempListSelfCheckoutUserPosition];

            if (selfCheckout.OnlineOrderDeliveryCashAvailable)
            {
                cbPayType.Items.Add("Готівкою кур'єру");
            }
        }

        private void setTypePayment(int selectedPaymentType)
        {
            var selfCheckout = listSelfCheckouts[tempListSelfCheckoutUserPosition];
            cbLoyaltyCard.Visible = true;
            tbAmountUser.Visible = true;
            lbAmountUserText.Visible = true;

            bool isWholesale30 = isWholesale(30);
            bool isWholesale50 = isWholesale(50);

            switch (selectedPaymentType)
            {
                case 0:
                    paymentType = isWholesale30 ? PaymentType.CashWholesale : PaymentType.CashRetail;
                    break;
                case 1:
                case 2:
                    paymentType = isWholesale30 ? PaymentType.CardWholesale : PaymentType.CardRetail;
                    tbAmountUser.Visible = false;
                    lbAmountUserText.Visible = false;
                    break;
                case 3:
                    cbLoyaltyCard.Visible = false;
                    paymentType = isWholesale50 ? PaymentType.CashDeliveryWholesale : PaymentType.CashDeliveryRetail;
                    break;
                default:
                    paymentType = isWholesale30 ? PaymentType.CashWholesale : PaymentType.CashRetail;
                    break;
            }

            payment = selfCheckout.ProcessReceipt(getProudctsFromCart(), paymentType, cbLoyaltyCard.Checked, cbDeliveryCart.Checked);
            lbCartAmount.Text = payment.TotalPrice.ToString();
        }

        private bool isWholesale(int countForWholesale)
        {
            bool isWholesale = true;

            foreach (var item in listCartItems)
            {
                if (item.Count < countForWholesale)
                {
                    isWholesale = false;
                    break;
                }
            }

            return isWholesale;
        }

        private List<Product> getProudctsFromCart()
        {
            var list = new List<Product>();
            foreach (var item in listCartItems)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    list.Add(item.Product);
                }
            }
            return list;
        }

        private void ShowTransactions()
        {
            lvTransactions.Items.Clear();
            var selfCheckout = listSelfCheckouts[tempListSelfCheckoutPosition];
            foreach (Transaction transaction in selfCheckout.Transactions)
            {
                AddItemToTransactionListView(transaction.TransactionDateTime.Date + "", transaction.TransactionType + "", transaction.User + "", transaction.Amount + "");
            }
        }

        private void ShowTransactionByType(TransactionType transactionType)
        {
            var selfCheckout = listSelfCheckouts[tempListSelfCheckoutPosition];
            lvTransactions.Items.Clear();
            foreach (var item in selfCheckout.GetTransactionByType(transactionType))
            {
                AddItemToTransactionListView(item.TransactionDateTime + "", item.TransactionType + "", item.User + "", item.Amount + "");
            }
        }

        private void ShowCartItems()
        {
            decimal allPrice = 0;
            foreach (var cartItem in listCartItems)
            {
                var price = cartItem.Product.Price * cartItem.Count;
                allPrice += price;
                AddItemToCartListView(cartItem.Product.Name, cartItem.Product.Code, allPrice.ToString(), cartItem.Count);
            }
        }
    }
}
