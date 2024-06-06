namespace Task
{
    public static class Task1
    {
        public static List<int> AddList(int length)
        {
            List<int> list = new List<int>();
            Random rndm = new Random();
            while (list.Count < length)
            {
                int randomNum = rndm.Next(1, 50);
                bool found = false;
                int index = 0;
                while (index < list.Count)
                {
                    if (list[index] == randomNum)
                    {
                        found = true;
                        break;
                    }
                    index++;
                }
                if (!found)
                {
                    list.Add(randomNum);
                }
            }

            return list;
        }
    }
}

