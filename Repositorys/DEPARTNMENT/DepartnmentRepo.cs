using EFCore;
using Microsoft.EntityFrameworkCore;
using Models.DTO.Departnment;
using Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repositorys.DEPARTNMENT
{
    public class DepartnmentRepo : IDepartnmentRepo
    {
        private readonly DatabaseContext _dbContext;
        public DepartnmentRepo(DatabaseContext db)
        {
            _dbContext= db;
        }
        public async Task<bool> AddDepartnmetn(AddDepartnemtDTO adddepartment)
        {
            try
            {
                var dep = new Departnment();
                dep.DepartnmentName = adddepartment.DepartnmentName;
                dep.IsActive = true;
                dep.IsDelete = false;
                dep.CretedDate = DateTime.UtcNow;
                await _dbContext.Departments.AddAsync(dep);
                await  _dbContext.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                  throw ex;
            }
        }

        public async Task<bool> DeleteDepartnment(int id)

        {
            try
            {
                var task = _dbContext.Departments.Where(x => x.pkDepartnemtid == id).FirstOrDefault();
                if (task != null)
                {
                    task.IsDelete = true;
                    task.IsActive = false;
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<GetAllDepartnmentDTO>> GetAllDepartnment()
        {
            try
            {
                var res = await _dbContext.Departments.Where(x=>x.IsActive&& !x.IsDelete).Select(x=>new GetAllDepartnmentDTO()
                {
                    PkDepartnemtId = x.pkDepartnemtid,
                    DepartnmentName = x.DepartnmentName
                }).ToListAsync();

                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<GetAllDepartnmentDTO> GetDepartnmentbyid(int id)
        {
            try
            {
                var emp = await _dbContext.Departments.Where(x => x.pkDepartnemtid == id && x.IsActive && !x.IsDelete )
                    .Select(x => new GetAllDepartnmentDTO
                    {
                       PkDepartnemtId= x.pkDepartnemtid,
                       DepartnmentName= x.DepartnmentName

                    }).FirstOrDefaultAsync();
                return emp;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateDepartnmetn(UpdateDepartnmentDTO updtatdep)
        {
            try
            {
                var dep = _dbContext.Departments.Where(x=> x.pkDepartnemtid== updtatdep.Id).FirstOrDefault();
               if(dep != null)
                {
                    dep.DepartnmentName = updtatdep.DepartnmentName;
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
