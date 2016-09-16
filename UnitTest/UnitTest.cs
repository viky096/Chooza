using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Security;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        #region[Membership]
        [TestMethod]
        public void ValidateUser()
        {
            try
            {
                
                if (Membership.ValidateUser("safi", "safi@07"))
                {
                    Console.Write("valid user");
                }
                else
                {
                    Console.Write("Invalid User");
                }
              
                
            }
            catch (Exception ex)
            {
            }
        }
        [TestMethod]
        public void CreateUser()
        {
            try
            {
                MembershipCreateStatus status;
                Guid ApplicationId = Guid.NewGuid();

                Membership.CreateUser("safi", "safi@07", "safi-07@live.com", null, null, true, null, out status);
                if (status == MembershipCreateStatus.Success)
                {
                    Console.Write("User Created");
                }
                else
                {
                    Console.Write("There was some error in creating User");
                }


            }
            catch (Exception ex)
            {
            }
        }

        [TestMethod]
        public void UpdateUser()
        {
            try
            {
            
                MembershipUser u;
                u=Membership.GetUser("safi");
                u.Email = "viky096@yahoo.com";
                Membership.UpdateUser(u);
                Console.Write(u.Email);
                
                




            }
            catch (Exception ex)
            {

            }

        }
        [TestMethod]
        public void GetUserByMail()
        {
            try
            {

                string username = Membership.GetUserNameByEmail("viky096@yahoo.com");
                   if (username != null)
                {
                    Console.Write("User found");
                }
                else
                {
                    Console.Write("User Not Found");
                }





            }
            catch (Exception ex)
            {

            }

        }
        #endregion
    }
}
