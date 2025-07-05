using API_BlazorForSome.Models;

namespace API_BlazorForSome.Interfaces
{
    public interface IWorkPlacesService
    {
        IEnumerable<WorkPlace> GetAllWorkPlace();

        WorkPlace GetWorkPlaceById(int id);

        WorkPlace AddWorkPlace(WorkPlace record);

        WorkPlace UpdateWorkPlace(int id, WorkPlace updatupdatedRecordeCars);

        void DeleteWorkPlace(int id);
    }
}
