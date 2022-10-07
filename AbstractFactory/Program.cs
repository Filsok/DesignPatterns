using AbstractFactory;

var uiApplication = new Application(new WindowsFactory());
uiApplication.RenderUI();