#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
// generated file
// from .\simple.svg
// using .\csharp.xml
// by C:\Users\dep05119\Documents\Code\svgcompiler\svgconverter.exe
#endregion

using System.Drawing;
using System.Drawing.Drawing2D;

namespace Philips.PIC.CommonControls.Generated
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("C__Users_dep05119_Documents_Code_svgcompiler_svgconverter_exe", "1")]
	public class PaintAvatar
    {
        private readonly PatientAvatarRenderer _patientAvatarRenderer = new PatientAvatarRenderer();

	
        private void SetPathData_path519(IRenderPath path)
        {   // Label: Max
		    path.Start();
            path.Move(125.669600f,39.137896f);
            path.Cubic(125.669600f,39.137896f,217.292570f,-21.147492f,239.523990f,-7.937500f);
            path.Cubic(310.909580f,34.480085f,143.053470f,148.743970f,122.645790f,162.430180f);
            path.Cubic(89.528053f,139.656070f,13.354237f,56.136838f,74.038051f,15.249811f);
            path.Cubic(93.890739f,1.873634f,125.669600f,39.137896f,125.669600f,39.137896f);
            path.Close();

        }

	
        private void SetPathData_path517(IRenderPath path)
        {   // Label: Min
		    path.Start();
            path.Move(125.669600f,61.060515f);
            path.Cubic(125.669600f,61.060515f,130.395950f,41.056632f,153.784190f,52.089757f);
            path.Cubic(199.410090f,73.613231f,122.645790f,161.602190f,122.645790f,161.602190f);
            path.Cubic(122.645790f,161.602190f,40.084624f,46.050825f,82.580313f,24.774811f);
            path.Cubic(103.985870f,14.057841f,125.669600f,61.060515f,125.669600f,61.060515f);
            path.Close();

        }

	
        private void SetPathData_path523(IRenderPath path)
        {   // Label: Time
		    path.Start();
            path.Move(102.339860f,102.918580f);
            path.Cubic(113.002950f,40.010533f,115.976120f,90.017506f,125.970820f,94.936682f);
            path.Cubic(129.258830f,96.554968f,134.848630f,84.806947f,138.159820f,87.655557f);
            path.Line(152.681790f,101.593800f);

        }

	
        private void SetPathData_path1(IRenderPath path)
        {   // Label: 
		    path.Start();
            path.Move(49.952675f,203.926645f);
            path.Cubic(63.695062f,203.926645f,74.835468f,199.152185f,74.835468f,193.262590f);
            path.Cubic(74.835468f,187.372995f,63.695062f,182.598535f,49.952675f,182.598535f);
            path.Cubic(36.210288f,182.598535f,25.069882f,187.372995f,25.069882f,193.262590f);
            path.Cubic(25.069882f,199.152185f,36.210288f,203.926645f,49.952675f,203.926645f);
            path.Close();

        }


        private void Paint_path519(PaintAvatarInfo p) //Path: Max
        {
            _patientAvatarRenderer.FillColor = 0x000000;
            SetPathData_path519(_patientAvatarRenderer);
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------


        private void Paint_path517(PaintAvatarInfo p) //Path: Min
        {
            _patientAvatarRenderer.FillColor = 0xff0000;
            SetPathData_path517(_patientAvatarRenderer);
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------


        private void Paint_path523(PaintAvatarInfo p) //Path: Time
        {
            _patientAvatarRenderer.FillColor = 0x000000;
            SetPathData_path523(_patientAvatarRenderer);
            _patientAvatarRenderer.Fill(p);
		   
        }
//----------------------------------------


        //Group: Heart
        private void Paint_g528(PaintAvatarInfo p)
        {
		    IRenderPath Min = new TemporaryRenderPath();
		    IRenderPath Max = new TemporaryRenderPath();
		    IRenderPath Time = new TemporaryRenderPath();
		    SetPathData_path519(Max);
		    SetPathData_path517(Min);
		    SetPathData_path523(Time);
			_patientAvatarRenderer.Interpolate(p, Min, Max, Time);
        }
        //----------------------------------------


        private void Paint_path1(PaintAvatarInfo p) //Path: 
        {
            _patientAvatarRenderer.FillColor = 0xff7f2a;
            SetPathData_path1(_patientAvatarRenderer);
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