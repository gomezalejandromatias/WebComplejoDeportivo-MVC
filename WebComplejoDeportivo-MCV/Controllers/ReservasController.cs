
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebComplejoDeportivo_MCV.Models;
using WebComplejoDeportivo_MCV.Data;
using WebComplejoDeportivo_MCV.Models.Enum;

public class ReservasController : Controller
{
    private readonly ComplejoDbContext _context;

    public ReservasController(ComplejoDbContext context)
    {
        _context = context;
    }

    // GET: RESERVAS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Reservas.ToListAsync());
    }

    // GET: RESERVAS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var reserva = await _context.Reservas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (reserva == null)
        {
            return NotFound();
        }

        return View(reserva);
    }

    // GET: RESERVAS/Create
    public IActionResult Create()
    {   
         ViewBag.Canchas = _context.Canchas.ToList();

    

        return View();
    }

    // POST: RESERVAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CanchaId,Fecha,HoraInicio,HoraFin")] Reserva reserva,int PorcentajePago,string MetodoPago)
    {
        var cancha = await _context.Canchas.FindAsync(reserva.CanchaId);

        if (cancha == null) 
        {

            return NotFound();
        
        
        }

        reserva.Precio = cancha.PrecioTurno;
        reserva.Estado = EstadoReserva.Pendiente;

        
        

        Pago pago = new PagoEfectivo();
        pago.Estado = EstadoPago.Pendiente;


        if (PorcentajePago == 50) 
        {
            pago = new PagoTransferencia();
            pago.Importe = reserva.Precio / 2;
        
        
        }
        else if(PorcentajePago == 100)
        {

            pago = new PagoMercadoPago();
            pago.Importe = reserva.Precio;




        }


        try
        {
            pago.Estado = EstadoPago.Confirmado;
            reserva.Estado = EstadoReserva.Confirmada;
            


        }
        catch (Exception)
        {

            throw;
        }


        if (ModelState.IsValid)
        {
            _context.Add(reserva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        return View(reserva);
    }

    // GET: RESERVAS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var reserva = await _context.Reservas.FindAsync(id);
        if (reserva == null)
        {
            return NotFound();
        }
        return View(reserva);
    }

    // POST: RESERVAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,ReservanteId,CanchaId,Fecha,HoraInicio,HoraFin,Precio,Estado,FechaCreacion,Observaciones,RowVersion,Reservante,Cancha,Pagos")] Reserva reserva)
    {
        if (id != reserva.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(reserva);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservaExists(reserva.Id))
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
        return View(reserva);
    }

    // GET: RESERVAS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var reserva = await _context.Reservas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (reserva == null)
        {
            return NotFound();
        }

        return View(reserva);
    }

    // POST: RESERVAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var reserva = await _context.Reservas.FindAsync(id);
        if (reserva != null)
        {
            _context.Reservas.Remove(reserva);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ReservaExists(int? id)
    {
        return _context.Reservas.Any(e => e.Id == id);
    }
}
