using System;

namespace TenthAssignment
{


    public class User
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User(string fullName)
        {
            var name = fullName.Split(" ");
            this.FirstName = name[0];
            this.LastName = name[1];
        }

    }

    public class LoginEvent
    {
        public event EventHandler BannedUserEvent;

        public List<User> BannedUsersList { get; set; }

        public List<User> UsersList { get; set; }





        public void PlayAlarm(object sender, EventArgs e)
        {
            for (var i = 0; i < 3; i++)
            {
                Console.Beep(1100, 350);
            }
        }

        public void SendEmailToAdmin(object sender, EventArgs e)
        {
            System.Console.WriteLine("Warning email sent to admin.");
        }



        public void GetName()
        {


            string nameInput;
            do
            {
                Console.WriteLine("Enter your name:");

                nameInput = Console.ReadLine();

            } while (nameInput.Split(" ").Length != 2);



            User nameInputObject = new User(nameInput);

            if (UsersList.Any(User => User.FirstName == nameInputObject.FirstName && User.LastName == nameInputObject.LastName))
            {
                var user = UsersList.First(User => User.FirstName == nameInputObject.FirstName && User.LastName == nameInputObject.LastName);
                Console.WriteLine($"Welcome, {user.FirstName}!");
            }
            else if (BannedUsersList.Any(bannedUser => bannedUser.FirstName == nameInputObject.FirstName && bannedUser.LastName == nameInputObject.LastName))
            {
                var bannedUser = BannedUsersList.First(bannedUser => bannedUser.FirstName == nameInputObject.FirstName && bannedUser.LastName == nameInputObject.LastName);
                Console.WriteLine($"{bannedUser.FirstName} {bannedUser.LastName} IS A BANNED USER!!!");
                BannedUserEvent?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("User not found!");
            }



        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            LoginEvent eventClassObject = new LoginEvent();

            eventClassObject.UsersList = new List<User> { new User("Bob Dylan"), new User("Elvis Presley"), new User("Eric Clapton"), new User("George Harrison") };

            eventClassObject.BannedUsersList = new List<User> { new User("Jack Black"), new User("Steven Spielberg"), new User("Matthew McConaughey") };

            eventClassObject.BannedUserEvent += eventClassObject.PlayAlarm;
            eventClassObject.BannedUserEvent += eventClassObject.SendEmailToAdmin;

            eventClassObject.GetName();

        }
    }
}