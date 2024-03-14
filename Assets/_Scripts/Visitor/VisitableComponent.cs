public interface VisitableComponent
{
    void Accept(ComponentVisitor visitor);
}