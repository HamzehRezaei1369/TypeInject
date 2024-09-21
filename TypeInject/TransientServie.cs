namespace TypeInject
{
    public class TransientServie
    {
        public Guid guid { get; set; }
        public TransientServie()
        {
            guid = Guid.NewGuid();
        }

    }
}
