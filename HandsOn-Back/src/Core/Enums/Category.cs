namespace Core.Enums
{
    public enum Category
    {
        Infrastructure,
        Machine, 
        input, 
        defensive,
        othersLongTerm,
        othersShortTerm
    }

    public static class CategoryExtension
    {
        public static string ToFriendlyString(this Category category)
        {
            return category switch
            {
                Category.Infrastructure => "Infrastructure",
                Category.Machine => "Machine",
                Category.input => "input",
                Category.defensive => "defensive",
                Category.othersLongTerm => "othersLongTerm",
                Category.othersShortTerm => "othersShortTerm",
                _ => "Unknown",
            };
        }

        public static Category ToCategory(this string category)
        {
            return category.Replace(" ", "") switch
            {
                "Infrastructure" => Category.Infrastructure,
                "Machine" => Category.Machine,
                "input" => Category.input,
                "defensive" => Category.defensive,
                "othersLongTerm" => Category.othersLongTerm,
                "othersShortTerm" => Category.othersShortTerm,
                _ => Category.Infrastructure,
            };
        }

        public static Category[] GetValues()
        {
            return [Category.Infrastructure, Category.Machine, Category.input, Category.defensive, Category.othersLongTerm, Category.othersShortTerm];
        }
    }
}