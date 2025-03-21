using UnityEngine;

public class PNJTriggerAnimation : MonoBehaviour
{
    public Animator pnjAnimator;  // Référence à l'Animator du PNJ
    public string animationBool = "IsPlayerNear"; // Nom du paramètre booléen dans l'Animator

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Vérifie si c'est le joueur qui entre
        {
            pnjAnimator.SetBool(animationBool, true); // Active l'animation
            Debug.Log("Le joueur est dans la zone, animation activée !");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Vérifie si c'est le joueur qui sort
        {
            pnjAnimator.SetBool(animationBool, false); // Désactive l'animation
            Debug.Log("Le joueur est sorti de la zone, animation désactivée !");
        }
    }
}

