public class SynchronizedClock // TypeDefIndex: 13151
{
	public List<SynchronizedClock.TimedEvent> events; 

	private static float CurrentTime { get; }


	private static float get_CurrentTime() { }

	public void Add(float delta, float variance, Action<uint> action) { }

	public void Tick() { }

	public void .ctor() { }

}

public struct SynchronizedClock.TimedEvent // TypeDefIndex: 13152
{
	public float time; 
	public float delta; 
	public float variance; 
	public Action<uint> action; 

}

