public class NotifyLOD : LODComponent // TypeDefIndex: 9943
{	// Fields
	public float Distance; // 0x80
	public float MinDistanceMultiplier; // 0x84
	public GameObject TargetGameObject; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private INotifyLOD lodTarget; // 0x98

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C46B0 Offset: 0x4C3AB0 VA: 0x1804C46B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0xA37B40 Offset: 0xA36F40 VA: 0x180A37B40 Slot: 13
	protected override void Show() { }

	// RVA: 0xA37A70 Offset: 0xA36E70 VA: 0x180A37A70 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C4810 Offset: 0x4C3C10 VA: 0x1804C4810 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0xA379A0 Offset: 0xA36DA0 VA: 0x180A379A0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0xA37C10 Offset: 0xA37010 VA: 0x180A37C10
	public void .ctor() { }

}

