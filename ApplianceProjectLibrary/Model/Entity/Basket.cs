using System;

namespace ApplianceLibrary.Model.Entity
{
    public class Basket
    {
        private const int DEFAULT_SIZE = 100;
        private const string MSG_BASKET_IS_EMPTY = "Error! Basket is empty!";
        private const string MSG_BASKET_IS_FULL = "Error! Basket is full!";
        private const string MSG_POSITION = "Position in basket";

        private int count;
        private Appliance[] appliances;

        public Basket()
        {
            count = 0;
            appliances = new Appliance[DEFAULT_SIZE];
        }

        public int GetCount()
        {
            return count;
        }
        private bool ValidateIndex(int index)
        {
            return index >= 0 && index < count;
        }

        public Appliance this[int index]
        {
            get
            {
                if (ValidateIndex(index))
                {
                    return appliances[index];
                }

                throw new NotImplementedException();
            }
        }

        private bool IsEmpty()
        {
            return count == 0;
        }

        private bool IsFull()
        {
            return count == DEFAULT_SIZE;
        }

        public void Add(Appliance appliance)
        {
            if (IsFull())
            {
                Console.WriteLine(MSG_BASKET_IS_FULL);
            }
            else
            {
                appliances[count++] = appliance;
            }
        }

        public override string ToString()
        {
            string msg = "";

            if (IsEmpty())
            {
                msg = MSG_BASKET_IS_EMPTY;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    msg += MSG_POSITION + ": " + (i + 1) + "\n" +
                           appliances[i] + "\n";
                }
            }

            return msg;
        }
    }
}