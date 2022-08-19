public class EZSoftBoneColliderCylinder : EZSoftBoneColliderBase // TypeDefIndex: 7135
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Margin; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_InsideMode; // 0x1C

	// Properties
	public float margin { get; set; }
	public bool insideMode { get; set; }

	// Methods

	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	public float get_margin() { }

	// RVA: 0x772450 Offset: 0x771850 VA: 0x180772450
	public void set_margin(float value) { }

	// RVA: 0x7E8DD0 Offset: 0x7E81D0 VA: 0x1807E8DD0
	public bool get_insideMode() { }

	// RVA: 0x7E8E40 Offset: 0x7E8240 VA: 0x1807E8E40
	public void set_insideMode(bool value) { }

	// RVA: 0x228A010 Offset: 0x2289410 VA: 0x18228A010 Slot: 6
	public override void Collide(ref Vector3 position, float spacing) { }

	// RVA: 0x228A350 Offset: 0x2289750 VA: 0x18228A350
	public void .ctor() { }

}

