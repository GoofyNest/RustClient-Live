public class WorkshopView : MonoBehaviour // TypeDefIndex: 7769
{	// Fields
	public TextMeshProUGUI Title; // 0x18
	public TextMeshProUGUI AuthorName; // 0x20
	public TextMeshProUGUI VoteInfo; // 0x28
	public Button VoteUp; // 0x30
	public Button VoteDown; // 0x38
	private IWorkshopContent item; // 0x40

	// Properties
	protected WorkshopInterface Interface { get; }
	protected WorkshopItemEditor Editor { get; }

	// Methods

	// RVA: 0xE9B910 Offset: 0xE9AD10 VA: 0x180E9B910
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE9B870 Offset: 0xE9AC70 VA: 0x180E9B870
	protected WorkshopItemEditor get_Editor() { }

	// RVA: 0xE9B770 Offset: 0xE9AB70 VA: 0x180E9B770
	public void Update() { }

	// RVA: 0xE9B5F0 Offset: 0xE9A9F0 VA: 0x180E9B5F0
	public void UpdateFrom(IWorkshopContent item) { }

	// RVA: 0xE9B460 Offset: 0xE9A860 VA: 0x180E9B460
	public void OnVoteUp() { }

	// RVA: 0xE9B330 Offset: 0xE9A730 VA: 0x180E9B330
	public void OnVoteDown() { }

	// RVA: 0xE9B590 Offset: 0xE9A990 VA: 0x180E9B590
	public void OpenWeb() { }

	// RVA: 0xE9B2B0 Offset: 0xE9A6B0 VA: 0x180E9B2B0
	internal void Clear() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

