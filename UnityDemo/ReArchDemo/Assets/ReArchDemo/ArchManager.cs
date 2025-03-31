using System.Collections;
using System.Collections.Generic;
using ReArch.Core;
using UnityEngine;

public class ArchManager : MonoBehaviour
{
    private World world;
    
    
    void Start()
    {
        world = World.Create();
    }
    
    
}
