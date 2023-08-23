using builder_pattern.builder;
using builder_pattern.director;
using builder_pattern.@object;

internal class Program
{
    private static void Main(string[] args)
    {
        IBuilder builder = new CarBuilder();
        IDirector director = new CarDirector();
        Vehicle car = director.Instruct(builder);
        car.ShowObject();
    }
}