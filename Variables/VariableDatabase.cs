using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x020002A4 RID: 676
	[Token(Token = "0x20002A4")]
	public class VariableDatabase : NetworkSingleton<VariableDatabase>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000304")]
		public string SaveFolderName
		{
			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0xABA700", Offset = "0xAB9100", VA = "0x180ABA700", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000305")]
		public string SaveFileName
		{
			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0xABA6D0", Offset = "0xAB90D0", VA = "0x180ABA6D0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000306")]
		public Loader Loader
		{
			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0x71CA10", Offset = "0x71B410", VA = "0x18071CA10", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x17000307")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6000DFB")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000308")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6000DFC")]
			[Address(RVA = "0x63D950", Offset = "0x63C350", VA = "0x18063D950", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DFD")]
			[Address(RVA = "0x71CA90", Offset = "0x71B490", VA = "0x18071CA90", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000309")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6000DFE")]
			[Address(RVA = "0x63D960", Offset = "0x63C360", VA = "0x18063D960", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0x63DA60", Offset = "0x63C460", VA = "0x18063DA60", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x000070E0 File Offset: 0x000052E0
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030A")]
		public bool HasChanged
		{
			[Token(Token = "0x6000E00")]
			[Address(RVA = "0x71C9F0", Offset = "0x71B3F0", VA = "0x18071C9F0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E01")]
			[Address(RVA = "0x71CA80", Offset = "0x71B480", VA = "0x18071CA80", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x1700030B")]
		public int LoadOrder
		{
			[Token(Token = "0x6000E02")]
			[Address(RVA = "0x71CA00", Offset = "0x71B400", VA = "0x18071CA00", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E03")]
		[Address(RVA = "0xAB8470", Offset = "0xAB6E70", VA = "0x180AB8470", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0xAB8D30", Offset = "0xAB7730", VA = "0x180AB8D30", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0xAB8740", Offset = "0xAB7140", VA = "0x180AB8740")]
		private void CreateVariables()
		{
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0xAB84C0", Offset = "0xAB6EC0", VA = "0x180AB84C0")]
		public void CreatePlayerVariables(Player owner)
		{
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0xAB92C0", Offset = "0xAB7CC0", VA = "0x180AB92C0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0xAB85A0", Offset = "0xAB6FA0", VA = "0x180AB85A0")]
		public void CreateVariable(string name, VariableDatabase.EVariableType type, string initialValue, bool persistent, EVariableMode mode, Player owner, EVariableReplicationMode replicationMode = EVariableReplicationMode.Networked)
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0xAB7FE0", Offset = "0xAB69E0", VA = "0x180AB7FE0")]
		public void AddVariable(BaseVariable variable)
		{
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0xABA2B0", Offset = "0xAB8CB0", VA = "0x180ABA2B0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendValue(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0xAB98B0", Offset = "0xAB82B0", VA = "0x180AB98B0")]
		[ObserversRpc]
		[TargetRpc]
		public void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0xABA310", Offset = "0xAB8D10", VA = "0x180ABA310")]
		public void SetVariableValue(string variableName, string value, bool network = true)
		{
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0xAB8B80", Offset = "0xAB7580", VA = "0x180AB8B80")]
		public BaseVariable GetVariable(string variableName)
		{
			return null;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0E")]
		public T GetValue<T>(string variableName)
		{
			return null;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0xAB93D0", Offset = "0xAB7DD0", VA = "0x180AB93D0")]
		[Button]
		public void PrintAllVariables()
		{
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0xAB9690", Offset = "0xAB8090", VA = "0x180AB9690")]
		public void PrintVariableValue(string variableName)
		{
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0xAB9190", Offset = "0xAB7B90", VA = "0x180AB9190")]
		public void NotifyItemAcquired(string id, int quantity)
		{
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0xAB88E0", Offset = "0xAB72E0", VA = "0x180AB88E0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0xAB8DC0", Offset = "0xAB77C0", VA = "0x180AB8DC0")]
		public void LoadVariable(VariableData data)
		{
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E14")]
		[Address(RVA = "0xABA500", Offset = "0xAB8F00", VA = "0x180ABA500")]
		public VariableDatabase()
		{
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0xAB9050", Offset = "0xAB7A50", VA = "0x180AB9050", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0xAB9000", Offset = "0xAB7A00", VA = "0x180AB9000", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0xAB9EE0", Offset = "0xAB88E0", VA = "0x180AB9EE0")]
		private void RpcWriter___Server_SendValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0xAB9BB0", Offset = "0xAB85B0", VA = "0x180AB9BB0")]
		public void RpcLogic___SendValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0xAB9C40", Offset = "0xAB8640", VA = "0x180AB9C40")]
		private void RpcReader___Server_SendValue_3895153758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0xAB9D70", Offset = "0xAB8770", VA = "0x180AB9D70")]
		private void RpcWriter___Observers_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0xAB9AE0", Offset = "0xAB84E0", VA = "0x180AB9AE0")]
		public void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0xAB9BC0", Offset = "0xAB85C0", VA = "0x180AB9BC0")]
		private void RpcReader___Observers_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0xABA150", Offset = "0xAB8B50", VA = "0x180ABA150")]
		private void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0xAB9CF0", Offset = "0xAB86F0", VA = "0x180AB9CF0")]
		private void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E20")]
		[Address(RVA = "0xAB81C0", Offset = "0xAB6BC0", VA = "0x180AB81C0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Variables.VariableDatabase_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04000E40 RID: 3648
		[Token(Token = "0x4000E40")]
		[FieldOffset(Offset = "0x120")]
		public List<BaseVariable> VariableList;

		// Token: 0x04000E41 RID: 3649
		[Token(Token = "0x4000E41")]
		[FieldOffset(Offset = "0x128")]
		public Dictionary<string, BaseVariable> VariableDict;

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000E42")]
		[FieldOffset(Offset = "0x130")]
		private List<string> playerVariables;

		// Token: 0x04000E43 RID: 3651
		[Token(Token = "0x4000E43")]
		[FieldOffset(Offset = "0x138")]
		public VariableCreator[] Creators;

		// Token: 0x04000E44 RID: 3652
		[Token(Token = "0x4000E44")]
		[FieldOffset(Offset = "0x140")]
		public StorableItemDefinition[] ItemsToTrackAcquire;

		// Token: 0x04000E45 RID: 3653
		[Token(Token = "0x4000E45")]
		[FieldOffset(Offset = "0x148")]
		private VariablesLoader loader;

		// Token: 0x04000E4A RID: 3658
		[Token(Token = "0x4000E4A")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted;

		// Token: 0x04000E4B RID: 3659
		[Token(Token = "0x4000E4B")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted;

		// Token: 0x020002A5 RID: 677
		[Token(Token = "0x20002A5")]
		public enum EVariableType
		{
			// Token: 0x04000E4D RID: 3661
			[Token(Token = "0x4000E4D")]
			Bool,
			// Token: 0x04000E4E RID: 3662
			[Token(Token = "0x4000E4E")]
			Number
		}
	}
}
