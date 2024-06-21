using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class MateriasRepositorio : IMateriaisRepositorio
    {
        private readonly Contexto _dbContext;
        public MateriasRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MateriasModel>> GetAll()
        {
            return await _dbContext.Materias.ToListAsync();
        }

        public async Task<MateriasModel> GetById(int id)
        {
            return await _dbContext.Materias.FirstOrDefaultAsync(x => x.MateriasId == id);
        }

        public async Task<MateriasModel> InsertMateria(MateriasModel materia)
        {
            await _dbContext.Materias.AddAsync(materia);
            await _dbContext.SaveChangesAsync();
            return materia;
        }

        public async Task<MateriasModel> UpdateMateria(MateriasModel materia, int id)
        {
            MateriasModel materias = await GetById(id);
            if (materias == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                materias.MateriasName = materia.MateriasName;
                _dbContext.Materias.Update(materias);
                await _dbContext.SaveChangesAsync();
            }
            return materias;
        }
        public async Task<bool> DeleteMateria(int id)
        {
            MateriasModel materias = await GetById(id);
            if (materias == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Materias.Remove(materias);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}

