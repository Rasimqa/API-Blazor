using API_Coworking.DBContext;
using API_Coworking.Interfaces;
using API_Coworking.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Coworking.Service
{
    public class SpaceService : ISpacesService
    {
        private readonly CoworkingServiceDBContext _context;

        public SpaceService(CoworkingServiceDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Spaces> GetAllSpaces()
        {
            return _context.Spaces.ToList();
        }
        public Spaces GetSpaceById(int id)
        {
            return _context.Spaces.FirstOrDefault(c => c.id == id);
        }

        public Spaces AddSpaces(Spaces Spaces)
        {
            _context.Spaces.Add(Spaces);
            _context.SaveChanges();
            return Spaces;
        }

        public Spaces UpdateSpaces(int id, Spaces updateSpaces)
        {
            var Spaces = _context.Spaces.FirstOrDefault(c => c.id == id);
            if (Spaces == null) return null;

            Spaces.NameSpace = updateSpaces.NameSpace;
            Spaces.Description = updateSpaces.Description;
            Spaces.Address = updateSpaces.Address;
            Spaces.Square = updateSpaces.Square;
            _context.SaveChanges();
            return Spaces;
        }

        public void DeleteSpace(int id)
        {
            var movie = _context.Spaces.FirstOrDefault(c => c.id == id);
            if (movie != null)
            {
                _context.Spaces.Remove(movie);
                _context.SaveChanges();
            }
        }
    }
}
