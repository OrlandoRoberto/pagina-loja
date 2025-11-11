using Microsoft.AspNetCore.Mvc;
using ProjetoCrud2B.Repositorio;



namespace ProjetoCrud2B.Controllers
{
    public class UsuarioController : Controller
    {
        //declaração
        private readonly UsuarioRepositorio _usuarioRepositorio;


        //construtor
        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            //instância
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuario(email);

            if(usuario != null && usuario.senha == senha)
            {
                return RedirectToAction("ListarProduto", "Produto");
            }
            ModelState.AddModelError("", "Email e Senha Inválidos");
            return View();
        }




        public IActionResult Index()
        {
            return View();
        }
    }
}
