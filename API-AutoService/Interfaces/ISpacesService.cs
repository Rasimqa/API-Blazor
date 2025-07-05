using API_BlazorForSome.Models;

namespace API_BlazorForSome.Interfaces
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
