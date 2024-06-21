using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IMateriaisRepositorio
    {
        Task<List<MateriasModel>> GetAll();

        Task<MateriasModel> GetById(int id);

        Task<MateriasModel> InsertMateria(MateriasModel materia);

        Task<MateriasModel> UpdateMateria(MateriasModel materia, int id);

        Task<bool> DeleteMateria(int id);
    }
}
