using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using WebComplejoDeportivo_MCV.Models;
using WebComplejoDeportivo_MCV.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetCoreGeneratedDocument;
using WebComplejoDeportivo_MCV.Models.ViewModels;
using Microsoft.Identity.Client.NativeInterop;



namespace WebComplejoDeportivo_MCV.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UserManager<Usuario> _usermanager;
        private readonly ComplejoDbContext _complejoDbContext;

        

        public UsuarioController(UserManager<Usuario> userManager,ComplejoDbContext complejoDbContext)
        {
            _usermanager = userManager;
            _complejoDbContext = complejoDbContext;

        }



        // GET: UsuarioController
        public ActionResult Index()
        {

            ViewBag.Roles = new SelectList(_complejoDbContext.Roles,"Id", "Nombre");
            ViewBag.Complejos = new SelectList(_complejoDbContext.Complejos, "Id", "Nombre");
            
            return View("CrearUsuario");



        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
       [ValidateAntiForgeryToken]
        public async Task <ActionResult> CrearUsuario(CrearUsuarioViewModel model)
        {


            if (!ModelState.IsValid)
            {
                return View(model);
            }



            try
            {
             Usuario usuario = new Usuario();

            usuario.Nombre = model.Nombre; 
            usuario.Apellido = model.Apellido;
            usuario.Email = model.Email;
                usuario.UserName = model.Email;
        
            usuario.RolId = model.RolId;
            usuario.ComplejoId = model.ComplejoId;
            usuario.Activo = model.Activo;

             var crear = await _usermanager.CreateAsync(usuario,model.Password);

                if (!crear.Succeeded) 
                {
                    foreach (var item in crear.Errors)
                    {

                        ModelState.AddModelError("", item.Description);

                        return View(model);

                    }



                }

                



            }
            catch (Exception)
            {


                throw;
            }


            return RedirectToAction("Index");
        }

   

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
