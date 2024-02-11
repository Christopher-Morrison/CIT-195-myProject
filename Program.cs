using System;

namespace myProject
{
    class myBirds
    {
        private string _typeOfBird;
        private int _numberOfBirds;
        private static int _totalBirds = 0;

        myBirds()
        {
            _typeOfBird = "";
            _numberOfBirds = 0;
        }
        myBirds(string bird, int num)
        {
            _typeOfBird = bird;
            _numberOfBirds = num;
            _totalBirds += num;
        }
        public string getBirdType()
        { return _typeOfBird; }
        public int getNumberOfBirds() 
        { return _numberOfBirds; }
        public int getTotalBirds()
        { return _totalBirds; }
        public void setBirdType(string bird)
        { _typeOfBird = bird; }
        public void setNumberOfBirds(int num)
        { _numberOfBirds = num; }
        public void updateTotalBirds(int num)
        { _totalBirds += num;}
        static void Main(string[] args)
        {
            myBirds bird = new myBirds();
            Console.WriteLine("What type of bird is it?");
            bird.setBirdType(Console.ReadLine());
            Console.WriteLine("How many of this bird?");
            var tempNumBird = int.Parse(Console.ReadLine());
            bird.setNumberOfBirds(tempNumBird);
            bird.updateTotalBirds(tempNumBird);

            myBirds finch = new myBirds();
            finch.setBirdType("Red breasted house finch");
            finch.setNumberOfBirds(5);
            finch.updateTotalBirds(5);

            myBirds chickadee = new myBirds("chickadee",12);

            Console.WriteLine("What type of bird is it?");
            var tempBirdType = Console.ReadLine();
            Console.WriteLine("How many of this bird?");
            tempNumBird = int.Parse(Console.ReadLine());
            myBirds bird2 = new myBirds(tempBirdType,tempNumBird);

            printBirds(bird);
            printBirds(finch);
            printBirds(chickadee);
            printBirds(bird2);
            printTotalBirds(bird);            
        }
        static void printBirds(myBirds birdObject)
        {
            Console.WriteLine($"Number of {birdObject.getBirdType()}: {birdObject.getNumberOfBirds()}");
        }
        static void printTotalBirds(myBirds birdObject)
        {
            Console.WriteLine($"Total number of birds: {birdObject.getTotalBirds()}");
        }
    }
}