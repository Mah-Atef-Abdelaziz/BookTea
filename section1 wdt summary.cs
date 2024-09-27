/*
Console.WriteLine("enter ,.....");
string input=Console.ReadLine();

Console.WriteLine(input);*/

//decimal money = Convert.ToDecimal(90.6);
//Console.WriteLine(money);
/*
DateTime x = new DateTime(2024,12,4);
x = DateTime.Now;

Console.WriteLine(x.Day);
Console.WriteLine(x.DayOfYear);
*/


/*
enum Genders
{
    Male,
    Female
}

Console.WriteLine(value: Genders.Male.ToString());
*/
/*
 
//string interpolation
string fname = "Ahmed";
string lname = "Mazen";
string sent = $"This is {fname}ssss {lname}";
Console.WriteLine(sent);
*/

/*
double h = 90.9;
string result = h.ToString();
Console.WriteLine(h);
*/

//var vari = "sad";
//vari = "der";


/*
//type casting 



decimal d = Convert.ToDecimal(45.78);
double f = (double) d;
Console.WriteLine(f);
 */
/*
int age = 20;


if (age<18)
{
    Console.WriteLine("Child");
}
else if(age>18 && age <20)
{
    Console.WriteLine("Teen");

}
else
{
    Console.WriteLine("?????????");
}
*/


//string ,object -> refrence type
//int,float,double,bool -> value type


//int? x = null;
//Console.WriteLine(x);

//String name = null;
//Console.WriteLine(name[0]); //exception

//solution 1 for null exception
/*String name = null;
if (name != null)
{

    Console.WriteLine(name[0]);
}
else
{
    Console.WriteLine("Can't be empty");
}*/

/*
   //solution 2
try
{
    string name = null;
    Console.WriteLine(name[0]);
}
catch (Exception ex)
{
    //Console.WriteLine(ex.Message);
    Console.WriteLine("Can't be empty");
}

*/

/*
List<string> names = new List<string>();
names.Add("Mohammed");
names.Add("Momen");
names.Add("Sarah");
names.Add("Ahmed");
bool ahmedexists=names.Contains("Ahmed");
Console.WriteLine(ahmedexists);

if (names.Count==0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine("not empty");
    Console.WriteLine(names.Count);
    for(int i = 0; i < names.Count; i++)
    {
        Console.WriteLine(names[i]);
    }

    foreach(var item in names)
    {
        Console.WriteLine(item);
    }

}

*/