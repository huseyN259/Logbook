using WinFormsApp7.Models;

namespace WinFormsApp7.Repository;

public class FakeRepository
{
    static public List<Student> GetStudents()
    {
        return new List<Student>()
        {
            new Student(1, null, "Huseyn", "Ibrahimov", "Allahverdi", new DateTime(2022, 10, 3), ParticipationStatus.Unknown, null, null, null, null),
            new Student(2, null, "Nuran", "Huseynova", "Savalan", new DateTime(2022, 10, 3), ParticipationStatus.Unknown, null, null, null, null),
            new Student(3, "avatar1.png", "Emma", "Stone", "", new DateTime(2022, 10, 2), ParticipationStatus.Present, null, null, null, null),
            new Student(4, "avatar2.png", "Andrew", "Garfield", "", new DateTime(2022, 10, 2), ParticipationStatus.Late, null, null, null, null),
			new Student(5, "avatar1.png", "Dylan", "O'brien", "", new DateTime(2022, 10, 4), ParticipationStatus.Late, null, null, null, null),
			new Student(6, "avatar1.png", "Tyler", "Posey", "", new DateTime(2022, 10, 5), ParticipationStatus.Present, null, null, null, null),
			new Student(7, null, "Crystal", "Reed", "", new DateTime(2022, 10, 1), ParticipationStatus.Absent, null, null, null, null),
		};
    }
}