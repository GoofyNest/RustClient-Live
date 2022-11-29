public class NoticeArea : SingletonComponent<NoticeArea> // TypeDefIndex: 12806
{
	public GameObjectRef itemPickupPrefab; 
	public GameObjectRef itemPickupCondensedText; 
	public GameObjectRef itemDroppedPrefab; 
	public AnimationCurve pickupSizeCurve; 
	public AnimationCurve pickupAlphaCurve; 
	public AnimationCurve reuseAlphaCurve; 
	public AnimationCurve reuseSizeCurve; 
	private IVitalNotice[] notices; 
	private List<ItemPickupNotice> pickups; 
	private RealTimeSince timeSinceUpdatedNotices; 


	protected override void Awake() { }

	public static void ItemPickUp(ItemDefinition def, int amount, string nameOverride) { }

	private void Update() { }

	private void UpdateLayout() { }

	private static Vector2 ApplySizing(RectTransform rectT, bool setSize = False) { }

	public void RefreshNotices() { }

	public void .ctor() { }

}

