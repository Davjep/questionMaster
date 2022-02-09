// See https://aka.ms/new-console-template for more information


namespace questionMaster {
    
    public class Program {
        public static void Main(string[] args) {
            string hello = "Hello World";
            Questions questions = new Questions();
            
            Console.WriteLine(hello + " " + questions.getQuestion());
        }
    }
}
