public class MathAssignment : Assignment
{
    // Attributes
    // textbook section ("7.3")
    private string _textbookSection;
    // problems from the section ("3-10, 20-21")
    private string _problems;


    // Constructor
    // should require a value for each item it stores
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        // _studentName = studentName;
        // _topic = topic;
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method
    // return a summary of the assignment w/ name & topic
    // display math homework list w/ section # & problems ("Section 7.3 Problems 8-19")
    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }

}