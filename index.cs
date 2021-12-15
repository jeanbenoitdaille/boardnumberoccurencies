    using System;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static Dictionary<int, int> StoreAndCount(int[] arr)
            {
                var res = new Dictionary<int, int>();
                foreach (var i in arr)
                {
                    if (res.ContainsKey(i))
                    {
                        res[i]++;
                    } else
                    {
                        res.Add(i, 1);
                    }
            }
                return res;
            }
        }
    }