namespace NumberGuessing; 

public class Game{


public Game(){



}

  public void GuessNum(){
        
          int end = 0; 
         Generator gen = new Generator();
         int secretNum = gen.randGen();
        
         do
        {
                Console.WriteLine("Enter you number");
    
                // This being run multiple times could cause some trouble 
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



public void RunGame(){


        Console.WriteLine("Would you like to play a game");
        Console.WriteLine("Type yes or no into the console");

        string answer = Console.ReadLine(); 
        
        if(answer == "yes"){
        
        
                Console.WriteLine("The aim of the game is to guess the Secret number");
                Console.WriteLine("The number will be between 0 and 10 and you must guess it correctly");
                Console.WriteLine("Try as many times as you want");
            // Call the method here 
            GuessNum(); 
            
        }
        
        if(answer == "no"){
            Console.WriteLine("maybe another time"); 
            
        }
}

}