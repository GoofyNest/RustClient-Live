public sealed class TimeWarning : IDisposable // TypeDefIndex: 5600
{

	private void .ctor() { }

	public static TimeWarning New(string name, int maxmilliseconds = 0) { }

	public void Dispose() { }

	[ConditionalAttribute] 
	public static void BeginSample(string name) { }

	[ConditionalAttribute] 
	public static void EndSample() { }

}

