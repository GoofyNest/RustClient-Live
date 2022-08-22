public class WorkshopView : MonoBehaviour // TypeDefIndex: 7769
{	public TextMeshProUGUI Title; // 0x18
	public TextMeshProUGUI AuthorName; // 0x20
	public TextMeshProUGUI VoteInfo; // 0x28
	public Button VoteUp; // 0x30
	public Button VoteDown; // 0x38
	private IWorkshopContent item; // 0x40

	protected WorkshopInterface Interface { get; }
	protected WorkshopItemEditor Editor { get; }


	protected WorkshopInterface get_Interface() { }

	protected WorkshopItemEditor get_Editor() { }

	public void Update() { }

	public void UpdateFrom(IWorkshopContent item) { }

	public void OnVoteUp() { }

	public void OnVoteDown() { }

	public void OpenWeb() { }

	internal void Clear() { }

	public void .ctor() { }

}

