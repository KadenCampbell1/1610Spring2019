using UnityEngine;

//Integrated from school
//Not being used
[CreateAssetMenu]
public class BackgroundValues : ScriptableObject
{
    public bool backgroundMoving;
    public int backgroundColorInt;
    public bool originalColor;
    public float originalBlue;
    public float originalGreen;
    public float originalRed;
    
    
    public enum MyBackgroundName
    {
        Foreground,
        Midground,
        Background
    }
    
    public MyBackgroundName myName;
}
