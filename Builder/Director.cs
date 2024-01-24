using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.Builder
{
    public class Director
    {
        private IInvoiceBuilder builder;
        // this method create invoice with our standard package (2 items)
        public Invoice CreateMonthlyInvoice(string vendor) 
        {
            var invoice = builder.SetDate(DateTime.Now)
                .SetInvoiceNumber($"FVAT{DateTime.Now.Date}")
                .SetVendor(vendor)
                .SetVendee("Vendee")
                .SetLineItems(new List<string> { "Item 1", "Item 2" })
                .Build();

            return invoice;
        }
        // this method create blank invoice
        public Invoice BlankInvoice()
        {
            var invoice = builder.SetDate(DateTime.Now)
                .SetInvoiceNumber("")
                .SetVendor("")
                .SetVendee("")
                .SetLineItems(new List<string> { "", "" })
                .Build();

            return invoice;
        }
    }
}
