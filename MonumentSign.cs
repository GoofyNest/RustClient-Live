public class MonumentSign : LODComponent // TypeDefIndex: 8808
{	// Fields
	public float viewDistance; // 0x80
	public GameObject uiRoot; // 0x88
	public RustText signText; // 0x90
	private MonumentInfo closestMonument; // 0x98
	private int currentLod; // 0xA0
	private bool force; // 0xA4

	// Methods

	// RVA: 0x7B4530 Offset: 0x7B3930 VA: 0x1807B4530
	private void UpdateText() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x7B3E30 Offset: 0x7B3230 VA: 0x1807B3E30 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x7B4390 Offset: 0x7B3790 VA: 0x1807B4390 Slot: 13
	protected override void Show() { }

	// RVA: 0x7B4250 Offset: 0x7B3650 VA: 0x1807B4250 Slot: 14
	protected override void Hide() { }

	// RVA: 0x7B42E0 Offset: 0x7B36E0 VA: 0x1807B42E0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C46C0 Offset: 0x4C3AC0 VA: 0x1804C46C0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x7B3E40 Offset: 0x7B3240 VA: 0x1807B3E40
	private MonumentInfo FindClosestMonument() { }

	// RVA: 0x7B4660 Offset: 0x7B3A60 VA: 0x1807B4660
	public void .ctor() { }

}

