using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PCConfiguration.Core;
using PCConfiguration.Core.Models;
using PCConfiguration.Core.Services;
using PCConfiguration.Web.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PCConfiguration.Web.Controllers
{
    public class PCConfigurationController : Controller
    {
        private readonly IPCConfigurationService _service;
        private readonly ICartService _cartService;
        private readonly ISessionStorageHandler _storageHandler;
        private readonly ILogger<PCConfigurationController> _logger;

        public PCConfigurationController(IPCConfigurationService service, ICartService cartService, ISessionStorageHandler storageHandler, ILogger<PCConfigurationController> logger)
        {
            _service = service;
            _cartService = cartService;
            _storageHandler = storageHandler;
            _logger = logger;
        }

        public async Task<IActionResult> PCConfigurationAsync(PartViewModel selectedPart = null)
        {
            _logger.LogInformation("Getting Cart from session or creating new one...");
            Cart cart = _storageHandler.GetCartFromSessionStorage(HttpContext.Session);

            _logger.LogInformation("Getting All Parts from database...");
            var items = await _service.GetAllParts();

            if (selectedPart.Name != null)
            {
                // If part is selected - add it to Cart
                // If part is unselected - remove it from Cart
                _cartService.TogglePart(cart, selectedPart);

                // Set the update Cart to session
                _storageHandler.SetCartToSessionStorage(HttpContext.Session, cart);
            }

            _logger.LogInformation("Setting up the ViewModel for PC Configuration page...");
            var model = _cartService.SetupModel(items, cart);
            return View(model);
        }

        public async Task<IActionResult> CPU()
        {
            _logger.LogInformation("Getting All CPU items from database...");
            var cpus = await _service.GetAllCPUItems();
            return View(cpus);
        }
        public async Task<IActionResult> Motherboard()
        {
            _logger.LogInformation("Getting All Motherboard items from database...");
            var motherboards = await _service.GetAllMotherboardItems();
            return View(motherboards);
        }
        public async Task<IActionResult> RAM()
        {
            _logger.LogInformation("Getting All RAM items from database...");
            var ram = await _service.GetAllRAMItems();
            return View(ram);
        }
        public async Task<IActionResult> Storage()
        {
            _logger.LogInformation("Getting All Storage items from database...");
            var storages = await _service.GetAllStorageItems();
            return View(storages);
        }
        public async Task<IActionResult> VideoCard()
        {
            _logger.LogInformation("Getting All VideoCard items from database...");
            var videoCards = await _service.GetAllVideoCardItems();
            return View(videoCards);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
