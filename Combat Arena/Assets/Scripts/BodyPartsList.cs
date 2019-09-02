using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartsList : MonoBehaviour
{
    [SerializeField]
    public struct Bodypart
    {
        public GameObject gameObject;
        public Rigidbody rigidbody;
        public bool pickable;
    }
}
