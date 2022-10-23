using State;

var context = new Context();

context.EjectCard();
context.InsertCard();
context.InsertPin(1111);
context.InsertCard();
context.InsertPin(8888);
context.WithdrawCash(200_000);
context.InsertCard();