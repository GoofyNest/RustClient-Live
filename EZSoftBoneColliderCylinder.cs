public class EZSoftBoneColliderCylinder : EZSoftBoneColliderBase // TypeDefIndex: 7135
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Margin; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_InsideMode; // 0x1C

	public float margin { get; set; }
	public bool insideMode { get; set; }


	public float get_margin() { }

	public void set_margin(float value) { }

	public bool get_insideMode() { }

	public void set_insideMode(bool value) { }

	public override void Collide(ref Vector3 position, float spacing) { }

	public void .ctor() { }

}

