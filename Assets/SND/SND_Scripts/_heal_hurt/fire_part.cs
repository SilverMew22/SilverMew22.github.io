using UnityEngine;


public class fire_part : MonoBehaviour
{
    public Texture2D tex;
    private ParticleSystem ps;
    private Sprite sprite;

    //public GameObject objectToDisable;
    //public static bool disabled = false;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), Vector2.zero);

        var textureSheetAnimation = ps.textureSheetAnimation;
        textureSheetAnimation.enabled = true;
        textureSheetAnimation.mode = ParticleSystemAnimationMode.Sprites;
        textureSheetAnimation.AddSprite(sprite);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //objectToDisable.SetActive(false);
            ps.Play(false);
        }
        if (!Input.GetMouseButton(0))
        {
            //objectToDisable.SetActive(true);
            ps.Play(true);
        }
    } }
        
    
