namespace Core.Enums
{
    public enum Category
    {
        Infrastructure,
        Machine, 
        Input, 
        Defensive,
        OthersLongTerm,
        OthersShortTerm
    }

    public static class CategoryExtension
    {
        public static string ToFriendlyString(this Category category)
        {
            return category switch
            {
                Category.Infrastructure => "Infrastructure",
                Category.Machine => "Machine",
                Category.Input => "Input",
                Category.Defensive => "Defensive",
                Category.OthersLongTerm => "OthersLongTerm",
                Category.OthersShortTerm => "OthersShortTerm",
                _ => "Unknown",
            };
        }

        public static Category ToCategory(this string category)
        {
            return category.Replace(" ", "") switch
            {
                "Infrastructure" => Category.Infrastructure,
                "Machine" => Category.Machine,
                "Input" => Category.Input,
                "Defensive" => Category.Defensive,
                "OthersLongTerm" => Category.OthersLongTerm,
                "OthersShortTerm" => Category.OthersShortTerm,
                _ => Category.Infrastructure,
            };
        }

        public static Category[] GetValues()
        {
            return [Category.Infrastructure, Category.Machine, Category.Input, Category.Defensive, Category.OthersLongTerm, Category.OthersShortTerm];
        }
    }
}