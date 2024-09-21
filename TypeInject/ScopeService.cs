namespace TypeInject
{
    public class ScopeService
    {
        public Guid guid { get; set; }
        public ScopeService()
        {
            guid = Guid.NewGuid();
        }

    }
}
