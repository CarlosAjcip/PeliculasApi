using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PeliculasApi.Servicios;

namespace PeliculasApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get;}

        public void ConfigureServices(IServiceCollection services)
        {
            //haciendo autommaper
            services.AddAutoMapper(typeof(Startup));
            
            //ruta o url para almacenar archivos locales en el wwwroot
            services.AddTransient<IAlmacenadorArchivos, AlmacenadorArchivoLocal>();
            services.AddHttpContextAccessor();

            //cadena a la conexion Db
           services.AddDbContext<ApplicationDbContext>(options => 
           options.UseSqlServer(Configuration.GetConnectionString("DefualtConnection")));

           services.AddControllers();
                  
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
