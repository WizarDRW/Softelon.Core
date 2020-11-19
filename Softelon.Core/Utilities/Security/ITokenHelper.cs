using System;
using System.Collections.Generic;
using Softelon.Core.Entities.Concrete;
using Softelon.Core.Utilities.Security.Jwt;

namespace Softelon.Core.Utilities.Security
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
