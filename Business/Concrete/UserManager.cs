using Business.Abstract;
using Business.Contants;
using Core.Entities.Concrete;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }
     
        public IResult Delete(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetByMail(string email)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.Email == email),Messages.Listed);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user),Messages.Listed);
        }

        public IResult Update(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Updated);
        }

        User IUserService.GetByMail(string email)
        {
            throw new NotImplementedException();
        }

        List<OperationClaim> IUserService.GetClaims(User user)
        {
            throw new NotImplementedException();
        }
    }
}
