using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Section 7.3", "8-19", "Roberto Rodriguez", "Fractions"); 
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II", "Mary Waters", "");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
    public class Assignment
    {
        protected string _studentName;
        private string _topic;

        public Assignment(string name, string topic)
        {
            _studentName = name;
            _topic = topic;
        }

        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public MathAssignment(string textbookSection, string problems, string name, string topic) : base(name, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        public string GetHomeworkList() 
        {
            return $"{_textbookSection} Problems {_problems}";
        }
    }
    public class WritingAssignment : Assignment
    {
        private string _title;

        public WritingAssignment(string title, string name, string topic) : base(name, topic)
        {
            _title = title;
        }              

        public string GetWritingInformation() 
        {
            return $"{_title} by {_studentName}";
        }
    }
}