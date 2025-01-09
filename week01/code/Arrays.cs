public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //my implementation. first I need to do is to call the double [] and make it where I can store new info in it and also make it a variable called multiples. 
        // the second thing I shoud do is once I call that new double I put the perameter [length]
        // third thing I should do is create a for loop that will keep running as long as i the index is less then length
        // fourth thing I need to do is make sure it gets added to the index when it does run through
        // then I need to  call the multiples variable with the i for index and make that = the other perameter number
        // then I will take number and multiplay it by i the index and + by 1
        // doing this will make it grow by 1 each time until the loop reaches the length specification

        double [] multiples = new double[length];

        for (int i = 0; i < length; i ++ ){
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // first I will create a variable that will hold the length of the data
        // then I will create a temporary list that will store rotated list for me
        // then I need to take what ever amount specified and add it to the front by 
        // taking the amount - the length of the data and adding that data to a temporary list
        // then I need to take the rest of the numbers in the list in put them in the back by takeing the same approach but just targeting the numbers after the amount.
        // then I add those to the temporary list 
        // then I clear the original list
        // and put in my new info with my temp list 

        //variable for length of data 
         int n = data.Count;

        // Create a temporary list to store new data rotations
        List<int> tempList = new List<int>();

        // take the amount specified and put them at the front 
        for (int i = n - amount; i < n; i++)
        {
            tempList.Add(data[i]);
        }

        // add the rest of the numbers 
        for (int i = 0; i < n - amount; i++)
        {
            tempList.Add(data[i]);
        }
        // clear old list and fill it with tempList 
        data.Clear();
        data.AddRange(tempList);
    }
}
