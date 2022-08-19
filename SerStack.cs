internal sealed class SerStack // TypeDefIndex: 1118
{	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x11FD410 Offset: 0x11FC810 VA: 0x1811FD410
	internal void .ctor(string stackId) { }

	// RVA: 0x11FD2D0 Offset: 0x11FC6D0 VA: 0x1811FD2D0
	internal void Push(object obj) { }

	// RVA: 0x11FD240 Offset: 0x11FC640 VA: 0x1811FD240
	internal object Pop() { }

	// RVA: 0x11FD100 Offset: 0x11FC500 VA: 0x1811FD100
	internal void IncreaseCapacity() { }

	// RVA: 0x11FD1F0 Offset: 0x11FC5F0 VA: 0x1811FD1F0
	internal object Peek() { }

	// RVA: 0x11FD1A0 Offset: 0x11FC5A0 VA: 0x1811FD1A0
	internal object PeekPeek() { }

	// RVA: 0x11FD190 Offset: 0x11FC590 VA: 0x1811FD190
	internal bool IsEmpty() { }

}

