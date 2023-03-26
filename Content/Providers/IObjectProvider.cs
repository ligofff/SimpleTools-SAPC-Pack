namespace Ligofff.ObjectProviders
{
    public interface IObjectProvider<out T>
    {
        public T Get { get; }
    }
}