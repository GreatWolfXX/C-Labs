using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    internal class SelfCheckoutClass
    {
        public SelfCheckoutClass(
            string name, 
            string model,
            string locationAddress,
            bool cardPaymentAvailable = false,
            bool onlineOrderAvailable = false,
            bool onlineOrderDeliveryAvailable = false,
            bool onlineOrderDeliveryCashAvailable = false
)
        {
            Name = name;
            Model = model;
            LocationAddress = locationAddress;
            CardPaymentAvailable = cardPaymentAvailable;
            OnlineOrderAvailable = onlineOrderAvailable;
            OnlineOrderDeliveryAvailable = onlineOrderDeliveryAvailable;
            OnlineOrderDeliveryCashAvailable = onlineOrderDeliveryCashAvailable;
            Products = new List<Product>();
            Transactions = new List<Transaction>();
        }

        public string Name { get; set; }
        public string Model { get; set; }
        public string LocationAddress { get; set; }
        public decimal CashBalance { get; set; }
        public decimal CardBalance { get; set; }
        public bool CardPaymentAvailable { get; set; }
        public bool OnlineOrderAvailable { get; set; }
        public bool OnlineOrderDeliveryAvailable { get; set; }
        public bool OnlineOrderDeliveryCashAvailable { get; set; }
        private List<Product> Products { get; set; }
        public List<Transaction> Transactions { get; set; }

        public void AddProduct(Product productToAdd)
        {
            var result = Products.AddUnique(productToAdd);
            if (result)
            {
                Transaction.CommitTransaction(this, new Transaction(TransactionType.AddProduct, Users.Cashier, 1));
            }
           
        }

        public void AddListProducts(List<Product> listProductsToAdd)
        {
            foreach (Product product in listProductsToAdd)
            {
                var result = Products.AddUnique(product);
                if (result)
                {
                    Transaction.CommitTransaction(this, new Transaction(TransactionType.AddProduct, Users.Cashier, 1));
                }
            }
        }

        public List<Product> GetListProducts()
        {
            return Products;
        }
        public void WithdrawCash(decimal amount)
        {
            if (CashBalance<amount)
            {
                throw new InvalidOperationException($"Unable to withdraw cash , not enougth balance");
            }
            CashBalance -= amount;
            Transaction.CommitTransaction(this, new Transaction(TransactionType.WithdrawCash, Users.Cashier, amount));
        }
        public decimal TotalReceiptSumm(List<Product> products)
        {
            decimal summ = 0;
            foreach (var product in products)
            {
                summ += product.Price;
            }
            return summ;
        }
        public void ProcessReceipt(List<Product> products, PaymentType paymentType, decimal insertedCash)
        {
            var summ = TotalReceiptSumm(products);

            switch (paymentType)
            {
                case PaymentType.CardRetail:
                    /*CardBalance += summ;
                    Transaction.CommitTransaction(this, new(TransactionType.BuyWithCard, Users.System, summ));*/
                    break;
                case PaymentType.CashRetail:
                    /*CashBalance += summ;
                    Transaction.CommitTransaction(this, new(TransactionType.BuyWithCash, Users.System, summ));

                    if (insertedCash > summ)
                    {
                        CashBalance -= insertedCash - summ;
                        Transaction.CommitTransaction(this, new(TransactionType.GiveChange, Users.System, insertedCash - summ));
                    }
                    else
                    {
                        Console.WriteLine($"Insufficient cash.");
                    }         */          
                    break;
                case PaymentType.CashDeliveryRetail:

                    break;
                case PaymentType.CardWholesale:

                    break;
                case PaymentType.CashWholesale:

                    break;
                case PaymentType.CashDeliveryWholesale:

                    break;
                default:
                    break;
            }
        }
        public void TopUpCash(decimal amount)
        {
            CashBalance += amount;
            Transaction.CommitTransaction(this, new Transaction(TransactionType.CashTopUp, Users.Cashier, amount));
        }
        public void PrintTransactions() 
        {
            foreach(var transaction in Transactions)
            {
                /*Console.WriteLine(transaction.ToString());*/
            }
        }

    }
    public enum PaymentType
    {
        CardRetail,
        CashRetail,
        CashDeliveryRetail,
        CardWholesale,
        CashWholesale,
        CashDeliveryWholesale,
    }
}
