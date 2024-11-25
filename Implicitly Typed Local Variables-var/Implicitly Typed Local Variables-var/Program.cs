// var => Implicitly Typed Local Variables
//     =>   نوعه هيتحدد اوتوماتيك علي حسب القيمه الا انا هدهاله اول مره var لو عملت متغر نوعه 


using Seed_Data;
// في المكان ال عاوز استخدمها فيه Extention method الا انا معرف فيها ال namespace لل using لازم اعمل 
using Implicitly_Typed_Local_Variables_var.Extention;

// getByName => Extention Method in => Implicitly_Typed_Local_Variables_var.Extention (namespace)
var listByName = GetData.GetCustomers().getByName("ahmed");

foreach (var kvp in listByName)
{
    Console.WriteLine($"name {kvp.name} : age {kvp.age}");
}
