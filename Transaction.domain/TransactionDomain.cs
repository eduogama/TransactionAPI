﻿using Microsoft.VisualBasic;

namespace Transaction.domain
{
    public class TransactionDomain
    {

        public required string AccountID { get; set; }
        public required string TransactionID { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionCurrencyCode { get; set; }
        public int LocalHour { get; set; }
        public string TransactionScenario { get; set; }
        public string TransactionType { get; set; }
        public string TransactionIPaddress { get; set; }
        public string IpState { get; set; }
        public string IpPostalCode { get; set; }
        public string IpCountry { get; set; }
        public int IsProxyIP { get; set; }
        public string BrowserLanguage { get; set; }
        public string PaymentInstrumentType { get; set; }
        public string CardType { get; set; }
        public string PaymentBillingPostalCode { get; set; }
        public string PaymentBillingState { get; set; }
        public string PaymentBillingCountryCode { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingCountry { get; set; }
        public string CvvVerifyResult { get; set; }
        public int DigitalItemCount { get; set; }
        public int PhysicalItemCount { get; set; }
        public DateTime TransactionDateTime { get; set; }

    }
}
