using System.Collections.Generic;

namespace CoffeeBrand.Infrastructure
{
    public class InMemoryCoffeeBrandRepository
    
    {
        private readonly List<CoffeeBrand> _coffeeBrands = new List<CoffeeBrand>();

        public InMemoryCoffeeBrandRepository()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            // Simulando dados em memória
            CoffeeBrand starbucks = new CoffeeBrand
            {
                Id = 1,
                Name = "Starbucks",
                Origin = "Seattle, Washington, USA",
                RoastLevel = "Medium",
                Description = "Starbucks is one of the largest coffeehouse chains in the world, known for its wide range of coffee beverages and global presence."
            };

            CoffeeBrand lavazza = new CoffeeBrand
            {
                Id = 2,
                Name = "Lavazza",
                Origin = "Turin, Italy",
                RoastLevel = "Dark",
                Description = "Lavazza is an Italian coffee brand, one of the most popular in the country, offering a variety of coffee blends and products."
            };

            CoffeeBrand peetsCoffee = new CoffeeBrand
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

        public IEnumerable<CoffeeBrand> GetAllCoffeeBrands()
        {
            return _coffeeBrands;
        }
    }
}
