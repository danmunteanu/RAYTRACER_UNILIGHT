namespace Unilight
{
    public class Scene
    {
        private List<GObject> mObjects = new List<GObject>();
        private List<PointLight> mLights = new List<PointLight>();

        public void AddObject(GObject obj)
        {
            mObjects.Add(obj);
        }

        public void RemoveObjectAt(int idx)
        {
            mObjects.RemoveAt(idx);
        }

        public int CountObjects()
        {
            return mObjects.Count();
        }
        public void ClearObjects()
        {
            mObjects.Clear();
        }

        public GObject GetObjectAt(int idx)
        {
            if (idx < 0 || idx >= mObjects.Count) {
                return null;
            }
            return mObjects.ElementAt(idx);
        }

        public void AddLight(PointLight l)
        {
            mLights.Add(l);
        }

        public void RemoveLightAt(int index)
        {
            mLights.RemoveAt(index);
        }

        public int CountLights()
        {
            return mLights.Count;
        }

        public PointLight GetLightAt(int i)
        {
            if (i < 0 || i >= mLights.Count) {
                return null;
            }
            return mLights.ElementAt(i);
        }
        public void ClearLights()
        {
            mLights.Clear();
        }

    }

}