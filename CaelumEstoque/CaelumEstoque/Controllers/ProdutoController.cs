using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        [HttpGet]
        public ActionResult Index()
        {

            ProdutosDAO dao = new ProdutosDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;

            return View();
        }

        public ActionResult Form()
        {
            var categoriaDao = new CategoriasDAO();
            var categorias =  categoriaDao.Lista();
            ViewBag.Categorias = categorias;

            return View();
        }

        //para receber todas as informações osmente como post
        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {

            var dao = new ProdutosDAO();
            dao.Adiciona(produto);

            return RedirectToAction("Index","Produto");
        }
    }
}