var words = new List<string> { "a", "bb", "ccc", "dddd" };
var wordsLongerThan2Letters = words.Where(word => word.Length > 2);

var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
var oddNumbers = numbers.Where(number => number % 2 == 1);

Console.ReadKey();

/*
 * Why words and numbers still can use where method, even though they have different types (List and Array)?
 * 
 * Because the where method is not defined in the List class nor the Array class, but in Enumerable class.
 * The where method itself is also static and it is an Extension method,
 * 
 * ==> public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource>, ...) {...}
 * 
 * the extended type is IEnumerable of T (C# Collections).
 * 
 * LINQ is basically a group of extension methods for IEnumerable,
 * we can use it with almost every C# Collections. No matter if we -
 * operate on an Array, a List, or anything else. We'll be using LINQ all the same.
 * That's one of the greatest advantages of LINQ.
 * 
 * LINQ is one of the namespaces imported with global usings, so we can import it in any file
 */