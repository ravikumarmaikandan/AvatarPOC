#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
// Author:      Ravikumar.Maikandan
// Date:        1/29/2024 2:39:11 PM
#endregion

using System.Drawing;

namespace AvatarPOC.Generated
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("AvatarPOC", "1")]
    public class PaintAvatar
    {
        private readonly PatientAvatarRenderer _patientAvatarRenderer = new PatientAvatarRenderer();
        public void Paint(PaintAvatarInfo avatarInfo)
        {

            _patientAvatarRenderer.FillColor = Color.Red;
            _patientAvatarRenderer.Ellipse(0, 0, avatarInfo.TopicInfo.Width, 100);
            _patientAvatarRenderer.Fill(avatarInfo);

        }
    }
}
