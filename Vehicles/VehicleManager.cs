using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000877 RID: 2167
	[Token(Token = "0x2000877")]
	public class VehicleManager : NetworkSingleton<VehicleManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000875")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003BC4")]
			[Address(RVA = "0x83B200", Offset = "0x839C00", VA = "0x18083B200", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000876")]
		public string SaveFileName
		{
			[Token(Token = "0x6003BC5")]
			[Address(RVA = "0x83B1D0", Offset = "0x839BD0", VA = "0x18083B1D0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000877")]
		public Loader Loader
		{
			[Token(Token = "0x6003BC6")]
			[Address(RVA = "0x672D50", Offset = "0x671750", VA = "0x180672D50", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x00010050 File Offset: 0x0000E250
		[Token(Token = "0x17000878")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003BC7")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003BC9 RID: 15305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000879")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003BC8")]
			[Address(RVA = "0x66EEE0", Offset = "0x66D8E0", VA = "0x18066EEE0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BC9")]
			[Address(RVA = "0x6FBE90", Offset = "0x6FA890", VA = "0x1806FBE90", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003BCB RID: 15307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087A")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003BCA")]
			[Address(RVA = "0x71CA10", Offset = "0x71B410", VA = "0x18071CA10", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BCB")]
			[Address(RVA = "0x7A1A10", Offset = "0x7A0410", VA = "0x1807A1A10", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06003BCC RID: 15308 RVA: 0x00010068 File Offset: 0x0000E268
		// (set) Token: 0x06003BCD RID: 15309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087B")]
		public bool HasChanged
		{
			[Token(Token = "0x6003BCC")]
			[Address(RVA = "0x7A1990", Offset = "0x7A0390", VA = "0x1807A1990", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BCD")]
			[Address(RVA = "0x7A1A00", Offset = "0x7A0400", VA = "0x1807A1A00", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x1700087C")]
		public int LoadOrder
		{
			[Token(Token = "0x6003BCE")]
			[Address(RVA = "0x83B1C0", Offset = "0x839BC0", VA = "0x18083B1C0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BCF")]
		[Address(RVA = "0x839A10", Offset = "0x838410", VA = "0x180839A10", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0x839EA0", Offset = "0x8388A0", VA = "0x180839EA0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD1")]
		[Address(RVA = "0x83AFB0", Offset = "0x8399B0", VA = "0x18083AFB0")]
		[ServerRpc(RequireOwnership = false)]
		public void SpawnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD2")]
		[Address(RVA = "0x83AA10", Offset = "0x839410", VA = "0x18083AA10")]
		public LandVehicle SpawnAndReturnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			return null;
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0x839DC0", Offset = "0x8387C0", VA = "0x180839DC0")]
		public LandVehicle GetVehiclePrefab(string vehicleCode)
		{
			return null;
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x83A970", Offset = "0x839370", VA = "0x18083A970")]
		public LandVehicle SpawnAndLoadVehicle(VehicleData data, string path, bool playerOwned)
		{
			return null;
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x839F30", Offset = "0x838930", VA = "0x180839F30")]
		public void LoadVehicle(VehicleData data, string path)
		{
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x839BD0", Offset = "0x8385D0", VA = "0x180839BD0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x83ADA0", Offset = "0x8397A0", VA = "0x18083ADA0")]
		public void SpawnLoanSharkVehicle(Vector3 position, Quaternion rot)
		{
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x839A90", Offset = "0x838490", VA = "0x180839A90")]
		[ObserversRpc(RunLocally = true)]
		private void EnableLoanSharkVisuals(NetworkObject veh)
		{
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x83B000", Offset = "0x839A00", VA = "0x18083B000")]
		public VehicleManager()
		{
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x83A0F0", Offset = "0x838AF0", VA = "0x18083A0F0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x83A0A0", Offset = "0x838AA0", VA = "0x18083A0A0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDC")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDD")]
		[Address(RVA = "0x83A600", Offset = "0x839000", VA = "0x18083A600")]
		private void RpcWriter___Server_SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDE")]
		[Address(RVA = "0x83A2C0", Offset = "0x838CC0", VA = "0x18083A2C0")]
		public void RpcLogic___SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDF")]
		[Address(RVA = "0x83A380", Offset = "0x838D80", VA = "0x18083A380")]
		private void RpcReader___Server_SpawnVehicle_3323115898(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE0")]
		[Address(RVA = "0x83A4C0", Offset = "0x838EC0", VA = "0x18083A4C0")]
		private void RpcWriter___Observers_EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE1")]
		[Address(RVA = "0x83A1F0", Offset = "0x838BF0", VA = "0x18083A1F0")]
		private void RpcLogic___EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE2")]
		[Address(RVA = "0x83A310", Offset = "0x838D10", VA = "0x18083A310")]
		private void RpcReader___Observers_EnableLoanSharkVisuals_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE3")]
		[Address(RVA = "0x8399C0", Offset = "0x8383C0", VA = "0x1808399C0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vehicles.VehicleManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040029B3 RID: 10675
		[Token(Token = "0x40029B3")]
		[FieldOffset(Offset = "0x120")]
		public List<LandVehicle> AllVehicles;

		// Token: 0x040029B4 RID: 10676
		[Token(Token = "0x40029B4")]
		[FieldOffset(Offset = "0x128")]
		[Header("Vehicles")]
		public List<LandVehicle> VehiclePrefabs;

		// Token: 0x040029B5 RID: 10677
		[Token(Token = "0x40029B5")]
		[FieldOffset(Offset = "0x130")]
		public List<LandVehicle> PlayerOwnedVehicles;

		// Token: 0x040029B6 RID: 10678
		[Token(Token = "0x40029B6")]
		[FieldOffset(Offset = "0x138")]
		private VehiclesLoader loader;

		// Token: 0x040029BB RID: 10683
		[Token(Token = "0x40029BB")]
		[FieldOffset(Offset = "0x158")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x040029BC RID: 10684
		[Token(Token = "0x40029BC")]
		[FieldOffset(Offset = "0x159")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted;
	}
}
