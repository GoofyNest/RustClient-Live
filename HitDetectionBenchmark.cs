public class HitDetectionBenchmark : BenchmarkScene // TypeDefIndex: 8255
{	private const int PlayerCount = 50;
	public GameObjectRef PlayerModelPrefab; // 0x40
	public GameObjectRef PlayerCollisionPrefab; // 0x48
	protected List<PlayerModel> PlayerModels; // 0x50
	protected List<BaseCollision> PlayerCollisions; // 0x58
	protected ItemModWearable[] Wearables; // 0x60


	public override void StartBenchmark() { }

	public override void BenchmarkUpdate() { }

	public override void StopBenchmark() { }

	public void .ctor() { }

}

private sealed class HitDetectionBenchmark.<>c // TypeDefIndex: 8256
{	public static readonly HitDetectionBenchmark.<>c <>9; // 0x0
	public static Func<ItemDefinition, ItemModWearable> <>9__6_0; // 0x8
	public static Func<ItemModWearable, bool> <>9__6_1; // 0x10
	public static Func<ItemModWearable, Guid> <>9__6_2; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal ItemModWearable <StartBenchmark>b__6_0(ItemDefinition x) { }

	internal bool <StartBenchmark>b__6_1(ItemModWearable x) { }

	internal Guid <StartBenchmark>b__6_2(ItemModWearable x) { }

}

