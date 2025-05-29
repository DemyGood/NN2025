using UnityEngine;

public class InvisibleBonus : MonoBehaviour, IBonus
{
    [SerializeField] private int _bonusDuration;
    [SerializeField] private int _bonusAmount;
    public void GetBonus(int i)
    {

    }
}
