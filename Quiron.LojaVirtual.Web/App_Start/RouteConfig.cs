using System.Web.Mvc;
using System.Web.Routing;

namespace Quiron.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Setando para permitir adicionar rotas nos controllers diretamente sem ser por aqui
            routes.MapMvcAttributeRoutes(); 


            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 1 - Inicio     ->     site.com.br/

            routes.MapRoute(null,
                "",
                new
                {
                    controller = "Vitrine",
                    action = "ListaProdutos",
                    categoria = (string)null,
                    pagina = 1
                });


            // 2     ->     site.com.br/pagina1

            routes.MapRoute(null,
                "Pagina{pagina}",
                new
                {
                    controller = "Vitrine",
                    action = "ListaProdutos",
                    categoria = (string)null
                },
                new { pagina = @"\d+" });


            //3     ->     site.com.br/categoria

            routes.MapRoute(null, "{categoria}", new
            {
                controller = "Vitrine",
                action = "ListaProdutos",
                pagina = 1
            });


            //4     ->     site.com.br/categoria/pagina2

            routes.MapRoute(null,
                "{categoria}/Pagina{pagina}",
                new
                {
                    controller = "Vitrine",
                    action = "ListaProdutos"
                },
                new { pagina = @"\d+" });


            //routes.MapRoute("ObterImagem",
            //    "Vitrine/ObterImagem/{produtoId}",
            //    new
            //    {
            //        controller = "Vitrine",
            //        action = "ObterImagem",
            //        produtoId = UrlParameter.Optional
            //    });

            routes.MapRoute(null, "{controller}/{action}");

        }
    }
}
