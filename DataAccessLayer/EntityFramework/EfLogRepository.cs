﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfLogRepository : GenericRepository<TBL_LOG>, ILogDal
    {
    }
}
