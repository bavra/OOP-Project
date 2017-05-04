using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public int PlayerNumber;  
      
    public abstract void Play(Game cellGrid);
}