using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_project_paterns.Builder
{
    public interface IInvoiceBuilder
    {

        public Invoice Build();


        public InvoiceBuilder SetVendor(string vendor);



        public InvoiceBuilder SetVendee(string vendee);


        public InvoiceBuilder SetNote(string note);


        public InvoiceBuilder SetLineItems(IEnumerable<string> lineItems);

        public InvoiceBuilder SetInvoiceNumber(string number);


        public InvoiceBuilder SetDate(DateTime date);
        
    }
}
