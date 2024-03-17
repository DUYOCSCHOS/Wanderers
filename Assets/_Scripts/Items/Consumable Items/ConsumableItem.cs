public abstract class ConsumableItem : Item
{
    protected ConsumableItem(){
        stack = 99;
    }

    public abstract void Consume();
}
