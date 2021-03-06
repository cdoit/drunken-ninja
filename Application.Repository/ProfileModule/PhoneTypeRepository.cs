﻿using Application.Core.ProfileModule.PhoneAggregate;
using Application.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.ProfileModule
{
    public class PhoneTypeRepository:Repository<PhoneType>, IPhoneTypeRepository
    {
        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public PhoneTypeRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
