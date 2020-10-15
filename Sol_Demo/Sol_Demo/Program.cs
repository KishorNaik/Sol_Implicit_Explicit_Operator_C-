using System;

namespace Sol_Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UserEntity userEntity = new UserEntity()
            {
                FirstName = "Kishor",
                LastName = "Naik "
            };

            // Implicit Conversion
            UserModel userModel = userEntity;

            // Implicit Conversion
            userEntity = userModel;

            // Explicit Conversion
            //UserModel userModel = (UserModel)userEntity;
        }
    }

    public class UserEntity
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }
    }

    public class UserModel
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        // Convert User Entity Model into User Model by using implicit operator
        public static implicit operator UserModel(UserEntity userEntity)
        {
            return new UserModel()
            {
                FirstName = userEntity.FirstName,
                LastName = userEntity.LastName
            };
        }

        // Or You can convert vise versa.
        public static implicit operator UserEntity(UserModel userModel)
        {
            return new UserEntity()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName
            };
        }

        // either user explicit or implicit
        // Convert User Entity Model into User Model by using explicit operator
        //public static explicit operator UserModel(UserEntity userEntity)
        //{
        //    return new UserModel()
        //    {
        //        FirstName = userEntity.FirstName,
        //        LastName = userEntity.LastName
        //    };
        //}
    }
}