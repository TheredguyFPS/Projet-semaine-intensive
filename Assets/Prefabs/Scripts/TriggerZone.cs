using UnityEngine;

public class PNJTriggerAnimation : MonoBehaviour
{
    public Animator pnjAnimator;  // R�f�rence � l'Animator du PNJ
    public string animationBool = "IsPlayerNear"; // Nom du param�tre bool�en dans l'Animator

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // V�rifie si c'est le joueur qui entre
        {
            pnjAnimator.SetBool(animationBool, true); // Active l'animation
            Debug.Log("Le joueur est dans la zone, animation activ�e !");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // V�rifie si c'est le joueur qui sort
        {
            pnjAnimator.SetBool(animationBool, false); // D�sactive l'animation
            Debug.Log("Le joueur est sorti de la zone, animation d�sactiv�e !");
        }
    }
}

