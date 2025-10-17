using DesafioPOO.Models;

var nokia = new Nokia("+55 16 123123123", "A-20", "1254544", 512);
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Instagram");
nokia.InstalarAplicativo("LinkedIn");
nokia.Ligar();
nokia.ReceberLigacao();


var iPhone = new Iphone("+55 21 2121321321", "I90", "1358755", 1024);
iPhone.InstalarAplicativo("WhatsApp");
iPhone.InstalarAplicativo("Instagram");
iPhone.InstalarAplicativo("LinkedIn");
iPhone.Ligar();
iPhone.ReceberLigacao();