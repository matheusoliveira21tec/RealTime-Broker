using RealTimeBroker.Web.HostedServices;
using RealTimeBroker.Web.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR();
builder.Services.AddHostedService<UpdateStockPriceHostedService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.MapHub<BrokerHub>("/brokerhub");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
