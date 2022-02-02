using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
	private static PoolPart[] _pools;
	private static GameObject _objectsParent;

	public static void Initialize(PoolPart[] newPools)
	{
		_pools = newPools;
		_objectsParent = new GameObject();
		_objectsParent.name = "Pool";
		for (int i = 0; i < _pools.Length; i++)
		{
			if (_pools[i].Prefab != null)
			{
				_pools[i].Pool = new ObjectPooling();
				_pools[i].Pool.Initialize(_pools[i].Count, _pools[i].Prefab, _objectsParent.transform);
			}
		}
	}

	public static GameObject GetObject(string name, Vector3 position, Quaternion rotation)
	{
		GameObject result = null;
		if (_pools != null)
		{
			for (int i = 0; i < _pools.Length; i++)
			{
				if (string.Compare(_pools[i].Name, name) == 0)
				{ 
					result = _pools[i].Pool.GetObject().gameObject; 
					result.transform.position = position;
					result.transform.rotation = rotation;
					result.SetActive(true); 
					return result;
				}
			}
		}
		return result; 
	}
}
public struct PoolPart
{
	public string Name; 
	public PoolObject Prefab; 
	public int Count; 
	public ObjectPooling Pool; 
}
