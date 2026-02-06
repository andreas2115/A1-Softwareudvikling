namespace DIKUCanteen;

public class Student : Person{
    public bool HasCup = false;

    public Student(string name, string occupation, int age) : base(name, occupation, age)
    {
        
    }

    public void TakeCup(Canteen canteen)
    {
        if (HasCup || canteen.Cups <= 0)
        {
            return;
        } 
        canteen.TakeCup();
        HasCup = true;
    } 

    public void ReturnCup(Canteen canteen)
    {
        if (HasCup == false){
            return;
        }
        canteen.ReturnCup();
        HasCup = false;

    }
}
