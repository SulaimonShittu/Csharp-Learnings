
List<Student> students = new List<Student>
{
    new Student { ID = 1, FullName = "John Doe" },
    new Student { ID = 2, FullName = "Jane Doe" },
    new Student { ID = 3, FullName = "Alice" },
    new Student { ID = 4, FullName = "Bob" },
    new Student { ID = 5, FullName = "Charlie" },
    new Student { ID = 6, FullName = "David" },
    new Student { ID = 7, FullName = "Eve" },
    new Student { ID = 8, FullName = "Frank" },
    new Student { ID = 9, FullName = "Grace" },
    new Student { ID = 10, FullName = "Hannah"}
};

List<StudentRecord> studentRecords = new List<StudentRecord>
{
    new StudentRecord { StudentId = 1, EnglishScore = 80, MathsScore = 90 },
    new StudentRecord { StudentId = 2, EnglishScore = 65, MathsScore = 95 },
    new StudentRecord { StudentId = 3, EnglishScore = 90, MathsScore = 70 },
    new StudentRecord { StudentId = 4, EnglishScore = 95, MathsScore = 76 },
    new StudentRecord { StudentId = 5, EnglishScore = 91, MathsScore = 88 },
    new StudentRecord { StudentId = 6, EnglishScore = 55, MathsScore = 65 },
    new StudentRecord { StudentId = 7, EnglishScore = 92, MathsScore = 70 },
    new StudentRecord { StudentId = 8, EnglishScore = 56, MathsScore = 73 },
    new StudentRecord { StudentId = 9, EnglishScore = 70, MathsScore = 68 },
    new StudentRecord { StudentId = 10, EnglishScore = 75, MathsScore = 83 }
};

Main();

void Main()
{
    foreach (var studentRecord in studentRecords)
    {
        studentRecord.EnglishGrade = Grade(studentRecord.EnglishScore);
        studentRecord.MathsGrade = Grade(studentRecord.MathsScore);
    }

    foreach (var sr in studentRecords)
    {
        var x = students
            .FirstOrDefault(s => s.ID == sr.StudentId)
            ?.FullName;
        Console.WriteLine($"{x} - English: {sr.EnglishScore} ({sr.EnglishGrade}), Maths: {sr.MathsScore} ({sr.MathsGrade})");
    }
}



char Grade(int score)
{
    if (score >= 90)
        return 'A';
    else if (score >= 80)
        return 'B';
    else if (score >= 70)
        return 'C';
    else if (score >= 60)
        return 'D';
    else
        return 'F';
}
public class Student {
    public string FullName { get; set; }
    public int ID { get; set; }
}
public class StudentRecord
{
    public int StudentId { get; set; }
    public int EnglishScore { get; set; }
    public char EnglishGrade { get; set; }
    public int MathsScore { get; set; }
    public char MathsGrade {get; set; }
}