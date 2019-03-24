using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using TareaHelpers.Datos;



namespace TareaHelpers.Controllers
{
    public class RegistrosController : Controller
    {
        // GET: Registros
        public ActionResult Index()
        {
            return View();
        }


       
        public ActionResult Registro()
        {

            return View();

        }

        
        [HttpPost]
        public ActionResult Registro(Datos.Models.BindingModels.RegistroUsuariosBindingModel model, string correr, string bailar, string cantar, string pintar)
        {

            
            ViewBag.Nombre = model.Nombre;
            ViewBag.Apellido = model.Apellido;
            ViewBag.Cedula = model.Cedula;
            ViewBag.Sexo = model.Sexo;
            ViewBag.Ocupacion = model.Ocupacion;
            ViewBag.CheckBox = model.CheckBox;
            ViewBag.Correo = model.Correo;
            ViewBag.Edad = model.Edad;
            ViewBag.Telefono = model.Telefono;

            if (correr == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Correr";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }
            if (bailar == "true" && correr == "true")
            {
                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Bailar, Cantar";
            }
            else
            {
                model.CheckBox.CompareTo(false);
            }
            if(bailar == "true")
            {
                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Bailar";
            }
            else
            {
                model.CheckBox.CompareTo(false);
            }
            ////////////////////////////////////////////////////////////////



            if (cantar == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Cantar";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }


            if (pintar == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Pintar";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }


            if (cantar == "true" && pintar == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Pintar, Cantar";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }


            //////////////////////////////////////////////////////


            if (cantar == "true" && pintar == "true" && correr == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Pintar Cantar Correr";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }

            if (cantar == "true" && pintar == "true" && bailar == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Pintar Cantar Bailar";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }

            if (cantar == "true" && pintar == "true" && correr == "true" && bailar == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Pintar Cantar Correr bailar";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }

            //////////////////////////////////////////////////////////////////////


            if (cantar == "true" && correr == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Cantar, Correr";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }

            if (cantar == "true" && bailar == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Cantar, Bailar";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }

            /////////////////////////////////////////////////////////////////////////////////

            if (pintar == "true" && correr == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Pintar, Correr";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }

            if (pintar == "true" && bailar == "true")
            {

                model.CheckBox.CompareTo(true);
                ViewBag.CheckBox = "Pintar, Bailar";
            }
            else
            {
                model.CheckBox.CompareTo(false);


            }





            /*ViewBag.Nombre = gua.Nombre;*/


            if (ModelState.IsValid)
            {
                return View("Resultado");
            }


            return View(model);

        }

       /* public ActionResult Resultado(Datos.Models.BindingModels.RegistroUsuariosBindingModel ver)
        {
           
            

           

            return View("Resultado");
        }*/

    }

    internal class NombreCheckBox
    {
    }
}