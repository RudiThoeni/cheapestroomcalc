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
            //Request 2 Rooms. all of them are available only, same prices, should give A A 200 as result

            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 2, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 2, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });            

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test2()
        {
            //Request 2 Rooms. Room A only available 1 time, same prices, should give A B 220 as result

            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test3()
        {
            //Request 2 Rooms. Room A only available 1 time, different room prices, should give B A 195 as result

            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 95 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 110 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test4()
        {
            //Request 2 Rooms. all available, different room prices, should give B A 163 as result

            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 80 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 82 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 81 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 85 });


            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test5()
        {
            //3 eooms requested available A 1 time B 2 time

            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 110 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "A", RoomFree = 1, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "C", RoomFree = 2, RoomPrice = 115 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test6()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 3, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 3, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 120 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 110 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "A", RoomFree = 3, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "B", RoomFree = 2, RoomPrice = 120 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

        public static MyRequest Test7()
        {
            List<CheapestOffer> mylist = new List<CheapestOffer>();
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "A", RoomFree = 1, RoomPrice = 200 });
            mylist.Add(new CheapestOffer() { RoomSeq = 1, RoomId = "B", RoomFree = 2, RoomPrice = 100 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "A", RoomFree = 1, RoomPrice = 205 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "B", RoomFree = 2, RoomPrice = 110 });
            mylist.Add(new CheapestOffer() { RoomSeq = 2, RoomId = "C", RoomFree = 2, RoomPrice = 105 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "A", RoomFree = 1, RoomPrice = 200 });
            mylist.Add(new CheapestOffer() { RoomSeq = 3, RoomId = "B", RoomFree = 2, RoomPrice = 115 });

            return new MyRequest() { offerlist = mylist, rooms = 2 };
        }

    }

    public class MyRequest
    {
        public List<CheapestOffer> offerlist { get; set; }
        public int rooms { get; set; }
    }
}
