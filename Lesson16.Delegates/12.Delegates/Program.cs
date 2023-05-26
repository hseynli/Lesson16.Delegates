Functional functional = new Functional(MethodF);

Delegate3 delegate3 = functional.Invoke(new Delegate1(Method1), new Delegate2(Method2));

Console.WriteLine(delegate3.Invoke());

Delegate3 MethodF(Delegate1 delegate1, Delegate2 delegate2)
{
    return delegate { return delegate1.Invoke() + delegate2.Invoke(); };
}

string Method1() { return "Hello "; }
string Method2() { return "world!"; }

delegate Delegate3 Functional(Delegate1 delegate1, Delegate2 delegate2);
delegate string Delegate1();
delegate string Delegate2();
delegate string Delegate3();