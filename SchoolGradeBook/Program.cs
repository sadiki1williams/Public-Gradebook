using System;
using System.Collections.Generic;

class Gradebook
{
    // A simple class to store student ID and grade
    class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }
        public int ID { get; set; }
        public Student(string name, int id)
        {
            Name = name;
            Grades = new List<int>();
            ID = id;
        }
    }

    static void Main(string[] args)
    {
        // List is used to store all students
        List<Student> students = new List<Student>();

        // Try to add students and their grades
        students.Add(new Student("Sadiki", 1));
        students[0].Grades.AddRange(new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 });

        students.Add(new Student("Landley", 2));
        students[1].Grades.AddRange(new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 });

        students.Add(new Student("Elijah", 3));
        students[2].Grades.AddRange(new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 });

        students.Add(new Student("Manny", 4));
        students[3].Grades.AddRange(new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 });

        students.Add(new Student("Christian", 5));
        students[4].Grades.AddRange(new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 });

        students.Add(new Student("Zay", 6));
        students[5].Grades.AddRange(new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 });

        // New method to calculate the average grade
        foreach (var student in students)
        {
            double averageGrade = CalculateAverage(student.Grades);
            Console.WriteLine($"Student: {student.Name}, Average Grade: {averageGrade:F2}");
        }
    }

    static double CalculateAverage(List<int> grades)
    {
        if (grades.Count == 0)
            return 0;
        int total = 0;
        foreach (var grade in grades)
        {
            total += grade;
        }
        return (double)total / grades.Count;
    }


    private static int PrintMenu()
    {
        PrintStars(80);
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Remove Student");
        Console.WriteLine("3. View all Students");
        Console.WriteLine("4. Add Grade");
        Console.WriteLine("5. Calculate Average Grade");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        return int.Parse(Console.ReadLine());
        PrintStars(80);

