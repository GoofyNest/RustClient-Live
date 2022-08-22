public class OccludeeState : OcclusionCulling.SmartListValue // TypeDefIndex: 11505
{	public int slot; // 0x18
	public bool isStatic; // 0x1C
	public int layer; // 0x20
	public OcclusionCulling.OnVisibilityChanged onVisibilityChanged; // 0x28
	public OcclusionCulling.Cell cell; // 0x30
	public OcclusionCulling.SimpleList<OccludeeState.State> states; // 0x38

	public bool isVisible { get; }


	public bool get_isVisible() { }

	public OccludeeState Initialize(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, int slot, Vector4 sphereBounds, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	public void Invalidate() { }

	public void MakeVisible() { }

	public void .ctor() { }

}

public struct OccludeeState.State // TypeDefIndex: 11506
{	public Vector4 sphereBounds; // 0x0
	public float minTimeVisible; // 0x10
	public float waitTime; // 0x14
	public uint waitFrame; // 0x18
	public byte isVisible; // 0x1C
	public byte active; // 0x1D
	public byte callback; // 0x1E
	public byte pad1; // 0x1F
	public static OccludeeState.State Unused; // 0x0


	private static void .cctor() { }

}

