using System;

namespace HolisticWare.Security
{
    public partial class RandomData
    {
        public RandomData()
        {
        }

        static RandomData()
        {
            seed = Convert.ToInt32(DateTime.Now.Subtract(DateTime.Today).TotalSeconds);

            rand = new Random(seed); // changing the seed to get more randomized

            return;
        }

        static int seed;
        static Random rand = null;

        public string RandomString(ulong number_of_characters = 16)
        {
            //
            // Generate a unique state string to check for forgeries
            //

            char[] chars = new char[number_of_characters];

            for (var i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)rand.Next((int)'a', (int)'z' + 1);
            }

            string state_string = new string(chars);

            return state_string;
        }
    }
}
