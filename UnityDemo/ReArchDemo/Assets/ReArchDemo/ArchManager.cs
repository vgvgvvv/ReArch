using System;
using System.Collections;
using System.Collections.Generic;
using ReArch.Core;
using ReArchDemo;
using UnityEngine;

public class ArchManager : MonoBehaviour
{
    private World world;
    
    private readonly QueryDescription _entitiesToMove = new QueryDescription().WithAll<Position, Velocity, GameObjectHandle>();
    
    void Start()
    {
        world = World.Create();
        
        for (var index = 0; index < 150; index++)
        {
            world.Create(
                new Position { Vec2 = new Vector2(1.0f, 1.0f) },
                new Velocity { Vec2 = new Vector2(1.0f, 1.0f) }
            );
        }

    }

    void Update()
    {
        world.Query<Position, Velocity, GameObjectHandle>(_entitiesToMove, DoUpdate);
    }
    
    void DoUpdate(ref Position pos, ref Velocity vel, ref GameObjectHandle handle)
    {
        pos.Vec2 += vel.Vec2;
    }

    private void OnDestroy()
    {
        world.Dispose();
        world = null;
    }
}
