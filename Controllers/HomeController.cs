using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Brenda", "91597553697", "brenda-carvalho82@technocut.com.br", "Pixuruca");
        Cliente cliente2 = new Cliente(02, "Brenda", "91597553697", "brenda-carvalho82@technocut.com.br", "Pixuruca");
        Cliente cliente3 = new Cliente(03, "Brenda", "91597553697", "brenda-carvalho82@technocut.com.br", "Pixuruca");
        Cliente cliente4 = new Cliente(04, "Brenda", "91597553697", "brenda-carvalho82@technocut.com.br", "Pixuruca");
        Cliente cliente5 = new Cliente(05, "Brenda", "91597553697", "brenda-carvalho82@technocut.com.br", "Pixuruca");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "Caio e Murilo Filmagens Ltda", "66337799000114", "ouvidoria@caioemurilofilmagensltda.com.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Caio e Murilo Filmagens Ltda", "66337799000114", "ouvidoria@caioemurilofilmagensltda.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Caio e Murilo Filmagens Ltda", "66337799000114", "ouvidoria@caioemurilofilmagensltda.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Caio e Murilo Filmagens Ltda", "66337799000114", "ouvidoria@caioemurilofilmagensltda.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Caio e Murilo Filmagens Ltda", "66337799000114", "ouvidoria@caioemurilofilmagensltda.com.br");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
