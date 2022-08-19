public static class ListEx // TypeDefIndex: 6569
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetRandom<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB040 Offset: 0x5EA440 VA: 0x1805EB040
	|-ListEx.GetRandom<ItemModEngineItem>
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetRandom<T>(List<T> list, uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EAFC0 Offset: 0x5EA3C0 VA: 0x1805EAFC0
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetRandom<T>(List<T> list, ref uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB0B0 Offset: 0x5EA4B0 VA: 0x1805EB0B0
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void Shuffle<T>(List<T> list, uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537080 Offset: 0x1536480 VA: 0x181537080
	|-ListEx.Shuffle<int>
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void Shuffle<T>(List<T> list, ref uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1541040 Offset: 0x1540440 VA: 0x181541040
	|-ListEx.Shuffle<PlaceMonumentsRailside.SpawnInfo>
	|-ListEx.Shuffle<PlaceMonumentsRoadside.SpawnInfo>
	|
	|-RVA: 0x1540DF0 Offset: 0x15401F0 VA: 0x181540DF0
	|-ListEx.Shuffle<int>
	|
	|-RVA: 0x1540F10 Offset: 0x1540310 VA: 0x181540F10
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void BubbleSort<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1540C30 Offset: 0x1540030 VA: 0x181540C30
	|-ListEx.BubbleSort<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void RemoveUnordered<T>(List<T> list, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1540D60 Offset: 0x1540160 VA: 0x181540D60
	|-ListEx.RemoveUnordered<CullingVolume>
	|-ListEx.RemoveUnordered<FoliageCell>
	|-ListEx.RemoveUnordered<PathList>
	|-ListEx.RemoveUnordered<IEnumerator>
	|-ListEx.RemoveUnordered<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1B9EF50 Offset: 0x1B9E350 VA: 0x181B9EF50
	public static double TruncatedAverage(List<double> list, float pct) { }

}

private sealed class ListEx.<>c // TypeDefIndex: 6570
{	// Fields
	public static readonly ListEx.<>c <>9; // 0x0
	public static Func<double, double> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x1BAAC60 Offset: 0x1BAA060 VA: 0x181BAAC60
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1BAAC50 Offset: 0x1BAA050 VA: 0x181BAAC50
	internal double <TruncatedAverage>b__7_0(double x) { }

}

