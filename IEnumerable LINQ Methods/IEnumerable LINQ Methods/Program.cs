

List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

List<string> stringList = new List<string>
            { "Yasser Sanad", "Mo Sanad", "Mahmoud Sanad", "Ahmed Sanad" };

// Method Syntax (way One) 
// var result = myList.Where(l => l > 5); 

// Query Syntax (way Two)
var result = from l in myList 
             where l > 5
             select l;

// في الاخر Enumerable.Where() الطريقتين بيتحولوا الي 

foreach (var item in result)
{
    Console.WriteLine(item);
}