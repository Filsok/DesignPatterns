using Builder;

Console.WriteLine("Hello, World!");

var builder = new InvoiceBuilder();

var invoice = builder.SetVendor("Google..")
    .SetVendee("Vendee")
    .SetInvoiceNumber("111222333")
    .SetDate(DateTime.Now)
    .SetLineItems(new List<string>() { "LineItem1", "LineItem2", "LineItem3" })
    .Build();

Console.WriteLine($"{invoice.Vendor}\n{invoice.Vendee}");