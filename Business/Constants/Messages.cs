using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Invalid Product Name";

        public static string MaintanaceTime = "Now pur Working Hour";

        public static string ProductListed = "Products Listed";

        public static string ProductCountOfCategoryError = "Count of Product must less then 10";
        public static string ProductNameAlreadyExists="This Product Name already existing";
        public static string CategoryLimitExceded="It is out of Range";
        public static string AuthorizationDenied= "you do not have permission";
        public static string UserRegistered="User Registered";
        public static string UserNotFound="User Not Found";
        public static string PasswordError="Wrong password";
        public static string SuccessfulLogin="Successful Lodin";
        public static string UserAlreadyExists="User Already Exists";
        public static string AccessTokenCreated="Access Token Created";
    }
}
