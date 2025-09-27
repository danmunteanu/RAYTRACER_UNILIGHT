namespace UnilightRaytracer
{

public class Triangle : GObject
{
    //  vertices in counter clockwise order
    private Vector V1 = new Vector ();
    private Vector V2 = new Vector ();
    private Vector V3 = new Vector ();
    
    private Vector normal = new Vector ();
    
    //  Default constructor
    public Triangle ()
    {
        recomputeNormal();
    }
    
    public Triangle (Vector v1, Vector v2, Vector v3)
    {
        this.V1 = v1;
        this.V2 = v2;
        this.V3 = v3;
        recomputeNormal ();
    }
    
    private void recomputeNormal ()
    {
        normal = V1.Subtract (V3).Cross (V2.Subtract (V3));
        normal.Normalize ();
    }
    
    public override void Accept (Visitor v)
    {
        v.Visit (this);
    }
    
    public override Vector GetNormalAt (Vector p)
    {
        return normal;
    }

    public Vector getV1() {
        return V1;
    }

    public void setV1(Vector p1) {
        bool mustRecompute = !this.V1.Equals (p1);        
        this.V1 = p1;
        if (mustRecompute) {
            recomputeNormal();
        }
    }

    public Vector getV2() {
        return V2;
    }

    public void setV2(Vector p2) {
        bool mustRecompute = !this.V2.Equals (p2);
        this.V2 = p2;
        if (mustRecompute) {
            recomputeNormal();
        }
    }

    public Vector getV3() {
        return V3;
    }

    public void setV3(Vector p3) {
        bool mustRecompute = !this.V3.Equals (p3);
        this.V3 = p3;
        if (mustRecompute) {
            recomputeNormal();
        }
    }
    
  
}

}