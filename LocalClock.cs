public class LocalClock // TypeDefIndex: 11382
{	// Fields
	public List<LocalClock.TimedEvent> events; // 0x10

	// Methods

	// RVA: 0x4F7670 Offset: 0x4F6A70 VA: 0x1804F7670
	public void Add(float delta, float variance, Action action) { }

	// RVA: 0x4F7760 Offset: 0x4F6B60 VA: 0x1804F7760
	public void Tick() { }

	// RVA: 0x4F78F0 Offset: 0x4F6CF0 VA: 0x1804F78F0
	public void .ctor() { }

}

public struct LocalClock.TimedEvent // TypeDefIndex: 11383
{	// Fields
	public float time; // 0x0
	public float delta; // 0x4
	public float variance; // 0x8
	public Action action; // 0x10

}

