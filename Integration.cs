public class Integration : BaseIntegration // TypeDefIndex: 8229
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnManifestUpdated; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnServerMetadataUpdated; // 0x18
	private Auth _auth; // 0x20
	private IAuthTicket _steamTicket; // 0x28

	// Properties
	public override string PublicKey { get; }
	public override string Bucket { get; }
	public override string UserId { get; }
	public override string UserName { get; }
	public override Auth Auth { get; }
	public override string ServerAddress { get; }
	public override string ServerName { get; }

	// Methods

	// RVA: 0x1069060 Offset: 0x1068460 VA: 0x181069060 Slot: 4
	public override string get_PublicKey() { }

	// RVA: 0x1069030 Offset: 0x1068430 VA: 0x181069030 Slot: 5
	public override string get_Bucket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1068D50 Offset: 0x1068150 VA: 0x181068D50
	public void add_OnManifestUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1069500 Offset: 0x1068900 VA: 0x181069500
	public void remove_OnManifestUpdated(Action value) { }

	// RVA: 0x1068B30 Offset: 0x1067F30 VA: 0x181068B30 Slot: 6
	public override void OnManifestFile(Manifest manifest) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1068DF0 Offset: 0x10681F0 VA: 0x181068DF0
	public void add_OnServerMetadataUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10695A0 Offset: 0x10689A0 VA: 0x1810695A0
	public void remove_OnServerMetadataUpdated(Action value) { }

	// RVA: 0xDD1C40 Offset: 0xDD1040 VA: 0x180DD1C40 Slot: 7
	public override void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

	// RVA: 0x10692F0 Offset: 0x10686F0 VA: 0x1810692F0 Slot: 8
	public override string get_UserId() { }

	// RVA: 0x1069400 Offset: 0x1068800 VA: 0x181069400 Slot: 9
	public override string get_UserName() { }

	// RVA: 0x1068E90 Offset: 0x1068290 VA: 0x181068E90 Slot: 14
	public override Auth get_Auth() { }

	// RVA: 0x1068B50 Offset: 0x1067F50 VA: 0x181068B50 Slot: 19
	public override bool ShouldReportException(string message, string stackTrace, LogType type) { }

	// RVA: 0x1069090 Offset: 0x1068490 VA: 0x181069090 Slot: 10
	public override string get_ServerAddress() { }

	// RVA: 0x1069200 Offset: 0x1068600 VA: 0x181069200 Slot: 11
	public override string get_ServerName() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

