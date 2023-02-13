using Ahorcado.Clase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ahorcado.MVC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public char LetraIngresada { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string url = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetDisplayUrl(Request);
            AhorcadoJuego.Inicializar("AGILES"); // Fuerza palabra "AGILES" para testear victoria
        }

        public void OnPostLetra() 
        {
            AhorcadoClase partida = AhorcadoJuego.GetPartidaActual;
            if (partida.getVida() > 0)
            {
                partida.adivinarLetra(LetraIngresada);
            }
            else
            {
                Response.Redirect("/");
            }
        }


    }
}