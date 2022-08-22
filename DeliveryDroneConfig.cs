public class DeliveryDroneConfig : BaseScriptableObject // TypeDefIndex: 8800
{	public Vector3 vendingMachineOffset; // 0x20
	public float maxDistanceFromVendingMachine; // 0x2C
	public Vector3 halfExtents; // 0x30
	public float testHeight; // 0x3C
	public LayerMask layerMask; // 0x40


	public void FindDescentPoints(VendingMachine vendingMachine, float currentY, out Vector3 waitPosition, out Vector3 descendPosition) { }

	public bool IsVendingMachineAccessible(VendingMachine vendingMachine, Vector3 offset, out RaycastHit hitInfo) { }

	public void .ctor() { }

}

