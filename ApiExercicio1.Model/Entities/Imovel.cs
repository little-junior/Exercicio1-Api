namespace ApiExercicio1.Model.Entities
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

    }
}
