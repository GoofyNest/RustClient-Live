public class TechTreeEntry : TechTreeWidget // TypeDefIndex: 10913
{	// Fields
	public RawImage icon; // 0x28
	public GameObject ableToUnlockBackground; // 0x30
	public GameObject unlockedBackground; // 0x38
	public GameObject lockedBackground; // 0x40
	public GameObject lockOverlay; // 0x48
	public GameObject selectedBackground; // 0x50
	public Image radialUnlock; // 0x58
	public float holdTime; // 0x60
	private bool locked; // 0x64
	private bool pathToUnlock; // 0x65
	private bool isSelected; // 0x66
	private float radialFillTime; // 0x68

	// Methods

	// RVA: 0x7AC260 Offset: 0x7AB660 VA: 0x1807AC260 Slot: 6
	public override bool IsLocked() { }

	// RVA: 0x7AC4E0 Offset: 0x7AB8E0 VA: 0x1807AC4E0 Slot: 9
	public override void SetSelected(bool wantsSelected) { }

	// RVA: 0x7AC5D0 Offset: 0x7AB9D0 VA: 0x1807AC5D0
	private void UpdateRadialFill() { }

	// RVA: 0x7AC4D0 Offset: 0x7AB8D0 VA: 0x1807AC4D0 Slot: 8
	public override void SetLocked(bool isLocked) { }

	// RVA: 0x7AC4C0 Offset: 0x7AB8C0 VA: 0x1807AC4C0 Slot: 10
	public override void SetAbleToUnlock(bool wants) { }

	// RVA: 0x7AC250 Offset: 0x7AB650 VA: 0x1807AC250 Slot: 7
	public override bool HasPathToUnlock() { }

	// RVA: 0x7AC270 Offset: 0x7AB670 VA: 0x1807AC270
	public void Refresh() { }

	// RVA: 0x7AC900 Offset: 0x7ABD00 VA: 0x1807AC900
	public void .ctor() { }

}

