using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI goalText;

    // IsTrigger‚É”½‰‚ª‚ ‚Á‚½
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        //Canvas‚ÉƒS[ƒ‹‚µ‚½î•ñ‚ğ‘—‚é
        goalText.enabled = true;
        
    }
}
