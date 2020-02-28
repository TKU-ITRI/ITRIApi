﻿using System;
using ITRI.Models;
using ITRI.Models.Entities;
using ITRI.Models.Helper;
using ITRI.Models.Interface;
using ITRI.Services.Interface;
using ITRI.ViewModels;
using System.Linq;

namespace ITRI.Services
{
    public class MemberS : BaseService, IMemberS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Member> _repository = new Repository<Member>();

        public MemberS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<Member> GetAll(int start, int length)
        {
            var count = _repository.GetAll().Count();
            var data = _repository.GetAll().Skip(start).Take(length);
            var result = new DatatablesVM<Member>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public Member GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(Member data)
        {

           // var Member = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(Member data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var Member = _repository.Get(c => c.Id == id);
            _repository.Delete(Member);
        }
    }
}