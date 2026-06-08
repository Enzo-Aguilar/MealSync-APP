namespace MealSync_APP.Globals
{
    public class Holder
    {
        private const int _InvalidId = -1;
        public int ID { get; set; } = _InvalidId;
        public int UserId { get; set; } = _InvalidId;
        public int BankAccountId { get; set; } = _InvalidId;
        public bool IsActive { get; set; } = true;
        public int OwnershipOrder { get; set; } = 1;
        public Holder Clear()
        {
            return new Holder();
        }
    }
}
