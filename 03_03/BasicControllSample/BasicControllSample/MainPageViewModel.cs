namespace BasicControllSample
{
    internal class MainPageViewModel
    {
        public List<Item> Items { get; set; } = new List<Item>();
    }

    public class Item
    {
        public string Text { get; set; }
    }
}