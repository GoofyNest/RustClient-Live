public class VendingMachineScreen : MonoBehaviour // TypeDefIndex: 10410
{
	public RawImage largeIcon; 
	public RawImage blueprintIcon; 
	public Text mainText; 
	public Text lowerText; 
	public Text centerText; 
	public RawImage smallIcon; 
	public VendingMachine vendingMachine; 
	public Sprite outOfStockSprite; 
	public Renderer fadeoutMesh; 
	public CanvasGroup screenCanvas; 
	public Renderer light1; 
	public Renderer light2; 
	public float nextImageTime; 
	public int currentImageIndex; 
	private float imageCycleTime; 
	private const float maxDistSq = 225;


	public void UpdateLOD() { }

	public void UpdateLightAnimation() { }

	private void Update() { }

	public void .ctor() { }

}

public enum VendingMachineScreen.vmScreenState // TypeDefIndex: 10411
{
	public int value__; 
	public const VendingMachineScreen.vmScreenState ItemScroll = 0;
	public const VendingMachineScreen.vmScreenState Vending = 1;
	public const VendingMachineScreen.vmScreenState Message = 2;
	public const VendingMachineScreen.vmScreenState ShopName = 3;
	public const VendingMachineScreen.vmScreenState OutOfStock = 4;

}

