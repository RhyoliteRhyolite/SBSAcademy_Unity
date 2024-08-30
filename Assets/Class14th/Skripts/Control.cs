using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] Vector3 direction;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        /* ForceMode.Force : ������ ���� ���� �� �������� �����̴� ��� (���� O)
         * ForceMode.Acceleration : ������ ���� ���� �� �������� �����̴� ��� (���� X)
         * 
         * ForceMode.Impulse : ������ ���� ���� �� �������� �����̴� ��� (���� O)
         * ForceMode.VelocityCharge : ������ ���� ���� �� �������� �����̴� ��� (���� X)
         */

        rigidBody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
