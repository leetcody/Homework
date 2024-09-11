namespace ConsoleApp1;

internal class Program { 
	private static void Main() {
		string firstName = "Cody";
		string lastName = "Leet";
		string country = "Canada";
		string college = "NBCC";
		string programOfStudy = "IT: Software Development";
        
		string outputString = "My name is " + firstName + " " + lastName + ", and I am from " + country + ".\n" + 
		                      "I am currently enrolled in " + programOfStudy + " at " + college;
        
		Console.WriteLine(outputString);
	}
}
