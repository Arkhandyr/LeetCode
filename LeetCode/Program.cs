using LeetCode;

while (true)
{
    Console.Write("\nLeetCode to run:");
    Run(int.Parse(Console.ReadLine()));
}

void Run(int number) 
{
	switch (number)
	{
        case 88:
            LeetCode88.Run();
            break;
        case 27:
            LeetCode27.Run();
			break;
        default:
			break;
	}
}