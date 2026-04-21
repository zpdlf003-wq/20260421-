using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float speed_x = 5.0f;
    void Update()
        //Updatev() 매 프레임 마다 실행
    {
        transform.Translate(Vector3.right * speed_x * Time.deltaTime);
    }
}
