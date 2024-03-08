#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.Threading.Tasks;

public class EScreenshotTaker : ScriptableObject
{
    [MenuItem("Escripts/Take Screenshot #s")] 
    private static async void TakeScreenshot()
    {
        string screenshotsDirectory = "Assets/Screenshots";

        if (!System.IO.Directory.Exists(screenshotsDirectory))
        {
            System.IO.Directory.CreateDirectory(screenshotsDirectory);
        }

        string path = screenshotsDirectory + "/Screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";
        ScreenCapture.CaptureScreenshot(path);
        Debug.Log("Screenshot saved: " + path);

        await Task.Delay(1000);
        AssetDatabase.Refresh();
        Debug.Log("Asset Database refreshed.");
    }
}
#endif