using SallesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SallesWebMvc.Services
{
    public class SellerService
    {
        private readonly SallesWebMvcContext _context; 

        public SellerService(SallesWebMvcContext context)        {
            _context = context;
        }

        //Retorna uma lista com todos os vendedores do banco de dados

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
