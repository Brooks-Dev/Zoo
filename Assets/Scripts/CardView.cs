using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text exhibit;
    public Image animalImg;

    public CardModel[] cards;

    public void UpdateCard(int ID)
    {
        if (cards[ID] != null)
        {
            title.text = cards[ID].title;
            description.text = cards[ID].description;
            exhibit.text = cards[ID].exhibit;
            animalImg.sprite = cards[ID].animalImg;
        }
    }
}
