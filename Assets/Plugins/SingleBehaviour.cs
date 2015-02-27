using UnityEngine;

public class SingleBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance_;
    public static T instance
    {
        get
        {
           if (instance_ == null)
                instance_ = GameObject.FindObjectOfType(typeof(T)) as T;
            if (instance_ == null)
           {
                GameObject o = new GameObject("_SingleBehaviour_<" + typeof(T).ToString() + ">");
                instance_ = o.AddComponent<T>();
            }
            return instance_;
        }
    }
}
/*
 * Il est parfois nécessaire de n’avoir qu’une seule instance d’un script dans une scène 
 * et de pouvoir y accéder depuis d’importe quel objet (pour lancer des coroutines par exemple). 
 * Une sorte de singleton.
 * Mais comme la class MonoBehaviour ne nous permet pas de définir le constructeur de nos scripts 
 * et encore moins le mettre en private, il est difficile d’appliquer ce design pattern. 
 * Il est cependant possible de retrouver plus ou moins le même comportement.
 http://blog.remibodin.fr/unity3d-singleton-behaviour/
 */