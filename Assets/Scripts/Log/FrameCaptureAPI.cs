using System;
using UnityEngine;

namespace Log
{
    public class FrameCaptureAPI
    {
        public void SaveImageToFile(String path, int frameCount)
        {
            // Both Eye
            String imageFileName = "Frame-" + frameCount + "-.png";
            ScreenCapture.CaptureScreenshot(path + "/" + imageFileName,
                ScreenCapture.StereoScreenCaptureMode.BothEyes);
        }
    }
}