using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class ChooseCharacter : MonoBehaviour
{
    TextMeshProUGUI TMPName, TMPRol, TMPWeapon;
    public Sprite p1, p2, p3;
    public GameObject photoSoloPlayer, nameSoloPlayer, rolSoloPlayer, weaponSoloPlayer, photoJ1, photoJ2, nameJ1, rolJ1, weaponJ1, nameJ2, rolJ2, weaponJ2;
    // Start is called before the first frame update
    void Start()
    {
        /*p1 = Resources.Load("portrait1", typeof(Sprite)) as Sprite;
        p2 = Resources.Load("portrait2", typeof(Sprite)) as Sprite;
        p3 = Resources.Load("portrait3", typeof(Sprite)) as Sprite;
    */}

    public void RightArrowSolo()
    {
        if (photoSoloPlayer.GetComponent<Image>().sprite.name == "portrait2")
        {
            TMPName = nameSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Alex";
            TMPRol = rolSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Dise�ador";
            TMPWeapon = weaponSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Libreta";

            photoSoloPlayer.GetComponent<Image>().sprite = p3;

        }
        else if (photoSoloPlayer.GetComponent<Image>().sprite.name == "portrait1")
        {
            TMPName = nameSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Pol";
            TMPRol = rolSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Programador";
            TMPWeapon = weaponSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Teclado";

            photoSoloPlayer.GetComponent<Image>().sprite = p2;
        }
        else if (photoSoloPlayer.GetComponent<Image>().sprite.name == "portrait3")
        {
            TMPName = nameSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Auri";
            TMPRol = rolSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Artista";
            TMPWeapon = weaponSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Lapiz Wacom";

            photoSoloPlayer.GetComponent<Image>().sprite = p1;
        }
    }

    public void LeftArrowSolo()
    {

        if (photoSoloPlayer.GetComponent<Image>().sprite.name == "portrait1")
        {
            TMPName = nameSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Alex";
            TMPRol = rolSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Dise�ador";
            TMPWeapon = weaponSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Libreta";

            photoSoloPlayer.GetComponent<Image>().sprite = p3;

        }else if (photoSoloPlayer.GetComponent<Image>().sprite.name == "portrait3")
        {
            TMPName = nameSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Pol";
            TMPRol = rolSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Programador";
            TMPWeapon = weaponSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Teclado";

            photoSoloPlayer.GetComponent<Image>().sprite = p2;
        }
        else if (photoSoloPlayer.GetComponent<Image>().sprite.name == "portrait2")
        {
            TMPName = nameSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Auri";
            TMPRol = rolSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Artista";
            TMPWeapon = weaponSoloPlayer.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Lapiz Wacom";

            photoSoloPlayer.GetComponent<Image>().sprite = p1;
        }
    }

    public void RightArrowJ1()
    {
        if (photoJ1.GetComponent<Image>().sprite.name == "portrait2")
        {
            TMPName = nameJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Alex";
            TMPRol = rolJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Dise�ador";
            TMPWeapon = weaponJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Libreta";

            photoJ1.GetComponent<Image>().sprite = p3;

        }
        else if (photoJ1.GetComponent<Image>().sprite.name == "portrait1")
        {
            TMPName = nameJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Pol";
            TMPRol = rolJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Programador";
            TMPWeapon = weaponJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Teclado";

            photoJ1.GetComponent<Image>().sprite = p2;
        }
        else if (photoJ1.GetComponent<Image>().sprite.name == "portrait3")
        {
            TMPName = nameJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Auri";
            TMPRol = rolJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Artista";
            TMPWeapon = weaponJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Lapiz Wacom";

            photoJ1.GetComponent<Image>().sprite = p1;
        }
    }

    public void LeftArrowJ1()
    {
        if (photoJ1.GetComponent<Image>().sprite.name == "portrait1")
        {
            TMPName = nameJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Alex";
            TMPRol = rolJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Dise�ador";
            TMPWeapon = weaponJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Libreta";

            photoJ1.GetComponent<Image>().sprite = p3;

        }
        else if (photoJ1.GetComponent<Image>().sprite.name == "portrait3")
        {
            TMPName = nameJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Pol";
            TMPRol = rolJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Programador";
            TMPWeapon = weaponJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Teclado";

            photoJ1.GetComponent<Image>().sprite = p2;
        }
        else if (photoJ1.GetComponent<Image>().sprite.name == "portrait2")
        {
            TMPName = nameJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Auri";
            TMPRol = rolJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Artista";
            TMPWeapon = weaponJ1.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Lapiz Wacom";

            photoJ1.GetComponent<Image>().sprite = p1;
        }
    }

    public void RightArrowJ2()
    {
        if (photoJ2.GetComponent<Image>().sprite.name == "portrait2")
        {
            TMPName = nameJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Alex";
            TMPRol = rolJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Dise�ador";
            TMPWeapon = weaponJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Libreta";

            photoJ2.GetComponent<Image>().sprite = p3;

        }
        else if (photoJ2.GetComponent<Image>().sprite.name == "portrait1")
        {
            TMPName = nameJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Pol";
            TMPRol = rolJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Programador";
            TMPWeapon = weaponJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Teclado";

            photoJ2.GetComponent<Image>().sprite = p2;
        }
        else if (photoJ2.GetComponent<Image>().sprite.name == "portrait3")
        {
            TMPName = nameJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Auri";
            TMPRol = rolJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Artista";
            TMPWeapon = weaponJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Lapiz Wacom";

            photoJ2.GetComponent<Image>().sprite = p1;
        }
    }

    public void LeftArrowJ2()
    {
        if (photoJ2.GetComponent<Image>().sprite.name == "portrait1")
        {
            TMPName = nameJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Alex";
            TMPRol = rolJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Dise�ador";
            TMPWeapon = weaponJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Libreta";

            photoJ2.GetComponent<Image>().sprite = p3;

        }
        else if (photoJ2.GetComponent<Image>().sprite.name == "portrait3")
        {
            TMPName = nameJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Pol";
            TMPRol = rolJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Programador";
            TMPWeapon = weaponJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Teclado";

            photoJ2.GetComponent<Image>().sprite = p2;
        }
        else if (photoJ2.GetComponent<Image>().sprite.name == "portrait2")
        {
            TMPName = nameJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPName.text = "Auri";
            TMPRol = rolJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPRol.text = "Artista";
            TMPWeapon = weaponJ2.GetComponent<TMPro.TextMeshProUGUI>();
            TMPWeapon.text = "Arma: Lapiz Wacom";

            photoJ2.GetComponent<Image>().sprite = p1;
        }
    }

    public void PlaySolo()
    {
        //COMPROBAR CUAL ES EL PORTAIT QUE HAY CUANDO LE DA AL PLAY Y PASARLE AL PLAYERPREF EL NUMERO CORRESPONDIENTE PARA QUE EN LA SIGUIENTE ESCENA LO CARGUE Y JUEGE
        if (photoSoloPlayer.GetComponent<Image>().sprite.name == "portrait1")
        {
            PlayerPrefs.SetInt("PJ1", 1);
        }
        else if (photoSoloPlayer.GetComponent<Image>().sprite.name == "portrait2")
        {
            PlayerPrefs.SetInt("PJ1", 2);
        }
        else if (photoSoloPlayer.GetComponent<Image>().sprite.name == "portrait3")
        {
            PlayerPrefs.SetInt("PJ1", 3);
        }

        //SceneManager.LoadScene("PruebaDatos");
    }

    public void PlayMulti()
    {
        //COMPROBAR CUAL ES EL PORTAIT QUE HAY CUANDO LE DA AL PLAY Y PASARLE AL PLAYERPREF EL NUMERO CORRESPONDIENTE PARA QUE EN LA SIGUIENTE ESCENA LO CARGUE Y JUEGE
        if (photoJ1.GetComponent<Image>().sprite.name == "portrait1")
        {
            PlayerPrefs.SetInt("PJ1", 1);
        }
        else if (photoJ1.GetComponent<Image>().sprite.name == "portrait2")
        {
            PlayerPrefs.SetInt("PJ1", 2);
        }
        else if (photoJ1.GetComponent<Image>().sprite.name == "portrait3")
        {
            PlayerPrefs.SetInt("PJ1", 3);
        }

        //PJ2
        if (photoJ2.GetComponent<Image>().sprite.name == "portrait1")
        {
            PlayerPrefs.SetInt("PJ2", 1);
        }
        else if (photoJ2.GetComponent<Image>().sprite.name == "portrait2")
        {
            PlayerPrefs.SetInt("PJ2", 2);
        }
        else if (photoJ2.GetComponent<Image>().sprite.name == "portrait3")
        {
            PlayerPrefs.SetInt("PJ2", 3);
        }



        //SceneManager.LoadScene("PruebaDatos");
    }


}