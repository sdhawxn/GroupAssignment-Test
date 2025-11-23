using Stripe;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

StripeConfiguration.ApiKey = "sk_test_51SWiwG3GFN7B7nUjkTlkpQomPamSQS7yYdatzIdWD3phjizTtDpPKUTZHJLrHM17AunJwRVb0TgnAo2NNM6thBE8001ussyZWr";

var app = builder.Build();

// ADD THIS LINE
app.UseDefaultFiles();  

app.UseStaticFiles();
app.MapControllers();

app.Run();

