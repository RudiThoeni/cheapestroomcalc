using Combinatorics.Collections;
using RoomCalc;


var myinput = MyInput.GenerateInput();

var list = myinput.offerlist;
var rooms = myinput.rooms;

//Create combinations
Combinations<CheapestOffer> combinations = new Combinations<CheapestOffer>(list, rooms);

List<CheapestRoomCombinationResult> myresult = new List<CheapestRoomCombinationResult>();

int counter = 1;

foreach (IList<CheapestOffer> c in combinations)
{
	bool addcombination = true;
	
	for (int i = 0; i < rooms; i++)
	{
		Console.Write(String.Format("{{{0} ({1}) }}  ", c[i].RoomId, c[i].RoomSeq));
	}
	Console.Write("\n");


	//Check with roomseqdict if the combination is valid

	for (int i = 0; i < rooms; i++)
	{
		if (c.Where(x => x.RoomSeq == c[i].RoomSeq).Count() > 1)
		{
			Console.WriteLine("Removing combination - same roomseq");
			addcombination = false;
		}

		if (!addcombination)
			break;
	}

	//TODO remove all combinations where roomfree does not match
	//string roomid = c[0].RoomId;
	//int roomcount = 

	//for (int i = 0; i < rooms; i++)
	//{
	//	if()
	//}


	if (addcombination)
    {
		myresult.Add(new CheapestRoomCombinationResult() { CheapestRoomCombination = c });
	}
}

Console.WriteLine("Result is");

foreach(var x in myresult)
{
	for(int i = 0; i < rooms; i++)
    {
		Console.Write(String.Format("{{{0} ({1}) Price: {2} }}", x.CheapestRoomCombination[i].RoomId, x.CheapestRoomCombination[i].RoomSeq, x.CheapestRoomCombination[i].RoomPrice));
    }
	Console.WriteLine("Total:" + x.Price);
}

var cheapestcombination = myresult.OrderBy(x => x.Price).Take(1).FirstOrDefault();
Console.ForegroundColor = ConsoleColor.Red;	
Console.WriteLine(cheapestcombination.Price + " " + String.Join(",", cheapestcombination.CheapestRoomCombination.Select(x =>x.RoomId)));

Console.ReadLine();