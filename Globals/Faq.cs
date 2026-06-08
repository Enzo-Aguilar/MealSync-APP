namespace MealSync_APP.Globals
{
    public class Faq
    {
        private const int _InvalidId = -1;
        public int ID { get; set; } = _InvalidId;
        public int UserId { get; set; } = _InvalidId;
        public string Answer { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool IsAnswered { get; set; } = false;
        public string Question { get; set; } = string.Empty;

        public Faq Clear()
        {
            return new Faq();
        }
    }
}
