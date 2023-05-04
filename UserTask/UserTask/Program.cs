using UserTask.Models;

namespace UserTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new(
                   fullName:"Mahammad Mustafayev",
                   email:"mahammadmustafayev@gmail.com"
                );
            user.Password = "password";
            user.ShowInfo();

            User user1 = new(
                fullName:"Valeh Amirbekov",
                email: "valehamirbekov@gmail.com"
                );
            user1.Password = "pasS1word";
            user1.ShowInfo();
        }
    }
}