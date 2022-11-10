using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.Mvc;
using RecuperacionMVC.Models;
namespace RecuperacionMVC.Controllers
{
    
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public static Operacion objOp = new Operacion();
        public static TipoOperacion objTipo = new TipoOperacion();
        public ActionResult OperacionesTipo()
        {
            return View(objOp.Listar());
        }
    }
}