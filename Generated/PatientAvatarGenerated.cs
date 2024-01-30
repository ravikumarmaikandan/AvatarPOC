#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
// generated file
// from .\UIGeneraterFiles\simple.svg
// using .\UIGeneraterFiles\csharp.xml
// by D:\AvatarCodeGenerator\svgcompiler\svgconverter.exe
#endregion

using System.Drawing;
using System.Drawing.Drawing2D;

namespace Philips.PIC.CommonControls.Generated
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("D__AvatarCodeGenerator_svgcompiler_svgconverter_exe", "1")]
	public class PaintAvatar
    {
        private readonly PatientAvatarRenderer _patientAvatarRenderer = new PatientAvatarRenderer();

	
        private void PaintPath_path519_f0(PatientAvatarRenderer path)
        {   // Label: filling of Max
		    path.Start();
            path.Move(125.669600f,39.137896f);
            path.Cubic(125.669600f,39.137896f,151.063180f,1.737438f,173.294600f,14.947430f);
            path.Cubic(244.680190f,57.365015f,143.053470f,148.743970f,122.645790f,162.430180f);
            path.Cubic(89.528053f,139.656070f,13.354237f,56.136838f,74.038051f,15.249811f);
            path.Cubic(93.890739f,1.873634f,125.669600f,39.137896f,125.669600f,39.137896f);
            path.Close();

        }

	
        private void PaintPath_path519_s0(PatientAvatarRenderer path)
        {   // Label: stroke of Max
		    path.Start();
            path.Move(125.770259f,39.052054f);
            path.Cubic(104.565545f,14.187160f,87.261074f,6.180996f,73.964130f,15.140099f);
            path.Cubic(13.153224f,56.112757f,89.440560f,139.756456f,122.570830f,162.539185f);
            path.Cubic(143.134946f,148.848616f,244.902366f,57.343149f,173.362178f,14.833701f);
            path.Cubic(158.478648f,5.989853f,142.508352f,14.101746f,125.560152f,39.063585f);
            path.Close();
            path.Move(125.779048f,39.212207f);
            path.Cubic(142.688954f,14.306769f,158.468658f,6.291685f,173.227022f,15.061159f);
            path.Cubic(244.458014f,57.386881f,142.971994f,148.639324f,122.572106f,162.320309f);
            path.Cubic(89.615546f,139.555684f,13.555250f,56.160919f,74.111972f,15.359523f);
            path.Cubic(87.285279f,6.483723f,104.401840f,14.402948f,125.568941f,39.223738f);
            path.Close();

        }

	
        private void PaintPath_path517(PatientAvatarRenderer path)
        {   // Label: Min
		    path.Start();
            path.Move(125.669600f,61.060515f);
            path.Cubic(125.669600f,61.060515f,144.614690f,13.741686f,168.002930f,24.774811f);
            path.Cubic(213.628830f,46.298285f,122.645790f,161.602190f,122.645790f,161.602190f);
            path.Cubic(122.645790f,161.602190f,40.084624f,46.050825f,82.580313f,24.774811f);
            path.Cubic(103.985870f,14.057841f,125.669600f,61.060515f,125.669600f,61.060515f);
            path.Close();

        }

	
        private void PaintPath_path523_f1(PatientAvatarRenderer path)
        {   // Label: filling of Time
		    path.Start();
            path.Move(102.339860f,102.918580f);
            path.Cubic(113.002950f,40.010533f,115.976120f,90.017506f,125.970820f,94.936682f);
            path.Cubic(129.258830f,96.554968f,134.848630f,84.806947f,138.159820f,87.655557f);
            path.Line(152.681790f,101.593800f);

        }

	
        private void PaintPath_path523_s1(PatientAvatarRenderer path)
        {   // Label: stroke of Time
		    path.Start();

        }

	
        private void PaintPath_path1(PatientAvatarRenderer path)
        {   // Label: 
		    path.Start();
            path.Move(49.952675f,203.926645f);
            path.Cubic(63.695062f,203.926645f,74.835468f,199.152185f,74.835468f,193.262590f);
            path.Cubic(74.835468f,187.372995f,63.695062f,182.598535f,49.952675f,182.598535f);
            path.Cubic(36.210288f,182.598535f,25.069882f,187.372995f,25.069882f,193.262590f);
            path.Cubic(25.069882f,199.152185f,36.210288f,203.926645f,49.952675f,203.926645f);
            path.Close();

        }


        private void Paint_path519_f0(PaintAvatarInfo p) //Path: filling of Max
        {
            _patientAvatarRenderer.FillColor = 0xe;
            PaintPath_path519_f0(_patientAvatarRenderer);
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------


        private void Paint_path519_s0(PaintAvatarInfo p) //Path: stroke of Max
        {
            _patientAvatarRenderer.FillColor = 0x000000;
            PaintPath_path519_s0(_patientAvatarRenderer);
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


        private void Paint_path517(PaintAvatarInfo p) //Path: Min
        {
            _patientAvatarRenderer.FillColor = 0xff0000;
            PaintPath_path517(_patientAvatarRenderer);
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------


        private void Paint_path523_f1(PaintAvatarInfo p) //Path: filling of Time
        {
            _patientAvatarRenderer.FillColor = 0xe;
            PaintPath_path523_f1(_patientAvatarRenderer);
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------


        private void Paint_path523_s1(PaintAvatarInfo p) //Path: stroke of Time
        {
            _patientAvatarRenderer.FillColor = 0x000000;
            PaintPath_path523_s1(_patientAvatarRenderer);
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------


        //Group: Time
        private void Paint_path523(PaintAvatarInfo p)
        {
		    Paint_path523_f1(p);// filling of Time
		    Paint_path523_s1(p);// stroke of Time
        }
        //----------------------------------------


        //Group: Heart
        private void Paint_g528(PaintAvatarInfo p)
        {
        }
        //----------------------------------------


        private void Paint_path1(PaintAvatarInfo p) //Path: 
        {
            _patientAvatarRenderer.FillColor = 0xff7f2a;
            PaintPath_path1(_patientAvatarRenderer);
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------


        //Group: Layer1
        private void Paint_layer1(PaintAvatarInfo p)
        {
		    Paint_g528(p);// Heart
		    Paint_path1(p);// 
        }
        //----------------------------------------


        //Group: 
        private void Paint_svg515(PaintAvatarInfo p)
        {
		    Paint_layer1(p);// Layer1
        }
        //----------------------------------------

		 

        public void PaintSVG(PaintAvatarInfo p)
        {
			Paint_svg515(p);
        }
    }
}