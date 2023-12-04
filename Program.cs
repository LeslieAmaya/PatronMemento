using PatronMemento.Caretaker;
using PatronMemento.ConcreteOriginator;

HistoryManager hm = new HistoryManager();
URLBar urlBar = new URLBar(hm, "www.myportafolio.com/");

urlBar.NavigateTo("AcercaDeMi");
urlBar.NavigateTo("Proyectos");
urlBar.NavigateTo("Proyecto1");

Console.WriteLine($"URL después de navegar hasta Proyecto 1:\n{urlBar.GetURL()}");
hm.Undo();
Console.WriteLine($"\nUrl después de regresar a Proyectos:\n{urlBar.GetURL()}");
hm.Undo();
Console.WriteLine($"\nUrl después de regresar a Acerca de mi:\n{urlBar.GetURL()}");
hm.Undo();
Console.WriteLine($"\nUrl después de regresar al Inicio:\n{urlBar.GetURL()}");
