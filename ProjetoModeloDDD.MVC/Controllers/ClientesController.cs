using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Infra.Data.Repositories;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteAppService.GetAll());
            return View(clienteViewModel);
        }

        public ActionResult Especiais()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteAppService.ObterClientesEspeciais());
            return View(clienteViewModel);
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteAppService.Add(clienteDomain);

                return RedirectToAction("Index");
            }

                return View(cliente);

        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteAppService.Update(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(cliente);

        }

        public ActionResult Delete(long id)
        {
            var cliente = _clienteAppService.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            var cliente = _clienteAppService.GetById(id);
            _clienteAppService.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
