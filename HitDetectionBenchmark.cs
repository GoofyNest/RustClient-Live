public class HitDetectionBenchmark : BenchmarkScene // TypeDefIndex: 8255
{	// Fields
	private const int PlayerCount = 50;
	public GameObjectRef PlayerModelPrefab; // 0x40
	public GameObjectRef PlayerCollisionPrefab; // 0x48
	protected List<PlayerModel> PlayerModels; // 0x50
	protected List<BaseCollision> PlayerCollisions; // 0x58
	protected ItemModWearable[] Wearables; // 0x60

	// Methods

	// RVA: 0x754E90 Offset: 0x754290 VA: 0x180754E90 Slot: 7
	public override void StartBenchmark() { }

	// RVA: 0x754B10 Offset: 0x753F10 VA: 0x180754B10 Slot: 8
	public override void BenchmarkUpdate() { }

	// RVA: 0x755530 Offset: 0x754930 VA: 0x180755530 Slot: 9
	public override void StopBenchmark() { }

	// RVA: 0x7557E0 Offset: 0x754BE0 VA: 0x1807557E0
	public void .ctor() { }

}

private sealed class HitDetectionBenchmark.<>c // TypeDefIndex: 8256
{	// Fields
	public static readonly HitDetectionBenchmark.<>c <>9; // 0x0
	public static Func<ItemDefinition, ItemModWearable> <>9__6_0; // 0x8
	public static Func<ItemModWearable, bool> <>9__6_1; // 0x10
	public static Func<ItemModWearable, Guid> <>9__6_2; // 0x18

	// Methods

	// RVA: 0x762AE0 Offset: 0x761EE0 VA: 0x180762AE0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x762970 Offset: 0x761D70 VA: 0x180762970
	internal ItemModWearable <StartBenchmark>b__6_0(ItemDefinition x) { }

	// RVA: 0x7629C0 Offset: 0x761DC0 VA: 0x1807629C0
	internal bool <StartBenchmark>b__6_1(ItemModWearable x) { }

	// RVA: 0x762A20 Offset: 0x761E20 VA: 0x180762A20
	internal Guid <StartBenchmark>b__6_2(ItemModWearable x) { }

}

