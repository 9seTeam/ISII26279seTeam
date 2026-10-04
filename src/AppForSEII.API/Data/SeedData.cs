namespace AppForSEII.API.Data {
    public class SeedData {
        public static void Initialize(ApplicationDbContext dbContext, IServiceProvider serviceProvider, ILogger logger) {
            List<string> rolesNames = new List<string> { "Administrator", "Employee", "Customer" };

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            try {
                SeedRoles(roleManager, rolesNames);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the roles in the Database.");
            }

            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            try {
                SeedUsers(userManager, rolesNames);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the Users in the Database.");
            }

            try {
                SeedModelos3D(dbContext);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the 3D models in the Database.");
            }
          
            try{
                SeedImpresoras3D(dbContext);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the Impresoras3D in the Database.");
            }
 
            try {
                SeedAccesorios(dbContext);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the Accesorios in the Database.");
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager, List<string> roles) {

            foreach (string roleName in roles) {
                //it checks such role does not exist in the database 
                if (!roleManager.RoleExistsAsync(roleName).Result) {
                    IdentityRole role = new IdentityRole();
                    role.Name = roleName;
                    role.NormalizedName = roleName;
                    IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                }
            }

        }

        public static void SeedUsers(UserManager<ApplicationUser> userManager, List<string> roles) {
            //first, it checks the user does not already exist in the DB
            if (userManager.FindByNameAsync("elena@uclm.es").Result == null) {
                ApplicationUser user = new ApplicationUser("1", "Elena", "Navarro Martínez", "elena@uclm.es");
                user.EmailConfirmed = true;

                var result = userManager.CreateAsync(user, "Password1234%");
                result.Wait();

                if (result.IsCompletedSuccessfully) {
                    //administrator role
                    userManager.AddToRoleAsync(user, roles[0]).Wait();
                }
            }


            if (userManager.FindByNameAsync("peter@uclm.es").Result == null) {
                //A customer class has been defined because it has different attributes (purchase, rental, etc.)
                ApplicationUser user = new ApplicationUser("3", "Peter", "Jackson", "peter@uclm.es");
                user.EmailConfirmed = true;

                var result = userManager.CreateAsync(user, "OtherPass12$");

                result.Wait();

                if (result.IsCompletedSuccessfully) {
                    //customer role
                    userManager.AddToRoleAsync(user, roles[2]).Wait();

                }
            }

        }
        
        public static void SeedAccesorios(ApplicationDbContext dbcontext) {

    if (dbcontext.Accesorios.FirstOrDefault(a => a.Nombre == "Boquilla pfa") == null) {
        Accesorio accesorio = new Accesorio(
            "Boquilla pfa",
            CategoriaAccesorio.Boquillas,
            "Resina",
            20,
            8.50m);

        dbcontext.Accesorios.Add(accesorio);
    }

    if (dbcontext.Accesorios.FirstOrDefault(a => a.Nombre == "Allen") == null) {
        Accesorio accesorio = new Accesorio(
            "Allen",
            CategoriaAccesorio.Herramientas,
            "Universal",
            10,
            25.00m);

        dbcontext.Accesorios.Add(accesorio);
    }

    if (dbcontext.Accesorios.FirstOrDefault(a => a.Nombre == "LimpiaFull") == null) {
        Accesorio accesorio = new Accesorio(
            "LimpiaFull",
            CategoriaAccesorio.KitsLimpieza,
            "Universal",
            15,
            18.00m);

        dbcontext.Accesorios.Add(accesorio);
    }

    dbcontext.SaveChanges();
}

        public static void SeedImpresoras3D(ApplicationDbContext dbcontext) {

            if (dbcontext.Impresoras3Ds.FirstOrDefault(i => i.Nombre == "HP") == null) {
                Impresora3D impresora = new Impresora3D(
                "HP",
                "HP V2",
                TipoImpresora.Filamento,
                "Impresora de sobremesa, ideal para tener en casa",
                0.25m,
                5.00m);

                dbcontext.Impresoras3Ds.Add(impresora);
            }

            if (dbcontext.Impresoras3Ds.FirstOrDefault(i => i.Nombre == "Lenovo") == null) {
                Impresora3D impresora = new Impresora3D(
                "Lenovo",
                "Lenovo X",
                TipoImpresora.Resina,
                "Impresora de resina de alta precisión",
                0.30m,
                7.50m);

                dbcontext.Impresoras3Ds.Add(impresora);
            }

            if (dbcontext.Impresoras3Ds.FirstOrDefault(i => i.Nombre == "Prink") == null) {
                Impresora3D impresora = new Impresora3D(
                "Prink",
                "Prink MK4",
                TipoImpresora.Polimero,
                "Impresora de gama alta para polímeros técnicos",
                0.35m,
                9.00m);

                dbcontext.Impresoras3Ds.Add(impresora);
            }        

            dbcontext.SaveChanges();
        }


        public static void SeedModelos3D(ApplicationDbContext dbContext) {
            // Evita duplicar datos si la aplicación se arranca varias veces
            if (dbContext.LicenciasModelo3Ds.Any()) {
                return;
            }

            var licenciaPersonal = new LicenciaModelo3D {
                Nombre = "Uso personal",
                FechaExpiracion = DateTime.Now.AddYears(1)    // expira dentro de un año
            };
            var licenciaTemporal = new LicenciaModelo3D {
                Nombre = "Licencia temporal",
                FechaExpiracion = DateTime.Now.AddDays(20)   // expira en menos de un mes
            };

            dbContext.LicenciasModelo3Ds.AddRange(licenciaPersonal, licenciaTemporal);
            dbContext.SaveChanges();   // necesario para que las licencias tengan Id

            dbContext.Modelos3Ds.AddRange(
                new Modelo3D { Nombre = "Dragon articulado", Categoria = "Miniaturas", Formato = FormatoModelo3D.STL, Precio = 9.99m, LicenciaModelo3DId = licenciaPersonal.Id },
                new Modelo3D { Nombre = "Torre de Pisa figura", Categoria = "Decoracion", Formato = FormatoModelo3D.OBJ, Precio = 4.50m, LicenciaModelo3DId = licenciaPersonal.Id },
                new Modelo3D { Nombre = "Pack figuras ajedrez", Categoria = "Miniaturas", Formato = FormatoModelo3D.TresMF, Precio = 14.90m, LicenciaModelo3DId = licenciaTemporal.Id }
            );
            dbContext.SaveChanges();
        }



    }
}