internal class PropagationPaths // TypeDefIndex: 4700
{	// Fields
	private static readonly ObjectPool<PropagationPaths> s_Pool; // 0x0
	public readonly List<VisualElement> trickleDownPath; // 0x10
	public readonly List<VisualElement> targetElements; // 0x18
	public readonly List<VisualElement> bubbleUpPath; // 0x20

	// Methods

	// RVA: 0xECD280 Offset: 0xECC680 VA: 0x180ECD280
	public void .ctor() { }

	// RVA: 0xECD070 Offset: 0xECC470 VA: 0x180ECD070
	internal static PropagationPaths Copy(PropagationPaths paths) { }

	// RVA: 0xECCDE0 Offset: 0xECC1E0 VA: 0x180ECCDE0
	public static PropagationPaths Build(VisualElement elem, PropagationPaths.Type pathTypesRequested) { }

	// RVA: 0xECD150 Offset: 0xECC550 VA: 0x180ECD150
	public void Release() { }

	// RVA: 0xECD210 Offset: 0xECC610 VA: 0x180ECD210
	private static void .cctor() { }

}

public enum PropagationPaths.Type // TypeDefIndex: 4701
{	// Fields
	public int value__; // 0x0
	public const PropagationPaths.Type None = 0;
	public const PropagationPaths.Type TrickleDown = 1;
	public const PropagationPaths.Type BubbleUp = 2;

}

