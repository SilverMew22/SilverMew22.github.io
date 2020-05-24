using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    public GameObject tree;

    void Start()
    {
            for (int xPos = 0; xPos <= 10; xPos++)
            {
            
            {
                Instantiate(tree, new Vector3(xPos * 2f+10f,  2f, 1), Quaternion.identity);
            }
            }


        //for (int xPos = 0; xPos <= 10; xPos++)
        //{
            
        //    {
        //        Instantiate(tree, new Vector3(xPos * 2f + 5f, 2f, 1), Quaternion.identity);
        //    }
        //}

       
        
        //    for (int zPos = 0; zPos < 10; zPos++)
        //    {
        //        Instantiate(tree, new Vector3(1, 2f, zPos * 2f + 5f), Quaternion.identity);
        //    }
        

        
        
        //    for (int zPos = 0; zPos < 10; zPos++)
        //    {
        //        Instantiate(tree, new Vector3(1, 2f, zPos * 2f + 5f), Quaternion.identity);
        //    }
        }
    }

    

