namespace speedCam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username ");
            string userName = Console.ReadLine();
            Console.WriteLine(userName + " enter the speed limit!");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userName + " now enter the speed of the car!");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            int failurePoint = carSpeed - speedLimit;
            int differencePoint = 0;

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok!");
            }
            else
            {
                for(int count = 5; count <= failurePoint; count += 1)
                {
                    if(count % 5 == 0)
                    {
                        differencePoint++;
                    }
                }
                Console.WriteLine("Now you have cross your speed limit! You get " + differencePoint + " points.");
            }
            if (differencePoint >= 12)
            {
                Console.WriteLine("To high you have License Suspended! ");
            }
        }
                    
    }
}