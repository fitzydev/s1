using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020008D6 RID: 2262
	[Token(Token = "0x20008D6")]
	public class TrashManager : NetworkSingleton<TrashManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06003EBA RID: 16058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DF")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003EBA")]
			[Address(RVA = "0x85C460", Offset = "0x85AE60", VA = "0x18085C460", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06003EBB RID: 16059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E0")]
		public string SaveFileName
		{
			[Token(Token = "0x6003EBB")]
			[Address(RVA = "0x85C430", Offset = "0x85AE30", VA = "0x18085C430", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06003EBC RID: 16060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E1")]
		public Loader Loader
		{
			[Token(Token = "0x6003EBC")]
			[Address(RVA = "0x71CA10", Offset = "0x71B410", VA = "0x18071CA10", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06003EBD RID: 16061 RVA: 0x00010D10 File Offset: 0x0000EF10
		[Token(Token = "0x170008E2")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003EBD")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06003EBE RID: 16062 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003EBF RID: 16063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E3")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003EBE")]
			[Address(RVA = "0x63D950", Offset = "0x63C350", VA = "0x18063D950", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EBF")]
			[Address(RVA = "0x71CA90", Offset = "0x71B490", VA = "0x18071CA90", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06003EC0 RID: 16064 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003EC1 RID: 16065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E4")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003EC0")]
			[Address(RVA = "0x63D960", Offset = "0x63C360", VA = "0x18063D960", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EC1")]
			[Address(RVA = "0x63DA60", Offset = "0x63C460", VA = "0x18063DA60", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x00010D28 File Offset: 0x0000EF28
		// (set) Token: 0x06003EC3 RID: 16067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E5")]
		public bool HasChanged
		{
			[Token(Token = "0x6003EC2")]
			[Address(RVA = "0x71C9F0", Offset = "0x71B3F0", VA = "0x18071C9F0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003EC3")]
			[Address(RVA = "0x71CA80", Offset = "0x71B480", VA = "0x18071CA80", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x00010D40 File Offset: 0x0000EF40
		[Token(Token = "0x170008E6")]
		public int LoadOrder
		{
			[Token(Token = "0x6003EC4")]
			[Address(RVA = "0x71CA00", Offset = "0x71B400", VA = "0x18071CA00", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC5")]
		[Address(RVA = "0x85C250", Offset = "0x85AC50", VA = "0x18085C250", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x857FE0", Offset = "0x8569E0", VA = "0x180857FE0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC7")]
		[Address(RVA = "0x8583D0", Offset = "0x856DD0", VA = "0x1808583D0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC8")]
		[Address(RVA = "0x858790", Offset = "0x857190", VA = "0x180858790")]
		public void ReplicateTransformData(TrashItem trash)
		{
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC9")]
		[Address(RVA = "0x85C0B0", Offset = "0x85AAB0", VA = "0x18085C0B0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECA")]
		[Address(RVA = "0x858720", Offset = "0x857120", VA = "0x180858720")]
		[ObserversRpc]
		private void ReceiveTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x857340", Offset = "0x855D40", VA = "0x180857340")]
		public TrashItem CreateTrashItem(string id, Vector3 posiiton, Quaternion rotation, [Optional] Vector3 initialVelocity, string guid = "", bool startKinematic = false)
		{
			return null;
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECC")]
		[Address(RVA = "0x85C1C0", Offset = "0x85ABC0", VA = "0x18085C1C0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECD")]
		[Address(RVA = "0x857520", Offset = "0x855F20", VA = "0x180857520")]
		[TargetRpc]
		[ObserversRpc]
		private void CreateTrashItem(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECE")]
		[Address(RVA = "0x856CC0", Offset = "0x8556C0", VA = "0x180856CC0")]
		private TrashItem CreateAndReturnTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			return null;
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECF")]
		[Address(RVA = "0x857140", Offset = "0x855B40", VA = "0x180857140")]
		public TrashItem CreateTrashBag(string id, Vector3 posiiton, Quaternion rotation, TrashContentData content, [Optional] Vector3 initialVelocity, string guid = "", bool startKinematic = false)
		{
			return null;
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED0")]
		[Address(RVA = "0x85C120", Offset = "0x85AB20", VA = "0x18085C120")]
		[ServerRpc(RequireOwnership = false)]
		private void SendTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED1")]
		[Address(RVA = "0x857010", Offset = "0x855A10", VA = "0x180857010")]
		[TargetRpc]
		[ObserversRpc]
		private void CreateTrashBag(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED2")]
		[Address(RVA = "0x856970", Offset = "0x855370", VA = "0x180856970")]
		private TrashItem CreateAndReturnTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			return null;
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED3")]
		[Address(RVA = "0x857630", Offset = "0x856030", VA = "0x180857630")]
		public void DestroyAllTrash()
		{
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED4")]
		[Address(RVA = "0x857710", Offset = "0x856110", VA = "0x180857710")]
		public void DestroyTrash(TrashItem trash)
		{
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED5")]
		[Address(RVA = "0x85BF80", Offset = "0x85A980", VA = "0x18085BF80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendDestroyTrash(string guid)
		{
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED6")]
		[Address(RVA = "0x857870", Offset = "0x856270", VA = "0x180857870")]
		[ObserversRpc(RunLocally = true)]
		private void DestroyTrash(string guid)
		{
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED7")]
		[Address(RVA = "0x857F00", Offset = "0x856900", VA = "0x180857F00")]
		public TrashItem GetTrashPrefab(string id)
		{
			return null;
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED8")]
		[Address(RVA = "0x8579B0", Offset = "0x8563B0", VA = "0x1808579B0")]
		public TrashItem GetRandomGeneratableTrashPrefab()
		{
			return null;
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x857B50", Offset = "0x856550", VA = "0x180857B50", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDA")]
		[Address(RVA = "0x85C2A0", Offset = "0x85ACA0", VA = "0x18085C2A0")]
		public TrashManager()
		{
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDB")]
		[Address(RVA = "0x8580C0", Offset = "0x856AC0", VA = "0x1808580C0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDC")]
		[Address(RVA = "0x858070", Offset = "0x856A70", VA = "0x180858070", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0x85AF70", Offset = "0x859970", VA = "0x18085AF70")]
		private void RpcWriter___Server_SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDF")]
		[Address(RVA = "0x858720", Offset = "0x857120", VA = "0x180858720")]
		private void RpcLogic___SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE0")]
		[Address(RVA = "0x859850", Offset = "0x858250", VA = "0x180859850")]
		private void RpcReader___Server_SendTransformData_2990100769(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE1")]
		[Address(RVA = "0x85AB30", Offset = "0x859530", VA = "0x18085AB30")]
		private void RpcWriter___Observers_ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE2")]
		[Address(RVA = "0x858C80", Offset = "0x857680", VA = "0x180858C80")]
		private void RpcLogic___ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x859570", Offset = "0x857F70", VA = "0x180859570")]
		private void RpcReader___Observers_ReceiveTransformData_2990100769(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x85B590", Offset = "0x859F90", VA = "0x18085B590")]
		private void RpcWriter___Server_SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x858F80", Offset = "0x857980", VA = "0x180858F80")]
		private void RpcLogic___SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x859C70", Offset = "0x858670", VA = "0x180859C70")]
		private void RpcReader___Server_SendTrashItem_478112418(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x85A690", Offset = "0x859090", VA = "0x18085A690")]
		private void RpcWriter___Observers_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x858A30", Offset = "0x857430", VA = "0x180858A30")]
		private void RpcLogic___CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x859310", Offset = "0x857D10", VA = "0x180859310")]
		private void RpcReader___Observers_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x85BC20", Offset = "0x85A620", VA = "0x18085BC20")]
		private void RpcWriter___Target_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x85A110", Offset = "0x858B10", VA = "0x18085A110")]
		private void RpcReader___Target_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x85B260", Offset = "0x859C60", VA = "0x18085B260")]
		private void RpcWriter___Server_SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x858E10", Offset = "0x857810", VA = "0x180858E10")]
		private void RpcLogic___SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x8599F0", Offset = "0x8583F0", VA = "0x1808599F0")]
		private void RpcReader___Server_SendTrashBag_3965031115(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x85A320", Offset = "0x858D20", VA = "0x18085A320")]
		private void RpcWriter___Observers_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF0")]
		[Address(RVA = "0x858950", Offset = "0x857350", VA = "0x180858950")]
		private void RpcLogic___CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF1")]
		[Address(RVA = "0x8590E0", Offset = "0x857AE0", VA = "0x1808590E0")]
		private void RpcReader___Observers_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF2")]
		[Address(RVA = "0x85B8B0", Offset = "0x85A2B0", VA = "0x18085B8B0")]
		private void RpcWriter___Target_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF3")]
		[Address(RVA = "0x859ED0", Offset = "0x8588D0", VA = "0x180859ED0")]
		private void RpcReader___Target_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF4")]
		[Address(RVA = "0x85AE40", Offset = "0x859840", VA = "0x18085AE40")]
		private void RpcWriter___Server_SendDestroyTrash_3615296227(string guid)
		{
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF5")]
		[Address(RVA = "0x857870", Offset = "0x856270", VA = "0x180857870")]
		private void RpcLogic___SendDestroyTrash_3615296227(string guid)
		{
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF6")]
		[Address(RVA = "0x8597E0", Offset = "0x8581E0", VA = "0x1808597E0")]
		private void RpcReader___Server_SendDestroyTrash_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF7")]
		[Address(RVA = "0x85A9F0", Offset = "0x8593F0", VA = "0x18085A9F0")]
		private void RpcWriter___Observers_DestroyTrash_3615296227(string guid)
		{
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF8")]
		[Address(RVA = "0x858B00", Offset = "0x857500", VA = "0x180858B00")]
		private void RpcLogic___DestroyTrash_3615296227(string guid)
		{
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0x859510", Offset = "0x857F10", VA = "0x180859510")]
		private void RpcReader___Observers_DestroyTrash_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0x856900", Offset = "0x855300", VA = "0x180856900", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04002BF9 RID: 11257
		[Token(Token = "0x4002BF9")]
		public const int TRASH_ITEM_LIMIT = 2000;

		// Token: 0x04002BFA RID: 11258
		[Token(Token = "0x4002BFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public TrashItem[] TrashPrefabs;

		// Token: 0x04002BFB RID: 11259
		[Token(Token = "0x4002BFB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public TrashItem TrashBagPrefab;

		// Token: 0x04002BFC RID: 11260
		[Token(Token = "0x4002BFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public TrashManager.TrashItemData[] GenerateableTrashItems;

		// Token: 0x04002BFD RID: 11261
		[Token(Token = "0x4002BFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<TrashItem> trashItems;

		// Token: 0x04002BFE RID: 11262
		[Token(Token = "0x4002BFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float TrashForceMultiplier;

		// Token: 0x04002BFF RID: 11263
		[Token(Token = "0x4002BFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private TrashLoader loader;

		// Token: 0x04002C04 RID: 11268
		[Token(Token = "0x4002C04")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<string> writtenItemFiles;

		// Token: 0x04002C05 RID: 11269
		[Token(Token = "0x4002C05")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002C06 RID: 11270
		[Token(Token = "0x4002C06")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x020008D7 RID: 2263
		[Token(Token = "0x20008D7")]
		[Serializable]
		public class TrashItemData
		{
			// Token: 0x06003EFB RID: 16123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003EFB")]
			[Address(RVA = "0x875B90", Offset = "0x874590", VA = "0x180875B90")]
			public TrashItemData()
			{
			}

			// Token: 0x04002C07 RID: 11271
			[Token(Token = "0x4002C07")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrashItem Item;

			// Token: 0x04002C08 RID: 11272
			[Token(Token = "0x4002C08")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float GenerationChance;
		}
	}
}
