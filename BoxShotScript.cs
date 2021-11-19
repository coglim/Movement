using UnityEngine;

public class BoxShotScript : MonoBehaviour
{
  public GameObject enemy;

  void Start()
  {
      Instantiate(enemy, new Vector3 (0, 1, 0), Quaternion.identity);

  }
}
