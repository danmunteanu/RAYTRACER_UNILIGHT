using LibUnilight;

namespace UnilightRaytracer
{

    public class Controller
    {
        public class SettingsInfo
        {
            public bool globalReflection = false;
            public bool computeSpecular = true;
            public bool computeDiffuse = true;
            public bool computeAmbient = true;
            public bool computeFog = true;
            public int depth = 1;
            public Vector eye = null;
            public Vector lookAt = null;
            public float width = 0;
            public float height = 0;
        }

        private Scene scene = null;
        private Raytracer rt = null;
        private RaytracerThread rtThread = null;

        //private EditorCreator editorCreator = new EditorCreator ();

        public Controller()
        {
        }

        public void setScene(Scene s)
        {
            this.scene = s;
        }

        public void setRaytracer(Raytracer r)
        {
            this.rt = r;
        }

        public void handleNewScene()
        {
            scene.clearLights();
            scene.clearObjects();
            scene.setAmbientColor(Color.black);
        }

        public void handleCloseScene()
        {
            scene.clearLights();
            scene.clearObjects();
            scene.setAmbientColor(Color.black);
            scene.setAmbientColor(Color.black);
        }

        /*    
        public void handleAmbientChanged(java.awt.Color col)
        {
            scene.setAmbientColor(new model.Color(col.getRed() / 255, col.getGreen() / 255, col.getBlue() / 255));
        }

        public void handleOpenScene(String dataFile) throws Exception
            {
                SerializationStorage sto = SerializationStorage.getInstance();
                sto.setDataFile(dataFile);
                scene = sto.load ();
                rt.setScene(scene);
            }*/

        /*    public void handleFogColorChanged(java.awt.Color col)
            {
                rt.setFogCol(new model.Color (col.getRed() / 255, col.getGreen() / 255, col.getBlue() / 255));
            }*/

        /*public void handleSaveScene( String dataFile) throws Exception
        {
            SerializationStorage sto = SerializationStorage.getInstance( );
            sto.setDataFile( dataFile );
            sto.save( scene );
        }*/

        public void handleRender()
        {
            if (!rtThread.MustRender)
            {
                rtThread.MustRender = true;
            }
        }

        public void handleStopRender()
        {
            if (!rt.isStopRender())
            {
                rt.setStopRender(true);
            }
        }

        public List<PointLight> handleFillLights()
        {
            if (scene == null)
            {
                return null;
            }
            List<PointLight> lights = scene.getLights();
            return lights;
        }

        public void handleAddLight()
        {
            scene.addLight(new PointLight());
        }

        public void handleRemoveLight(int index)
        {
            scene.removeLight(index);
        }

        public void handleRemoveObject(int index)
        {
            scene.removeObject(index);
        }

        public List<Geobject> handleFillObjects()
        {
            if (scene == null)
            {
                return null;
            }
            List<Geobject> objects = scene.getObjects();
            return objects;
        }

        public SettingsInfo handleFillSettings()
        {
            SettingsInfo info = new SettingsInfo();
            info.globalReflection = rt.GlobalReflection;
            info.computeSpecular = rt.ComputeSpecular;
            info.computeDiffuse = rt.ComputeDiffuse;
            info.computeAmbient = rt.ComputeAmbient;
            info.computeFog = rt.ComputeFog;
            info.depth = rt.getMaxTraceDepth();

            Camera cam = rt.getCamera();
            info.eye = cam.getEye();
            info.lookAt = cam.getLookAt();
            info.width = cam.getViewportWidth();
            info.height = cam.getViewportHeight();
            return info;
        }

        public void updateSettings(SettingsInfo info)
        {
            if (!rtThread.MustRender)
            {
                rt.setMaxTraceDepth(info.depth);
                rt.ComputeAmbient = info.globalReflection;
                rt.ComputeAmbient = info.computeSpecular;
                rt.ComputeAmbient = info.computeDiffuse;
                rt.ComputeAmbient = info.computeAmbient;
                rt.ComputeAmbient = info.computeFog;

                Camera cam = rt.getCamera();
                cam.setEye(info.eye);
                cam.setLookAt(info.lookAt);
                cam.setViewportWidth(info.width);
                cam.setViewportHeight(info.height);
            }
        }

        public RaytracerThread getRaytracerThread()
        {
            return rtThread;
        }

        public void setRaytracerThread(RaytracerThread rtThread)
        {
            this.rtThread = rtThread;
        }
    }

}