using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

     public float moveSpeed =1f;
     [SerializeField] GameObject bmbscr;

    public SwordAttack swordAttack;

     public ContactFilter2D movementFilter;

    Vector2 movementInput;

    Rigidbody2D rb;

    public float collisionOffset=0.05f;

    SpriteRenderer spriteRenderer;

    Animator animator;

    List<RaycastHit2D> castCollision=new List<RaycastHit2D>();
    bool canMove=true;
    public VectorValue startingPosition;


     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();
        spriteRenderer=GetComponent<SpriteRenderer>();
        transform.position= startingPosition.initialValue;
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }

    private void FixedUpdate()

    {if(canMove){
 
            if((movementInput != Vector2.zero)&& (!bmbscr.activeSelf)) {
            bool success=TryMove(movementInput);
            if(!success )
            {
                success=TryMove(new Vector2(movementInput.x,0));
            }
            if(!success)
                {
                    success=TryMove(new Vector2(0,movementInput.y));
                }

            

              animator.SetBool("isMoving",success);
        
        }
        else{
            animator.SetBool("isMoving",false);
        }
        //setting direction of sprite 
        if(movementInput.x < 0){
            spriteRenderer.flipX=true;
        }
        else if(movementInput.x > 0){
           spriteRenderer.flipX=false; 
        }}

    }
 
    

    private bool TryMove(Vector2 direction)
    {
        
        if(direction!=Vector2.zero){
            int count = rb.Cast(
                 direction,
                 movementFilter,
                 castCollision,
                 moveSpeed * Time.fixedDeltaTime + collisionOffset
                );
            if(count==0){
                rb.MovePosition(rb.position + moveSpeed*direction*Time.fixedDeltaTime);
                return true;
            }  else{return false;}}
            else{return false;}
        
       
    }

     void OnFire(){
        animator.SetTrigger("swordAttack");
    }

    public void SwordAttack(){
        LockMovement();
        if(spriteRenderer.flipX==true){
            swordAttack.AttackLeft();
        }
        else{
            swordAttack.AttackRight();

        }

        
    }

    public void EndSwordAttack(){
        UnlockMovement();
        swordAttack.StopAttack();
    }


    public void LockMovement(){
        canMove=false;
    }

    public void UnlockMovement(){
        canMove=true; 
    }
    
}
