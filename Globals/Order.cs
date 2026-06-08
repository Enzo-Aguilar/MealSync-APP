using System;

namespace MealSync_APP.Globals
{
    public class Order
    {
        private const int _InvalidId = -1;
        public int ID { get; set; } = _InvalidId;
        public int MealId { get; set; } = _InvalidId;
        public int TransactionId { get; set; } = _InvalidId;
        public int UserId { get; set; } = _InvalidId;
        public DateTime? BookedAt { get; set; }
        public Order Clear()
        {
            return new Order();
        }
    }
}
