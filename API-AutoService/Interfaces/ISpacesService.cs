using API_Coworking.Models;

namespace API_Coworking.Interfaces
{
    public interface ISpacesService
    {
        IEnumerable<Spaces> GetAllSpaces();

        Spaces GetSpaceById(int id);

        Spaces AddSpaces(Spaces Spaces);

        Spaces UpdateSpaces(int id, Spaces updateSpaces);

        void DeleteSpace(int id);
    }
}
