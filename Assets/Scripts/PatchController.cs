using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatchController : MonoBehaviour
{
    public InitialUI InitialUI { get; set; }

    private void Awake()
    {
        this.InitialUI = new InitialUI
        {
            Prefab = this.gameObject,
            InitialPosition = new Vector2(-8.5f, 4.5f),
            Matter = PrimitiveType.Cube, 
            PatchCount = new int[] {10, 18}
        };
    }

    void Start()
    {
        this.InitialUI.Generate();

        //InitialUI.Patches[0].GetComponent<Renderer>().material.color = Color.blue;

        //this.InitialUI.GetPatch(5, 2).GetComponent<Renderer>().material.color =
        //    Color.blue;
    }
}
