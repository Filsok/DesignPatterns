using Builder;

Console.WriteLine("Hello, World!");

var builder = new InvoiceBuilder();

builder.SetVendor("Google..");
builder.SetVendee("Vendee");
builder.SetInvoiceNumber("111222333");
builder.SetDate(DateTime.Now);
builder.SetLineItems(new List<string>() { "LineItem1", "LineItem2", "LineItem3" });

var invoice = builder.Build();

Console.WriteLine($"{invoice.Vendor}\n{invoice.Vendee}");