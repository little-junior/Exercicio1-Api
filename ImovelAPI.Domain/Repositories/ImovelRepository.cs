using ImovelAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImovelAPI.Domain.Repositories
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

        public bool Delete(int id)
        {
            return _imoveis.Remove(GetById(id));
        }

        //public bool Update(int id, ImovelDTO item)
        //{
        //    foreach(var imovel in _imoveis)
        //    {
        //        if (imovel.Id == id)
        //            imovel.Update(item);
        //        return true;
        //    }

        //    return false;
        //}
    }
}
