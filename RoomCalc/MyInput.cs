using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalc
{
    public class MyInput
    {
        public static List<MyRequest> GenerateInput()
        {
            List<MyRequest> mylist = new List<MyRequest>();

            mylist.Add(Test1());
            mylist.Add(Test2());
            mylist.Add(Test3());
            mylist.Add(Test4());
            mylist.Add(Test5());
            mylist.Add(Test6());
            mylist.Add(Test7());

            return mylist;
        }


        public static MyRequest Test1()
        {
            //Simple Request 2 Rooms. all of them are available only 

            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 2, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 2, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });            

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test2()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test3()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 110 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test4()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 2, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 2, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });


            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test5()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 110 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "B", RoomFree = 2, RoomPrice = 120 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test6()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 110 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "B", RoomFree = 2, RoomPrice = 120 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test7()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 110 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "B", RoomFree = 2, RoomPrice = 120 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

    }

    public class MyRequest
    {
        public List<CheapestOffer> offerlist { get; set; }
        public int rooms { get; set; }
    }
}
