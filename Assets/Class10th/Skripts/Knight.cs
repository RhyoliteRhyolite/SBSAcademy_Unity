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
        // 게임 오브젝트가 물리적이지 않은 충돌을 했을 때 이벤트 함수


    }

    private void OnTriggerStay(Collider other)
    {
        // 게임 오브젝트가 물리적이지 않은 충돌 중일 때 이벤트 함수

    }

    private void OnTriggerExit(Collider other)
    {
        // 게임 오브젝트가 물리적이지 않은 충돌을 벗어났을 때 이벤트 함수

    }
    #endregion
    #region OnCollision
    private void OnCollisionEnter(Collision collision)
    {
        // OnColiisionEnter() : 겜 오브젝트가 물리적 충돌을 시작할 때
        //                     호출되는 이벤트 함수.


    }

    private void OnCollisionStay(Collision collision)
    {
        // OnColiisionStay() : 겜 오브젝트가 물리적 충돌 중일 때
        //                     호출되는 이벤트 함수.


    }

    private void OnCollisionExit(Collision collision)
    {
        // OnColiisionExit() : 겜 옫브젝트가 물리적 충돌을 벗어났을 때
        //                     호출되는 이벤트 함수.


    }
    #endregion
}
