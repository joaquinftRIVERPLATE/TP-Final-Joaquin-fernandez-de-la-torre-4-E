using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comida : MonoBehaviour
{
    public GameObject[] Food;
    public int Currentindex = -1;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Currentindex++;
            if (Currentindex < Food.Length)
            {
                DeactivateAll();
                ActivateByIndex(Currentindex);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Currentindex--;
            if (Currentindex > 0)
            {
                DeactivateAll();
                ActivateByIndex(Currentindex);
            }
        }
    }







            void DeactivateAll()
            {
                for (int i = 0; i < Food.Length; i++)
                {
                    Food[i].SetActive(false);
                }
            }
            void ActivateAll()
            {
                for (int i = 0; i < Food.Length; i++)
                {
                    Food[i].SetActive(true);
                }
            }
            void ActivateByIndex(int index)
            {
                Food[index].SetActive(true);
            }
            void activateByIndex(int index)
            {
                Food[index].SetActive(true);
            }
  
}
