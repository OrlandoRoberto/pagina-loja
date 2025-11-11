using Microsoft.AspNetCore.Mvc;

namespace ProjetoCrud2B.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult ListarProduto()
        {
            return View();
        }
    }
}
