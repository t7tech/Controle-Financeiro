using System.Web.Mvc;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.UI.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly IUserService _userService;

        public UsuariosController(IUserService userRepository)
        {
            _userService = userRepository;
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(_userService.GetAll());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(string id)
        {
            return View(_userService.GetById(id));
        }

        public ActionResult DesativarLock(string id)
        {
            _userService.DisableLock(id);
            return RedirectToAction("Index");
        }
    }
}