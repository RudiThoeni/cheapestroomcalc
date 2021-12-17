using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalc
{
    public class MyInput
    {
        public static MyRequest GenerateInput()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 110 });
            //mylist.Add(new CheapestOffer(){ RoomSeq = 3, RoomId = "A3", RoomFree = 1, RoomPrice = 100 });
            //mylist.Add(new CheapestOffer(){ RoomSeq = 3, RoomId = "B3", RoomFree = 2, RoomPrice = 120 });
       
            return new MyRequest() {  offerlist = mylist, rooms = 2  };
        }

        //TODO Add all possible 
    }

    public class MyRequest
    {
        public List<CheapestOffer> offerlist { get; set; }
        public int rooms { get; set; }
    }
}
