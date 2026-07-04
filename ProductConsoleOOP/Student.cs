
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public Student()
    {

    }
    public Student(int Id, string name, DateOnly DateOfBirth)
    {
        this.Id = Id;
        this.Name = name;
        this.DateOfBirth = DateOfBirth;
    }
    public int CalculateAge()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);

        int age = today.Year - DateOfBirth.Year;

        if (today.Month < DateOfBirth.Month ||
           (today.Month == DateOfBirth.Month && today.Day < DateOfBirth.Day))
        {
            age--;
        }

        return age;
    }
}
