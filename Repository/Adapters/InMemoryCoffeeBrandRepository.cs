using Domain.Entities;
using Domain.Service;

namespace Infrastructure.Repository
{
    public class InMemoryCoffeeBrandRepository : ICoffeeBrandRepository
    {
        private readonly List<CoffeeBrandModel> _coffeeBrands = new();

        public InMemoryCoffeeBrandRepository()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            // Simulando dados em memória
            CoffeeBrandModel starbucks = new()
            {
                Id = 1,
                Name = "Starbucks",
                Origin = "Seattle, Washington, USA",
                RoastLevel = "Medium",
                Description = "Starbucks is one of the largest coffeehouse chains in the world, known for its wide range of coffee beverages and global presence."
            };

            CoffeeBrandModel lavazza = new()
            {
                Id = 2,
                Name = "Lavazza",
                Origin = "Turin, Italy",
                RoastLevel = "Dark",
                Description = "Lavazza is an Italian coffee brand, one of the most popular in the country, offering a variety of coffee blends and products."
            };

            CoffeeBrandModel peetsCoffee = new()
            {
                Id = 3,
                Name = "Peet's Coffee",
                Origin = "Berkeley, California, USA",
                RoastLevel = "FullCity",
                Description = "Peet's Coffee is a specialty coffee roaster and retailer, known for its commitment to high-quality, freshly roasted coffee."
            };

            // Adicionar as marcas de café à lista em memória
            _coffeeBrands.Add(starbucks);
            _coffeeBrands.Add(lavazza);
            _coffeeBrands.Add(peetsCoffee);
        }

        public IEnumerable<CoffeeBrandModel> GetAll()
        {
            return _coffeeBrands;
        }
    }
}
