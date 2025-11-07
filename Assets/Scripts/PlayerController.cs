using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Скорость движения
    public float Speed = 5f;
    public float JumpForce = 7f;

    private bool isGrounded;
    private bool jumpRequested;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); //Получаем Rigidbody игрока
    }

    void Update()
    {
        // Движение влево-вправо
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Speed * Time.deltaTime, 0, 0);

        //Запрос прыжка
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jumpRequested = true;
        }
        //Выход в главное меню
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    private void FixedUpdate()
    {
        if (jumpRequested) //Если запрошен прыжок
        {
            jumpRequested = false;  //сброс запроса пражка

            //Сбрасываем вертикальную скорость игрока
            var VertialSpeed = rb.linearVelocity;
            VertialSpeed.y = 0f;
            rb.linearVelocity = VertialSpeed;

            //Выполняем прыжок
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);

            //Блокируем двойной прыжок
            isGrounded = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        //Перебираем массив точек контакта collision.contacts
        foreach (var contact in collision.contacts)
        {
            if (contact.normal.y > 0.5f) // Смотрим комнпонету "y" нормали (вектор, перпендикулярный к поверхности)
            {                            //0.5 означает, что угол между нормалью и вектором (0,1,0) меньше arccos(0.5) = 60°
                isGrounded = true;       //Т.е. землёй считается поверхность не круче 60°
                return;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //Запрет прыжка в воздухе
        isGrounded = false;
    }
}