using _0_Framework.Domain;
using AccountManagement.Domain.RoleAgg;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account : EntityBase
    {
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string RePassword { get; set; }
        public string Mobile { get; private set; }
        public long RoleId { get; private set; }
        public Role Role { get; private set; }
        public string ProfilePhoto { get; private set; }

        public Account(string fullname, string mobile, string password, string rePassword, string profilePhoto,
            long roleId,
            string username)
        {
            Fullname = fullname;
            Mobile = mobile;
            Password = password;
            RePassword = rePassword;
            ProfilePhoto = profilePhoto;
            RoleId = roleId;

            if (RoleId == 0)
                RoleId = 2;

            Username = username;
        }

        public void Edit(string fullname, string mobile, string profilePhoto, long roleId,
            string username)
        {
            Fullname = fullname;
            Mobile = mobile;

            if (!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;

            RoleId = roleId;
            Username = username;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}