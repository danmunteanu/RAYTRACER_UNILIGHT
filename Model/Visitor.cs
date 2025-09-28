namespace Unilight
{
    public interface Visitor
    {
        public void Visit(Sphere prim);
        public void Visit(Box prim);
        public void Visit(Plane prim);
        public void Visit(Triangle prim);
    }

}