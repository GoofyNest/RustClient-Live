public class DeliveryDroneConfig : BaseScriptableObject // TypeDefIndex: 10510
{
	public Vector3 vendingMachineOffset; 
	public float maxDistanceFromVendingMachine; 
	public Vector3 halfExtents; 
	public float testHeight; 
	public LayerMask layerMask; 


	public void FindDescentPoints(VendingMachine vendingMachine, float currentY, out Vector3 waitPosition, out Vector3 descendPosition) { }

	public bool IsVendingMachineAccessible(VendingMachine vendingMachine, Vector3 offset, out RaycastHit hitInfo) { }

	public void .ctor() { }

}

