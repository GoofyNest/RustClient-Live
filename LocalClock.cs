public class LocalClock // TypeDefIndex: 11382
{	public List<LocalClock.TimedEvent> events; // 0x10


	public void Add(float delta, float variance, Action action) { }

	public void Tick() { }

	public void .ctor() { }

}

public struct LocalClock.TimedEvent // TypeDefIndex: 11383
{	public float time; // 0x0
	public float delta; // 0x4
	public float variance; // 0x8
	public Action action; // 0x10

}

