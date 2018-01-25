using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class ShuffledResultClass
    {
        public List<int> ShuffledResults(List<int> main, List<int> secondary)
        {
            int[] arr = main.ToArray();
            TheShuffleClass.Shuffle(arr);
            var converted = arr.Distinct().ToList();

            foreach (var item in converted)
                secondary.Add(item);

            return secondary;
        }
    }
}
