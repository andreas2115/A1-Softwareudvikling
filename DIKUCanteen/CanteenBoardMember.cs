namespace DIKUCanteen;

public class CanteenBoardMember : Student {

    public CanteenBoardMember(string name, string occupation, int age) : base(name, occupation, age) {
    }

    public static int CupBudget = 5;

    public void BuyCup(Canteen canteen) {
        if (CupBudget <= 0) {
            return;
        }
        canteen.ReturnCup();
        CupBudget--;

    }
}
