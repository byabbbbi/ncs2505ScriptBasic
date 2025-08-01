using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject target;
    int sum;

    void Start()
    {

        sum = 0;
        // Invoke ("SpawnObject", 2);
        InvokeRepeating("SpawnObject", 2, 1);
    }

    void Update()
    {
        if (sum >= 10)
        {
            CancelInvoke("SpawnObject");
        }
    }
    void SpawnObject()
    {
        // int(정수형)와 float(실수형)는 
        // //random에서 max값을 지정할 때
        // 포함인지 불포함인지 잘 봐야한다.
        int i = Random.Range(-5, 5);
        float y = Random.Range(-5, 5);

        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(-5.0f, 5.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
        sum++;
    }
}
