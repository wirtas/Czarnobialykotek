using UnityEngine;

public class PlayerColor : MonoBehaviour
{
  [SerializeField] private bool isRightBlack;
  [SerializeField] private Animator m_Animator;
  public bool IsRightBlack
  {
    get => isRightBlack;
    private set
    {
      isRightBlack = value;
      if (isRightBlack)
      {
        m_Animator.SetLayerWeight(1, 1);
        m_Animator.SetLayerWeight(2,0);
      }
      else
      {
        m_Animator.SetLayerWeight(1, 0);
        m_Animator.SetLayerWeight(2,1);
      }
    }
  }

  public void ChangePlayerColor()
  {
    IsRightBlack = !isRightBlack;
  }
}
