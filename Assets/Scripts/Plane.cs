// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class Plane : SceneEntity
{
    [SerializeField] private Vector3 center;
    [SerializeField] private Vector3 normal;
    
    public Vector3 Center => this.center;
    public Vector3 Normal => this.normal;
    
    public RaycastHit? Intersect(Ray ray)
    {
        // By default we use the Unity engine for ray-entity collisions.
        // See the parent 'SceneEntity' class definition for details.
        // Task: Replace with your own intersection computations.
        ray.
    }
}
