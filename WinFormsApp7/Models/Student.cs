namespace WinFormsApp7.Models;

public enum ParticipationStatus
{
	Unknown,
	Present,
	Absent,
	Late
}

public class Student
{
    public int Number { get; set; }
    public string? PictureUrl { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? FatherName { get; set; }
    public DateTime LastIn { get; set; }
    public ParticipationStatus Status { get; set; }
    public byte? LaboratoryWork { get; set; }
    public byte? ClassWork { get; set; }
    public byte? ActivityCrystal { get; set; }
    public string? Comment { get; set; }

    public string? FullName => $"{Name} {Surname} {FatherName}";

    public Student(int number, string? pictureUrl, string? name, string? surname, string? fatherName, DateTime lastIn, ParticipationStatus status, byte? laboratoryWork, byte? classWork, byte? activityCrystal, string? comment)
    {
        Number = number;
        PictureUrl = pictureUrl;
        Name = name;
        Surname = surname;
        FatherName = fatherName;
        LastIn = lastIn;
        Status = status;
        LaboratoryWork = laboratoryWork;
        ClassWork = classWork;
        ActivityCrystal = activityCrystal;
        Comment = comment;
    }
}