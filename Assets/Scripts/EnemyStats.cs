using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI;
using UnityEngine.AI;

public class EnemyStats : MonoBehaviour
{
    struct MyStruct
    {
        public static NavMeshAgent navAgent;
        public static float pounceSpeed;
        public static float pounceCountDownTime;
        public static Material material;

        public static Vector3 pounceTargetLocation;
    }
    
}
