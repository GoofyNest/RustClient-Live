public class HitDetectionBenchmark : BenchmarkScene // TypeDefIndex: 9960
{
	private const int PlayerCount = 50;
	public GameObjectRef PlayerModelPrefab; 
	public GameObjectRef PlayerCollisionPrefab; 
	protected List<PlayerModel> PlayerModels; 
	protected List<BaseCollision> PlayerCollisions; 
	protected ItemModWearable[] Wearables; 


	public override void StartBenchmark() { }

	public override void BenchmarkUpdate() { }

	public override void StopBenchmark() { }

	public void .ctor() { }

}

private sealed class HitDetectionBenchmark.<>c // TypeDefIndex: 9961
{
	public static readonly HitDetectionBenchmark.<>c <>9; 
	public static Func<ItemDefinition, ItemModWearable> <>9__6_0; 
	public static Func<ItemModWearable, bool> <>9__6_1; 
	public static Func<ItemModWearable, Guid> <>9__6_2; 


	private static void .cctor() { }

	public void .ctor() { }

	internal ItemModWearable <StartBenchmark>b__6_0(ItemDefinition x) { }

	internal bool <StartBenchmark>b__6_1(ItemModWearable x) { }

	internal Guid <StartBenchmark>b__6_2(ItemModWearable x) { }

}

