public class OccludeeState : OcclusionCulling.SmartListValue // TypeDefIndex: 11505
{
	public int slot; 
	public bool isStatic; 
	public int layer; 
	public OcclusionCulling.OnVisibilityChanged onVisibilityChanged; 
	public OcclusionCulling.Cell cell; 
	public OcclusionCulling.SimpleList<OccludeeState.State> states; 

	public bool isVisible { get; }


	public bool get_isVisible() { }

	public OccludeeState Initialize(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, int slot, Vector4 sphereBounds, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	public void Invalidate() { }

	public void MakeVisible() { }

	public void .ctor() { }

}

public struct OccludeeState.State // TypeDefIndex: 11506
{
	public Vector4 sphereBounds; 
	public float minTimeVisible; 
	public float waitTime; 
	public uint waitFrame; 
	public byte isVisible; 
	public byte active; 
	public byte callback; 
	public byte pad1; 
	public static OccludeeState.State Unused; 


	private static void .cctor() { }

}

