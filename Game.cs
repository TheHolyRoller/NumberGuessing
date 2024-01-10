namespace NumberGuessing; 

public class Game{


public Game(){



}


// Create the method that instantiates the Generator class and call it's method 

// Then use the result and keep going until the user has entered the right number 

public void runGame(){


        Console.WriteLine("Would you like to play a game");
        Console.WriteLine("Type yes or no into the console");

        string answer = Console.ReadLine(); 
        
        if(answer == "yes"){
        
        
                Console.WriteLine("The aim of the game is to guess the Secret number");
                Console.WriteLine("The number will be between 0 and 10 and you must guess it correctly");
                Console.WriteLine("Try as many times as you want");
                // Call the method here 
        
        }



}


  public void guessNum(){
        
          int end = 0; 
         Generator gen = new Generator();
         int secretNum = gen.randGen();


        
         do
        {


                Console.WriteLine("Enter you number");

                string guess = Console.ReadLine();

                int guessNum = Convert.ToInt32(guess);

                if (guessNum > secretNum)
                {

                    Console.WriteLine("Guess lower");

                }

                if (guessNum < secretNum)
                {

                    Console.WriteLine("Guess Higher");

                }

                if (guessNum == secretNum)
                {

                    Console.WriteLine("You guessed right you win!");
                    end = 1;
                    break;


                }

           
        }
        while (end == 0);
        
        
        }






}