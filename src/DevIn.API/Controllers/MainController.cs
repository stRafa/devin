using DevIn.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevIn.API.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotificator _notificator;
        public readonly IUser AppUser;
        protected Guid UserId { get; set; }
        public bool AuthenticatedUser { get; set; }

        protected MainController(INotificator notificator, IUser appUser)
        {
            _notificator = notificator;
            AppUser = appUser;

            if (appUser.IsAuthenticated())
            {
                UserId = appUser.GetUserId();
                AuthenticatedUser = true;
            }
        }
    }
}
