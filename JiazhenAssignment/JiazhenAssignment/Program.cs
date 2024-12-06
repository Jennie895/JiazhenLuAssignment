// See https://aka.ms/new-console-template for more information

using JiazhenAssignment;

// Playing with Console App
PlayingPart demo = new PlayingPart();
demo.Playing();

//-------------------
//Practice number sizes and ranges
PracticeNum demoOfPracticeNum = new PracticeNum();
demoOfPracticeNum.UnderstandingTypes();
demoOfPracticeNum.ConvertTime(5);

//--------------------
//Practice loops and operators
// -------1-------
PracticeLoops demoOfPracticeLoops = new PracticeLoops();
demoOfPracticeLoops.FizzBuzzis(100);

//Sample code execution
int max = 500;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}
//Answer:
//since i is a byte, the maximum value is 255, which always satisfies the condition: i<500; 
// Then the iteration adds i by 1, causing the overflow problem. i's value changes from 255 to 0,
// so this is an infinite loop which do not end.
// We can add a checking condition to check the value types of iterator and condition variable are the same.
// If not, then break the loop and print out the warning message. 

 
 for (byte i = 0; i < max; i++)
 {   
     if (i.GetType() != max.GetType())
     {
         Console.WriteLine("The value type of i and max are different");
         break; 
     }
     Console.WriteLine(i);
 }

demoOfPracticeLoops.GuessNumber();

//--------2--------
  demoOfPracticeLoops.PrintAPyramid(5);
//
// //--------3------- SAME AS ABOVE
// //--------4-------Birth days
 DateTime birthday = new DateTime(1999, 12, 31);
 demoOfPracticeLoops.DaysOfBrith(birthday);
//
// //--------5---------
 DateTime time = new DateTime(2014, 10, 11, 14, 30, 0);
 demoOfPracticeLoops.Greeting(time);
 DateTime timeNow = DateTime.Now;
 demoOfPracticeLoops.Greeting(timeNow);


 //-------6----------
demoOfPracticeLoops.Counting24();



//================Array and String==========
//----1--------
PracticeArrays demoOfPracticeArrays = new PracticeArrays();
string[] arr = { "apple", "banana", "3", "4", "6", "7", "8", "9","grape","avacado" };
string[] newArray = demoOfPracticeArrays.CopyArray(arr);
Console.WriteLine("The copy array is " + string.Join(", ",newArray));
Console.WriteLine("The original array is " + string.Join(", ",arr));

//---------2--------
demoOfPracticeArrays.ToDoList();

//-----3-------
int[] array = FindPrimesInRange.findPrimesInRange(2, 40);
Console.WriteLine(string.Join(", ",array));

//------4-------
RoationInteger.sumRoation();

//-------5--------
int[] input = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
int[] result = LongestEqualElement.FindLongest(input);
Console.WriteLine(string.Join(" ,",result));


//-------7----------
MostFrequentNumber.GetMostFrequentNumber();



//========================Practice Strings===============
//-----------1---------
ReverseString.ReverseStringWithArray();
ReverseString.PrintStringBackwards();


//------------2----------------
ReverseSentence.Reverse();


//------------3-----------------
UniquePalindrome.PrintUniquePalindrome();


//--------------4------------------
URL.PrintURL();