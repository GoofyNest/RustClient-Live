public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 4145
{	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	private ulong deviceId { get; }


	internal void .ctor(ulong deviceId) { }

	private ulong get_deviceId() { }

	public override bool Equals(object obj) { }

	public bool Equals(InputDevice other) { }

	public override int GetHashCode() { }

}

