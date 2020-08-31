using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula03.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class VagaController : Controller
    {

        //simular um banco de dados
        private static List<Vaga> _bancoVagas = new List<Vaga>();

        public IActionResult Index()
        {
            return View(_bancoVagas);
        }

        //Remover um cargo
        [HttpPost]
        public IActionResult Remover (int id)
        {
            //Remove da lista pelo index = id
            _bancoVagas.RemoveAt(_bancoVagas.FindIndex(v => v.Codigo == id));
            //Mensagem de sucesso
            TempData["msg"] = "Vaga removida com Sucesso";
            //Redirecionamento
            return RedirectToAction("Index");
        }

        [HttpPost]
        //Método que atualiza o Vaga
        public IActionResult Editar(Vaga vaga)
        {
            _bancoVagas[_bancoVagas.FindIndex(v => v.Codigo == vaga.Codigo)] = vaga;
            TempData["msg"] = "Vaga atualizada com sucesso!";
            return RedirectToAction("Index");
        }

        //Cadastrar uma vaga
        public IActionResult Cadastrar(Vaga vaga)
        {
            //Ver se tem algum elemento na lista
            if (_bancoVagas.Any())
            {
                vaga.Codigo = _bancoVagas[_bancoVagas.Count - 1].Codigo + 1;
            }
            else
            {
                vaga.Codigo = 1;
            }

            _bancoVagas.Add(vaga);
            TempData["msg"] = "Vaga cadastrada no sistema!!";
            return RedirectToAction("Index");

        }
    }
}
