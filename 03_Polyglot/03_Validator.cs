public class Auth {
    public static string ValidateLogin(string username, string password) {
        return username switch {
            "integerman" when password == "FuzzyBunny" => "You're in. Don't look in your variables pane.",
            "integerman" => $"I'm sorry, but IntegerMan's password is 'FuzzyBunny', not '{password}'",
            _ => $"I'm sorry, but the password '{password}' belongs to 'noobslayer69' and cannot be used by your username."
        };
    }
}