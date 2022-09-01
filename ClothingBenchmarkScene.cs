public class ClothingBenchmarkScene : BenchmarkScene // TypeDefIndex: 8250
{
	public GameObjectRef PlayerModelPrefab; 
	public bool ChangeClothingEveryFrame; 
	protected List<PlayerModel> PlayerModels; 
	protected ItemModWearable[] Wearables; 


	public override void StartBenchmark() { }

	public override void BenchmarkUpdate() { }

	public override void StopBenchmark() { }

	public void .ctor() { }

}

private sealed class ClothingBenchmarkScene.<>c // TypeDefIndex: 8251
{
	public static readonly ClothingBenchmarkScene.<>c <>9; 
	public static Func<ItemDefinition, ItemModWearable> <>9__4_0; 
	public static Func<ItemModWearable, bool> <>9__4_1; 
	public static Func<ItemModWearable, Guid> <>9__4_2; 
	public static Func<ItemModWearable, Guid> <>9__5_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal ItemModWearable <StartBenchmark>b__4_0(ItemDefinition x) { }

	internal bool <StartBenchmark>b__4_1(ItemModWearable x) { }

	internal Guid <StartBenchmark>b__4_2(ItemModWearable x) { }

	internal Guid <BenchmarkUpdate>b__5_0(ItemModWearable x) { }

}

