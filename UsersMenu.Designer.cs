using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class UsersMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersMenu));
            this.adminPanel = new System.Windows.Forms.Panel();
            this.lvTransactions = new System.Windows.Forms.ListView();
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTextTransactions = new System.Windows.Forms.Label();
            this.lbTextSlefCheckout = new System.Windows.Forms.Label();
            this.lbCashBalanceText = new System.Windows.Forms.Label();
            this.lbCashBalance = new System.Windows.Forms.Label();
            this.lbErrorCash = new System.Windows.Forms.Label();
            this.btnUploadCash = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.lbWithdrawCash = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.btnBackAdminPanel = new System.Windows.Forms.Button();
            this.listSelfCheckout = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChangeSelfCheckout = new System.Windows.Forms.Button();
            this.cbOnlineOrderDeliveryCash = new System.Windows.Forms.CheckBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.cbCardPayment = new System.Windows.Forms.CheckBox();
            this.lbFormCreatingSelfCheckout = new System.Windows.Forms.Label();
            this.cbOnlinOrder = new System.Windows.Forms.CheckBox();
            this.cbOnlineOrderDelivery = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCreateSelfCheckout = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.editProductPanel = new System.Windows.Forms.Panel();
            this.lbErrorProducts = new System.Windows.Forms.Label();
            this.btnBackProducts = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.tbPriceProduct = new System.Windows.Forms.TextBox();
            this.tbCodeProduct = new System.Windows.Forms.TextBox();
            this.tbNameProduct = new System.Windows.Forms.TextBox();
            this.lbEditProduct = new System.Windows.Forms.Label();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.nameColumnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codeColumnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userPanel = new System.Windows.Forms.Panel();
            this.lbCartAmount = new System.Windows.Forms.Label();
            this.lbCartAmountText = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbPayType = new System.Windows.Forms.Label();
            this.lbPayText = new System.Windows.Forms.Label();
            this.cbPayType = new System.Windows.Forms.ComboBox();
            this.lbCountCartRemove = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCartRemove = new System.Windows.Forms.Button();
            this.lbCartText = new System.Windows.Forms.Label();
            this.lvCart = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbCountProductsText = new System.Windows.Forms.Label();
            this.tbCountProducts = new System.Windows.Forms.TextBox();
            this.btnAddProductToCart = new System.Windows.Forms.Button();
            this.lbProductsListUser = new System.Windows.Forms.Label();
            this.lvProductsListUser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbUserMoney = new System.Windows.Forms.Label();
            this.lbUserMoneyText = new System.Windows.Forms.Label();
            this.btnBackUser = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            this.usersPanel.SuspendLayout();
            this.editProductPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.lvTransactions);
            this.adminPanel.Controls.Add(this.lbTextTransactions);
            this.adminPanel.Controls.Add(this.lbTextSlefCheckout);
            this.adminPanel.Controls.Add(this.lbCashBalanceText);
            this.adminPanel.Controls.Add(this.lbCashBalance);
            this.adminPanel.Controls.Add(this.lbErrorCash);
            this.adminPanel.Controls.Add(this.btnUploadCash);
            this.adminPanel.Controls.Add(this.btnWithdraw);
            this.adminPanel.Controls.Add(this.tbCash);
            this.adminPanel.Controls.Add(this.lbWithdrawCash);
            this.adminPanel.Controls.Add(this.lbError);
            this.adminPanel.Controls.Add(this.btnBackAdminPanel);
            this.adminPanel.Controls.Add(this.listSelfCheckout);
            this.adminPanel.Controls.Add(this.btnChangeSelfCheckout);
            this.adminPanel.Controls.Add(this.cbOnlineOrderDeliveryCash);
            this.adminPanel.Controls.Add(this.tbModel);
            this.adminPanel.Controls.Add(this.cbCardPayment);
            this.adminPanel.Controls.Add(this.lbFormCreatingSelfCheckout);
            this.adminPanel.Controls.Add(this.cbOnlinOrder);
            this.adminPanel.Controls.Add(this.cbOnlineOrderDelivery);
            this.adminPanel.Controls.Add(this.tbName);
            this.adminPanel.Controls.Add(this.btnCreateSelfCheckout);
            this.adminPanel.Controls.Add(this.tbAddress);
            resources.ApplyResources(this.adminPanel, "adminPanel");
            this.adminPanel.Name = "adminPanel";
            // 
            // lvTransactions
            // 
            this.lvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeColumn,
            this.typeColumn,
            this.userColumn,
            this.amountColumn});
            this.lvTransactions.HideSelection = false;
            resources.ApplyResources(this.lvTransactions, "lvTransactions");
            this.lvTransactions.MultiSelect = false;
            this.lvTransactions.Name = "lvTransactions";
            this.lvTransactions.UseCompatibleStateImageBehavior = false;
            this.lvTransactions.View = System.Windows.Forms.View.Details;
            // 
            // timeColumn
            // 
            resources.ApplyResources(this.timeColumn, "timeColumn");
            // 
            // typeColumn
            // 
            resources.ApplyResources(this.typeColumn, "typeColumn");
            // 
            // userColumn
            // 
            resources.ApplyResources(this.userColumn, "userColumn");
            // 
            // amountColumn
            // 
            resources.ApplyResources(this.amountColumn, "amountColumn");
            // 
            // lbTextTransactions
            // 
            resources.ApplyResources(this.lbTextTransactions, "lbTextTransactions");
            this.lbTextTransactions.Name = "lbTextTransactions";
            // 
            // lbTextSlefCheckout
            // 
            resources.ApplyResources(this.lbTextSlefCheckout, "lbTextSlefCheckout");
            this.lbTextSlefCheckout.Name = "lbTextSlefCheckout";
            // 
            // lbCashBalanceText
            // 
            resources.ApplyResources(this.lbCashBalanceText, "lbCashBalanceText");
            this.lbCashBalanceText.Name = "lbCashBalanceText";
            // 
            // lbCashBalance
            // 
            resources.ApplyResources(this.lbCashBalance, "lbCashBalance");
            this.lbCashBalance.Name = "lbCashBalance";
            // 
            // lbErrorCash
            // 
            resources.ApplyResources(this.lbErrorCash, "lbErrorCash");
            this.lbErrorCash.ForeColor = System.Drawing.Color.Tomato;
            this.lbErrorCash.Name = "lbErrorCash";
            // 
            // btnUploadCash
            // 
            resources.ApplyResources(this.btnUploadCash, "btnUploadCash");
            this.btnUploadCash.Name = "btnUploadCash";
            this.btnUploadCash.UseVisualStyleBackColor = true;
            this.btnUploadCash.Click += new System.EventHandler(this.btnUploadCash_Click);
            // 
            // btnWithdraw
            // 
            resources.ApplyResources(this.btnWithdraw, "btnWithdraw");
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // tbCash
            // 
            resources.ApplyResources(this.tbCash, "tbCash");
            this.tbCash.Name = "tbCash";
            // 
            // lbWithdrawCash
            // 
            resources.ApplyResources(this.lbWithdrawCash, "lbWithdrawCash");
            this.lbWithdrawCash.Name = "lbWithdrawCash";
            // 
            // lbError
            // 
            resources.ApplyResources(this.lbError, "lbError");
            this.lbError.ForeColor = System.Drawing.Color.Tomato;
            this.lbError.Name = "lbError";
            // 
            // btnBackAdminPanel
            // 
            resources.ApplyResources(this.btnBackAdminPanel, "btnBackAdminPanel");
            this.btnBackAdminPanel.Name = "btnBackAdminPanel";
            this.btnBackAdminPanel.UseVisualStyleBackColor = true;
            this.btnBackAdminPanel.Click += new System.EventHandler(this.btnBackAdminPanel_Click);
            // 
            // listSelfCheckout
            // 
            this.listSelfCheckout.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.modelColumn,
            this.addressColumn});
            this.listSelfCheckout.HideSelection = false;
            resources.ApplyResources(this.listSelfCheckout, "listSelfCheckout");
            this.listSelfCheckout.MultiSelect = false;
            this.listSelfCheckout.Name = "listSelfCheckout";
            this.listSelfCheckout.UseCompatibleStateImageBehavior = false;
            this.listSelfCheckout.View = System.Windows.Forms.View.Details;
            this.listSelfCheckout.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listSelfCheckout_ItemSelectionChanged);
            // 
            // nameColumn
            // 
            resources.ApplyResources(this.nameColumn, "nameColumn");
            // 
            // modelColumn
            // 
            resources.ApplyResources(this.modelColumn, "modelColumn");
            // 
            // addressColumn
            // 
            resources.ApplyResources(this.addressColumn, "addressColumn");
            // 
            // btnChangeSelfCheckout
            // 
            resources.ApplyResources(this.btnChangeSelfCheckout, "btnChangeSelfCheckout");
            this.btnChangeSelfCheckout.Name = "btnChangeSelfCheckout";
            this.btnChangeSelfCheckout.UseVisualStyleBackColor = true;
            this.btnChangeSelfCheckout.Click += new System.EventHandler(this.btnChangeSelfCheckout_Click);
            // 
            // cbOnlineOrderDeliveryCash
            // 
            resources.ApplyResources(this.cbOnlineOrderDeliveryCash, "cbOnlineOrderDeliveryCash");
            this.cbOnlineOrderDeliveryCash.Name = "cbOnlineOrderDeliveryCash";
            this.cbOnlineOrderDeliveryCash.UseVisualStyleBackColor = true;
            // 
            // tbModel
            // 
            resources.ApplyResources(this.tbModel, "tbModel");
            this.tbModel.Name = "tbModel";
            // 
            // cbCardPayment
            // 
            resources.ApplyResources(this.cbCardPayment, "cbCardPayment");
            this.cbCardPayment.Name = "cbCardPayment";
            this.cbCardPayment.UseVisualStyleBackColor = true;
            // 
            // lbFormCreatingSelfCheckout
            // 
            resources.ApplyResources(this.lbFormCreatingSelfCheckout, "lbFormCreatingSelfCheckout");
            this.lbFormCreatingSelfCheckout.Name = "lbFormCreatingSelfCheckout";
            // 
            // cbOnlinOrder
            // 
            resources.ApplyResources(this.cbOnlinOrder, "cbOnlinOrder");
            this.cbOnlinOrder.Name = "cbOnlinOrder";
            this.cbOnlinOrder.UseVisualStyleBackColor = true;
            // 
            // cbOnlineOrderDelivery
            // 
            resources.ApplyResources(this.cbOnlineOrderDelivery, "cbOnlineOrderDelivery");
            this.cbOnlineOrderDelivery.Name = "cbOnlineOrderDelivery";
            this.cbOnlineOrderDelivery.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // btnCreateSelfCheckout
            // 
            resources.ApplyResources(this.btnCreateSelfCheckout, "btnCreateSelfCheckout");
            this.btnCreateSelfCheckout.Name = "btnCreateSelfCheckout";
            this.btnCreateSelfCheckout.UseVisualStyleBackColor = true;
            this.btnCreateSelfCheckout.Click += new System.EventHandler(this.btnCreateSelfCheckout_Click);
            // 
            // tbAddress
            // 
            resources.ApplyResources(this.tbAddress, "tbAddress");
            this.tbAddress.Name = "tbAddress";
            // 
            // usersPanel
            // 
            this.usersPanel.Controls.Add(this.btnUser);
            this.usersPanel.Controls.Add(this.btnAdmin);
            resources.ApplyResources(this.usersPanel, "usersPanel");
            this.usersPanel.Name = "usersPanel";
            // 
            // btnUser
            // 
            resources.ApplyResources(this.btnUser, "btnUser");
            this.btnUser.Name = "btnUser";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAdmin
            // 
            resources.ApplyResources(this.btnAdmin, "btnAdmin");
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // editProductPanel
            // 
            this.editProductPanel.Controls.Add(this.lbErrorProducts);
            this.editProductPanel.Controls.Add(this.btnBackProducts);
            this.editProductPanel.Controls.Add(this.btnCreateProduct);
            this.editProductPanel.Controls.Add(this.tbPriceProduct);
            this.editProductPanel.Controls.Add(this.tbCodeProduct);
            this.editProductPanel.Controls.Add(this.tbNameProduct);
            this.editProductPanel.Controls.Add(this.lbEditProduct);
            this.editProductPanel.Controls.Add(this.lvProducts);
            resources.ApplyResources(this.editProductPanel, "editProductPanel");
            this.editProductPanel.Name = "editProductPanel";
            // 
            // lbErrorProducts
            // 
            resources.ApplyResources(this.lbErrorProducts, "lbErrorProducts");
            this.lbErrorProducts.ForeColor = System.Drawing.Color.Tomato;
            this.lbErrorProducts.Name = "lbErrorProducts";
            // 
            // btnBackProducts
            // 
            resources.ApplyResources(this.btnBackProducts, "btnBackProducts");
            this.btnBackProducts.Name = "btnBackProducts";
            this.btnBackProducts.UseVisualStyleBackColor = true;
            this.btnBackProducts.Click += new System.EventHandler(this.btnBackProducts_Click);
            // 
            // btnCreateProduct
            // 
            resources.ApplyResources(this.btnCreateProduct, "btnCreateProduct");
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // tbPriceProduct
            // 
            resources.ApplyResources(this.tbPriceProduct, "tbPriceProduct");
            this.tbPriceProduct.Name = "tbPriceProduct";
            // 
            // tbCodeProduct
            // 
            resources.ApplyResources(this.tbCodeProduct, "tbCodeProduct");
            this.tbCodeProduct.Name = "tbCodeProduct";
            // 
            // tbNameProduct
            // 
            resources.ApplyResources(this.tbNameProduct, "tbNameProduct");
            this.tbNameProduct.Name = "tbNameProduct";
            // 
            // lbEditProduct
            // 
            resources.ApplyResources(this.lbEditProduct, "lbEditProduct");
            this.lbEditProduct.Name = "lbEditProduct";
            // 
            // lvProducts
            // 
            this.lvProducts.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnProduct,
            this.codeColumnProduct,
            this.priceColumnProduct});
            this.lvProducts.HideSelection = false;
            this.lvProducts.HoverSelection = true;
            resources.ApplyResources(this.lvProducts, "lvProducts");
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnProduct
            // 
            resources.ApplyResources(this.nameColumnProduct, "nameColumnProduct");
            // 
            // codeColumnProduct
            // 
            resources.ApplyResources(this.codeColumnProduct, "codeColumnProduct");
            // 
            // priceColumnProduct
            // 
            resources.ApplyResources(this.priceColumnProduct, "priceColumnProduct");
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.lbCartAmount);
            this.userPanel.Controls.Add(this.lbCartAmountText);
            this.userPanel.Controls.Add(this.checkBox2);
            this.userPanel.Controls.Add(this.checkBox1);
            this.userPanel.Controls.Add(this.lbPayType);
            this.userPanel.Controls.Add(this.lbPayText);
            this.userPanel.Controls.Add(this.cbPayType);
            this.userPanel.Controls.Add(this.lbCountCartRemove);
            this.userPanel.Controls.Add(this.textBox1);
            this.userPanel.Controls.Add(this.btnCartRemove);
            this.userPanel.Controls.Add(this.lbCartText);
            this.userPanel.Controls.Add(this.lvCart);
            this.userPanel.Controls.Add(this.lbCountProductsText);
            this.userPanel.Controls.Add(this.tbCountProducts);
            this.userPanel.Controls.Add(this.btnAddProductToCart);
            this.userPanel.Controls.Add(this.lbProductsListUser);
            this.userPanel.Controls.Add(this.lvProductsListUser);
            this.userPanel.Controls.Add(this.lbUserMoney);
            this.userPanel.Controls.Add(this.lbUserMoneyText);
            this.userPanel.Controls.Add(this.btnBackUser);
            resources.ApplyResources(this.userPanel, "userPanel");
            this.userPanel.Name = "userPanel";
            // 
            // lbCartAmount
            // 
            resources.ApplyResources(this.lbCartAmount, "lbCartAmount");
            this.lbCartAmount.Name = "lbCartAmount";
            // 
            // lbCartAmountText
            // 
            resources.ApplyResources(this.lbCartAmountText, "lbCartAmountText");
            this.lbCartAmountText.Name = "lbCartAmountText";
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbPayType
            // 
            resources.ApplyResources(this.lbPayType, "lbPayType");
            this.lbPayType.Name = "lbPayType";
            // 
            // lbPayText
            // 
            resources.ApplyResources(this.lbPayText, "lbPayText");
            this.lbPayText.Name = "lbPayText";
            // 
            // cbPayType
            // 
            this.cbPayType.FormattingEnabled = true;
            this.cbPayType.Items.AddRange(new object[] {
            resources.GetString("cbPayType.Items"),
            resources.GetString("cbPayType.Items1"),
            resources.GetString("cbPayType.Items2")});
            resources.ApplyResources(this.cbPayType, "cbPayType");
            this.cbPayType.Name = "cbPayType";
            // 
            // lbCountCartRemove
            // 
            resources.ApplyResources(this.lbCountCartRemove, "lbCountCartRemove");
            this.lbCountCartRemove.Name = "lbCountCartRemove";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // btnCartRemove
            // 
            resources.ApplyResources(this.btnCartRemove, "btnCartRemove");
            this.btnCartRemove.Name = "btnCartRemove";
            this.btnCartRemove.UseVisualStyleBackColor = true;
            // 
            // lbCartText
            // 
            resources.ApplyResources(this.lbCartText, "lbCartText");
            this.lbCartText.Name = "lbCartText";
            // 
            // lvCart
            // 
            this.lvCart.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvCart.HideSelection = false;
            this.lvCart.HoverSelection = true;
            resources.ApplyResources(this.lvCart, "lvCart");
            this.lvCart.MultiSelect = false;
            this.lvCart.Name = "lvCart";
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // lbCountProductsText
            // 
            resources.ApplyResources(this.lbCountProductsText, "lbCountProductsText");
            this.lbCountProductsText.Name = "lbCountProductsText";
            // 
            // tbCountProducts
            // 
            resources.ApplyResources(this.tbCountProducts, "tbCountProducts");
            this.tbCountProducts.Name = "tbCountProducts";
            // 
            // btnAddProductToCart
            // 
            resources.ApplyResources(this.btnAddProductToCart, "btnAddProductToCart");
            this.btnAddProductToCart.Name = "btnAddProductToCart";
            this.btnAddProductToCart.UseVisualStyleBackColor = true;
            // 
            // lbProductsListUser
            // 
            resources.ApplyResources(this.lbProductsListUser, "lbProductsListUser");
            this.lbProductsListUser.Name = "lbProductsListUser";
            // 
            // lvProductsListUser
            // 
            this.lvProductsListUser.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProductsListUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvProductsListUser.HideSelection = false;
            this.lvProductsListUser.HoverSelection = true;
            resources.ApplyResources(this.lvProductsListUser, "lvProductsListUser");
            this.lvProductsListUser.MultiSelect = false;
            this.lvProductsListUser.Name = "lvProductsListUser";
            this.lvProductsListUser.UseCompatibleStateImageBehavior = false;
            this.lvProductsListUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // lbUserMoney
            // 
            resources.ApplyResources(this.lbUserMoney, "lbUserMoney");
            this.lbUserMoney.Name = "lbUserMoney";
            // 
            // lbUserMoneyText
            // 
            resources.ApplyResources(this.lbUserMoneyText, "lbUserMoneyText");
            this.lbUserMoneyText.Name = "lbUserMoneyText";
            // 
            // btnBackUser
            // 
            resources.ApplyResources(this.btnBackUser, "btnBackUser");
            this.btnBackUser.Name = "btnBackUser";
            this.btnBackUser.UseVisualStyleBackColor = true;
            this.btnBackUser.Click += new System.EventHandler(this.btnBackUser_Click);
            // 
            // UsersMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.usersPanel);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.editProductPanel);
            this.Name = "UsersMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.usersPanel.ResumeLayout(false);
            this.editProductPanel.ResumeLayout(false);
            this.editProductPanel.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel adminPanel;
        private ListView listSelfCheckout;
        private Button btnChangeSelfCheckout;
        private CheckBox cbOnlineOrderDeliveryCash;
        private TextBox tbModel;
        private CheckBox cbCardPayment;
        private Label lbFormCreatingSelfCheckout;
        private CheckBox cbOnlinOrder;
        private CheckBox cbOnlineOrderDelivery;
        private TextBox tbName;
        private Button btnCreateSelfCheckout;
        private TextBox tbAddress;
        private Button btnBackAdminPanel;
        private ColumnHeader nameColumn;
        private ColumnHeader modelColumn;
        private ColumnHeader addressColumn;
        private Label lbError;
        private Panel usersPanel;
        private Button btnUser;
        private Button btnAdmin;
        private Panel editProductPanel;
        private Button btnBackProducts;
        private Button btnCreateProduct;
        private TextBox tbPriceProduct;
        private TextBox tbCodeProduct;
        private TextBox tbNameProduct;
        private Label lbEditProduct;
        private ListView lvProducts;
        private ColumnHeader nameColumnProduct;
        private ColumnHeader codeColumnProduct;
        private ColumnHeader priceColumnProduct;
        private Label lbErrorProducts;
        private Label lbWithdrawCash;
        private TextBox tbCash;
        private Button btnWithdraw;
        private Button btnUploadCash;
        private Label lbErrorCash;
        private Label lbCashBalanceText;
        private Label lbCashBalance;
        private ListView lvTransactions;
        private ColumnHeader timeColumn;
        private ColumnHeader typeColumn;
        private ColumnHeader userColumn;
        private Label lbTextTransactions;
        private Label lbTextSlefCheckout;
        private ColumnHeader amountColumn;
        private Panel userPanel;
        private Button btnBackUser;
        private Label lbUserMoneyText;
        private Label lbUserMoney;
        private Label lbProductsListUser;
        private ListView lvProductsListUser;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnAddProductToCart;
        private Label lbCountProductsText;
        private TextBox tbCountProducts;
        private Label lbCountCartRemove;
        private TextBox textBox1;
        private Button btnCartRemove;
        private Label lbCartText;
        private ListView lvCart;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ComboBox cbPayType;
        private Label lbPayType;
        private Label lbPayText;
        private Label lbCartAmount;
        private Label lbCartAmountText;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}