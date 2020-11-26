using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface IInvoice: IIdentifiable
    {
         int CustomerId { get; set; }
         string InvoiceDate { get; set; }
         string BillingAdress { get; set; }
         string BillingCity { get; set; }
         string BllingState { get; set; }
         string BillingCountry { get; set; }
         string BillingPostalCode { get; set; }

         int Total { get; set;  }
    }
}
