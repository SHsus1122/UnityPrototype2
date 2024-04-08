using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    // 정해진 갯수 만큼만 생성해서 전역에서 사용하기 위해서 public 과 static 을 사용합니다.
    public static ObjectPooler SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;

    void Awake()
    {
        SharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Loop through list of pooled objects,deactivating them and adding them to the list 
        // 시작하면 풀링 오브젝트를 생성해줍니다. 지정해준 사이즈 만큼 반복문을 통해 생성합니다.
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            // 지정해놓은 프리팹에 해당하는 풀링 오브젝트를 생성하고 동시에 비활성화 시킵니다.
            // 이후 해당 오브젝트를 리스트에 추가해주고 편하게 관리하기 위해서 해당 오브젝트의 부모의 자식으로 귀속시킵니다.
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
            obj.transform.SetParent(this.transform); // set as children of Spawn Manager
        }
    }

    public GameObject GetPooledObject()
    {
        // For as many objects as are in the pooledObjects list
        // 풀링 오브젝트를 가져오는 방법으로 오브젝트 풀링의 사이즈 만큼 반복문을 돌립니다.
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            // if the pooled objects is NOT active, return that object 
            // 풀링 오브젝트를 가져올 때는 리스트의 가장 앞에 있는 녀석들부터 비활성화 된 녀석들을 가져와서 반환합니다.
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        // otherwise, return null   
        return null;
    }

}
