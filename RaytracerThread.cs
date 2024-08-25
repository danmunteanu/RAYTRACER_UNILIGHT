using LibUnilight;

public class RaytracerThread /*extends Thread*/
{
    private Raytracer raytracer = null;
    
    private bool keepRolling = true;
    
    public RaytracerThread(Raytracer rt)
    {
        this.raytracer = rt;
        //setName("Raytracer thread");
    }
    
    public bool MustRender { get; set; }

    public void run ()
    {
        while (keepRolling) {
            try { /*Thread.sleep(0);*/ } catch (Exception ex) {}

            if (MustRender) { 
                raytracer.render();
                MustRender = false;
            }
        }
    }        

}