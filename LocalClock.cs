public class LocalClock // TypeDefIndex: 13134
{
	public List<LocalClock.TimedEvent> events; 


	public void Add(float delta, float variance, Action action) { }

	public void Tick() { }

	public void .ctor() { }

}

public struct LocalClock.TimedEvent // TypeDefIndex: 13135
{
	public float time; 
	public float delta; 
	public float variance; 
	public Action action; 

}

