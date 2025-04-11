namespace Core.Enums
{
    public enum Source
    {
        Salary,
        Bonus,
        Investment,
        RentalIncome,
        Other
    }

    public static class SourceExtension
    {
        public static string ToFriendlyString(this Source source)
        {
            return source switch
            {
                Source.Salary => "Salary",
                Source.Bonus => "Bonus",
                Source.Investment => "Investment",
                Source.RentalIncome => "RentalIncome",
                Source.Other => "Other",
                _ => "Unknown",
            };
        }

        public static Source ToSource(this string source)
        {
            return source.Replace(" ", "") switch
            {
                "Salary" => Source.Salary,
                "Bonus" => Source.Bonus,
                "Investment" => Source.Investment,
                "RentalIncome" => Source.RentalIncome,
                "Other" => Source.Other,
                _ => Source.Other,
            };
        }

        public static Source[] GetValues()
        {
            return [Source.Salary, Source.Bonus, Source.Investment, Source.RentalIncome, Source.Other];
        }
    }
}