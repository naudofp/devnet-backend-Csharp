using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devnet_Csharp_backend.api.Services.User
{
public interface UserService
{
    Task<UserHolderDTO> login(UserLoginDTO dto);
}    
}
