public class CardTable : BaseCardGameEntity // TypeDefIndex: 10092
{
	private Option __menuOption_Menu_Play;
	[HeaderAttribute]
	[SerializeField]
	private ViewModel viewModel;
	[SerializeField]
	private CardGameUI.PlayingCardImage[] tableCards;
	[SerializeField]
	private Renderer[] tableCardBackings;
	[SerializeField]
	private Canvas cardUICanvas;
	[SerializeField]
	private Image[] tableCardImages;
	[SerializeField]
	private Sprite blankCard;
	[SerializeField]
	private CardTable.ChipStack[] chipStacks;
	[SerializeField]
	private CardTable.ChipStack[] fillerStacks;
	private Nullable<bool> localWasHoldingCards;
	private int lastVisualScrap;
	private static Dictionary<int, Sprite> tableCardImageDict;
	private static Sprite blankCardStatic;

	public override bool HasMenuOptions { get; }
	protected override float MaxStorageInteractionDist { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override float get_MaxStorageInteractionDist() { }

	protected override void ClientInit(Entity info) { }

	public override void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public override void Menu_Play(BasePlayer player) { }

	private void DelayedViewModelDeploy(float timeDelay) { }

	private void DeployViewModel() { }

	private void HolsterViewmodel() { }

	public bool RefreshPlayerCards() { }

	private void RefreshTableVisuals(List<PlayingCard> cards, int scrap) { }

	private static Sprite GetImage(int cardIndex) { }

	private void ShowStack(CardTable.ChipStack stack, ref int remainingScrap) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class CardTable.ChipStack : IComparable<CardTable.ChipStack> // TypeDefIndex: 10093
{
	public int chipValue;
	public GameObject[] chips;


	public int CompareTo(CardTable.ChipStack other) { }

	public void .ctor() { }

}

