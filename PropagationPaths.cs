internal class PropagationPaths // TypeDefIndex: 4703
{
	private static readonly ObjectPool<PropagationPaths> s_Pool; 
	public readonly List<VisualElement> trickleDownPath; 
	public readonly List<VisualElement> targetElements; 
	public readonly List<VisualElement> bubbleUpPath; 


	public void .ctor() { }

	internal static PropagationPaths Copy(PropagationPaths paths) { }

	public static PropagationPaths Build(VisualElement elem, PropagationPaths.Type pathTypesRequested) { }

	public void Release() { }

	private static void .cctor() { }

}

public enum PropagationPaths.Type // TypeDefIndex: 4704
{
	public int value__; 
	public const PropagationPaths.Type None = 0;
	public const PropagationPaths.Type TrickleDown = 1;
	public const PropagationPaths.Type BubbleUp = 2;

}

