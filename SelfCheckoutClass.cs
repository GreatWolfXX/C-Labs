using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    internal class SelfCheckoutClass
    {

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

        public void AddProduct(Product productToAdd)
        {
            var result = Products.AddUnique(productToAdd);
            if (result)
            {
                Transaction.CommitTransaction(this, new Transaction(TransactionType.AddProduct, Users.Cashier, productToAdd.Price));
            }
           
        }

        public void AddListProducts(List<Product> listProductsToAdd)
        {
            foreach (Product product in listProductsToAdd)
            {
                var result = Products.AddUnique(product);
                if (result)
                {
                    Transaction.CommitTransaction(this, new Transaction(TransactionType.AddProduct, Users.Cashier, product.Price));
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
        public Payment ProcessReceipt(List<Product> products, PaymentType paymentType, bool loyaltyСard = false, bool delivery = false)
        {
            Payment payment = null;
            var summ = TotalReceiptSumm(products);

            switch (paymentType)
            {
                case PaymentType.CashRetail:
                    payment = new CashPayment(products, summ, loyaltyСard, delivery);
                    payment.CalculateFinalPrice();
                    break;
                case PaymentType.CardRetail:
                    payment = new CardPayment(products, summ, loyaltyСard, delivery);
                    payment.CalculateFinalPrice();
                    break;
                case PaymentType.CashDeliveryRetail:
                    payment = new CourierCashPayment(products, summ, delivery);
                    payment.CalculateFinalPrice();
                    break;
                case PaymentType.CashWholesale:
                    payment = new WholesaleCashPayment(products, summ, loyaltyСard, delivery);
                    payment.CalculateFinalPrice();
                    break;
                case PaymentType.CardWholesale:
                    payment = new WholesaleCardPayment(products, summ, loyaltyСard, delivery);
                    payment.CalculateFinalPrice();
                    break;
                case PaymentType.CashDeliveryWholesale:
                    payment = new WholesaleCourierCashPayment(products, summ, delivery);
                    payment.CalculateFinalPrice();
                    break;
                default:
                    break;
            }
            return payment;
        }
        public void TopUpCash(decimal amount)
        {
            CashBalance += amount;
            Transaction.CommitTransaction(this, new Transaction(TransactionType.CashTopUp, Users.Cashier, amount));
        }

        public Payment CreateTransaction(Payment payment, PaymentType type)
        {
            CashBalance += payment.AmountPaid;
            payment.CalculateChange();
            switch (type)
            {
                case PaymentType.CardRetail:
                    Transaction.CommitTransaction(this, new Transaction(TransactionType.BuyWithCard, Users.System, payment.AmountPaid));
                    break;
               
                case PaymentType.CardWholesale:
                    Transaction.CommitTransaction(this, new Transaction(TransactionType.BuyWithCard, Users.System, payment.AmountPaid));
                    break;
               
                default:
                    Transaction.CommitTransaction(this, new Transaction(TransactionType.BuyWithCash, Users.System, payment.AmountPaid));
                    break;
            }
            if (payment.Change > 0)
            {
                Transaction.CommitTransaction(this, new Transaction(TransactionType.GiveChange, Users.System, payment.Change));
            }
            return payment;
        }
        public void PrintTransactions() 
        {
            foreach(var transaction in Transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
        }

        public List<Transaction> GetTransactionByType(TransactionType transactionType)
        {
            List<Transaction> transaction = new List<Transaction>();

            foreach(var item in Transactions)
            {
                if(item.TransactionType == transactionType)
                {
                    transaction.Add(item);
                }
            }
            return transaction;
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
