using System;
namespace task_DEV_9
{
    /// <summary>
    /// For one of the social networks (by choice of facebook or “in contact”) create a fake user,
    /// and write a program that, using WebDriver, logs in and displays a list of unread messages
    /// from all users to the console. Use Chrome as a browser.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string login="MyLogin"; //your account VK login
            string password="***********"; //your account VK password
            VkFunctions vk=new VkFunctions(); 
            string mess=vk.GetUnreadMessage(login, password);
            Console.WriteLine(mess);
        }
    }
}
