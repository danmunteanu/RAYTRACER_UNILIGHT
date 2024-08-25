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

        private Scene mScene = null;
        private Raytracer mRaytracer = null;
        private RaytracerThread mRenderThread = null;

        //private EditorCreator editorCreator = new EditorCreator ();

        public Controller()
        {
        }

        public void setScene(Scene s)
        {
            this.mScene = s;
        }

        public void setRaytracer(Raytracer r)
        {
            this.mRaytracer = r;
        }

        public void handleNewScene()
        {
            mScene.clearLights();
            mScene.clearObjects();
            mScene.setAmbientColor(Color.black);
        }

        public void handleCloseScene()
        {
            mScene.clearLights();
            mScene.clearObjects();
            mScene.setAmbientColor(Color.black);
            mScene.setAmbientColor(Color.black);
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
            if (!mRenderThread.MustRender)
            {
                mRenderThread.MustRender = true;
            }
        }

        public void handleStopRender()
        {
            if (!mRaytracer.isStopRender())
            {
                mRaytracer.setStopRender(true);
            }
        }

        public List<PointLight> handleFillLights()
        {
            if (mScene == null)
            {
                return null;
            }
            List<PointLight> lights = mScene.getLights();
            return lights;
        }

        public void handleAddLight()
        {
            mScene.addLight(new PointLight());
        }

        public void handleRemoveLight(int index)
        {
            mScene.removeLight(index);
        }

        public void handleRemoveObject(int index)
        {
            mScene.removeObject(index);
        }

        public List<Geobject> handleFillObjects()
        {
            if (mScene == null)
            {
                return null;
            }
            List<Geobject> objects = mScene.getObjects();
            return objects;
        }



    }

}