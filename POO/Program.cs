
using POO.ContentContext;



    var artigos = new List<Artigo>();
    artigos.Add(new Artigo("Artigo sobre OOP", "orientacao-objetos"));
    artigos.Add(new Artigo("Artigo sobre C#", "orientacao-csharp"));
    artigos.Add(new Artigo("Artigo sobre .NET", "orientacao-dotnet"));



    foreach (var artigo in artigos)
    {
        Console.WriteLine(artigo.Id);
        Console.WriteLine(artigo.Titulo);
        Console.WriteLine(artigo.Url);
    }

var curso = new List<Curso>();
var cursoOOP = new Curso("Fundamentos OOP", "fundamentos-oop");
var cursoCsharp = new Curso("Fundamentos C#", "fundamentos-oop");
var cursoASPnet = new Curso("Fundamentos ASP.NET", "fundamentos-oop");
curso.Add(cursoASPnet);
curso.Add(cursoCsharp);
curso.Add(cursoASPnet);

var carreiras = new List<Carreira>();
var carreira = new Carreira("Especialista .NET", "especialista-dotnet");

var carreiraItem = new CarreiraItem(1, "Comece aqui!", "", cursoOOP);
var carreiraItem3 = new CarreiraItem(2, "Aprenda C#", "", cursoCsharp);
var carreiraItem2 = new CarreiraItem(3, "Aprenda ASP.NET ", "", cursoASPnet);

carreira.Items.Add(carreiraItem);
carreira.Items.Add(carreiraItem2);
carreira.Items.Add(carreiraItem3);


carreiras.Add(carreira);

foreach(var carreiraa in carreiras)
{
    Console.WriteLine(carreira.Titulo);
    foreach (var item in carreiraa.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"Ordem: {item.Order} - Titulo: {item.Titulo}"); 
    }

}





