public class RigidbodyLOD : LODComponent // TypeDefIndex: 9953
{	// Fields
	public float Distance; // 0x80
	private Rigidbody rigidbody; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private bool kinematic; // 0x95

	// Methods

	// RVA: 0x4C4790 Offset: 0x4C3B90 VA: 0x1804C4790 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C46B0 Offset: 0x4C3AB0 VA: 0x1804C46B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x4C48C0 Offset: 0x4C3CC0 VA: 0x1804C48C0 Slot: 13
	protected override void Show() { }

	// RVA: 0x4C46F0 Offset: 0x4C3AF0 VA: 0x1804C46F0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C4810 Offset: 0x4C3C10 VA: 0x1804C4810 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C46C0 Offset: 0x4C3AC0 VA: 0x1804C46C0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x4C4960 Offset: 0x4C3D60 VA: 0x1804C4960
	public void .ctor() { }

}

