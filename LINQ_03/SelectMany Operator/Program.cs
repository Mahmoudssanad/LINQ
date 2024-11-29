using Example;

RunExample01();
Console.WriteLine("***************");
RunExample02();

Console.ReadKey();
void RunExample01()
{
    string[] sentences = {
                "I love asp.net core",
                "I like sql server also",
                "in general i love programming"
        };

    var words = sentences.SelectMany(x => x.Split(' '));

    var words01 = from word in words
                  from ch in word.Split(" ")
                  select ch;

    foreach (var word in words01)
    {
        Console.WriteLine(word);
    }
}

// Distinct method => do not repeate data
static void RunExample02()
{
    var employees = Repository.LoadEmployees();

    // Method Syntax
    var skills = employees.SelectMany(x => x.Skills).Distinct();

    // Query Syntax
    var result01 = (from employee in employees
                    from skill in employee.Skills
                    select skill).Distinct();

    foreach (var skill in result01)
        Console.WriteLine(skill);

}

// select Method == only one from in Query syntax
// SelectMany Method == two from in Query syntax