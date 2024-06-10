using System.Web;
using System.Web.Mvc;

namespace pSC06
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filter.VerificaSession());  // ejecuta este filtro para verifica el Login
                                                        // y ver si podemos entrar al menu
            
        }
    }
}
