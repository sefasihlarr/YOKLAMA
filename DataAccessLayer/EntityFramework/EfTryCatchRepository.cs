﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfTryCatchRepository : GenericRepository<TBL_TRY_CATCH>, ITryCatchDal
    {
    }
}
