using appweb1.Data;
using appweb1.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _ctx;
        public IndexModel(AppDbContext ctx)
        {
            _ctx=ctx;
        }

        public List<Cliente>clientes{get; set; }
        public void OnGet()
        {
            clientes= _ctx.clientes.ToList();
        }
    }
}
