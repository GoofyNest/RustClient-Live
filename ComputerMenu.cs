public class ComputerMenu : UIDialog // TypeDefIndex: 8685
{	// Fields
	public RectTransform bookmarkContainer; // 0x30
	public GameObject bookmarkPrefab; // 0x38
	public List<RCBookmarkEntry> activeEntries; // 0x40
	public EntityRef ownerComputer; // 0x48

	// Methods

	// RVA: 0x6D0880 Offset: 0x6CFC80 VA: 0x1806D0880 Slot: 10
	public virtual void InitMenu(BaseEntity computer) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 11
	public virtual bool WantsEyeOverride() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 12
	public virtual Transform GetCameraOverrideTransform() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 13
	public virtual BasePlayer.CameraMode GetCameraMode() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 14
	public virtual void BookmarkPressed(RCBookmarkEntry entry) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	public virtual void DisconnectPressed(RCBookmarkEntry entry) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	public virtual void DeletePressed(RCBookmarkEntry entry) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 17
	public virtual bool IsControlling(string identifier) { }

	// RVA: 0x6D0710 Offset: 0x6CFB10 VA: 0x1806D0710
	public void ClearBookmarkEntries() { }

	// RVA: 0x6D08B0 Offset: 0x6CFCB0 VA: 0x1806D08B0
	public void UpdateBookmarks() { }

	// RVA: 0x6D0C00 Offset: 0x6D0000 VA: 0x1806D0C00
	public void .ctor() { }

}

