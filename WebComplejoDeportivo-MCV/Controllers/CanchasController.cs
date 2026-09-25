
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebComplejoDeportivo_MCV.Models;
using WebComplejoDeportivo_MCV.Data;

public class CanchasController : Controller
{
    private readonly ComplejoDbContext _context;

    public CanchasController(ComplejoDbContext context)
    {
        _context = context;
    }

 

    // GET: CANCHAS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Canchas.ToListAsync());
    }

    // GET: CANCHAS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var cancha = await _context.Canchas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (cancha == null)
        {
            return NotFound();
        }

        return View(cancha);
    }

    // GET: CANCHAS/Create
    public IActionResult Create()
    {
        ViewBag.TiposCancha =  _context.TiposCancha.ToList();

        return View();
    }

    // POST: CANCHAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("TipoCanchaId,Nombre,Descripcion,PrecioTurno,FotoUrl,Activa,FotoArchivo")]
    Cancha cancha)
    {
        // TEMPORAL hasta implementar el usuario autenticado
        cancha.ComplejoId = 1;

        if (ModelState.IsValid)
        {
            // Si el usuario eligió una foto de su PC
            if (cancha.FotoArchivo != null)
            {
                // Obtenemos la extensión original (.jpg, .png, etc.)
                string extension = Path.GetExtension(cancha.FotoArchivo.FileName);

                // Creamos un nombre único para evitar fotos con el mismo nombre
                string nombreArchivo = Guid.NewGuid().ToString() + extension;

                // Ruta física donde vamos a guardar la imagen
                string rutaCompleta = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "imagenes",
                    "canchas",
                    nombreArchivo
                );

                // Guardamos físicamente el archivo
                using (var stream = new FileStream(rutaCompleta, FileMode.Create))
                {
                    await cancha.FotoArchivo.CopyToAsync(stream);
                }

                // Guardamos en FotoUrl la dirección de la imagen
                cancha.FotoUrl = "/imagenes/canchas/" + nombreArchivo;
            }

            // Guardamos la cancha en SQL
            _context.Add(cancha);
            await _context.SaveChangesAsync();

            ViewBag.Canchas = cancha;

            return RedirectToAction(nameof(Index));
        }

        // IMPORTANTE:
        // Si hubo un error de validación, tenemos que volver
        // a cargar la lista porque la vista usa ViewBag.TiposCancha.
        ViewBag.TiposCancha = _context.TiposCancha.ToList();

        return View(cancha);
    }

    // GET: CANCHAS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        ViewBag.TiposCancha = _context.TiposCancha.ToList();

        if (id == null)
        {
            return NotFound();
        }

        var cancha = await _context.Canchas.FindAsync(id);
        if (cancha == null)
        {
            return NotFound();
        }
        return View(cancha);
    }

    // POST: CANCHAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,ComplejoId,TipoCanchaId,Nombre,Descripcion,PrecioTurno,FotoUrl,Activa,Complejo,TipoCancha,HorariosDisponibles,Reservas")] Cancha cancha)
    {
        if (id != cancha.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(cancha);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CanchaExists(cancha.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(cancha);
    }

    // GET: CANCHAS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var cancha = await _context.Canchas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (cancha == null)
        {
            return NotFound();
        }

        return View(cancha);
    }

    // POST: CANCHAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var cancha = await _context.Canchas.FindAsync(id);
        if (cancha != null)
        {
            cancha.Activa = false;
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Activar(int id)
    {
        var cancha = await _context.Canchas.FindAsync(id);

        if (cancha == null)
        {
            return NotFound();
        }

        cancha.Activa = true;

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }


    private bool CanchaExists(int? id)
    {
        return _context.Canchas.Any(e => e.Id == id);
    }
}
