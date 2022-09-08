


int[] items = new int[6];
int search,i;

for(i=0;i<items.Length;i++)
{
	Console.WriteLine("Enter Items Price: ");
	items[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("*-------------------------------*");

Console.WriteLine("Enter Search Value: ");
search = Convert.ToInt32(Console.ReadLine());

for(i=0;i<items.Length;i++)
{
	if (search == items[i])
	{
		break;
	}
}

if (i == items.Length)
{
	Console.WriteLine("Value Not  Found !");
}


else
{
	Console.WriteLine("Value Found At " +i +" Index");
}