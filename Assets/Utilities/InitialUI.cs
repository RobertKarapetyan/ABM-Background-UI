using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using UnityEngine;

public class InitialUI 
{
    public GameObject Prefab { get; set; }
    public PrimitiveType Matter { get; set; }
    public List<GameObject> Patches { get; set; }
    public Vector2 InitialPosition { get; set; }
    public int[] PatchCount { get; set; }

    public InitialUI()
    {
        this.Patches = new List<GameObject>();
    }

    public void Generate()
    {
        for (int i = 0; i < PatchCount[0]; i++)
        {
            for (int j = 0; j < PatchCount[1]; j++)
            {
                GameObject c = GameObject.CreatePrimitive(PrimitiveType.Cube);
                c.transform.position = new Vector3(InitialPosition.x + (float)j,
                    InitialPosition.y - (float)i, 0);
                c.name = "Patch" + i.ToString() + "_" + j.ToString();
                c.transform.parent = Prefab.transform;

                Patches.Add(c);
            }
        }
    }

    public GameObject GetPatch(int x, int y)
    {
        return this.Patches[this.PatchCount[1] * y + x];
    }
}

