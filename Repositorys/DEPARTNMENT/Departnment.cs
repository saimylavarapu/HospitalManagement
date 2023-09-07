﻿using EFCore;
using Microsoft.EntityFrameworkCore;
using Models.DTO.Departnment;
using Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repositorys.DEPARTNMENT
{
    public class Departnments : IDepartnment
    {
        private readonly DatabaseContext _dbContext;
        public Departnments(DatabaseContext db)
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
               dep.ModifiedDate = DateTime.UtcNow;
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
                var task = _dbContext.Departments.Where(x => x.PkDepartnemtId == id).FirstOrDefault();
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

        public Task<List<GetAllDepartnmentDTO>> GetAllDepartnment()
        {
            try
            {
          
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
                var dep = _dbContext.Departments.Where(x=> x.PkDepartnemtId== updtatdep.Id).FirstOrDefault();
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
