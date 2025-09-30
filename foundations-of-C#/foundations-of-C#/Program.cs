using System.Formats.Asn1;

OperatorExamples();
TryAnIf();
TrySomeLoops();
TryAnElseIf();

void OperatorExamples() {
    int width = 3;
    width++;

    int height = 2 + 4;
    int area = width * height;
    Console.WriteLine(area);

    string result = "This Area";
    result = result + " is " + area;
    Console.WriteLine(result);

    bool truthValue = true;
    Console.WriteLine(truthValue);

    while (area < 50)
    {
        height++;
        area = width * height;
    }

    do
    {
        width--;
        area = width * height;
    } while (area > 25);
}

void TryAnIf()
{
    int someValue = 4;
    string name = "Bobbo Jr.";
    if ((someValue == 3) && (name == "Joe"))
    {
        Console.WriteLine("x is 3 and the name is Joe");
    }
    Console.WriteLine("this line runs no matter what");
}

void TryAnElseIf()
{
    int x = 5;
    if (x == 10)
    {
        Console.WriteLine("x must be 10");
    }
    else
    {
        Console.WriteLine("x isn't 10");
    }
}

void TrySomeLoops()
{
    int count = 0;

    while (count < 10)
    {
        count += 1;
    }

    for (int i = 0; i < 5; i++)
    {
        count -= 1;
    }

    Console.WriteLine("The answer is " + count);
}