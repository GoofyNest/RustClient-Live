public class ComputerMenu : UIDialog // TypeDefIndex: 8685
{	public RectTransform bookmarkContainer; // 0x30
	public GameObject bookmarkPrefab; // 0x38
	public List<RCBookmarkEntry> activeEntries; // 0x40
	public EntityRef ownerComputer; // 0x48


	public virtual void InitMenu(BaseEntity computer) { }

	public virtual bool WantsEyeOverride() { }

	public virtual Transform GetCameraOverrideTransform() { }

	public virtual BasePlayer.CameraMode GetCameraMode() { }

	public virtual void BookmarkPressed(RCBookmarkEntry entry) { }

	public virtual void DisconnectPressed(RCBookmarkEntry entry) { }

	public virtual void DeletePressed(RCBookmarkEntry entry) { }

	public virtual bool IsControlling(string identifier) { }

	public void ClearBookmarkEntries() { }

	public void UpdateBookmarks() { }

	public void .ctor() { }

}

