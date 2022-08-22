public class Integration : BaseIntegration // TypeDefIndex: 8229
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnManifestUpdated; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnServerMetadataUpdated; // 0x18
	private Auth _auth; // 0x20
	private IAuthTicket _steamTicket; // 0x28

	public override string PublicKey { get; }
	public override string Bucket { get; }
	public override string UserId { get; }
	public override string UserName { get; }
	public override Auth Auth { get; }
	public override string ServerAddress { get; }
	public override string ServerName { get; }


	public override string get_PublicKey() { }

	public override string get_Bucket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_OnManifestUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_OnManifestUpdated(Action value) { }

	public override void OnManifestFile(Manifest manifest) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_OnServerMetadataUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_OnServerMetadataUpdated(Action value) { }

	public override void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

	public override string get_UserId() { }

	public override string get_UserName() { }

	public override Auth get_Auth() { }

	public override bool ShouldReportException(string message, string stackTrace, LogType type) { }

	public override string get_ServerAddress() { }

	public override string get_ServerName() { }

	public void .ctor() { }

}

