internal class Login
{
    static int counter = 0;
    private static Login instance = null;
     private Login()
    {      counter++;
        Console.WriteLine("Instance {0} running!!!",counter);
        
    }
    public static Login getaccess
    {
        get
        {
            if (instance == null)
            {
                instance = new Login();
            }
            else
            {
                Console.WriteLine("press 1 for logout and login other app\n press 2 for logout app \n press 3 for continue application");
                int reply = int.Parse(Console.ReadLine());
                if (reply == 1)
                {
                    instance = null;
                    Console.WriteLine("Logout application");
                    Console.WriteLine("Enter username");
                    string name = Console.ReadLine();
                    instance = new Login();
                    instance.login(name);
                }
                else if (reply == 2)
                {
                    Console.WriteLine("Logout application .....");
                    instance=null;
                }
                else
                {
                    Console.WriteLine("Continue Session .....");
                }
            }
            return instance;
        }
        

    }
   
    public void login(string name)
    {
        Console.WriteLine("Login successfully");
    }
}
