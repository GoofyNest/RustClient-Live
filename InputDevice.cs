public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 4145
{	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x23E500 Offset: 0x23D900 VA: 0x18023E500
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x23E510 Offset: 0x23D910 VA: 0x18023E510
	private ulong get_deviceId() { }

	// RVA: 0x23E3E0 Offset: 0x23D7E0 VA: 0x18023E3E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E490 Offset: 0x23D890 VA: 0x18023E490 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x23E4D0 Offset: 0x23D8D0 VA: 0x18023E4D0 Slot: 2
	public override int GetHashCode() { }

}

