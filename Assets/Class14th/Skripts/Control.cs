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
        /* ForceMode.Force : 연속적 힘을 가해 겜 오브젝을 움직이는 방식 (무게 O)
         * ForceMode.Acceleration : 연속적 힘을 가해 겜 오브젝을 움직이는 방식 (무게 X)
         * 
         * ForceMode.Impulse : 순간적 힘을 가해 겜 오브젝을 움직이는 방식 (무게 O)
         * ForceMode.VelocityCharge : 순간적 힘을 가해 겜 오브젝을 움직이는 방식 (무게 X)
         */

        rigidBody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
