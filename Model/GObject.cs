namespace Unilight
{
    public abstract class GObject
    {
        protected static int _instanceCount = 0; // shared across all instances

        private Vector3D mOrigin = new Vector3D();
        
        public string Name { get; set; }

        public Material Material { get; set; } = new ();
        
        public Vector3D Origin
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

        public abstract Vector3D GetNormalAt(Vector3D p);
    }
}
