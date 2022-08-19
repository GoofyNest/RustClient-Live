public class OccludeeState : OcclusionCulling.SmartListValue // TypeDefIndex: 11505
{	// Fields
	public int slot; // 0x18
	public bool isStatic; // 0x1C
	public int layer; // 0x20
	public OcclusionCulling.OnVisibilityChanged onVisibilityChanged; // 0x28
	public OcclusionCulling.Cell cell; // 0x30
	public OcclusionCulling.SimpleList<OccludeeState.State> states; // 0x38

	// Properties
	public bool isVisible { get; }

	// Methods

	// RVA: 0xA3B1D0 Offset: 0xA3A5D0 VA: 0x180A3B1D0
	public bool get_isVisible() { }

	// RVA: 0xA3AE90 Offset: 0xA3A290 VA: 0x180A3AE90
	public OccludeeState Initialize(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, int slot, Vector4 sphereBounds, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	// RVA: 0xA3AFE0 Offset: 0xA3A3E0 VA: 0x180A3AFE0
	public void Invalidate() { }

	// RVA: 0xA3B0B0 Offset: 0xA3A4B0 VA: 0x180A3B0B0
	public void MakeVisible() { }

	// RVA: 0xA3B1C0 Offset: 0xA3A5C0 VA: 0x180A3B1C0
	public void .ctor() { }

}

public struct OccludeeState.State // TypeDefIndex: 11506
{	// Fields
	public Vector4 sphereBounds; // 0x0
	public float minTimeVisible; // 0x10
	public float waitTime; // 0x14
	public uint waitFrame; // 0x18
	public byte isVisible; // 0x1C
	public byte active; // 0x1D
	public byte callback; // 0x1E
	public byte pad1; // 0x1F
	public static OccludeeState.State Unused; // 0x0

	// Methods

	// RVA: 0xA4FC30 Offset: 0xA4F030 VA: 0x180A4FC30
	private static void .cctor() { }

}

