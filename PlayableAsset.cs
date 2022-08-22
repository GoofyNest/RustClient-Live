public abstract class PlayableAsset : ScriptableObject // TypeDefIndex: 3865
{	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }


	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	public virtual double get_duration() { }

	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	protected void .ctor() { }

}

