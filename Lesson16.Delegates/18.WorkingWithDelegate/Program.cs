string[] names = new string[] { "Farid", "Hesen", "Kazim", "Fariq" };
IEnumerable<string> query = names.Filter(p => p.StartsWith("F"));

IEnumerable<string> query2 = names.Filter(p => CustomFilter(p));

for (int i = 0; i < query.Count(); i++)
    Console.WriteLine(query.ElementAt(i));

bool CustomFilter(string input)
{
    return input == "Farid";
}

static class Extensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        List<T> list = new List<T>();

        for (int i = 0; i < source.Count(); i++)
            if (predicate(source.ElementAt(i)))
                list.Add(source.ElementAt(i));

        return list;
    }
}