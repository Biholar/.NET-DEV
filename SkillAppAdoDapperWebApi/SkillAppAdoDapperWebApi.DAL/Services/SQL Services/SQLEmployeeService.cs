﻿using System.Collections.Generic;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;

namespace SkillManagement.DataAccess.Services
{
    public class SQLEmployeeService : ISQLEmployeeService
    {
        ISQLunitOfWork _SqlsqlunitOfWork;
        public SQLEmployeeService(ISQLunitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public long AddEmployee(Product employee)
        {
            return _SqlsqlunitOfWork.SQLEmployeeRepository.Add(employee);
            //_sqlunitOfWork.Complete();
        }

        public void DeleteEmployee(Product employee)
        {
            _SqlsqlunitOfWork.SQLEmployeeRepository.Delete(employee);
        }

        public IEnumerable<Product> GetAllEmployees()
        {
            return _SqlsqlunitOfWork.SQLEmployeeRepository.GetAll();
        }

        public Product GetEmployeeById(long Id)
        {
            return _SqlsqlunitOfWork.SQLEmployeeRepository.Get(Id);
        }

        public void UpdateEmployee(Product employee)
        {
            _SqlsqlunitOfWork.SQLEmployeeRepository.Update(employee);
        }
    }
}
