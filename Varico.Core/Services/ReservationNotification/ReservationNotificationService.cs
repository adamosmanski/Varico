using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Varico.EF.Models;

namespace Varico.Core.Services.ReservationNotification
{
    public class ReservationNotificationService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IHubContext<ReservationHub> _hubContext;

        public ReservationNotificationService(IServiceScopeFactory scopeFactory, IHubContext<ReservationHub> hubContext)
        {
            _scopeFactory = scopeFactory;
            _hubContext = hubContext;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<VaricoDbContext>();

                    var today = DateOnly.FromDateTime(DateTime.UtcNow);
                    var twoDaysLater = today.AddDays(2);

                    var expiringReservations = await dbContext.Vehicles
                        .Where(v => v.DateEnd.HasValue)
                        .ToListAsync(stoppingToken);


                    foreach (var reservation in expiringReservations)
                    {
                        await _hubContext.Clients.All.SendAsync("ReceiveReservationAlert",
                            $"Rezerwacja pojazdu {reservation.Brand} kończy się za 2 dni!", stoppingToken);
                    }
                }

                await Task.Delay(TimeSpan.FromMinutes(15), stoppingToken);
            }
        }
    }
}
