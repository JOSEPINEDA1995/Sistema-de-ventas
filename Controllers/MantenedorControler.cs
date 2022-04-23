using Microsoft.AspNetCore.Mvc;
using Sistema_de_ventas.Conexion;
using Sistema_de_ventas.Models;


namespace Sistema_de_ventas.Controllers
{
    public class MantenedorControler : Controller
    {
        DeparamentoDatos dp = new DeparamentoDatos();
        public IActionResult Listar()
        { //mostar la vista
          var lista = dp.listar();

            return View(lista);
        }

        public IActionResult Guardar()
        {//solo devielve la vista 
            
            return View();
        }

      

        [HttpPost]
        public IActionResult Guardar(DepartamentoModelo depa)
        {// metodo que recibe el objeto para guardar en la bd 
            
         //valida si estan llenos los campos
            if(!ModelState.IsValid)
                return View();
            var respuesta = dp.guardar(depa);
         //con el if si es verdadero rertornamos los datos a una vista que yo desee
         if(respuesta)
                return RedirectToAction("Listar"); //redirecciona al formulario listar
         else
            return View();
        }


        public IActionResult Editar(int idDepa)
        {//solo devielve la vista 
            var Depa = dp.listaruno(idDepa);
            return View(Depa);
        }

        [HttpPost]
        public IActionResult Editar(DepartamentoModelo depa)
        {// metodo que recibe el objeto para guardar en la bd 

            //valida si estan llenos los campos
            if (!ModelState.IsValid)
                return View();
            var respuesta = dp.modificar(depa);
            //con el if si es verdadero rertornamos los datos a una vista que yo desee
            if (respuesta)
                return RedirectToAction("Listar"); //redirecciona al formulario listar
            else
                return View();
        }
    }
}
