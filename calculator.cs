class Calculator {

void Calculate(){

Console.WriteLine("Please enter your function");

string function = Console.ReadLine();

Console.WriteLine("Please enter first number");

string stringOne = Console.ReadLine();

Console.WriteLine("Please enter second number");

string stringTwo = Console.ReadLine();

decimal numberOne = Convert.ToDecimal(stringOne);
decimal numberTwo = Convert.ToDecimal(stringTwo);

decimal sum;

if(function == "*")
{
    sum = numberOne * numberTwo;
}
else if (function == "+")
{
    sum = numberOne + numberTwo; 
}

else if (function == "-")
{
    sum = numberOne - numberTwo;
}
   
else if (function == "/")
{
    sum = numberOne / numberTwo;
}

else
{
    sum = 0;
}
Console.WriteLine(sum);


}

}