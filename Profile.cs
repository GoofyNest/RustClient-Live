public class Profile // TypeDefIndex: 11085
{
	public Stopwatch watch; 
	public string category; 
	public string name; 
	public float warnTime; 


	public void .ctor(string cat, string nam, float WarnTime = 1) { }

	public void Start() { }

	public void Stop() { }

}

public class Profile : ConsoleSystem // TypeDefIndex: 13692
{

	private static void NeedProfileFolder() { }

	[ClientVar] 
	[ServerVar] 
	public static void start(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void stop(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

}

