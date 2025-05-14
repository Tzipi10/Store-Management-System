using BlImplementation;
namespace BlApi
{
    public static class Factory
    {
        //public static IBl Get=> new Bl();
        public static IBl Get()
        {
            return new Bl();

        }
    }
}
