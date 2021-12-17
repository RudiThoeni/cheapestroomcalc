using Combinatorics.Collections;
using RoomCalc;
using System.Diagnostics;

var myinputlist = MyInput.GenerateInput();

int counter = 1;

foreach (var myinput in myinputlist)
{
	Console.WriteLine("---------------------------------TEST" + counter + "--------------------------------------");
	counter++;

	var list = myinput.offerlist;
	var rooms = myinput.rooms;
	
	List<CheapestRoomCombinationResult> myresult = new List<CheapestRoomCombinationResult>();

	Console.ForegroundColor = ConsoleColor.Green;

	Console.WriteLine("Requested " + rooms + " Rooms");

	//Display Roominfo
	foreach (var roominfoid in list.Select(x => x.RoomId).Distinct())
	{
		var room = list.Where(x => x.RoomId == roominfoid).FirstOrDefault();
		Console.WriteLine("Room Id " + roominfoid + " available " + room.RoomFree + " price:" + room.RoomPrice);
	}

	Console.ForegroundColor = ConsoleColor.Yellow;

	Stopwatch mywatch = new Stopwatch();
	mywatch.Start();

	//Create combinations OR use variations??
	Combinations<CheapestOffer> combinations = new Combinations<CheapestOffer>(list, rooms);

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
				Console.WriteLine("Removing combination - room in the same roomseq");
				addcombination = false;
			}

			if (!addcombination)
				break;
		}

		//TODO remove all combinations where more rooms are used than roomfree 
		//string roomid = c[0].RoomId;
		//int roomcount = 

		if (addcombination)
		{
			for (int i = 0; i < rooms; i++)
			{
				//Check how often room with this id is used
				if (c.Where(x => x.RoomId == c[i].RoomId).Count() > c[i].RoomFree)
				{
					Console.WriteLine("Removing combination - room used more than available!");
					addcombination = false;
				}

				if (!addcombination)
					break;
			}
		}


		if (addcombination)
		{
			myresult.Add(new CheapestRoomCombinationResult() { CheapestRoomCombination = c });
		}
	}

	Console.WriteLine("Result is");

	foreach (var x in myresult)
	{
		for (int i = 0; i < rooms; i++)
		{
			Console.Write(String.Format("{{{0} ({1}) Price: {2} }}", x.CheapestRoomCombination[i].RoomId, x.CheapestRoomCombination[i].RoomSeq, x.CheapestRoomCombination[i].RoomPrice));
		}
		Console.WriteLine("Total:" + x.Price);
	}

	var cheapestcombination = myresult.OrderBy(x => x.Price).Take(1).FirstOrDefault();
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine(cheapestcombination.Price + " " + String.Join(",", cheapestcombination.CheapestRoomCombination.Select(x => x.RoomId)));

	mywatch.Stop();
	Console.WriteLine("Time taken:" + mywatch.ElapsedMilliseconds);
}

Console.ReadLine();