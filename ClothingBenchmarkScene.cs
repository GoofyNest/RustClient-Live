public class ClothingBenchmarkScene : BenchmarkScene // TypeDefIndex: 8249
{	public GameObjectRef PlayerModelPrefab; // 0x40
	public bool ChangeClothingEveryFrame; // 0x48
	protected List<PlayerModel> PlayerModels; // 0x50
	protected ItemModWearable[] Wearables; // 0x58


	public override void StartBenchmark() { }

	public override void BenchmarkUpdate() { }

	public override void StopBenchmark() { }

	public void .ctor() { }

}

private sealed class ClothingBenchmarkScene.<>c // TypeDefIndex: 8250
{	public static readonly ClothingBenchmarkScene.<>c <>9; // 0x0
	public static Func<ItemDefinition, ItemModWearable> <>9__4_0; // 0x8
	public static Func<ItemModWearable, bool> <>9__4_1; // 0x10
	public static Func<ItemModWearable, Guid> <>9__4_2; // 0x18
	public static Func<ItemModWearable, Guid> <>9__5_0; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal ItemModWearable <StartBenchmark>b__4_0(ItemDefinition x) { }

	internal bool <StartBenchmark>b__4_1(ItemModWearable x) { }

	internal Guid <StartBenchmark>b__4_2(ItemModWearable x) { }

	internal Guid <BenchmarkUpdate>b__5_0(ItemModWearable x) { }

}

