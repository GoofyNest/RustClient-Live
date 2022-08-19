public abstract class PlayableAsset : ScriptableObject // TypeDefIndex: 3865
{	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x18F5210 Offset: 0x18F4610 VA: 0x1818F5210 Slot: 5
	public virtual double get_duration() { }

	// RVA: 0x18F5270 Offset: 0x18F4670 VA: 0x1818F5270 Slot: 6
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F5010 Offset: 0x18F4410 VA: 0x1818F5010
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F51E0 Offset: 0x18F45E0 VA: 0x1818F51E0
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	protected void .ctor() { }

}

