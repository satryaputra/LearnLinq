/*
 * IEnumerable<T> 
 * 
 * (IEnumerable of T) is an interface implemented by most the C# collections,
 * Arrays, Lists, HashSets, Dictionaries all implement it.
 * The 'T' means any type. For example, we can have IEnumerable of -
 * integers, datetimes, strings or anything else.
 * 
 * This interface enables iterating a collection with a foreach loop.
 * If a type does not implement the IEnumerable interface,
 * it will not be possible to iterate it with this type of a loop.
 * 
 * As i said before, most of the LINQ methods are extension - 
 * methods for IEnumerable of T. That means we can user them -
 * with any type that implements this interface.
 * 
 * Another important thing to know about IEnumerable is - 
 * that is doesn't expose any methods for collection modification.
 * That means LINQ methods will never modify the input collections because - 
 * they simply don't have the means to do so. There are no methods for collection - 
 * modification in the IEnumerable of T interface that LINQ could use to - 
 * modify a collection.
 * 
 * LINQ provides methods like, for example, Append. 
 * That adds an element at the end of collection.
 * !!! Still, the original collection will not be modified by this method.
 * !!! A new collection will be created instead.
 */

var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
var numbersWith10 = numbers.Append(10); // return IEnumerable<int>

Console.WriteLine("Numbers: " + string.Join(", ", numbers));
Console.WriteLine("Numbers with 10: " + string.Join(", ", numbersWith10));

Console.ReadKey();

/*
 * The numbers collection has not been modified.
 * The number 10 is not there.
 * A new collection with 10 at the end has been created.
 *
 * Whenever LINQ executes an opertaion that creates a new collection,
 * it return it as IEnumerable of T.
 * 
 * There are more methods that produce new collections in LINQ. 
 * For example, there is the Where method that filters the collection, or
 * OrderBy method that sorts it.
 * They both produce the result as an IEnumerable of T and they don't - 
 * modify the input collection.
 * 
 * Note : IOrderedEnumerable<T> is derived from IEnumerable<T>
 */