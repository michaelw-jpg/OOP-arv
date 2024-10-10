namespace OOP_arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Chihuahua dog1 = new Chihuahua(3,false,9,true,"mupp", "chihuahua","grå");
            Labrador dog2 = new Labrador();
            Bear bear1 = new Bear();
            Bird bird = new Bird();
            bear1.eat();
            bear1.Fishing();
            bear1.MakeSound();

            Console.WriteLine();

            dog1.Sleep();           
            dog1.MakeSound();
            dog1.eat();
            dog1.Fetch();


            Console.WriteLine();
            dog2.Fetch();

            Console.WriteLine();
            bird.MakeSound();
            bird.Fly();

        }
    }
}
