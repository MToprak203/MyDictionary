namespace MyDictionary
{
    class MyDictionary<T,K>
    {
        T[] Keys;
        K[] Values;

        public MyDictionary()
        {
            Keys = new T[0];
            Values = new K[0];
        }

        public void Add(T key, K value)
        {
            T[] tempKeys = Keys;
            K[] tempValues = Values;

            Keys = new T[Keys.Length + 1];
            Values = new K[Values.Length + 1];

            for(int i = 0; i < tempKeys.Length; i++)
            {
                Keys[i] = tempKeys[i];
                Values[i] = tempValues[i];
            }

            Keys[Keys.Length - 1] = key;
            Values[Values.Length - 1] = value;
        }

       /* public K GetValue(T key)
        {
            int i;
            for (i = 0; i < Keys.Length; i++)
            {
                if (Keys[i].Equals(key))
                    break;
            }

            if (i == Keys.Length)
                return default(K);

            return Values[i];
        }
       */
    }
}
