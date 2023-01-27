using System.Security.Cryptography.X509Certificates;

namespace test
{
    public class Program
    {
        static void Main()
        {
            //Car car1 = new Car();
            //car1.colour = "red";
            //car1.name = "BMW";
            //car1.horsePower = 123;
            //car1.highspeed = 324;
            //Console.WriteLine(car1.GetDetails());

            //Dog dog = new Dog("White","kity","trerriy",10);
            //Cat cat = new Cat("black", "kiss", "jsijs", 5);






            //Console.WriteLine(dog.GetVoice());
            //Console.WriteLine(cat.GetVoice());


            Inital: var document=Console.ReadLine();

            if (document == "basic")
            {
                var basic = new DocumentProgram();
                basic.OpenDocument();
                basic.EditDocument();
                basic.SaveDocument();
                  
            }
            else if(document=="pro")
            {
                var pro=new ProDocumentProgram();
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument();
            }
            else if(document=="expert")
            {
                var expert=new ExpertDocumentProgram();
                expert.OpenDocument();
                expert.EditDocument();  
                expert.SaveDocument();
            }
            else
            {
                Console.WriteLine("try again");
            }
            goto Inital;












            //Console.WriteLine();
            //Console.WriteLine();












            //Animal Animal1 = new Animal("dog", "terrier", 4);

            //Console.WriteLine(Animal1.GetDetails());

            //Building Building1 = new Building("happy homes", 200, 600);
            //Console.WriteLine(Building1.Volume());




            //Console.WriteLine(Building1.GetDetails());
        }

        


        
            
        

    }








}