using System;

namespace Card_Game_C;

public abstract class Card
{
    public int Damage { get; set; }
    public int Healt { get; set; }
    public int Cost { get; set; }
    //
    public string Name { get; set; }
    public CardType CardType { get; set; }
    //
    public int CardNum { get; set; }

    public override string ToString(){
        return Name + "-"+ Damage.ToString() + "-"+ Healt.ToString() + "-"+ Cost.ToString();
    }
}
