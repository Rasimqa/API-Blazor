using API_Coworking.Models;

namespace API_Coworking.Interfaces
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
