using System.Threading;
using Cysharp.Threading.Tasks;

public abstract class Modifier
{
    protected CancellationTokenSource cancellationTokenSource = new();

    public abstract void StartOperation();
    public abstract void StopOperation();

    protected abstract UniTask OnModify();
}
