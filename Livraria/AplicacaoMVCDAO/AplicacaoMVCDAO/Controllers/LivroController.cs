using AplicacaoMVCDAO.Intefaces;
using AplicacaoMVCDAO.Models.Livros;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AplicacaoMVCDAO.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroDAO _livroDAO;

        public LivroController(ILivroDAO livroDAO)
        {
            _livroDAO = livroDAO;
        }

        // GET: LivroController
        public ActionResult Index()
        {
            List<Livro> livros = _livroDAO.Listar();
            return View(livros);
        }

        // GET: LivroController/Details/5
        public ActionResult Details(int id)
        {
            Livro livro = _livroDAO.ObterPorId(id);
            return View(livro);
        }

        // GET: LivroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LivroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                Livro livro = new Livro();
                await TryUpdateModelAsync(livro);

                livro = _livroDAO.Inserir(livro);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivroController/Edit/5
        public ActionResult Edit(int id)
        {
            Livro livro = _livroDAO.ObterPorId(id);
            return View(livro);
        }

        // POST: LivroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                Livro livro = new Livro();
                await TryUpdateModelAsync(livro);

                _livroDAO.Alterar(livro);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivroController/Delete/5
        public ActionResult Delete(int id)
        {
            Livro livro = _livroDAO.ObterPorId(id);
            return View(livro);
        }

        // POST: LivroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                Livro livro = new Livro();
                await TryUpdateModelAsync(livro);

                _livroDAO.Deletar(livro);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
