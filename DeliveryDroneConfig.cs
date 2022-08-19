public class DeliveryDroneConfig : BaseScriptableObject // TypeDefIndex: 8800
{	// Fields
	public Vector3 vendingMachineOffset; // 0x20
	public float maxDistanceFromVendingMachine; // 0x2C
	public Vector3 halfExtents; // 0x30
	public float testHeight; // 0x3C
	public LayerMask layerMask; // 0x40

	// Methods

	// RVA: 0x8F2890 Offset: 0x8F1C90 VA: 0x1808F2890
	public void FindDescentPoints(VendingMachine vendingMachine, float currentY, out Vector3 waitPosition, out Vector3 descendPosition) { }

	// RVA: 0x8F2D20 Offset: 0x8F2120 VA: 0x1808F2D20
	public bool IsVendingMachineAccessible(VendingMachine vendingMachine, Vector3 offset, out RaycastHit hitInfo) { }

	// RVA: 0x8F2FA0 Offset: 0x8F23A0 VA: 0x1808F2FA0
	public void .ctor() { }

}

