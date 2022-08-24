public class LocalClock // TypeDefIndex: 11382
{
	public List<LocalClock.TimedEvent> events; 


public void Add(float delta, float variance, Action action) { }

public void Tick() { }

public void .ctor() { }

}

public struct LocalClock.TimedEvent // TypeDefIndex: 11383
{
	public float time; 
	public float delta; 
	public float variance; 
	public Action action; 

}

