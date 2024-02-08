using System.Text.Json.Serialization;

namespace ImovelAPI.Domain
{
    public class Imovel
    {
        public Imovel(double area, string tipo)
        {
            _id++;
            Id = _id;
            Area = area;
            Tipo = tipo;
        }


        private static int _id = 0;
        public int Id { get; set; }
        public double Area { get; set; }
        public string Tipo { get; set; }

        public void Update(Imovel imovel)
        {
            Id = imovel.Id;
            Area = imovel.Area;
            Tipo = imovel.Tipo;
        }
    }
}
