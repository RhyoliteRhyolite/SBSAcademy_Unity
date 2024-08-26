using System.Collections;
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
    [SerializeField] Animator animator;
    [SerializeField] float speed = 2.5f;

    private WaitForSeconds waitForSeconds = new WaitForSeconds(5.0f);

    private void Start()
    {
        state = State.WALK;
        animator = GetComponent<Animator>();
    }

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
    public void Walk()
    {
        animator.SetBool("Attack", false);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void Attack()
    {
        animator.SetBool("Attack", true);

    }
    public void Die()
    {
        animator.Play("Die");
    }
    private IEnumerator KnockBack(Collider other)
    {
        yield return waitForSeconds;

        other.transform.position += new Vector3(0, 0, -3);
    }

    private void OnTriggerEnter(Collider other)
    {
        state = State.ATTACK;

        StartCoroutine(KnockBack(other));
    }

    private void OnTriggerExit(Collider other)
    {
        state = State.DIE;
    }
}
