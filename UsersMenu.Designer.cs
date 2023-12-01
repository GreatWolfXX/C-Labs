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
            this.lbErrorProductsUser = new System.Windows.Forms.Label();
            this.lvUserProducts = new System.Windows.Forms.ListView();
            this.nameProductUserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codeProductUserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceProductUserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvListSelfCheckoutUser = new System.Windows.Forms.ListView();
            this.nameSelfCheckoutColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codeSelfCheckoutColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressSelfCheckoutColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbListSelfCheckoutText = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.tbAmountUser = new System.Windows.Forms.TextBox();
            this.lbAmountUserText = new System.Windows.Forms.Label();
            this.lbCartAmount = new System.Windows.Forms.Label();
            this.lbCartAmountText = new System.Windows.Forms.Label();
            this.cbLoyaltyCard = new System.Windows.Forms.CheckBox();
            this.cbDeliveryCart = new System.Windows.Forms.CheckBox();
            this.lbPayType = new System.Windows.Forms.Label();
            this.lbPayText = new System.Windows.Forms.Label();
            this.cbPayType = new System.Windows.Forms.ComboBox();
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
            this.lbUserMoney = new System.Windows.Forms.Label();
            this.lbUserMoneyText = new System.Windows.Forms.Label();
            this.btnBackUser = new System.Windows.Forms.Button();
            this.lbErrorPay = new System.Windows.Forms.Label();
            this.btnSortByWithdrawCash = new System.Windows.Forms.Button();
            this.btnSortByBuyWithCard = new System.Windows.Forms.Button();
            this.btnSortByBuyWithCash = new System.Windows.Forms.Button();
            this.btnSortByAddProduct = new System.Windows.Forms.Button();
            this.btnSortByGiveChange = new System.Windows.Forms.Button();
            this.btnSortByCashTopUp = new System.Windows.Forms.Button();
            this.lbTypeSortTransactoin = new System.Windows.Forms.Label();
            this.btnSortAll = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            this.usersPanel.SuspendLayout();
            this.editProductPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.btnSortAll);
            this.adminPanel.Controls.Add(this.lbTypeSortTransactoin);
            this.adminPanel.Controls.Add(this.btnSortByAddProduct);
            this.adminPanel.Controls.Add(this.btnSortByGiveChange);
            this.adminPanel.Controls.Add(this.btnSortByCashTopUp);
            this.adminPanel.Controls.Add(this.btnSortByBuyWithCash);
            this.adminPanel.Controls.Add(this.btnSortByBuyWithCard);
            this.adminPanel.Controls.Add(this.btnSortByWithdrawCash);
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
            this.userPanel.Controls.Add(this.lbErrorPay);
            this.userPanel.Controls.Add(this.lbErrorProductsUser);
            this.userPanel.Controls.Add(this.lvUserProducts);
            this.userPanel.Controls.Add(this.lvListSelfCheckoutUser);
            this.userPanel.Controls.Add(this.lbListSelfCheckoutText);
            this.userPanel.Controls.Add(this.btnPay);
            this.userPanel.Controls.Add(this.tbAmountUser);
            this.userPanel.Controls.Add(this.lbAmountUserText);
            this.userPanel.Controls.Add(this.lbCartAmount);
            this.userPanel.Controls.Add(this.lbCartAmountText);
            this.userPanel.Controls.Add(this.cbLoyaltyCard);
            this.userPanel.Controls.Add(this.cbDeliveryCart);
            this.userPanel.Controls.Add(this.lbPayType);
            this.userPanel.Controls.Add(this.lbPayText);
            this.userPanel.Controls.Add(this.cbPayType);
            this.userPanel.Controls.Add(this.lbCartText);
            this.userPanel.Controls.Add(this.lvCart);
            this.userPanel.Controls.Add(this.lbCountProductsText);
            this.userPanel.Controls.Add(this.tbCountProducts);
            this.userPanel.Controls.Add(this.btnAddProductToCart);
            this.userPanel.Controls.Add(this.lbProductsListUser);
            this.userPanel.Controls.Add(this.lbUserMoney);
            this.userPanel.Controls.Add(this.lbUserMoneyText);
            this.userPanel.Controls.Add(this.btnBackUser);
            resources.ApplyResources(this.userPanel, "userPanel");
            this.userPanel.Name = "userPanel";
            // 
            // lbErrorProductsUser
            // 
            resources.ApplyResources(this.lbErrorProductsUser, "lbErrorProductsUser");
            this.lbErrorProductsUser.ForeColor = System.Drawing.Color.Tomato;
            this.lbErrorProductsUser.Name = "lbErrorProductsUser";
            // 
            // lvUserProducts
            // 
            this.lvUserProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameProductUserColumn,
            this.codeProductUserColumn,
            this.priceProductUserColumn});
            this.lvUserProducts.HideSelection = false;
            resources.ApplyResources(this.lvUserProducts, "lvUserProducts");
            this.lvUserProducts.MultiSelect = false;
            this.lvUserProducts.Name = "lvUserProducts";
            this.lvUserProducts.UseCompatibleStateImageBehavior = false;
            this.lvUserProducts.View = System.Windows.Forms.View.Details;
            this.lvUserProducts.SelectedIndexChanged += new System.EventHandler(this.lvUserProducts_SelectedIndexChanged);
            // 
            // nameProductUserColumn
            // 
            resources.ApplyResources(this.nameProductUserColumn, "nameProductUserColumn");
            // 
            // codeProductUserColumn
            // 
            resources.ApplyResources(this.codeProductUserColumn, "codeProductUserColumn");
            // 
            // priceProductUserColumn
            // 
            resources.ApplyResources(this.priceProductUserColumn, "priceProductUserColumn");
            // 
            // lvListSelfCheckoutUser
            // 
            this.lvListSelfCheckoutUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameSelfCheckoutColumn,
            this.codeSelfCheckoutColumn,
            this.addressSelfCheckoutColumn});
            this.lvListSelfCheckoutUser.HideSelection = false;
            resources.ApplyResources(this.lvListSelfCheckoutUser, "lvListSelfCheckoutUser");
            this.lvListSelfCheckoutUser.MultiSelect = false;
            this.lvListSelfCheckoutUser.Name = "lvListSelfCheckoutUser";
            this.lvListSelfCheckoutUser.UseCompatibleStateImageBehavior = false;
            this.lvListSelfCheckoutUser.View = System.Windows.Forms.View.Details;
            this.lvListSelfCheckoutUser.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvListSelfCheckoutUser_ItemSelectionChanged);
            // 
            // nameSelfCheckoutColumn
            // 
            resources.ApplyResources(this.nameSelfCheckoutColumn, "nameSelfCheckoutColumn");
            // 
            // codeSelfCheckoutColumn
            // 
            resources.ApplyResources(this.codeSelfCheckoutColumn, "codeSelfCheckoutColumn");
            // 
            // addressSelfCheckoutColumn
            // 
            resources.ApplyResources(this.addressSelfCheckoutColumn, "addressSelfCheckoutColumn");
            // 
            // lbListSelfCheckoutText
            // 
            resources.ApplyResources(this.lbListSelfCheckoutText, "lbListSelfCheckoutText");
            this.lbListSelfCheckoutText.Name = "lbListSelfCheckoutText";
            // 
            // btnPay
            // 
            resources.ApplyResources(this.btnPay, "btnPay");
            this.btnPay.Name = "btnPay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tbAmountUser
            // 
            resources.ApplyResources(this.tbAmountUser, "tbAmountUser");
            this.tbAmountUser.Name = "tbAmountUser";
            // 
            // lbAmountUserText
            // 
            resources.ApplyResources(this.lbAmountUserText, "lbAmountUserText");
            this.lbAmountUserText.Name = "lbAmountUserText";
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
            // cbLoyaltyCard
            // 
            resources.ApplyResources(this.cbLoyaltyCard, "cbLoyaltyCard");
            this.cbLoyaltyCard.Name = "cbLoyaltyCard";
            this.cbLoyaltyCard.UseVisualStyleBackColor = true;
            this.cbLoyaltyCard.CheckedChanged += new System.EventHandler(this.cbLoyaltyCard_CheckedChanged);
            // 
            // cbDeliveryCart
            // 
            resources.ApplyResources(this.cbDeliveryCart, "cbDeliveryCart");
            this.cbDeliveryCart.Name = "cbDeliveryCart";
            this.cbDeliveryCart.UseVisualStyleBackColor = true;
            this.cbDeliveryCart.CheckedChanged += new System.EventHandler(this.cbDeliveryCart_CheckedChanged);
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
            resources.ApplyResources(this.cbPayType, "cbPayType");
            this.cbPayType.Name = "cbPayType";
            this.cbPayType.SelectedIndexChanged += new System.EventHandler(this.cbPayType_SelectedIndexChanged);
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
            this.btnAddProductToCart.Click += new System.EventHandler(this.btnAddProductToCart_Click);
            // 
            // lbProductsListUser
            // 
            resources.ApplyResources(this.lbProductsListUser, "lbProductsListUser");
            this.lbProductsListUser.Name = "lbProductsListUser";
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
            // lbErrorPay
            // 
            resources.ApplyResources(this.lbErrorPay, "lbErrorPay");
            this.lbErrorPay.ForeColor = System.Drawing.Color.Tomato;
            this.lbErrorPay.Name = "lbErrorPay";
            // 
            // btnSortByWithdrawCash
            // 
            resources.ApplyResources(this.btnSortByWithdrawCash, "btnSortByWithdrawCash");
            this.btnSortByWithdrawCash.Name = "btnSortByWithdrawCash";
            this.btnSortByWithdrawCash.UseVisualStyleBackColor = true;
            this.btnSortByWithdrawCash.Click += new System.EventHandler(this.btnSortByWithdrawCash_Click);
            // 
            // btnSortByBuyWithCard
            // 
            resources.ApplyResources(this.btnSortByBuyWithCard, "btnSortByBuyWithCard");
            this.btnSortByBuyWithCard.Name = "btnSortByBuyWithCard";
            this.btnSortByBuyWithCard.UseVisualStyleBackColor = true;
            this.btnSortByBuyWithCard.Click += new System.EventHandler(this.btnSortByBuyWithCard_Click);
            // 
            // btnSortByBuyWithCash
            // 
            resources.ApplyResources(this.btnSortByBuyWithCash, "btnSortByBuyWithCash");
            this.btnSortByBuyWithCash.Name = "btnSortByBuyWithCash";
            this.btnSortByBuyWithCash.UseVisualStyleBackColor = true;
            this.btnSortByBuyWithCash.Click += new System.EventHandler(this.btnSortByBuyWithCash_Click);
            // 
            // btnSortByAddProduct
            // 
            resources.ApplyResources(this.btnSortByAddProduct, "btnSortByAddProduct");
            this.btnSortByAddProduct.Name = "btnSortByAddProduct";
            this.btnSortByAddProduct.UseVisualStyleBackColor = true;
            this.btnSortByAddProduct.Click += new System.EventHandler(this.btnSortByAddProduct_Click);
            // 
            // btnSortByGiveChange
            // 
            resources.ApplyResources(this.btnSortByGiveChange, "btnSortByGiveChange");
            this.btnSortByGiveChange.Name = "btnSortByGiveChange";
            this.btnSortByGiveChange.UseVisualStyleBackColor = true;
            this.btnSortByGiveChange.Click += new System.EventHandler(this.btnSortByGiveChange_Click);
            // 
            // btnSortByCashTopUp
            // 
            resources.ApplyResources(this.btnSortByCashTopUp, "btnSortByCashTopUp");
            this.btnSortByCashTopUp.Name = "btnSortByCashTopUp";
            this.btnSortByCashTopUp.UseVisualStyleBackColor = true;
            this.btnSortByCashTopUp.Click += new System.EventHandler(this.btnSortByCashTopUp_Click);
            // 
            // lbTypeSortTransactoin
            // 
            resources.ApplyResources(this.lbTypeSortTransactoin, "lbTypeSortTransactoin");
            this.lbTypeSortTransactoin.Name = "lbTypeSortTransactoin";
            // 
            // btnSortAll
            // 
            resources.ApplyResources(this.btnSortAll, "btnSortAll");
            this.btnSortAll.Name = "btnSortAll";
            this.btnSortAll.UseVisualStyleBackColor = true;
            this.btnSortAll.Click += new System.EventHandler(this.btnSortAll_Click);
            // 
            // UsersMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.editProductPanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.usersPanel);
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
        private Button btnAddProductToCart;
        private Label lbCountProductsText;
        private TextBox tbCountProducts;
        private Label lbCartText;
        private ComboBox cbPayType;
        private Label lbPayType;
        private Label lbPayText;
        private Label lbCartAmount;
        private Label lbCartAmountText;
        private CheckBox cbLoyaltyCard;
        private CheckBox cbDeliveryCart;
        private Button btnPay;
        private TextBox tbAmountUser;
        private Label lbAmountUserText;
        private ListView lvListSelfCheckoutUser;
        private ColumnHeader nameSelfCheckoutColumn;
        private ColumnHeader codeSelfCheckoutColumn;
        private ColumnHeader addressSelfCheckoutColumn;
        private Label lbListSelfCheckoutText;
        private ListView lvUserProducts;
        private ColumnHeader nameProductUserColumn;
        private ColumnHeader codeProductUserColumn;
        private ColumnHeader priceProductUserColumn;
        private ListView lvCart;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label lbErrorProductsUser;
        private Label lbErrorPay;
        private Label lbTypeSortTransactoin;
        private Button btnSortByAddProduct;
        private Button btnSortByGiveChange;
        private Button btnSortByCashTopUp;
        private Button btnSortByBuyWithCash;
        private Button btnSortByBuyWithCard;
        private Button btnSortByWithdrawCash;
        private Button btnSortAll;
    }
}