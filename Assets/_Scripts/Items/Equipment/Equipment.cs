public abstract class Equipment : Item
{
    protected Equipment(){
        stack = 1;
    }

    public abstract void Equip();
}
