using Microsoft.AspNetCore.SignalR;

namespace Varico.Core.Services.ReservationNotification
{
    public class ReservationHub : Hub
    {
        private readonly IHubContext<ReservationHub> _hubContext;
        public ReservationHub(IHubContext<ReservationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task NotifyReservationEnding(int vehicleId)
        {
            var message = $"Rezerwacja pojazdu {vehicleId} kończy się za 2 dni!";
            await _hubContext.Clients.All.SendAsync("ReceiveReservationAlert", message);
        }        
    }
}
