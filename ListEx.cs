public static class ListEx // TypeDefIndex: 6583
{

	[ExtensionAttribute]
	public static T GetRandom<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-ListEx.GetRandom<ItemModEngineItem>
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute]
	public static T GetRandom<T>(List<T> list, uint seed) { }
	/* GenericInstMethod :
	|
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute]
	public static T GetRandom<T>(List<T> list, ref uint seed) { }
	/* GenericInstMethod :
	|
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute]
	public static void Shuffle<T>(List<T> list, uint seed) { }
	/* GenericInstMethod :
	|
	|-ListEx.Shuffle<int>
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute]
	public static void Shuffle<T>(List<T> list, ref uint seed) { }
	/* GenericInstMethod :
	|
	|-ListEx.Shuffle<PlaceMonumentsRailside.SpawnInfo>
	|-ListEx.Shuffle<PlaceMonumentsRoadside.SpawnInfo>
	|
	|-ListEx.Shuffle<int>
	|
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute]
	public static void BubbleSort<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-ListEx.BubbleSort<object>
	*/

	[ExtensionAttribute]
	public static void RemoveUnordered<T>(List<T> list, int index) { }
	/* GenericInstMethod :
	|
	|-ListEx.RemoveUnordered<CullingVolume>
	|-ListEx.RemoveUnordered<FoliageCell>
	|-ListEx.RemoveUnordered<PathList>
	|-ListEx.RemoveUnordered<IEnumerator>
	|-ListEx.RemoveUnordered<object>
	*/

	[ExtensionAttribute]
	public static double TruncatedAverage(List<double> list, float pct) { }

}

private sealed class ListEx.<>c // TypeDefIndex: 6584
{
	public static readonly ListEx.<>c <>9;
	public static Func<double, double> <>9__7_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal double <TruncatedAverage>

}

