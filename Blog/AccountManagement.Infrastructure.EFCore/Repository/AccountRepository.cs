﻿using System.Collections.Generic;
using System.Linq;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;

namespace AccountManagement.Infrastructure.EFCore.Repository
{
    public class AccountRepository : RepositoryBase<long, Account>, IAccountRepository
    {
        private readonly AccountContext _context;

        public AccountRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public EditAccount GetDetails(long id)
        {
            return _context.Accounts.Select(x => new EditAccount
            {
                Id = x.Id,
                Username = x.Username,
                Password = x.Password,
                Mobile = x.Mobile,
                Fullname = x.Fullname,
                RoleId = x.RoleId
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            var query = _context.Accounts.Select(x => new AccountViewModel
            {
                Id = x.Id,
                ProfilePhoto = x.ProfilePhoto,
                Fullname = x.Fullname,
                Mobile = x.Mobile,
                Role = "مدیر سیستم",
                RoleId = 2,
                Username = x.Username
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Fullname))
                query = query.Where(x => x.Fullname.Contains(searchModel.Fullname));

            if (!string.IsNullOrWhiteSpace(searchModel.Username))
                query = query.Where(x => x.Username.Contains(searchModel.Username));

            if (!string.IsNullOrWhiteSpace(searchModel.Mobile))
                query = query.Where(x => x.Mobile.Contains(searchModel.Mobile));

            if (searchModel.RoleId > 0)
                query = query.Where(x => x.RoleId == searchModel.RoleId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}