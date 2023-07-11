using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetForEnemy : MonoBehaviour
{
    [SerializeField] float distance = 3f; // Olu�turulan noktan�n objeden olan uzakl���
    public GameObject pointObject; 


    private void Start()
    {
      
    }

    public void GenerateRandomPoint()
    {
     
        // Objeye olan uzakl�k vekt�r�
        Vector3 offset = Random.onUnitSphere * distance;

        // Olu�turulan noktan�n konumu
        Vector3 randomPoint = transform.position + offset;
        randomPoint.y = 0f; // Y koordinat�n� s�f�r olarak ayarla

        // Noktay� yerle�tir
        pointObject = new GameObject("EmptyObject");
        pointObject.transform.position = randomPoint;


    }
}
