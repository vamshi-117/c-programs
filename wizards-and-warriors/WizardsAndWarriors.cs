using System;

abstract class Character
{
    protected string characterType;

    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {      if(target.Vulnerable()){
            return 10;
        }else{
            return 6;
    
    }
        // Implementation of DamagePoints method for Warrior
        throw new NotImplementedException("Please implement the Warrior.DamagePoints() method");
    }   

 
}

class Wizard : Character
{
    public bool SpellPrepared { get; private set; }
    
    public Wizard() : base("Wizard")
    {
     
    }

    public override int DamagePoints(Character target)
    {  if(!SpellPrepared){
        return 3;
    }else{
        return 12;
    }
        // Implementation of DamagePoints method for Wizard
       
    }
    
    public bool PrepareSpell()
    {     return SpellPrepared=true;
        // Implementation of PrepareSpell method for Wizard
       
    }
     public override bool Vulnerable()
    {
        return !SpellPrepared;
    }

   


}

