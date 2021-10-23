using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_4
{
    /* Class: Phone
     * Author: Jonathan Karcher
     * Purpose: To define a phone
     */
    public abstract class Phone
    {
        // a string containing the phone number
        private string phoneNumber;
        // a string containing the address
        public string address;
        /* Method: PhoneNumber
         * Purpose: Return the phone number
         * Restrictions: None
         */
        public string PhoneNumber()
        {
            return phoneNumber;
        }
        /* Method: Connect
         * Purpose: To connect the phone to other phones
         * Restrictions: None
         */
        public abstract void Connect();
        /* Method: Disconnect
         * Purpose: To disconnect the phone from other phones
         * Restrictions: None
         */
        public abstract void Disconnect();
    }
    /* Class: RotaryPhone
     * Author: Jonathan Karcher
     * Purpose: To define a rotary phone
     */
    public class RotaryPhone : Phone, PhoneInterface
    {
        /* Method: Answer
         * Purpose: To answer a call
         * Restrictions: None
         */
        public void Answer()
        { }
        /* Method: MakeCall
         * Purpose: To dial a call
         * Restrictions: None
         */
        public void MakeCall()
        { }
        /* Method: HangUp
         * Purpose: To hang up the phone
         * Restrictions: None
         */
        public void HangUp()
        { }
        /* Method: Connect
         * Purpose: To connect the phone to other phones
         * Restrictions: None
         */
        public override void Connect()
        { }
        /* Method: Disconnect
         * Purpose: To disconnect the phone from other phones
         * Restrictions: None
         */
        public override void Disconnect()
        { }
    }
    /* Class: Tardis
     * Author: Jonathan Karcher
     * Purpose: Define a tardis
     */
    public class Tardis : RotaryPhone
    {
        // does the Dr have a sonic Screwdriver
        private bool sonicScrewdriver;
        // which Dr Who is it
        private byte whichDrWho;
        // the name of the female SideKick
        private string femaleSideKick;
        // outside area of the tardis
        public double exteriorSurfaceArea;
        // inside area of the tardis
        public double interiorVolume;
        /* Property: WhichDrWho
         * purpose: Return the value of whichDrWho
         * Restrictions: Read only
         */
        public byte WhichDrWho
        {
            get { return whichDrWho; }
        }
        /* Property: FemaleSideKick
         * purpose: Return the value of femaleSideKick
         * Restrictions: Read only
         */
        public string FemaleSideKick
        {
            get { return femaleSideKick; }
        }
        /* Method: TimeTravel
         * purpose: Travel randomy through time
         * Restrictions: None
         */
        public void TimeTravel()
        { }
        /* Operator: ==
         * Purpose: Define == to compare the value of which Dr Who
         * Restrictions: None
         */
        public static bool operator ==(Tardis a, Tardis b)
        {
            bool toReturn;
            // if the byte values are the same
            if (a.WhichDrWho == b.WhichDrWho)
            {
                toReturn = true;
            }
            // if the byte values are different
            else
            {
                toReturn = false;
            }
            return toReturn;
        }
        /* Operator: !=
         * Purpose: Define != to compare the value of which Dr Who
         * Restrictions: None
         */
        public static bool operator !=(Tardis a, Tardis b)
        {
            bool toReturn;
            // if the byte value is not the same
            if (a.WhichDrWho != b.WhichDrWho)
            {
                toReturn = true;
            }
            // if the byte value is the same
            else
            {
                toReturn = false;
            }
            return toReturn;
        }
        /* Operator: >
         * Purpose: Define > to compare the value of which Dr Who, 10 beats all others
         * Restrictions: None
         */
        public static bool operator >(Tardis a, Tardis b)
        {
            bool toReturn;
            // if they are not the same Dr and the first is 10 
            if (a != b && a.WhichDrWho == 10)
            {
                // exit here
                return true;
            }
            // if they are not the same and the second Dr is 10 
            else if(a != b && b.WhichDrWho == 10)
            {
                // exit here
                return false;
            }
            // if a is greater than b
            if (a.WhichDrWho > b.WhichDrWho)
            {
                toReturn = true;
            }
            // if b is the same or greater
            else
            {
                toReturn = false;
            }
            return toReturn;
        }
        /* Operator: <
         * Purpose: Define < to compare the value of which Dr Who, 10 beats all others
         * Restrictions: None
         */
        public static bool operator <(Tardis a, Tardis b)
        {
            bool toReturn;
            // if they are not the same Dr and the first is 10
            if (a != b && a.WhichDrWho == 10)
            {
                // exit here
                return false;
            }
            // if they are not the same and the second Dr is 10
            else if (a != b && b.WhichDrWho == 10)
            {
                // exit here
                return true;
            }
            // if a is less than b
            if (a.WhichDrWho < b.WhichDrWho)
            {
                toReturn = true;
            }
            // if b is the same or lesser
            else
            {
                toReturn = false;
            }
            return toReturn;
        }
        /* Operator: >=
         * Purpose: Define >= to compare the value of which Dr Who, 10 beats all others
         * Restrictions: None
         */
        public static bool operator >=(Tardis a, Tardis b)
        {
            bool toReturn;
            // if they are not the same Dr and the first is 10
            if (a != b && a.WhichDrWho == 10)
            {
                // exit here
                return true;
            }
            // if they are not the same and the second Dr is 10
            else if (a != b && b.WhichDrWho == 10)
            {
                // exit here
                return false;
            }
            // if they are not the same Dr and the first is greater
            if (a != b && a > b)
            {
                toReturn = true;
            }
            // if they are not the same Dr and the first is lesser
            else if (a != b && a < b)
            {
                toReturn = false;
            }
            // if the byte value of a.whichDrWho is greater than the byte value of b.whichDrWho
            else if (a.WhichDrWho >= b.WhichDrWho)
            {
                toReturn = true;
            }
            // if the byte value of a.whichDrWho is less than the byte value of b.whichDrWho
            else
            {
                toReturn = false;
            }
            return toReturn;
        }
        /* Operator: <=
         * Purpose: Define <= to compare the value of which Dr Who, 10 beats all others
         * Restrictions: None
         */
        public static bool operator <=(Tardis a, Tardis b)
        {
            bool toReturn;
            // if they are not the same Dr and the first is 10
            if (a != b && a.WhichDrWho == 10)
            {
                // exit here
                return false;
            }
            // if they are not the same and the second Dr is 10
            else if (a != b && b.WhichDrWho == 10)
            {
                // exit here
                return true;
            }
            // if they are not the same Dr and the first is greater
            if (a != b && a > b)
            {
                toReturn = false;
            }
            // if they are not the same Dr and the first is lesser
            else if (a != b && a < b)
            {
                toReturn = true;
            }
            // if the byte value of a.whichDrWho is greater than the byte value of b.whichDrWho
            else if (a.WhichDrWho <= b.WhichDrWho)
            {
                toReturn = true;
            }
            // if the byte value of a.whichDrWho is less than the byte value of b.whichDrWho
            else
            {
                toReturn = false;
            }
            return toReturn;
        }
    }
    /* Interface: PhoneInterface
     * Author: Jonathan Karcher
     * Purpose: Describe basic actions that a phone can perform
     */
    public interface PhoneInterface
    {
        /* Method: Answer
         * purpose: Answer a phone call
         * Restrictions: None
         */
        void Answer();
        /* Method: MakeCall
         * purpose: Make a phone call
         * Restrictions: None
         */
        void MakeCall();
        /* Method: HangUp
         * purpose: Hang up the phone
         * Restrictions: None
         */
        void HangUp();

    }
    /* Class: PushButtonPhone
     * Author: Jonathan Karcher
     * Purpose: Define a push button phone
     */
    public class PushButtonPhone : Phone, PhoneInterface
    {
        /* Method: Answer
         * purpose: Answer a phone call
         * Restrictions: None
         */
        public void Answer()
        { }
        /* Method: MakeCall
         * purpose: Make a phone call
         * Restrictions: None
         */
        public void MakeCall()
        { }
        /* Method: HangUp
         * purpose: Hang up the phone
         * Restrictions: None
         */
        public void HangUp()
        { }
        /* Method: Connect
         * Purpose: To connect the phone to other phones
         * Restrictions: None
         */
        public override void Connect()
        { }
        /* Method: Disconnect
         * Purpose: To disconnect the phone from other phones
         * Restrictions: None
         */
        public override void Disconnect()
        { }
    }
    /* Class: PhoneBooth
     * Author: Jonathan Karcher
     * Purpose: Define a phone booth
     */
    public class PhoneBooth : PushButtonPhone
    {
        // is the user superman
        private bool superMan;
        // the cost of placing a call
        public double costPerCall;
        // is there a phonebook
        public bool phoneBook;
        /* Method: OpenDoor
         * Puropse: Open the door
         * Restrictions: None
         */
        public void OpenDoor()
        { }
        /* Method: CloseDoor
         * Puropse: Close the door
         * Restrictions: None
         */
        public void CloseDoor()
        { }
    }
    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: The main entery class for the program
     */
    class Program
    {
        /* Method: Main
         * Puropse: The main entery point of the program
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // create a tardis
            Tardis tardis = new Tardis();
            // create a phone booth
            PhoneBooth phonebooth = new PhoneBooth();
            // call UsePhone
            UsePhone(tardis);
            UsePhone(phonebooth);
        }
        /* Method: UsePhone
         * Puropse: Use the phone of any aplicable object and then use a special function related to the object
         * Restrictions: None
         */
        static void UsePhone(object obj)
        {
            // cast the phone to the object to the interface reference
            PhoneInterface phoneI = (PhoneInterface)obj;
            // have the phone object make a call
            phoneI.MakeCall();
            // have the phone object hang up the phone
            phoneI.HangUp();
            // if the phone object is a tardis
            if(obj.GetType() == typeof(Tardis))
            {
                // cast the phone to the object to the tardis reference
                Tardis t = (Tardis)obj;
                // travel randomly through time
                t.TimeTravel();
            }
            // if the phone object is a phone booth
            if (obj.GetType() == typeof(PhoneBooth))
            {
                // cast the phone to the object to the phone booth reference
                PhoneBooth p = (PhoneBooth)obj;
                // open the door
                p.OpenDoor();
            }
        }
    }
}
