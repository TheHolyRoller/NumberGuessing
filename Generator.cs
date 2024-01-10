namespace NumberGuessing; 

public class Generator{

public Generator(){


}

// Add in the generator method here 

public int randGen(){


        Random rand = new Random();

      int secretNum = rand.Next(0, 11);

        return secretNum; 

}







}