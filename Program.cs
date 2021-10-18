using static  System.Console;


WriteLine("Hello World!");

var sistema = new Sistema();
var vista = new Vista();
var controlador = new Controlador(sistema, vista);