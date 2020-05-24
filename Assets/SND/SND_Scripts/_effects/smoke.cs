using UnityEngine;


public class smoke : MonoBehaviour
{
    
   // public ParticleSystem ps;
   

    public GameObject objectToDisable;
    //public static bool disabled = false;

    void Start()
    {
        //ps = GetComponent<ParticleSystem>();
        //sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), Vector2.zero);

        
        
        //textureSheetAnimation.AddSprite(sprite);
    }

    void Update()
    {
        //if (Castle_Health_System.Cas_health >= 100)
        //{
        //    objectToDisable.SetActive(false);
            //ps.Play(false);
       // }
        if (Castle_Health_System.Cas_health <= 80f)
        {
            objectToDisable.SetActive(true);
            //ps.Play(true);
        }
    }
}
