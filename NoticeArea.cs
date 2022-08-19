public class NoticeArea : SingletonComponent<NoticeArea> // TypeDefIndex: 11040
{	// Fields
	public GameObjectRef itemPickupPrefab; // 0x18
	public GameObjectRef itemPickupCondensedText; // 0x20
	public GameObjectRef itemDroppedPrefab; // 0x28
	public AnimationCurve pickupSizeCurve; // 0x30
	public AnimationCurve pickupAlphaCurve; // 0x38
	private IVitalNotice[] notices; // 0x40
	private List<ItemPickupNotice> pickups; // 0x48
	private RealTimeSince timeSinceUpdatedNotices; // 0x50

	// Methods

	// RVA: 0xA36B00 Offset: 0xA35F00 VA: 0x180A36B00 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA36B60 Offset: 0xA35F60 VA: 0x180A36B60
	public static void ItemPickUp(ItemDefinition def, int amount, string nameOverride) { }

	// RVA: 0xA37720 Offset: 0xA36B20 VA: 0x180A37720
	private void Update() { }

	// RVA: 0xA372D0 Offset: 0xA366D0 VA: 0x180A372D0
	private void UpdateLayout() { }

	// RVA: 0xA36970 Offset: 0xA35D70 VA: 0x180A36970
	private static Vector2 ApplySizing(RectTransform rectT, bool setSize = False) { }

	// RVA: 0xA37010 Offset: 0xA36410 VA: 0x180A37010
	public void RefreshNotices() { }

	// RVA: 0xA378B0 Offset: 0xA36CB0 VA: 0x180A378B0
	public void .ctor() { }

}

