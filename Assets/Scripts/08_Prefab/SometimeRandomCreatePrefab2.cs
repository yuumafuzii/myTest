using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ときどき、範囲内にランダムにプレハブを作る
public class SometimeRandomCreatePrefab2 : MonoBehaviour
{

    public GameObject newPrefab; //[作るプレハブ]
    public float intervalSec = 1; //[作成間隔（秒）]
    public int newz = -5; //[描画順]


    void Start()
    {
        //指定秒ごとに、CreatePrefabを繰り返し実行する予約
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }
    void CreatePrefab()
    {
        //このオブジェクトの範囲内にランダムに
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;
        Vector3 newPos = transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);
        newPos.z = newz;
        //プレハブを作ってその一の手前に表示する
        GameObject newGameobject = Instantiate(newPrefab) as GameObject;
        newGameobject.transform.position = newPos;
    }
}