public class WorkshopView : MonoBehaviour // TypeDefIndex: 7776
{
	public TextMeshProUGUI Title; 
	public TextMeshProUGUI AuthorName; 
	public TextMeshProUGUI VoteInfo; 
	public Button VoteUp; 
	public Button VoteDown; 
	private IWorkshopContent item; 

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

