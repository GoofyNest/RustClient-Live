public class TechTreeEntry : TechTreeWidget // TypeDefIndex: 10913
{	public RawImage icon; // 0x28
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


	public override bool IsLocked() { }

	public override void SetSelected(bool wantsSelected) { }

	private void UpdateRadialFill() { }

	public override void SetLocked(bool isLocked) { }

	public override void SetAbleToUnlock(bool wants) { }

	public override bool HasPathToUnlock() { }

	public void Refresh() { }

	public void .ctor() { }

}

