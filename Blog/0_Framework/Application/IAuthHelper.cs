﻿using System.Collections.Generic;

namespace _0_Framework.Application
{
    public interface IAuthHelper
    {
        void Signin(AuthViewModel account);
        bool IsAuthenticated();
        void SignOut();
        string CurrentAccountRole();
        AuthViewModel CurrentAccountInfo();
        List<int> GetPermissions();
        long CurrentAccountId();
    }
}