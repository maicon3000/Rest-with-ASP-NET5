﻿using RestWithASPNET5.Data.VO;

namespace RestWithASPNET5.Controllers.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);

        TokenVO ValidateCredentials(TokenVO token);

        bool RevokeToken(string userName);
    }
}
