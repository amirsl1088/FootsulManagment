using AllBlocks.Persistence.EF;
using Footsul.Persistence.EF;
using Footsul.Persistence.EF.Players;
using Footsul.Persistence.EF.Teams;
using Footsul.Services.Players;
using Footsul.Services.Players.Contracts;
using Footsul.Services.Teams;
using Footsul.Services.Teams.Contracts;
using Taav.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EFDataContext>();
builder.Services.AddScoped<TeamService, TeamAppService>();
builder.Services.AddScoped<TeamRepository, EFTeamRepository>();
builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<PlayerService, PlayerAppService>();
builder.Services.AddScoped<PlayerRepository, EFPlayerRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
