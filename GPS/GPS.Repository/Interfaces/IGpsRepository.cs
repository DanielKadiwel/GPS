﻿using GPS.Domain.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Repository.Interfaces
{
    public interface IGpsRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> SaveChancesAsync();
        EmpresaVO GetEmpresasByCnpj(string cnpj);
    }
}