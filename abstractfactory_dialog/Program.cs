using abstractfactory_dialog;
using abstractfactory_dialog.Abstract;
using abstractfactory_dialog.Concrete;

Dialog wdialog = new WindowsDialog();
Dialog webd = new WebDialog();
IButton htmlbutton = new HtmlButton();

wdialog.CreateButton();
wdialog.Render();

webd.CreateButton();
webd.Render();

htmlbutton.OnClick();
