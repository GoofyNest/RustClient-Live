public struct List.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1490
{
	private List<T> list;
	private int index;
	private int version;
	private T current;

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(List<T> list) { }
	/* GenericInstMethod :
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	*/

	private bool MoveNextRare() { }
	/* GenericInstMethod :
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	|
	*/

}

public static class List // TypeDefIndex: 4849
{

	[ExtensionAttribute]
	public static void Compare<T, TListA, TListB>(TListA a, TListB b, List<T> added, List<T> removed, List<T> remained) { }
	/* GenericInstMethod :
	|
	*/

	[ExtensionAttribute]
	public static void Compare<TListA, TListB, TItemA, TItemB, TKey>(TListA a, TListB b, HashSet<TKey> added, HashSet<TKey> removed, HashSet<TKey> remained, Func<TItemA, TKey> selectorA, Func<TItemB, TKey> selectorB) { }
	/* GenericInstMethod :
	|
	|
	*/

	[ExtensionAttribute]
	public static TItem FindWith<TItem, TKey>(IReadOnlyCollection<TItem> items, Func<TItem, TKey> selector, TKey search, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|
	|
	*/

	[ExtensionAttribute]
	public static Nullable<TItem> TryFindWith<TItem, TKey>(IReadOnlyCollection<TItem> items, Func<TItem, TKey> selector, TKey search, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	*/

	[ExtensionAttribute]
	public static int FindIndexWith<TItem, TKey>(IReadOnlyList<TItem> items, Func<TItem, TKey> selector, TKey search) { }
	/* GenericInstMethod :
	|
	*/

	[CompilerGeneratedAttribute]
	internal static void <Compare>g__InitializeWith|1_0<TListA, TListB, TItemA, TItemB, TKey>(HashSet<TKey> set, HashSet<TKey> values) { }
	/* GenericInstMethod :
	|
	|
	*/

}

