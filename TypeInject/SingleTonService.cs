namespace TypeInject
{
    public class SingleTonService
    {
        public Guid guid { get; set; }
        public SingleTonService()
        {
            guid = Guid.NewGuid();
        }
    }
}
