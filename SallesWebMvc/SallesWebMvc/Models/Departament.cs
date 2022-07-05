using System;
using System.Collections.Generic;
using System.Linq;

namespace SallesWebMvc.Models

{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament()
        {

        }
        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            // Passa uma expressão labda que filtra as vendas as penas nessas datas
            // para cada vendedores da lista chamando o total de vendas do vendedor no periodo inicial e final
            // e faz uma soma de todas as vendas do departamento

            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
