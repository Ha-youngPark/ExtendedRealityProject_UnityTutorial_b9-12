using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //#1.속력 바꾸기.
        // rigid.velocity = new  Vector3(2, 4, -1); 
        

        //#2.힘을 가하기
        if(Input.GetButtonDown("Jump")){
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        
        rigid.AddForce(vec, ForceMode.Impulse);
        
        //#3. 회전력
        // rigid.AddTorque(Vector3.down);
    }


    private void OnTriggerStay(Collider other){
        if(other.name == "b11_Cube")
            rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }

    public void Jump(){
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }

}
