namespace Inheritance
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public void GetNameAndAge()
    {
      Console.WriteLine("The Person Has Name: {0} and age: {1}", Name, Age);
    }

  }
}