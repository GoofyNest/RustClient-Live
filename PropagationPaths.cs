internal class PropagationPaths // TypeDefIndex: 4700
{	private static readonly ObjectPool<PropagationPaths> s_Pool; // 0x0
	public readonly List<VisualElement> trickleDownPath; // 0x10
	public readonly List<VisualElement> targetElements; // 0x18
	public readonly List<VisualElement> bubbleUpPath; // 0x20


	public void .ctor() { }

	internal static PropagationPaths Copy(PropagationPaths paths) { }

	public static PropagationPaths Build(VisualElement elem, PropagationPaths.Type pathTypesRequested) { }

	public void Release() { }

	private static void .cctor() { }

}

public enum PropagationPaths.Type // TypeDefIndex: 4701
{	public int value__; // 0x0
	public const PropagationPaths.Type None = 0;
	public const PropagationPaths.Type TrickleDown = 1;
	public const PropagationPaths.Type BubbleUp = 2;

}

