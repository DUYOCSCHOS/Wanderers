public interface StatsComponentVisitor
{
    void Visit(HealthComponent healthComponent);
    void Visit(ManaComponent manaComponent);
    void Visit(StaminaComponent staminaComponent);
}
