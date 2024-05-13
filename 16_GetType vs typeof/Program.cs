using static System.Console;

// Example 1
Type type1 = typeof(Base);
WriteLine(type1.FullName);

var baseObj = new Base();
Type type2 = baseObj.GetType();
WriteLine("FullName: " + type2.FullName);
WriteLine("Attributes: " + type2.Attributes);
WriteLine("BaseType: " + type2.BaseType);
WriteLine("ContainsGenericParameters: " + type2.ContainsGenericParameters);
WriteLine("DeclaringType: " + type2.DeclaringType);
WriteLine("Namespace: " + type2.Namespace);
WriteLine("MemberType: " + type2.MemberType);


// Example 2
PrintTypeName("aaa");
PrintTypeName(10);

// Example 3
Base derivedAsBase = new Derived();
var type3 = derivedAsBase.GetType();
WriteLine(type3.FullName);

ReadKey();

// Example 2
void PrintTypeName(object obj)
{    
    var type1 = obj.GetType();
    //var type2 = typeof(obj);   // doesn't work, object will be known at runtime
    WriteLine(type1.FullName);
}


// Example 1
class Base
{

}

class Derived : Base
{

}