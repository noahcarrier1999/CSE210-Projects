



using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Ingredient{

    //variables
    private string _ingName;
    private int _amount;
    private string _unit;

    public string IngName {
        get => _ingName;
        set => _ingName = value;
        }


    public int Amount {
        get => _amount;
        set => _amount = value;
        }

    public string Unit {
        get => _unit;
        set => _unit = value;
        }

    public Ingredient(string IngName, int Amount, string Unit) {
        _ingName = IngName;
        _amount = Amount;
        _unit = Unit;
    }

    public Ingredient() {
        _ingName = "Default";
        _amount = 0;
        _unit = "cup";
    }


    
}