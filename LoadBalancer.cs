public class LoadBalancer : SingletonComponent<LoadBalancer> // TypeDefIndex: 13107
{
	public static bool Paused;
	private const float MinMilliseconds = 1;
	private const float MaxMilliseconds = 100;
	private const int MinBacklog = 1000;
	private const int MaxBacklog = 100000;
	private Queue<DeferredAction>[] queues;
	private Stopwatch watch;


	protected void LateUpdate() { }

	public static int Count() { }

	public static void ProcessAll() { }

	public static void Enqueue(DeferredAction action) { }

	private static void CreateInstance() { }

	public void .ctor() { }

	private static void .cctor() { }

}

