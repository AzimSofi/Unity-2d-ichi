using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    private Animator playerAnimator;

    // Startメソッドで初期化
    void Start()
    {
        playerAnimator = gameObject.GetComponent<Animator>();
    }

    // Updateメソッドで毎フレーム処理
    void Update()
    {
        Movement();
        Skill("Q", "Attack", playerAnimator);
    }

    // プレイヤーの移動を管理
    private void Movement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 moveVector = new Vector2(moveX, moveY);

        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
    }

    // スキルを発動
    private void Skill(string key_skill, string skill, Animator animator)
    {
        KeyCode convertedKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), key_skill);

        if (Input.GetKeyDown(convertedKey))
        {
            animator.SetBool(skill, true);
        }
        if (Input.GetKeyUp(convertedKey))
        {
            animator.SetBool(skill, false);
        }
    }
}
