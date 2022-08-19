public class VendingMachineScreen : MonoBehaviour // TypeDefIndex: 8738
{	// Fields
	public RawImage largeIcon; // 0x18
	public RawImage blueprintIcon; // 0x20
	public Text mainText; // 0x28
	public Text lowerText; // 0x30
	public Text centerText; // 0x38
	public RawImage smallIcon; // 0x40
	public VendingMachine vendingMachine; // 0x48
	public Sprite outOfStockSprite; // 0x50
	public Renderer fadeoutMesh; // 0x58
	public CanvasGroup screenCanvas; // 0x60
	public Renderer light1; // 0x68
	public Renderer light2; // 0x70
	public float nextImageTime; // 0x78
	public int currentImageIndex; // 0x7C
	private float imageCycleTime; // 0x80
	private const float maxDistSq = 225;

	// Methods

	// RVA: 0xAD42D0 Offset: 0xAD36D0 VA: 0x180AD42D0
	public void UpdateLOD() { }

	// RVA: 0xAD4580 Offset: 0xAD3980 VA: 0x180AD4580
	public void UpdateLightAnimation() { }

	// RVA: 0xAD4680 Offset: 0xAD3A80 VA: 0x180AD4680
	private void Update() { }

	// RVA: 0x946D50 Offset: 0x946150 VA: 0x180946D50
	public void .ctor() { }

}

public enum VendingMachineScreen.vmScreenState // TypeDefIndex: 8739
{	// Fields
	public int value__; // 0x0
	public const VendingMachineScreen.vmScreenState ItemScroll = 0;
	public const VendingMachineScreen.vmScreenState Vending = 1;
	public const VendingMachineScreen.vmScreenState Message = 2;
	public const VendingMachineScreen.vmScreenState ShopName = 3;
	public const VendingMachineScreen.vmScreenState OutOfStock = 4;

}

