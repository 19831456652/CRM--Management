using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace CustomerManagement.API
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
            // ����ע��
            Tools.RelyDi.Di(services);
            services.AddControllers();
            services.AddAuthentication("Bearer")
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("abcdABCD1234abcdABCD1234")),    // ���ܽ���Token����Կ

                       // �Ƿ���֤������
                       ValidateIssuer = true,
                       // ����������
                       ValidIssuer = "server",

                       // �Ƿ���֤������
                       // ����������
                       ValidateAudience = true,
                        ValidAudience = "client007",

                       // �Ƿ���֤������Ч��
                       ValidateLifetime = true,
                       // ÿ�ΰ䷢���ƣ�������Чʱ��
                       ClockSkew = TimeSpan.FromMinutes(120)
                    };
                });

            //����
            services.AddCors(options =>
            {
                options.AddPolicy("any", builder =>
                {
                    builder
                        .SetIsOriginAllowed(_ => true)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
            });




            services.AddSwaggerGen(c =>
            {
                //У��ʹ��
                c.AddSecurityRequirement(new OpenApiSecurityRequirement());
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = "Format: Bearer {auth_token}",
                    Name = "Authorization",
                    In = ParameterLocation.Header

                });

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplication1", Version = "v1" });

                //xmlע��
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CustomerManagement.API v1"));
            }

            app.UseRouting();

            //����
            app.UseCors();
            //��ȨУ��
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
