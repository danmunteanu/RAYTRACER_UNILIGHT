namespace Unilight
{

    public class Triangle : GObject
    {
        //  vertices in counter clockwise order
        private Vector3D V1 = new Vector3D ();
        private Vector3D V2 = new Vector3D ();
        private Vector3D V3 = new Vector3D ();
    
        private Vector3D normal = new Vector3D ();
    
        //  Default constructor
        public Triangle ()
        {
            recomputeNormal();
        }
    
        public Triangle (Vector3D v1, Vector3D v2, Vector3D v3)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.V3 = v3;
            recomputeNormal ();
        }

        private void recomputeNormal()
        {
            normal = (V2 - V3).Cross(V1 - V3).Normalized();
        }

        public override void Accept (Visitor v)
        {
            v.Visit (this);
        }
    
        public override Vector3D GetNormalAt (Vector3D p)
        {
            return normal;
        }

        public Vector3D getV1() {
            return V1;
        }

        public void setV1(Vector3D p1) {
            bool mustRecompute = !this.V1.Equals (p1);        
            this.V1 = p1;
            if (mustRecompute) {
                recomputeNormal();
            }
        }

        public Vector3D getV2() {
            return V2;
        }

        public void setV2(Vector3D p2) {
            bool mustRecompute = !this.V2.Equals (p2);
            this.V2 = p2;
            if (mustRecompute) {
                recomputeNormal();
            }
        }

        public Vector3D getV3() {
            return V3;
        }

        public void setV3(Vector3D p3) {
            bool mustRecompute = !this.V3.Equals (p3);
            this.V3 = p3;
            if (mustRecompute) {
                recomputeNormal();
            }
        }
    
  
    }

}