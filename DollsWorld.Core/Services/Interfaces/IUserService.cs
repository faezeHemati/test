using System;
using System.Collections.Generic;
using System.Text;
using DollsWorld.Core.DTOs;
using DollsWorld.DataLayer.Entities.User;
using DollsWorld.DataLayer.Entities.Wallet;

namespace DollsWorld.Core.Services.Interfaces
{
   public interface IUserService
   {
       bool IsExistUserName(string userName);
       bool IsExistEmail(string email);
       int AddUser(User user);
       User LoginUser(LoginViewModel login);
       User GetUserByEmail(string email);
       User GetUserById(int userId);
       User GetUserByActiveCode(string activeCode);
       User GetUserByUserName(string username);
       void UpdateUser(User user);
       bool ActiveAccount(string activeCode);
       int GetUserIdByUserName(string userName);
       void DeleteUser(int userId);

       #region User Panel

       InformationUserViewModel GetUserInformation(string username);
       InformationUserViewModel GetUserInformation(int userId);  // گرفتن اطلاعات کاربر بر اساس آیدی کاربر : مورد استفاده در حذف کردن کاربر 
       SideBarUserPanelViewModel GetSideBarUserPanelData(string username);
       EditProfileViewModel GetDataForEditProfileUser(string username);
       void EditProfile(string username,EditProfileViewModel profile);
       bool CompareOldPassword(string oldPassword, string username);

       void ChangeUserPassword(string userName, string newPassword);

        #endregion

       #region Wallet

       int BalanceUserWallet(string userName);
       List<WalletViewModel> GetWalletUser(string userName);
       int ChargeWallet(string userName, int amount,string description,bool isPay=false);
       int AddWallet(Wallet wallet);
       Wallet GetWalletByWalletId(int walletId);
       void UpdateWallet(Wallet wallet);

        #endregion

        #region Admin Panel

       UserForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
       UserForAdminViewModel GetDeleteUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");

       // به دلیل پسورد هایی که باید در ادمین هش شوند ، باید یک کتد دیگر برای افزودن کاربر مربوط به قسمت ادمین ساخته شود
        int AddUserFromAdmin(CreateUserViewModel user);  
       EditUserViewModel GetUserForShowInEditMode(int userId);  // با گرفتن آیدی کاربر ، اطلاعات کاربر را می دهد جهت ویرایش
       void EditUserFromAdmin(EditUserViewModel editUser);

       #endregion
   }
}
