# Explanation for the Program

The basic idea of this particular solution is to find how many strings in the given array meets the requirement length of 3 or less symbols. Then it writes all such strings in the newly created array.

> _It has a size of the number of fitted strings in the array_

## Basic Rundown of The Code	

1. The method gets array of strings **inputArray** and maximum possible length of a string **maxLength** as an input.  

2. At the beggining it assigns **numberOfNeededStrings** the number of strings with the length less than **maxLength** to 0.  

3. It uses a cycle *for* to go through all of the elements of the **inputArray** starting with **counter** equals 0.
    1. Inside the cycle it makes a check if the current element of the array has length within the **maxLength**. 
    2. If the check above is correct it increases the future size **numberOfNeededStrings** of the final array by 1.
    >_Since I am obliged to use array as my main object I have to find the required size of the array upfront._  

4. Now the method creates a new array with a size of **numberOfNeededStrings** and it assigns the starting position from **inputArray** **positionFromInput** to 0.

5. It uses a cycle *for* to go through all of the elements of the **outputArray** to fill it from **inputArray** starting with **counter** equals 0.
    1. Inside this cycle the method checks if the current element **inputArray[possitionFromInput]** has a length of 4 or more symbols. If this is true the method takes the next element of **inputArray**.
    2. Now since the current element **inputArray[possitionFromInput]** has a length of 3 symbols or less it stores this strings into the current position of an output **outputArray[counter]** and increases **possitionFromInput** by 1.  

6. Finally, the method returns the string array **outputArray** that contains all of the strings from **inputArray** with a length less or equal to the **maxLength**. It is possible that the **outputArray** is empty array since **inputArray** may contains no strings with such short length.  
> _As an extra addition to the task I have added a **PrintArray** method which simply prints all elements of any given array in order to simplify the process of verification._ 
        
