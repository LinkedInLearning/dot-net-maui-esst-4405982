namespace CollectionSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		List<Person> people = new List<Person>()
		{
			new Person() { Name = "ABC", Age = 20 },
            new Person() { Name = "DEF", Age = 30 },
            new Person() { Name = "GHI", Age = 40 }
        };

		BindingContext = people;
	}
}

public class Person
{
    public string Name { get; set; }
	public int Age { get; set; }
}

