using KayBarhoum;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;






namespace KayBarhoum
{

    enum CardSuit { Heart, Diamond, Spades, Clubs }

    public class Deck : MonoBehaviour
    {
        [Header("Reference")]
        [SerializeField] private GameObject cardGameObjectPrefab;
        [SerializeField] private Card cardPrefab;

            [Header("Collections")]
            [SerializeField] private List<Card> deck;
        private string[] values = new string[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        // Start is called before the first frame update
        void Start()
        {
          
      
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}



// Created by Owen
// Adapted by Aaron & GAD170 class


//using System.Collections.Generic;
//using System;
//using UnityEngine;

//namespace GAD170
//{
//    enum CardSuit { Clubs, Spades, Hearts, Diamonds }

//    public class Deck : MonoBehaviour
//    {
//        [Header("References")]
//        [SerializeField] private Card cardPrefab;

//        [Header("Collections")]
//        [SerializeField] private List<Card> deck;
//        private string[] values = new string[13] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

//        void Start()
//        {
//            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
//            {
//                foreach (string value in values)
//                {
//                    Card newCard = Instantiate(cardPrefab, transform);

//                    newCard.value = value;
//                    newCard.suit = suit.ToString();
//                    newCard.name = value + " of " + suit;

//                    deck.Add(_newCard);
//                }
//            }
//        }
//    }
//}

