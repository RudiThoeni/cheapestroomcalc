using Combinatorics.Collections;
using RoomCalc;

List<CheapestOffer> mylist = new List<CheapestOffer>();
mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A1", RoomFree = 1, RoomPrice = 100 });
mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B1", RoomFree = 2, RoomPrice = 120 });
mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A2", RoomFree = 1, RoomPrice = 100 });
mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B2", RoomFree = 2, RoomPrice = 120 });
mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C2", RoomFree = 2, RoomPrice = 110 });
//mylist.Add(new CheapestOffer(){ RoomSeq = 3, RoomId = "A3", RoomFree = 1, RoomPrice = 100 });
//mylist.Add(new CheapestOffer(){ RoomSeq = 3, RoomId = "B3", RoomFree = 2, RoomPrice = 120 });

var arraylist = mylist.ToArray();

int rooms = 2;

//Create combinations
Combinations<CheapestOffer> combinations = new Combinations<CheapestOffer>(mylist, rooms);
string cformat = "Variations of {{A1 B1 A2 B2 C2}} choose 2: size = {0}";
Console.WriteLine(String.Format(cformat, combinations.Count));

List<CheapestRoomCombinationResult> myresult = new List<CheapestRoomCombinationResult>();

int counter = 1;

foreach (IList<CheapestOffer> c in combinations)
{
	bool addcombination = true;

	Console.WriteLine(String.Format("{{{0} {1} }}", c[0].RoomId, c[1].RoomId));

	//remove all with the same roomseq;


	int roomseqtemp = c[0].RoomSeq;
	for (int i = 1; i < rooms; i++)
	{
		if (c[i].RoomSeq == roomseqtemp)
			Console.WriteLine(String.Format("Removing {{{0} {1} }} same roomseq", c[0].RoomId, c[1].RoomId));

		roomseqtemp = c[i].RoomSeq;

		addcombination = false;
	}

	//TODO remove all combinations where roomfree does not match


	if(addcombination)
    {
		myresult.Add(new CheapestRoomCombinationResult() { CheapestRoomCombination = c });
	}
}

Console.WriteLine("Result is");

foreach(var x in myresult)
{
	for(int i = 0; i < rooms; i++)
    {
		Console.Write(String.Format("{{{0} ({1}) }} same roomseq", x.CheapestRoomCombination[0].RoomId, x.CheapestRoomCombination[1].RoomPrice));
    }
	Console.WriteLine("Total:" + x.Price);
}
	

Console.ReadLine();