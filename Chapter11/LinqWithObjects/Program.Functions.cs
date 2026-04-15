using System.Runtime.CompilerServices;

partial class Program
{
    private static void DeferredExecution(string[] names)
    {
        SectionTitle("Deferred Execution");

        var query1 = names.Where(name => name.EndsWith("m"));

        var query2 = from name in names where name.EndsWith("m") select name;

        string[] result1 = query1.ToArray();

        List<string> result2 = query2.ToList();

        foreach (string name in query1)
        {
            WriteLine(name);
            names[2] = "Jimmy";
        }
    }

    private static void FilteringUsingWhere(string[] names)
    {
        //var query = names.Where(new Func<string, bool>(NameLongerThanFour));

        //var query = names.Where(NameLongerThanFour);

        IOrderedEnumerable<string> query = names
            .Where(name => name.Length > 4)
            .OrderBy(name => name.Length)
            .ThenBy(name => name);

        foreach (string item in query)
        {
            WriteLine(item);
        }
    }

    static void FilteringByType()
    {
        SectionTitle("Filtering by type");

        List<Exception> exceptions = new()
        {
            new ArgumentException(), new SystemException(),
            new IndexOutOfRangeException(), new InvalidOperationException(),
            new NullReferenceException(), new InvalidCastException(),
            new OverflowException(), new DivideByZeroException(),
            new ApplicationException()
        };

        IEnumerable<ArithmeticException> arithmeticExceptions =
            exceptions.OfType<ArithmeticException>();

        foreach (ArithmeticException exception in arithmeticExceptions)
        {
            WriteLine(exception);
        }
    }

    static void Output(IEnumerable<string> cohort, string description ="")
    {
        if (!string.IsNullOrEmpty(description))
        {
            WriteLine(description);
        }

        Write(" ");
        WriteLine(string.Join(", ", cohort.ToArray()));
        WriteLine();
    }

    static void WorkingWithSets()
    {
        string[] cohort1 =
            { "Rachel", "Gareth", "Jonathan", "George" };

        string[] cohort2 =
            { "Jack", "Stephen", "Daniel", "Jack", "Jared" };

        string[] cohort3 =
            { "Declan", "Jack", "Jack", "Jasmine", "Conor" };

        SectionTitle("The cohorts");

        Output(cohort1, "Cohort1");
        Output(cohort2, "Cohort2");
        Output(cohort3, "Cohort3");

        SectionTitle("Set operations");

        Output(cohort2.Distinct(), "cohort2.Distinct()");
        Output(cohort2.DistinctBy(name => name.Substring(0, 2)),
            "cohort2.DistinctBy(name => name.Substring(0, 2)");
        Output(cohort2.Union(cohort3), "cohort2.Union(cohort3)");
        Output(cohort2.Concat(cohort3), "cohort2.Concat(cohort3)");
        Output(cohort2.Intersect(cohort3), "cohort2.Intersect(cohort3)");
        Output(cohort2.Except(cohort3), "cohort2.Except(cohort3)");
        Output(cohort1.Zip(cohort2,(c1, c2) => $"{c1} matched with {c2}"), "cohort1.Zip(cohort2)");
    }

    //static bool NameLongerThanFour(string name)
    //{
    //    return name.Length > 4;
    //}
}
