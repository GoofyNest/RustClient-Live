public class LocalClock // TypeDefIndex: 13121
{
	public List<LocalClock.TimedEvent> events; 


	public void Add(float delta, float variance, Action action) { }

	public void Tick() { }

	public void .ctor() { }

}

public struct LocalClock.TimedEvent // TypeDefIndex: 13122
{
	public float time; 
	public float delta; 
	public float variance; 
	public Action action; 

}

