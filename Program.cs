﻿using Creation_project_paterns.Builder;

namespace Creation_project_paterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new InvoiceBuilder();

            var invoice = builder.SetDate(new DateTime(2020, 1, 1))
                .SetInvoiceNumber("A1")
                .SetVendor("Google")
                .SetVendee("Vendee")
                .SetLineItems(new List<string> { "Item 1", "Item 2" })
                .Build();
            

            
        }
    }
}