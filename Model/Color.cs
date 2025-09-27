namespace UnilightRaytracer
{

public class Color
{
    //  each component is between [0, 1]
    public float r = 0;
    public float g = 0;
    public float b = 0;

    //  some default colors
    public static Color black = new Color (0, 0, 0);
    public static Color red = new Color (1, 0, 0);    
    public static Color green = new Color (0, 1, 0);
    public static Color blue = new Color (0, 0, 1);
    public static Color white = new Color (1, 1, 1);    
    public static Color yellow = new Color (1, 1, 0);
    public static Color cyan = new Color (0, 1, 1);
    public static Color magenta = new Color (1, 0, 1);
    
    public Color ()
    {        
    }
    
    public Color (float r, float g, float b)
    {
        //  clamp colors if necessary
        this.r = (r > 1 ? 1 : (r < 0 ? 0 : r));
        this.g = (g > 1 ? 1 : (g < 0 ? 0 : g));
        this.b = (b > 1 ? 1 : (b < 0 ? 0 : b));
    }
    
    public Color Add (Color c)
    {
        float red = r + c.r;
        float green = g + c.g;
        float blue = b + c.b;
        if (red > 1) red = 1;
        if (green > 1) green = 1;
        if (blue > 1) blue = 1;
        return new Color (red, green, blue);
    }

    public Color Subtract (Color c)
    {
        float red = r - c.r;
        float green = g - c.g;
        float blue = b - c.b;
        if (red < 0) red = 0;
        if (green < 0) green = 0;
        if (blue < 0) blue = 0;
        return new Color (red, green, blue);
    }
    
    public Color Multiply (Color c)
    {
        float red = r * c.r;
        float green = g * c.g;
        float blue = b * c.b;
        return new Color (  red > 1 ? 1 : (red < 0 ? 0 : red), 
                            green > 1 ? 1 : (green < 0 ? 0 : green), 
                            blue > 1 ? 1 : (blue < 0 ? 0 : blue));
    }
    
    public Color Multiply (float k)
    {
        float red = (float) (r * k);
        float green = (float) (g * k);
        float blue = (float) (b * k);
        return new Color (  red > 1 ? 1 : (red < 0 ? 0 : red), 
                            green > 1 ? 1 : (green < 0 ? 0 : green), 
                            blue > 1 ? 1 : (blue < 0 ? 0 : blue));
    }
}


}