using DataAccess.Entidades;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;
using DataAccess;

IHost app = Host.CreateDefaultBuilder() // El Host es el contexto donde corre nuestra aplicación, y tiene opciones tipo Compilador y de Configurar Servicios
.ConfigureServices((context, services) => // El Configure Services puede acceder a los otros proyectos externos
{
    services.AddDataAccess(); // Hacemos que el Program sepa de la existencia del proyecto DataAccess y sus servicios configurados, en este caso el MyDbContext
    services.AddServices(); // Hacemos que el Program sepa de la existencia del proyecto Services y sus servicios configurados, en este caso SvUser por medio de IUser


}).Build();//El Build inicia el Host y compila los proyectos externos para que sus servicios configurados sean entendidos por la aplicación principal

var svUser = app.Services.GetRequiredService<ISvUser>();


List<User> usersList = svUser.ListUsers();




