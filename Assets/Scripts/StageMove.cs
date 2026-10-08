using UnityEngine;
using UnityEngine.InputSystem;
public class StageMove : MonoBehaviour
{
    private InputAction moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveInput = InputSystem.actions.FindAction("Move");    
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(moveInput.ReadValue<Vector2>());

        //this.transform.localPositionはこのコードがアタッチメントされているゲームオブジェクトの位置情報
        //このゲームオブジェクトの今のtransformのpositionは　このゲームオブジェクトの今のtransformのposition + (Vector3)moveInput.ReadValue<Vector2>()
        //(Vector3)moveInput.ReadValue<Vector2>() はWASD入力した二次元Vector2情報XY(x,y,z=o)をVector3に変換させる(Vector3)
        //this.transform.localPosition += (Vector3)moveInput.ReadValue<Vector2>();

        //rotation このままじゃWSがY軸を沿ってを回転させている　ADがX軸を沿ってオブジェクトを回転させている
        //  this.transform.Rotate((Vector3)moveInput.ReadValue<Vector2>());
        //this.transform.Rotate += (Vector3)moveInput.ReadValue<Vector2>();

        Vector3 rotation;
        //Vector3 (x, y, z)

        //動きの値が大きすぎるとUnityの物理演算が追いつかないのでゲームオブジェクト同士がすり抜ける　閾値を掛ける
        float threshold = 0.2f;

        //rotation = new Vector3(moveInput.ReadValue<Vector2>().x, 0, moveInput.ReadValue<Vector2>().y);   この操作方法キモイので変えた
        //直感内容操作

        rotation = new Vector3(moveInput.ReadValue<Vector2>().y * threshold, 0, moveInput.ReadValue<Vector2>().x * threshold);


        this.transform.Rotate(rotation);
    }
}
