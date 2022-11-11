using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;


namespace KayBarhoum
{

    public enum Person { Undefined, Saeyoung, Jubilee, Kenma}

    public class Contact : MonoBehaviour
    {
        [SerializeField] private Person chosenPerson = Person.Undefined;
        [SerializeField] private new string name;
        [SerializeField] private string preferredName;
        [SerializeField] private string pronouns;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string email;
        [SerializeField] private string address;

        public void Initialise()
        {
            /// we want to set up all 3 characters here
            /// using an if statement we can say:
            /// use if statesments
            /// if variable == 0, set up Saeyoung
            /// if variable == 1, St up Jubilee
            /// if variable == 2, set up Kenma

            switch (chosenPerson)
            {

                case Person.Undefined:
                    break;
                case Person.Saeyoung:
                    Setup("Saeyoung", "707", "He/Him", "04707485156", "707besthackerever@gmail.com", "Mystic Messenger RFA hall");
                    break;
                case Person.Jubilee:
                    Setup("Jubilee", "Juby", "She/her", "0452488566", "Sleepyhollow@forestacres.com", "forest acres");
                    break;
                case Person.Kenma:
                    Setup("Kenma", "Kodzuken", "He/Him", "0498657328", "Kodzuken@games.com", "Nekoma High");
                    break;

                default:
                    Debug.Log("INvalid Choice!");
                    break;


            }
        }

        private void Setup(string newname,
                           string newpreferredName,
                           string newpronouns,
                           string newphoneNumber,
                           string newemail,
                           string newaddress)
        {
            name = newname;
            preferredName = newpreferredName;
            pronouns = newpronouns;
            phoneNumber = newphoneNumber;
            email = newemail;
            address = newaddress;

        }

        
    }



}
