public class ClothingBenchmarkScene : BenchmarkScene // TypeDefIndex: 8249
{	// Fields
	public GameObjectRef PlayerModelPrefab; // 0x40
	public bool ChangeClothingEveryFrame; // 0x48
	protected List<PlayerModel> PlayerModels; // 0x50
	protected ItemModWearable[] Wearables; // 0x58

	// Methods

	// RVA: 0x58E7A0 Offset: 0x58DBA0 VA: 0x18058E7A0 Slot: 7
	public override void StartBenchmark() { }

	// RVA: 0x58E440 Offset: 0x58D840 VA: 0x18058E440 Slot: 8
	public override void BenchmarkUpdate() { }

	// RVA: 0x58ECE0 Offset: 0x58E0E0 VA: 0x18058ECE0 Slot: 9
	public override void StopBenchmark() { }

	// RVA: 0x58EE50 Offset: 0x58E250 VA: 0x18058EE50
	public void .ctor() { }

}

private sealed class ClothingBenchmarkScene.<>c // TypeDefIndex: 8250
{	// Fields
	public static readonly ClothingBenchmarkScene.<>c <>9; // 0x0
	public static Func<ItemDefinition, ItemModWearable> <>9__4_0; // 0x8
	public static Func<ItemModWearable, bool> <>9__4_1; // 0x10
	public static Func<ItemModWearable, Guid> <>9__4_2; // 0x18
	public static Func<ItemModWearable, Guid> <>9__5_0; // 0x20

	// Methods

	// RVA: 0x5A3580 Offset: 0x5A2980 VA: 0x1805A3580
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5A3280 Offset: 0x5A2680 VA: 0x1805A3280
	internal ItemModWearable <StartBenchmark>b__4_0(ItemDefinition x) { }

	// RVA: 0x5A32D0 Offset: 0x5A26D0 VA: 0x1805A32D0
	internal bool <StartBenchmark>b__4_1(ItemModWearable x) { }

	// RVA: 0x5A3330 Offset: 0x5A2730 VA: 0x1805A3330
	internal Guid <StartBenchmark>b__4_2(ItemModWearable x) { }

	// RVA: 0x5A3200 Offset: 0x5A2600 VA: 0x1805A3200
	internal Guid <BenchmarkUpdate>b__5_0(ItemModWearable x) { }

}

