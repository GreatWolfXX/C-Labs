using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Transaction
    {
        public DateTime TransactionDateTime { get; set; }
        public Users User { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }

        public Transaction(TransactionType transactionType, Users user, decimal amount) 
        {
            TransactionDateTime = DateTime.Now;
            TransactionType = transactionType;
            User = user;
            Amount = amount;
        }
        
        public static void CommitTransaction(SelfCheckoutClass selfCheckout, Transaction transaction)
        {
            selfCheckout.Transactions
                .Add(transaction);
        }
        public override string ToString()
        {
            return $"Time : {TransactionDateTime} , User : {User}  Operation : {TransactionType} , Amount : {Amount}";
        }
    }

    public enum Users
    {
        System,
        Cashier
    }
    public enum TransactionType
    {
        WithdrawCash,
        BuyWithCard,
        BuyWithCash,
        CashTopUp,
        GiveChange,
        AddProduct
    }
}
