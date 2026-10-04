using AppForSEII.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppForSEII.API.DTOs.ApplicationUserDTO;

namespace AppForSEII.API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);


    }


    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Pieza3D> Piezas3Ds { get; set; }
    public DbSet<Material> Materiales { get; set; }
    public DbSet<EncargoImpresion> EncargoImpresions { get; set; }
    public DbSet<LineaEncargo> LineaEncargos { get; set; }

    public DbSet<Impresora3D> Impresoras3Ds { get; set; }
    public DbSet<ReservaImpresora> ReservaImpresoras { get; set; }
    public DbSet<LineaReserva> LineaReservas { get; set; }

    public DbSet<Modelo3D> Modelos3Ds { get; set; }
    public DbSet<LicenciaModelo3D> LicenciasModelo3Ds { get; set; }
    public DbSet<CompraModelo3D> CompraModelo3Ds { get; set; }
    public DbSet<LineaCompraModelo> LineaCompraModelos { get; set; }

    public DbSet<Accesorio> Accesorios { get; set; }
    public DbSet<CompraAccesorios> CompraAccesorioss { get; set; }
    public DbSet<LineaCompraAccesorio> LineaCompraAccesorios { get; set; }
}