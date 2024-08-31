using Dima.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var cnnStr = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(cnnStr);
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.CustomSchemaIds(n => n.FullName);
});
builder.Services.AddTransient<Handler>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost(
    "/v1/transactions",
    (TransactionRequest request, Handler handler)
        => handler.Handle(request))
    .WithName("Transcations: Create")
    .WithSummary("Create a new transaction")
    .Produces<ResponseOk>();

app.Run();


public class ResponseOk
{
    public long Id { get; set; }
    public string? Title { get; set; }
}

public class TransactionRequest
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public int Type { get; set; }
    public decimal Amount { get; set; }
    public long CategoryId { get; set; }
    public long UserId { get; set; }
}

public class Handler
{
    public ResponseOk Handle(TransactionRequest request)
    {
        return new ResponseOk
        {
            Id = 4,
            Title = request.Title
        };
    }
}