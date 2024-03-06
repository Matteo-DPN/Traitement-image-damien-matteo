using static System.Net.Mime.MediaTypeNames;

namespace Image_Morganico_Dupin
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAggrandissement()
        {
            MyImage im1 = new MyImage("mario.bmp");
            im1.Agrandir(4);
        }
        [TestMethod]
        public void TestMethodRetrecir()
        {
            MyImage im1 = new MyImage("mario.bmp");
            im1.Retrecir(4);
        }
        [TestMethod]
        public void TestMethodNuance()
        {
            MyImage im1 = new MyImage("mario.bmp");
            im1.NuanceGris();
        }
        [TestMethod]
        public void TestMethodSteganographie()
        {
            MyImage im1 = new MyImage("mario.bmp");
            im1.Steganographie("lena.bmp");
            im1.DeSteganographie();
        }
        [TestMethod]
        public void TestMethodMiroir()
        {
            MyImage im1 = new MyImage("mario.bmp");
            im1.Mirroir();
        }
        [TestMethod]
        public void TestMethodRotation()
        {
            MyImage im1 = new MyImage("mario.bmp");
            im1.Rotation(45);
        }
        [TestMethod]
        public void TestMethodHistogramme()
        {
            MyImage im1 = new MyImage("mario.bmp");
            im1.histogramme();
        }
    }
}