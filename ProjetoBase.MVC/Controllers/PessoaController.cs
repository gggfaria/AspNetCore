using Microsoft.AspNetCore.Mvc;
using ProjetoBase.Domain.Entities;
using ProjetoBase.Service.Services.Interfaces;

namespace ProjetoBase.Controllers
{
    public class PessoaController : Controller
    {
        private IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;

        }

        public IActionResult Index()
        {
            ViewBag.Teste = "Controller pessoa";
            //Pessoa pessoa = new Pessoa()
            //{
            //    Nome = "Gabriel",
            //    CPF = "11111111111"

            //};
            //_pessoaService.Insert(pessoa);
            return View();
        }
    }
}