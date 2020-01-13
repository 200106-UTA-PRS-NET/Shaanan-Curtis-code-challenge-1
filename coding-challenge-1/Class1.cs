using System;

namespace Library
{
    using System;

    namespace Library
    {
        public class Class1
        {
            public bool Method1(string temp)
            {
                int i = 0;
                int j = temp.Length - 1;
                while (i < temp.Length / 2)
                {
                    if (!char.IsLetter(temp[i]))
                        i++;
                    else if (!char.IsLetter(temp[j]))
                        j--;

                    if (char.ToLower(temp[i]) != char.ToLower(temp[j]))
                        return false;

                    j--;
                    i++;
                }
                return true;
            }
        }
    }
}
