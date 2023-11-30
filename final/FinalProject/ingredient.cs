



public class Ingredient{

    //variables
    private string _ingName;
    private int _amount;
    private string _unit;


    public Ingredient(string IngName, int Amount, string Unit){
        _ingName = IngName;
        _amount =  Amount;
        _unit = Unit;
    }

    public string IngName{

        get{return _ingName;}
        set{_ingName = value;}
    }

    public int Amount{
        
        get{return _amount;}
        set{_amount = value;}
    }

    public string Unit{
        
        get{return _unit;}
        set{_unit = value;}
    }
    
}