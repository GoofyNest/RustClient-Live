public class ComputerMenu : UIDialog // TypeDefIndex: 10414
{
	public RectTransform bookmarkContainer;
	public GameObject bookmarkPrefab;
	public List<RCBookmarkEntry> activeEntries;
	public EntityRef ownerComputer;


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

