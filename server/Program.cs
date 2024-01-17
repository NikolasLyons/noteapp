using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MrNote.Repositories;
using MrNote.Services;


var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddScoped<NoteRepository>();
    builder.Services.AddScoped<INotesService, NoteService>();  

    builder.Services.AddSwaggerGen(c=>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "MrNote", Version = "v1" });
    }
    );

    builder.Services.AddCors(options=>
    {
        options.AddPolicy("CorsDevPolicy", builder=>
        {
            builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .WithOrigins(new string[]{
                 "http://localhost:8080", "http://localhost:8081"
            });
        });
    }); 


}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment()){
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MrNote v1"));
        app.UseCors("CorsDevPolicy");
    }
     app.UseRouting();
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseEndpoints(endpoints=>
    {
        endpoints.MapControllers();
    });
    app.Run();
}
