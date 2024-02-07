using ApiExercicio1.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiExercicio1.Model.Repositories
{
    public class ImovelRepository : IRepository<Imovel>
    {
        private static List<Imovel> _imoveis = new List<Imovel>()
        {
            new Imovel(200, "Casa"),
            new Imovel(44, "Apartamento"),
            new Imovel(350, "Terreno")
        };


        public IEnumerable<Imovel> GetAll()
        {
            return _imoveis;
        }

        public Imovel GetById(int id)
        {
            return _imoveis.FirstOrDefault(i => i.Id == id);
        }

        public void Add(Imovel item)
        {
            _imoveis.Add(item);
        }
    }
}
