using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Import_Business
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public string BuyerUserName { get; set; }
        public string BuyerName { get; set; }
        public string BuyerNote { get; set; }
        public string BuyerAddress1 { get; set; }
        public string BuyerAddress2 { get; set; }
        public string BuyerCity { get; set; }
        public string BuyerSate { get; set; }
        public string BuyerZip { get; set; }
        public string BuyerCountry { get; set; }
        public string ShipToName { get; set; }
        public string ShipToPhone { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZip { get; set; }
        public string ShipToCountry { get; set; }
        public string ItemNumber { get; set; }
        public string ItemTitle { get; set; }
        public string CustomLabel { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }
        public string Size { get; set; }
        public string SellerId { get; set; }
    }
}
