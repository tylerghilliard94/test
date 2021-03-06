using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        void AddDog(Dog dog);
        void DeleteDog(int dogId);
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        List<Dog> GetDogsByOwnerId(int ownerId);
        void UpdateDog(Dog dog);
    }
}