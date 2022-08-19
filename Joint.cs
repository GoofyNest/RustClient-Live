public class Joint : Component // TypeDefIndex: 3927
{	// Properties
	public Rigidbody connectedBody { set; }
	public Vector3 anchor { set; }
	public Vector3 connectedAnchor { set; }
	public bool autoConfigureConnectedAnchor { set; }
	public bool enableCollision { set; }
	public bool enablePreprocessing { set; }

	// Methods

	// RVA: 0x22924E0 Offset: 0x22918E0 VA: 0x1822924E0
	public void set_connectedBody(Rigidbody value) { }

	// RVA: 0x22923A0 Offset: 0x22917A0 VA: 0x1822923A0
	public void set_anchor(Vector3 value) { }

	// RVA: 0x2292490 Offset: 0x2291890 VA: 0x182292490
	public void set_connectedAnchor(Vector3 value) { }

	// RVA: 0x22923F0 Offset: 0x22917F0 VA: 0x1822923F0
	public void set_autoConfigureConnectedAnchor(bool value) { }

	// RVA: 0x2292530 Offset: 0x2291930 VA: 0x182292530
	public void set_enableCollision(bool value) { }

	// RVA: 0x2292580 Offset: 0x2291980 VA: 0x182292580
	public void set_enablePreprocessing(bool value) { }

	// RVA: 0x2292350 Offset: 0x2291750 VA: 0x182292350
	private void set_anchor_Injected(ref Vector3 value) { }

	// RVA: 0x2292440 Offset: 0x2291840 VA: 0x182292440
	private void set_connectedAnchor_Injected(ref Vector3 value) { }

}

