public class Person {
    public string First {get; set;} = "Janelle";
    public string Last {get; set;} = "Doe";
    public string FullName => $"{First} {Last}";
    public string Phone {get; set;} = "555-1234";
    public string Email {get; set;} = "NotReal@SpamAlot.com";
}