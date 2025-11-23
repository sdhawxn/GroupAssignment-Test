using Stripe;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

StripeConfiguration.ApiKey = "YOUR_SECRET_API_KEY";

var app = builder.Build();

// ADD THIS LINE
app.UseDefaultFiles();  

app.UseStaticFiles();
app.MapControllers();

app.Run();


