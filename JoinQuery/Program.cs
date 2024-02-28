//List<int> list = new() { 1, 2, 3, 4, 5 };
//List<int> anotherList = new() { 4, 5, 6 };

//var query = (from l1 in list
//             join l2 in anotherList on l1 equals l2
//             select l1).ToArray();

//var queryMethod = list.Join(anotherList,
//                            l1 => l1,
//                            l2 => l2,
//                            (l1, l2) => new { l1, l2 }).ToArray();

//Array.ForEach(queryMethod, x => Console.WriteLine(x));

using JoinQuery;

var universities = new List<University>
{
    new University { Id = 1, Name = "TATU", Address = "Tashkent" },
    new University { Id = 2, Name = "Inha", Address = "Tashkent" },
    new University { Id = 3, Name = "Milliy", Address = "Tashkent" },
    new University { Id = 4, Name = "Jahon tillari", Address = "Tashkent" },
    new University { Id = 5, Name = "Westminister", Address = "Tashkent" },
    new University { Id = 6, Name = "TAQI", Address = "Tashkent" },
    new University { Id = 7, Name = "Turin", Address = "Tashkent" },
};

var students = new List<Student>
{
    new Student { Id = 1, FullName = "Anvar", Major = "CS", UniversityId = 1 },
    new Student { Id = 2, FullName = "Akmal", Major = "SWE", UniversityId = 1 },
    new Student { Id = 3, FullName = "Nodir", Major = "AI", UniversityId = 2 },
    new Student { Id = 4, FullName = "Sanjar", Major = "DB", UniversityId = 5 },
    new Student { Id = 5, FullName = "Ikrom", Major = "ML", UniversityId = 2 },
    new Student { Id = 6, FullName = "Akrom", Major = "DL", UniversityId = 2 },
    new Student { Id = 7, FullName = "Fayzulla", Major = "NLP", UniversityId = 2 },
    new Student { Id = 8, FullName = "Dilshod", Major = "CC", UniversityId = 1 },
    new Student { Id = 9, FullName = "Sarvar", Major = "Eng", UniversityId = 4 },
    new Student { Id = 10, FullName = "Sardor", Major = "AD", UniversityId = 6 },
};

var query = from university in universities
            join student in students on university.Id equals student.UniversityId
            select new { university.Address, university.Name, student.Major, student.FullName };

var queryMethod = universities.Join(students,
                                    u => u.Id,
                                    s => s.UniversityId,
                                    (u, s) =>
                                    new { u.Name, s.Major, s.FullName, u.Address });

foreach (var item in queryMethod)
{
    Console.WriteLine($"Universitet nomi: {item.Name}, universitet joylashuvi: {item.Address}," +
        $" talaba ismi: {item.FullName}, talaba yo'nalishi: {item.Major}");
}
