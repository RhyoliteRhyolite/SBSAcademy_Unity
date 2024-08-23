using UnityEngine;
public enum State
{
    WALK,
    ATTACK,
    DIE
}

public class Knight : MonoBehaviour
{
    [SerializeField] State state;

    private void Update()
    {
        switch (state)
        {
            case State.WALK:
                Walk();
                break;
            case State.ATTACK:
                Attack();
                break;
            case State.DIE:
                Die();
                break;
        }
    }

    #region State
    public void Walk()
    {
        gameObject.transform.position = Vector3.forward;
    }
    public void Attack()
    {
        Debug.Log("Attack");
    }
    public void Die()
    {
        Debug.Log("Die");
    }
    #endregion
    #region OnTrigger
    private void OnTriggerEnter(Collider other)
    {
        // ���� ������Ʈ�� ���������� ���� �浹�� ���� �� �̺�Ʈ �Լ�


    }

    private void OnTriggerStay(Collider other)
    {
        // ���� ������Ʈ�� ���������� ���� �浹 ���� �� �̺�Ʈ �Լ�

    }

    private void OnTriggerExit(Collider other)
    {
        // ���� ������Ʈ�� ���������� ���� �浹�� ����� �� �̺�Ʈ �Լ�

    }
    #endregion
    #region OnCollision
    private void OnCollisionEnter(Collision collision)
    {
        // OnColiisionEnter() : �� ������Ʈ�� ������ �浹�� ������ ��
        //                     ȣ��Ǵ� �̺�Ʈ �Լ�.


    }

    private void OnCollisionStay(Collision collision)
    {
        // OnColiisionStay() : �� ������Ʈ�� ������ �浹 ���� ��
        //                     ȣ��Ǵ� �̺�Ʈ �Լ�.


    }

    private void OnCollisionExit(Collision collision)
    {
        // OnColiisionExit() : �� ������Ʈ�� ������ �浹�� ����� ��
        //                     ȣ��Ǵ� �̺�Ʈ �Լ�.


    }
    #endregion
}
