	
#region Header
// copyright ...
// generated file
// from .\UIGeneraterFiles\simple.svg
// using .\UIGeneraterFiles\csharp.xml
// by D:\AvatarCodeGenerator\svgcompiler\svgconverter.exe
#endregion

using System.Drawing;
using System.Drawing.Drawing2D;

namespace AvatarPOC.Generated
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("D__AvatarCodeGenerator_svgcompiler_svgconverter_exe", "1")]
	public class PaintAvatar
    {
        private readonly PatientAvatarRenderer _patientAvatarRenderer = new PatientAvatarRenderer();
	
        private void PaintPath_path519_f0()
        {   // Label: filling of Max
		    _patientAvatarRenderer.Path = new GraphicsPath();
            _patientAvatarRenderer.Move(125.669600f,39.137896f);
            _patientAvatarRenderer.Curve(125.669600f,39.137896f,151.063180f,1.737438f,173.294600f,14.947430f);
            _patientAvatarRenderer.Curve(244.680190f,57.365015f,143.053470f,148.743970f,122.645790f,162.430180f);
            _patientAvatarRenderer.Curve(89.528053f,139.656070f,13.354237f,56.136838f,74.038051f,15.249811f);
            _patientAvatarRenderer.Curve(93.890739f,1.873634f,125.669600f,39.137896f,125.669600f,39.137896f);
//   p.close();

        }
	
        private void PaintPath_path519_s0()
        {   // Label: stroke of Max
		    _patientAvatarRenderer.Path = new GraphicsPath();
            _patientAvatarRenderer.Move(125.770259f,39.052054f);
            _patientAvatarRenderer.Curve(104.565545f,14.187160f,87.261074f,6.180996f,73.964130f,15.140099f);
            _patientAvatarRenderer.Curve(13.153224f,56.112757f,89.440560f,139.756456f,122.570830f,162.539185f);
            _patientAvatarRenderer.Curve(143.134946f,148.848616f,244.902366f,57.343149f,173.362178f,14.833701f);
            _patientAvatarRenderer.Curve(158.478648f,5.989853f,142.508352f,14.101746f,125.560152f,39.063585f);
//   p.close();
            _patientAvatarRenderer.Move(125.779048f,39.212207f);
            _patientAvatarRenderer.Curve(142.688954f,14.306769f,158.468658f,6.291685f,173.227022f,15.061159f);
            _patientAvatarRenderer.Curve(244.458014f,57.386881f,142.971994f,148.639324f,122.572106f,162.320309f);
            _patientAvatarRenderer.Curve(89.615546f,139.555684f,13.555250f,56.160919f,74.111972f,15.359523f);
            _patientAvatarRenderer.Curve(87.285279f,6.483723f,104.401840f,14.402948f,125.568941f,39.223738f);
//   p.close();

        }
	
        private void PaintPath_path517_f1()
        {   // Label: filling of Min
		    _patientAvatarRenderer.Path = new GraphicsPath();
            _patientAvatarRenderer.Move(125.669600f,61.060515f);
            _patientAvatarRenderer.Curve(125.669600f,61.060515f,144.614690f,13.741686f,168.002930f,24.774811f);
            _patientAvatarRenderer.Curve(213.628830f,46.298285f,122.645790f,161.602190f,122.645790f,161.602190f);
            _patientAvatarRenderer.Curve(122.645790f,161.602190f,40.084624f,46.050825f,82.580313f,24.774811f);
            _patientAvatarRenderer.Curve(103.985870f,14.057841f,125.669600f,61.060515f,125.669600f,61.060515f);
//   p.close();

        }
	
        private void PaintPath_path517_s1()
        {   // Label: stroke of Min
		    _patientAvatarRenderer.Path = new GraphicsPath();
            _patientAvatarRenderer.Move(125.789725f,61.005098f);
            _patientAvatarRenderer.Curve(111.321551f,29.643204f,96.869306f,17.472896f,82.521088f,24.656517f);
            _patientAvatarRenderer.Curve(54.091850f,38.889981f,67.484348f,84.626625f,122.538151f,161.679098f);
            _patientAvatarRenderer.Curve(183.419406f,84.796616f,198.582651f,39.054157f,168.059372f,24.655164f);
            _patientAvatarRenderer.Curve(152.389726f,17.263194f,138.188914f,29.435316f,125.546786f,61.011344f);
//   p.close();
            _patientAvatarRenderer.Move(125.792414f,61.109686f);
            _patientAvatarRenderer.Curve(138.410406f,29.593942f,152.431814f,17.575594f,167.946488f,24.894458f);
            _patientAvatarRenderer.Curve(198.257742f,39.193430f,183.182894f,84.669224f,122.541936f,161.520242f);
            _patientAvatarRenderer.Curve(67.725677f,84.509268f,54.407857f,39.027659f,82.639538f,24.893105f);
            _patientAvatarRenderer.Curve(96.832063f,17.787433f,111.106009f,29.807594f,125.549475f,61.115932f);
//   p.close();

        }
	
        private void PaintPath_path523_f2()
        {   // Label: filling of Time
		    _patientAvatarRenderer.Path = new GraphicsPath();
            _patientAvatarRenderer.Move(102.339860f,102.918580f);
            _patientAvatarRenderer.Curve(113.002950f,40.010533f,115.976120f,90.017506f,125.970820f,94.936682f);
            _patientAvatarRenderer.Curve(129.258830f,96.554968f,134.848630f,84.806947f,138.159820f,87.655557f);
//    p.line(152.681790,101.593800);

        }
	
        private void PaintPath_path523_s2()
        {   // Label: stroke of Time
		    _patientAvatarRenderer.Path = new GraphicsPath();

        }

        private void Paint_path519_f0(PaintAvatarInfo p) //Path: filling of Max
        {
            _patientAvatarRenderer.FillColor = Color.Red;//Color.FromArgb(0xe);
            PaintPath_path519_f0();
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------

        private void Paint_path519_s0(PaintAvatarInfo p) //Path: stroke of Max
        {
            _patientAvatarRenderer.FillColor = Color.Red;//Color.FromArgb(0x000000);
            PaintPath_path519_s0();
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------

        //Group: Max
        private void Paint_path519(PaintAvatarInfo p)
        {
		    Paint_path519_f0(p);// filling of Max
		    Paint_path519_s0(p);// stroke of Max
        }
        //----------------------------------------

        private void Paint_path517_f1(PaintAvatarInfo p) //Path: filling of Min
        {
            _patientAvatarRenderer.FillColor = Color.Red;//Color.FromArgb(0xff0000);
            PaintPath_path517_f1();
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------

        private void Paint_path517_s1(PaintAvatarInfo p) //Path: stroke of Min
        {
            _patientAvatarRenderer.FillColor = Color.Red;//Color.FromArgb(0x000000);
            PaintPath_path517_s1();
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------

        //Group: Min
        private void Paint_path517(PaintAvatarInfo p)
        {
		    Paint_path517_f1(p);// filling of Min
		    Paint_path517_s1(p);// stroke of Min
        }
        //----------------------------------------

        private void Paint_path523_f2(PaintAvatarInfo p) //Path: filling of Time
        {
            _patientAvatarRenderer.FillColor = Color.Red;//Color.FromArgb(0xe);
            PaintPath_path523_f2();
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------

        private void Paint_path523_s2(PaintAvatarInfo p) //Path: stroke of Time
        {
            _patientAvatarRenderer.FillColor = Color.Red;//Color.FromArgb(0x000000);
            PaintPath_path523_s2();
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------

        //Group: Time
        private void Paint_path523(PaintAvatarInfo p)
        {
		    Paint_path523_f2(p);// filling of Time
		    Paint_path523_s2(p);// stroke of Time
        }
        //----------------------------------------

        //Group: Heart
        private void Paint_g528(PaintAvatarInfo p)
        {
		    Paint_path519(p);// Max
		    Paint_path517(p);// Min
		    Paint_path523(p);// Time
        }
        //----------------------------------------

        //Group: Ebene 1
        private void Paint_layer1(PaintAvatarInfo p)
        {
		    Paint_g528(p);// Heart
        }
        //----------------------------------------

        //Group: 
        private void Paint_svg515(PaintAvatarInfo p)
        {
		    Paint_layer1(p);// Ebene 1
        }
        //----------------------------------------
		 

        public void PaintSVG(PaintAvatarInfo p)
        {
			Paint_svg515(p);
        }
    }
}