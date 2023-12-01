using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface Payment
    {
        List<Product> Products { get; set; }
        decimal TotalPrice { get; set; }
        decimal AmountPaid { get; set; }
        decimal Change { get; set; }
        bool HomeDelivery { get; set; }

        void CalculateFinalPrice();
        void CalculateChange();
    }

    public struct CashPayment : Payment
    {
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Change { get; set; }
        public bool HasLoyaltyCard { get; set; }
        public bool HomeDelivery { get; set; }

        public CashPayment(List<Product> products, decimal totalPrice, bool hasLoyaltyCard = false, bool homeDelivery = false) {
            Products = products;
            TotalPrice = totalPrice;
            AmountPaid = 0;
            Change = 0;
            HasLoyaltyCard = hasLoyaltyCard;
            HomeDelivery = homeDelivery;
        }

        public void CalculateFinalPrice()
        {
            decimal discount = HasLoyaltyCard ? TotalPrice * 0.05m : 0;
            decimal deliveryCharge = HomeDelivery ? 250 : 0;

            decimal finalPrice = TotalPrice - discount + deliveryCharge;

            TotalPrice = finalPrice;
        }

        public void CalculateChange()
        {
            Change = AmountPaid - TotalPrice;
        }
    }

    public struct CardPayment : Payment
    {
        public  List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Change { get; set; }
        public bool HasLoyaltyCard { get; set; }
        public bool HomeDelivery { get; set; }

        public CardPayment(List<Product> products, decimal totalPrice, bool hasLoyaltyCard, bool homeDelivery)
        {
            Products = products;
            TotalPrice = totalPrice;
            AmountPaid = totalPrice;
            Change = 0;
            HasLoyaltyCard = hasLoyaltyCard;
            HomeDelivery = homeDelivery;
        }

        public void CalculateFinalPrice()
        {
            decimal discount = HasLoyaltyCard ? TotalPrice * 0.05m : 0;
            decimal deliveryCharge = HomeDelivery ? 250 : 0;

            decimal finalPrice = TotalPrice - discount + deliveryCharge;

            TotalPrice = finalPrice;
        }

        public void CalculateChange()
        {
            Change = 0;
        }
    }

    public struct CourierCashPayment : Payment
    {
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Change { get; set; }
        public bool HomeDelivery { get; set; }

        public CourierCashPayment(List<Product> products, decimal totalPrice, bool homeDelivery)
        {
            Products = products;
            TotalPrice = totalPrice;
            AmountPaid = 0;
            Change = 0;
            HomeDelivery = homeDelivery;
        }
        public void CalculateFinalPrice()
        {
            decimal discount = 0;
            decimal deliveryCharge = HomeDelivery ? 250 : 0;

            decimal finalPrice = TotalPrice - discount + deliveryCharge;

            TotalPrice = finalPrice;
        }

        public void CalculateChange()
        {
            Change = AmountPaid - TotalPrice;
        }
    }

    public struct WholesaleCashPayment : Payment
    {
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Change { get; set; }
        public bool HasLoyaltyCard { get; set; }
        public bool HomeDelivery { get; set; }

        public WholesaleCashPayment(List<Product> products, decimal totalPrice, bool hasLoyaltyCard, bool homeDelivery)
        {
            Products = products;
            TotalPrice = totalPrice;
            AmountPaid = 0;
            Change = 0;
            HasLoyaltyCard = hasLoyaltyCard;
            HomeDelivery = homeDelivery;
        }
        public void CalculateFinalPrice()
        {
            decimal discount = HasLoyaltyCard ? TotalPrice * 0.08m : 0;
            decimal deliveryCharge = HomeDelivery ? 50 : 0;

            decimal finalPrice = TotalPrice - discount + deliveryCharge;

            TotalPrice = finalPrice;
        }

        public void CalculateChange()
        {
            Change = AmountPaid - TotalPrice;
        }
    }
    
    public struct WholesaleCardPayment : Payment
    {
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Change { get; set; }
        public bool HasLoyaltyCard { get; set; }
        public bool HomeDelivery { get; set; }

        public WholesaleCardPayment(List<Product> products, decimal totalPrice, bool hasLoyaltyCard, bool homeDelivery)
        {
            Products = products;
            TotalPrice = totalPrice;
            AmountPaid = totalPrice;
            Change = 0;
            HasLoyaltyCard = hasLoyaltyCard;
            HomeDelivery = homeDelivery;
        }

        public void CalculateFinalPrice()
        {
            decimal discount = HasLoyaltyCard ? TotalPrice * 0.08m : 0;
            decimal deliveryCharge = HomeDelivery ? 50 : 0;

            decimal finalPrice = TotalPrice - discount + deliveryCharge;

            TotalPrice = finalPrice;
        }

        public void CalculateChange()
        {
            Change = 0;
        }
    }

    public struct WholesaleCourierCashPayment : Payment
    {
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Change { get; set; }
        public bool HomeDelivery { get; set; }

        public WholesaleCourierCashPayment(List<Product> products, decimal totalPrice, bool homeDelivery)
        {
            Products = products;
            TotalPrice = totalPrice;
            AmountPaid = 0;
            Change = 0;
            HomeDelivery = homeDelivery;
        }

        public void CalculateFinalPrice()
        {
            decimal discount = 0;
            decimal deliveryCharge = 0;

            decimal finalPrice = TotalPrice - discount + deliveryCharge;

            TotalPrice = finalPrice;
        }

        public void CalculateChange()
        {
            Change = AmountPaid - TotalPrice;
        }
    }
}