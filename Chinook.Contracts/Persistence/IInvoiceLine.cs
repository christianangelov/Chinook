using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface IInvoiceLine : IIdentifiable
    {
         int InvoiceId { get; set; }
         int TrackId { get; set; }
         int UnitPrice { get; set; }
         int Quantity { get; set; } 
    }
}
