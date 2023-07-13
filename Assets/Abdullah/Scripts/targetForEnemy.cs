using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetForEnemy : MonoBehaviour
{
    [SerializeField] float distance = 3f; // Olu�turulan noktan�n objeden olan uzakl���
    public GameObject pointObject;
    [SerializeField] Enemy_AI Enemy_AI;



    private void Start()
    {
      
    }

    public void GenerateRandomPoint(GameObject enemy)
    {
 
        if (Vector3.Distance(transform.position, enemy.transform.position) < Enemy_AI.distanceEnemy)
        {
            // Objeye olan uzakl�k vekt�r�
            Vector3 offset = Random.onUnitSphere * distance;

            // Olu�turulan noktan�n konumu
            Vector3 randomPoint = transform.position + offset;
            randomPoint.y = enemy.transform.position.y; // Y koordinat�n� s�f�r olarak ayarla

            // Noktay� yerle�tir
            pointObject = new GameObject("EmptyObject");
            pointObject.transform.position = randomPoint;

        }
    }
}
