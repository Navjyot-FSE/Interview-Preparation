using OperatorOverloading_MethodExtention;
// See https://aka.ms/new-console-template for more information
SubjectMarks math = new SubjectMarks("Math", 90);
SubjectMarks english = new SubjectMarks("English", 57);
SubjectMarks history = new SubjectMarks("History", 88);

Console.WriteLine((math + english + history).marks);
Console.WriteLine(math.ToString().GetMarks(english));