using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalc
{
    public class CheapestOffer
    {
        public int RoomSeq { get; set; }
        public string RoomId { get; set; }
        public int RoomFree { get; set; }
        public double RoomPrice { get; set; }
    }

    public class CheapestRoomCombinationResult
    {
        public IList<CheapestOffer>? CheapestRoomCombination { get; set; }
        public double Price { get
            {
                return this.CheapestRoomCombination != null && this.CheapestRoomCombination.Count > 0 ? this.CheapestRoomCombination.Sum(x => x.RoomPrice) : 0;
            }
        }
    }
}
