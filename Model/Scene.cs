/*
 * Scene.cs
 *
 * Manages a 3D scene for the Unilight raytracer.
 *
 * Features:
 *   - Stores objects (GObject) and lights (PointLight)
 *   - Add, remove, and access objects and lights safely
 *   - Provides object and light counts
 *   - Optional read-only access to all objects and lights
 *
 * Usage:
 *   Scene scene = new Scene();
 *   scene.AddObject(new Sphere(...));
 *   scene.AddLight(new PointLight(...));
 *   int count = scene.ObjectCount;
 *   var obj = scene.GetObjectAt(0);
 *
 * Author: Dan Munteanu
 * Date: 28-Sep-2025
 */

namespace Unilight
{
    public class Scene
    {
        private readonly List<GObject> objects = new();
        private readonly List<PointLight> lights = new();

        // --- Objects ---

        public void AddObject(GObject obj) => objects.Add(obj);
        public void RemoveObjectAt(int idx)
        {
            if (idx >= 0 && idx < objects.Count)
                objects.RemoveAt(idx);
        }
        public void ClearObjects() => objects.Clear();
        public int ObjectCount => objects.Count;
        public GObject? GetObjectAt(int idx) => (idx >= 0 && idx < objects.Count) ? objects[idx] : null;

        public int IndexOfObject(GObject obj) => objects.IndexOf(obj);

        // --- Lights ---

        public void AddLight(PointLight light) => lights.Add(light);
        public void RemoveLightAt(int idx)
        {
            if (idx >= 0 && idx < lights.Count)
                lights.RemoveAt(idx);
        }
        public void ClearLights() => lights.Clear();
        public int LightCount => lights.Count;
        public PointLight? GetLightAt(int idx) => (idx >= 0 && idx < lights.Count) ? lights[idx] : null;

        // Optional: expose read-only lists if needed
        public IReadOnlyList<GObject> Objects => objects;
        public IReadOnlyList<PointLight> Lights => lights;
    }
}
