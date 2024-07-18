
using System.Collections.Generic;

namespace Card_Game_C;

public static class CardDataBase
{
    public static readonly List<Card> DATA = new List<Card>()
    {
        new UnitCard(){CardNum = 0, Name = "Artificer", Damage = 2, Healt = 2, Cost = 4},
        new UnitCard(){CardNum = 1,Name = "Black Lizard", Damage = 2, Healt = 4, Cost = 2},
        new UnitCard(){CardNum = 2,Name = "Blue Lizard", Damage = 2, Healt = 1, Cost = 1},
        new UnitCard(){CardNum = 3,Name = "Caramel Lizard", Damage = 5, Healt = 5, Cost = 5},
        new UnitCard(){CardNum = 4,Name = "Cyan Lizard", Damage = 3, Healt = 3, Cost = 3},
    };

    private static int index = 0;
    public static Card getUnitCard(){
       var aux = DATA[index];
       index++;
       return aux;
    }
}
