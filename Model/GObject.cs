namespace UnilightRaytracer
{
    public abstract class GObject
    {
        protected static int _instanceCount = 0; // shared across all instances

        private Vector mOrigin = new Vector();
        
        public string Name { get; set; }

        public Material Material { get; set; } = new ();
        
        public Vector Origin
        {
            get => mOrigin;
            set => mOrigin = value;
        }

        public bool Enabled { get; set; }

        protected GObject()
        {
            _instanceCount++;
            Name = "GObject " + _instanceCount;
        }

        public abstract void Accept(Visitor v);

        public abstract Vector GetNormalAt(Vector p);
    }
}
