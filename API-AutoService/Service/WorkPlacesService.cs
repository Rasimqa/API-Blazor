using API_BlazorForSome.DBContext;
using API_BlazorForSome.Interfaces;
using API_BlazorForSome.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API_BlazorForSome.Service
{
    public class WorkPlacesService : IWorkPlacesService
    {
        private readonly ArmyPetServiceDBContext _context;

        public WorkPlacesService(ArmyPetServiceDBContext context)
        {
            _context = context;
        }

        public IEnumerable<WorkPlace> GetAllWorkPlace()
        {
            return _context.WorkPlace.ToList();
        }

        public WorkPlace GetWorkPlaceById(int id)
        {
            return _context.WorkPlace.FirstOrDefault(r => r.id == id);
        }

        public WorkPlace AddWorkPlace(WorkPlace record)
        {
            try
            {
                _context.WorkPlace.Add(record);
                _context.SaveChanges();
                return record;
            }
            catch
            {
                return null;
            }
        }

        public WorkPlace UpdateWorkPlace(int id, WorkPlace updatedRecord)
        {
            var record = _context.WorkPlace.FirstOrDefault(r => r.id == id);
            if (record == null) return null;

            record.Description = updatedRecord.Description;
            record.PriceForDay = updatedRecord.PriceForDay;
            record.StartRent = updatedRecord.StartRent;
            record.EntRent = updatedRecord.EntRent;
            record.userid = updatedRecord.userid;
            record.spacesid = updatedRecord.spacesid;
            _context.SaveChanges();
            return record;
        }

        public void DeleteWorkPlace(int id)
        {
            var record = _context.WorkPlace.FirstOrDefault(r => r.id == id);
            if (record != null)
            {
                _context.WorkPlace.Remove(record);
                _context.SaveChanges();
            }
        }

    }
}
