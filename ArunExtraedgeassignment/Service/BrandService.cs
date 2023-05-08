using ArunExtraedgeassignment.Model;
using ArunExtraedgeassignment.Repository;

namespace ArunExtraedgeassignment.Service
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository repo;
        public BrandService(IBrandRepository repo)
        {
            this.repo = repo;
        }
        public int AddBrand(Brand brand)
        {
            return repo.AddBrand(brand);
        }

        public int DeleteBrand(int id)
        {
            return repo.DeleteBrand(id);
        }

        public IEnumerable<Brand> GetAllBrand()
        {
            return repo.GetAllBrand();
        }

        public Brand GetBrandById(int id)
        {
            return repo.GetBrandById(id);
        }

        public int UpdateBrand(Brand brand)
        {
            return repo.UpdateBrand(brand);
        }
    }
}
