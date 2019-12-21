using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    private Vector3 a = new Vector3(0, 0, 0);
    private Vector3 b = new Vector3(10, 10, 10);

    public Color red = Color.red;
    public Color blue = Color.blue;
    public Color newColor;

    private void Start()
    {
        //認識插值Lerp
        print(Mathf.Lerp(0, 10, 0.5f));
        print(Vector3.Lerp(a, b, 0.5f));
        newColor = Color.Lerp(red, blue, 0.5f);
    }
}
