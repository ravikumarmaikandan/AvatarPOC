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
            _patientAvatarRenderer.Move(125.669600f, 39.137896f);
            _patientAvatarRenderer.Curve(125.669600f, 39.137896f, 151.063180f, 1.737438f, 173.294600f, 14.947430f);
            _patientAvatarRenderer.Curve(244.680190f, 57.365015f, 143.053470f, 148.743970f, 122.645790f, 162.430180f);
            _patientAvatarRenderer.Curve(89.528053f, 139.656070f, 13.354237f, 56.136838f, 74.038051f, 15.249811f);
            _patientAvatarRenderer.Curve(93.890739f, 1.873634f, 125.669600f, 39.137896f, 125.669600f, 39.137896f);
            //   p.close();


            //_patientAvatarRenderer.Path.AddBezier(125.669600f, 39.137896f,
            //    125.669600f, 39.137896f,
            //    151.063180f, 1.737438f,
            //    173.294600f, 14.947430f);

            //_patientAvatarRenderer.Path.AddBezier(173.294600f, 14.947430f,
            //    244.680190f, 57.365015f,
            //    143.053470f, 148.743970f,
            //    122.645790f, 162.430180f);

            //_patientAvatarRenderer.Path.AddBezier(122.645790f, 162.430180f,
            //    89.528053f, 139.656070f,
            //    13.354237f, 56.136838f,
            //    74.038051f, 15.249811f);

            //_patientAvatarRenderer.Path.AddBezier(74.038051f, 15.249811f,
            //    93.890739f, 1.873634f,
            //125.669600f, 39.137896f,
            //125.669600f, 39.137896f);
        }

        private void PaintPath_path519_s0()
        {   // Label: stroke of Max
            ////    p.move(125.770259,39.052054);
            //   p.curve(104.565545,14.187160,87.261074,6.180996,73.964130,15.140099);
            //   p.curve(13.153224,56.112757,89.440560,139.756456,122.570830,162.539185);
            //   p.curve(143.134946,148.848616,244.902366,57.343149,173.362178,14.833701);
            //   p.curve(158.478648,5.989853,142.508352,14.101746,125.560152,39.063585);
            //   p.close();
            //    p.move(125.779048,39.212207);
            //   p.curve(142.688954,14.306769,158.468658,6.291685,173.227022,15.061159);
            //   p.curve(244.458014,57.386881,142.971994,148.639324,122.572106,162.320309);
            //   p.curve(89.615546,139.555684,13.555250,56.160919,74.111972,15.359523);
            //   p.curve(87.285279,6.483723,104.401840,14.402948,125.568941,39.223738);
            //   p.close();

        }

        private void PaintPath_path517_f1()
        {   // Label: filling of Min
            ////    p.move(125.669600,61.060515);
            //   p.curve(125.669600,61.060515,144.614690,13.741686,168.002930,24.774811);
            //   p.curve(213.628830,46.298285,122.645790,161.602190,122.645790,161.602190);
            //   p.curve(122.645790,161.602190,40.084624,46.050825,82.580313,24.774811);
            //   p.curve(103.985870,14.057841,125.669600,61.060515,125.669600,61.060515);
            //   p.close();

        }

        private void PaintPath_path517_s1()
        {   // Label: stroke of Min
            ////    p.move(125.789725,61.005098);
            //   p.curve(111.321551,29.643204,96.869306,17.472896,82.521088,24.656517);
            //   p.curve(54.091850,38.889981,67.484348,84.626625,122.538151,161.679098);
            //   p.curve(183.419406,84.796616,198.582651,39.054157,168.059372,24.655164);
            //   p.curve(152.389726,17.263194,138.188914,29.435316,125.546786,61.011344);
            //   p.close();
            //    p.move(125.792414,61.109686);
            //   p.curve(138.410406,29.593942,152.431814,17.575594,167.946488,24.894458);
            //   p.curve(198.257742,39.193430,183.182894,84.669224,122.541936,161.520242);
            //   p.curve(67.725677,84.509268,54.407857,39.027659,82.639538,24.893105);
            //   p.curve(96.832063,17.787433,111.106009,29.807594,125.549475,61.115932);
            //   p.close();

        }

        private void PaintPath_path523_f2()
        {   // Label: filling of Time
            ////    p.move(102.339860,102.918580);
            //   p.curve(113.002950,40.010533,115.976120,90.017506,125.970820,94.936682);
            //   p.curve(129.258830,96.554968,134.848630,84.806947,138.159820,87.655557);
            //    p.line(152.681790,101.593800);

        }

        private void PaintPath_path523_s2()
        {   // Label: stroke of Time
            //
        }

        private void Paint_path519_f0(PaintAvatarInfo p) //Path: filling of Max
        {
            //_patientAvatarRenderer.FillColor = Color.FromArgb(0xe);
            _patientAvatarRenderer.FillColor = Color.Red;
            PaintPath_path519_f0();
            _patientAvatarRenderer.Fill(p);

        }
        //----------------------------------------

        private void Paint_path519_s0(PaintAvatarInfo p) //Path: stroke of Max
        {
            _patientAvatarRenderer.FillColor = Color.FromArgb(0x000000);
            PaintPath_path519_s0();
            _patientAvatarRenderer.Fill(p);

        }
        //----------------------------------------

        //Group: Max
        private void Paint_path519(PaintAvatarInfo p)
        {
            Paint_path519_f0(p);// filling of Max
            //Paint_path519_s0(p);// stroke of Max
        }
        //----------------------------------------

        private void Paint_path517_f1(PaintAvatarInfo p) //Path: filling of Min
        {
            _patientAvatarRenderer.FillColor = Color.FromArgb(0xff0000);
            PaintPath_path517_f1();
            _patientAvatarRenderer.Fill(p);

        }
        //----------------------------------------

        private void Paint_path517_s1(PaintAvatarInfo p) //Path: stroke of Min
        {
            _patientAvatarRenderer.FillColor = Color.FromArgb(0x000000);
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
            _patientAvatarRenderer.FillColor = Color.FromArgb(0xe);
            PaintPath_path523_f2();
            _patientAvatarRenderer.Fill(p);

        }
        //----------------------------------------

        private void Paint_path523_s2(PaintAvatarInfo p) //Path: stroke of Time
        {
            _patientAvatarRenderer.FillColor = Color.FromArgb(0x000000);
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
            //Paint_path517(p);// Min
            //Paint_path523(p);// Time
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