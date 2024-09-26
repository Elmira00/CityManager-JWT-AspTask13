using CityManager_JWT_task13.Entites;

namespace CityManager_JWT_task13.Data.Abstract
{
    public interface IAppRepository
    {
        Task AddAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
        Task<bool> SaveAllAsync();

        Task<List<City>> GetCitiesAsync(int userId);
        Task<CityImage> GetPhotosByCityIdAsync(int cityId);
        Task<City> GetCityByIdAsync(int cityId);
        Task<CityImage> GetPhotoByIdAsync(int photoId);
    }
}
