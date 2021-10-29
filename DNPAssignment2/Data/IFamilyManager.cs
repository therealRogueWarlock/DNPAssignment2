using System.Collections.Generic;
using Models;

namespace Blazor_Authentication.Data
{
    public interface IFamilyManager
    {
        void AddFamily(Family family);
        void RemoveFamily(Family family);
        IList<Family> GetFamilies();
        void Update();
        Family GetFamily(int familyId);

        
        
        void RemoveAdult(int adultId);
        IList<Adult> GetAdults();
        Adult GetAdult(int id);
        
    }
}