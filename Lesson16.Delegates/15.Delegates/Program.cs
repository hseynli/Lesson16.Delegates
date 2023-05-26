// Action deleqatı ilə təyin olunmuş metodların qaytardığı nəticə void olmalıdır.
Action<string> action = new Action<string>(GetStr);
action.Invoke("Hello World!");

Action<string, string> action2 = (string s, string k) => { Console.WriteLine(s + k); };
action2("Hello ", "World!");

Action<string, string> action3 = (text1, text2) => { Console.WriteLine(text1 + text2); };
action3("Hello ", "World!");

void GetStr(string text) => Console.WriteLine(text);