// look on the picture for more details
bool flag = true;

Person person = new Person();
if (flag)
{
    string textInsideIf = "aaa"; // it's not on the stack because it was remove after exiting the if statement
    person.Name = "Tom";
}

string text = "bbb";

class Person
{
    public string Name { get; set; }
}