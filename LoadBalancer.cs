public class LoadBalancer : SingletonComponent<LoadBalancer> // TypeDefIndex: 11307
{	// Fields
	public static bool Paused; // 0x0
	private const float MinMilliseconds = 1;
	private const float MaxMilliseconds = 100;
	private const int MinBacklog = 1000;
	private const int MaxBacklog = 100000;
	private Queue<DeferredAction>[] queues; // 0x18
	private Stopwatch watch; // 0x20

	// Methods

	// RVA: 0x4F47B0 Offset: 0x4F3BB0 VA: 0x1804F47B0
	protected void LateUpdate() { }

	// RVA: 0x4F44B0 Offset: 0x4F38B0 VA: 0x1804F44B0
	public static int Count() { }

	// RVA: 0x4F4AF0 Offset: 0x4F3EF0 VA: 0x1804F4AF0
	public static void ProcessAll() { }

	// RVA: 0x4F4670 Offset: 0x4F3A70 VA: 0x1804F4670
	public static void Enqueue(DeferredAction action) { }

	// RVA: 0x4F45D0 Offset: 0x4F39D0 VA: 0x1804F45D0
	private static void CreateInstance() { }

	// RVA: 0x4F4C50 Offset: 0x4F4050 VA: 0x1804F4C50
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

