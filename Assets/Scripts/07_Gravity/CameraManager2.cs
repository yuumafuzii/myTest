using UnityEngine;

//カメラが動くものを追いかける
public class CameraManager2 : MonoBehaviour
{

    public GameObject player; //[プレイヤー]
    public Vector2 offset; //[オフセット]
    public float xlimit = 0; //[x軸制限]
    public bool followHOnly = true; //[水平追跡のみ]
    public bool smoothFollow = false;  //[滑らかフラグ]
    public float smoothSpeed = 4f; //[滑らか度]


    void LateUpdate()
    {
        if (player == null) return; //プレイヤーがいないなら終了
        Vector3 PlayerPos = player.transform.position;
        Vector3 desiredPos;
        float vx = PlayerPos.x + offset.x;
        float vz = transform.position.z;
        if (vx < xlimit) vx = xlimit;
        if (followHOnly)
        {
            desiredPos = new Vector3(vx, transform.position.y, vz);
        }
        else
        {
            desiredPos = new Vector3(vx, PlayerPos.y + offset.y, vz);
            desiredPos = new Vector3(vx,)
        }
    }
}