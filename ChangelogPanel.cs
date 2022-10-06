public class ChangelogPanel : MonoBehaviour // TypeDefIndex: 12720
{
	public GameObject AddedHeader; 
	public GameObject RemovedHeader; 
	public GameObject ChangedHeader; 
	public RustText AddedContent; 
	public RustText RemovedContent; 
	public RustText ChangedContent; 


	public void Open() { }

	public void Close() { }

	public void Rebuild() { }

	private void UpdateSection(ChangelogPanel.ChangelogSection section) { }

	private string BuildSection(ChangelogPanel.ChangelogSection section) { }

	public void .ctor() { }

}

private enum ChangelogPanel.ChangelogSection // TypeDefIndex: 12721
{
	public int value__; 
	public const ChangelogPanel.ChangelogSection Added = 0;
	public const ChangelogPanel.ChangelogSection Removed = 1;
	public const ChangelogPanel.ChangelogSection Changed = 2;

}

