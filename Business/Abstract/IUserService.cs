using Core.Entities.Concrete;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);     
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<User>> GetByMail(string mail);
    }
}
