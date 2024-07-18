using System;

namespace Card_Game_C;

public class UnitCard : Card
{
    public UnitCard(){
        CardType = CardType.UnitCard;
    }

    private bool IsDead(){
        return Healt <= 0;
    }

    public bool TakeDamage(int damge){
        Healt -= damge;
        return IsDead();
    }
    
}
