using AutoMapper;
using EasyJob.AppMVC.ViewModel;
using EasyJob_Business.Core.NotificationsErrors;
using EasyJob_Business.Models;
using EasyJob_Business.Models.Addresses;
using EasyJob_Business.Models.Addresses.Service;
using EasyJob_Business.Models.Addresses.Services;
using EasyJob_Business.Models.Sectors;
using EasyJob_Business.Models.Subsectors;
using EasyJob_Business.Models.Users;
using EasyJob_Business.Models.Users.Services;
using EasyJob_Business.Models.Vacancies.Jobs;
using EasyJob_Business.Models.Vacancies.Jobs.Services;
using EasyJob_Infra.Data.DbAplications;
using EasyJob_Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EasyJob.AppMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbApplication>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<DbApplication>();

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddAutoMapper(typeof(Startup));

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AddressViewModel, Adress>().ReverseMap();
                cfg.CreateMap<UserViewModel, User>().ReverseMap();
                cfg.CreateMap<SectorViewModel, Sector>().ReverseMap();
                cfg.CreateMap<SubsectorViewModel, Subsector>().ReverseMap();
                cfg.CreateMap<JobViewModel, Job>().ReverseMap();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<DbApplication, DbApplication>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<ISectorRepository, SectorRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<INotifier, Notifier>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
