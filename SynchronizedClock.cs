public class SynchronizedClock // TypeDefIndex: 11399
{	// Fields
	public List<SynchronizedClock.TimedEvent> events; // 0x10

	// Properties
	private static float CurrentTime { get; }

	// Methods

	// RVA: 0x7A4F90 Offset: 0x7A4390 VA: 0x1807A4F90
	private static float get_CurrentTime() { }

	// RVA: 0x7A4B60 Offset: 0x7A3F60 VA: 0x1807A4B60
	public void Add(float delta, float variance, Action<uint> action) { }

	// RVA: 0x7A4C60 Offset: 0x7A4060 VA: 0x1807A4C60
	public void Tick() { }

	// RVA: 0x7A4F20 Offset: 0x7A4320 VA: 0x1807A4F20
	public void .ctor() { }

}

public struct SynchronizedClock.TimedEvent // TypeDefIndex: 11400
{	// Fields
	public float time; // 0x0
	public float delta; // 0x4
	public float variance; // 0x8
	public Action<uint> action; // 0x10

}

