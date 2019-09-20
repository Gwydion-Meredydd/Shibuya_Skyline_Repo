
using UnityEngine;

public class Bullet_Time : MonoBehaviour {

   // public float slowdownFactor = 0.05f;
   // public float slowdownLength = 2f;

    void Update()
    {
        //Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
       // Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }
    public void Do_Bullet_Time()
    {
       // Time.timeScale = slowdownFactor;
       // Time.fixedDeltaTime = Time.timeScale * .02f;
    }
}
