using Mediator;

Button submitButton = new Button();
Checkbox clientType = new Checkbox();

new RegisterClientView(clientType, submitButton);       //wow. But it works...

submitButton.Click();
clientType.Select();