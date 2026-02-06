namespace DIKUCanteen;

public class Canteen : Room
{
  private int cups = 100;
  public int Cups
  {
    get {return cups;}
  }
  public Canteen(string name) : base(name)
  {
  }
  public Canteen(string name, int cups) : base(name)
  {
    this.cups = cups;
  }
  public override string ToString()
  {
    return $"{Name} has {cups} cups";
  }

  public void TakeCup()
  {
    if (cups <= 0)
    {
      return;
    }
    cups--;
  }

  public void ReturnCup()
  {
    cups++;
  }
}

