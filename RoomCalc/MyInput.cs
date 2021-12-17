using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalc
{
    static class MyInput
    {
        public static List<CheapestOffer> GenerateInput()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 110 });
            //mylist.Add(new CheapestOffer(){ RoomSeq = 3, RoomId = "A3", RoomFree = 1, RoomPrice = 100 });
            //mylist.Add(new CheapestOffer(){ RoomSeq = 3, RoomId = "B3", RoomFree = 2, RoomPrice = 120 });

            return mylist;
        }
    }
}
