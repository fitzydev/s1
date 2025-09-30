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
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Property;
using ScheduleOne.UI.Phone.Delivery;
using ScheduleOne.UI.Shop;
using UnityEngine.Events;

namespace ScheduleOne.Delivery
{
	// Token: 0x02000788 RID: 1928
	[Token(Token = "0x2000788")]
	public class DeliveryManager : NetworkSingleton<DeliveryManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078B")]
		public string SaveFolderName
		{
			[Token(Token = "0x60033E3")]
			[Address(RVA = "0x7A19D0", Offset = "0x7A03D0", VA = "0x1807A19D0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060033E4 RID: 13284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078C")]
		public string SaveFileName
		{
			[Token(Token = "0x60033E4")]
			[Address(RVA = "0x7A19A0", Offset = "0x7A03A0", VA = "0x1807A19A0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078D")]
		public Loader Loader
		{
			[Token(Token = "0x60033E5")]
			[Address(RVA = "0x672D50", Offset = "0x671750", VA = "0x180672D50", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060033E6 RID: 13286 RVA: 0x0000E448 File Offset: 0x0000C648
		[Token(Token = "0x1700078E")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60033E6")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078F")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60033E7")]
			[Address(RVA = "0x66EEE0", Offset = "0x66D8E0", VA = "0x18066EEE0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033E8")]
			[Address(RVA = "0x6FBE90", Offset = "0x6FA890", VA = "0x1806FBE90", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000790")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60033E9")]
			[Address(RVA = "0x71CA10", Offset = "0x71B410", VA = "0x18071CA10", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033EA")]
			[Address(RVA = "0x7A1A10", Offset = "0x7A0410", VA = "0x1807A1A10", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x0000E460 File Offset: 0x0000C660
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000791")]
		public bool HasChanged
		{
			[Token(Token = "0x60033EB")]
			[Address(RVA = "0x7A1990", Offset = "0x7A0390", VA = "0x1807A1990", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033EC")]
			[Address(RVA = "0x7A1A00", Offset = "0x7A0400", VA = "0x1807A1A00", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x0000E478 File Offset: 0x0000C678
		[Token(Token = "0x17000792")]
		public int LoadOrder
		{
			[Token(Token = "0x60033ED")]
			[Address(RVA = "0x73B250", Offset = "0x739C50", VA = "0x18073B250", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x79FAF0", Offset = "0x79E4F0", VA = "0x18079FAF0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x7A16A0", Offset = "0x7A00A0", VA = "0x1807A16A0", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F0")]
		[Address(RVA = "0x7A01D0", Offset = "0x79EBD0", VA = "0x1807A01D0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F1")]
		[Address(RVA = "0x7A0860", Offset = "0x79F260", VA = "0x1807A0860", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F2")]
		[Address(RVA = "0x7A0500", Offset = "0x79EF00", VA = "0x1807A0500")]
		private void OnMinPass()
		{
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x0000E490 File Offset: 0x0000C690
		[Token(Token = "0x60033F3")]
		[Address(RVA = "0x7A0260", Offset = "0x79EC60", VA = "0x1807A0260")]
		public bool IsLoadingBayFree(Property destination, int loadingDockIndex)
		{
			return default(bool);
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F4")]
		[Address(RVA = "0x7A12B0", Offset = "0x79FCB0", VA = "0x1807A12B0")]
		[ServerRpc(RequireOwnership = false)]
		public void SendDelivery(DeliveryInstance delivery)
		{
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F5")]
		[Address(RVA = "0x7A0AA0", Offset = "0x79F4A0", VA = "0x1807A0AA0")]
		[ObserversRpc]
		[TargetRpc]
		private void ReceiveDelivery(NetworkConnection conn, DeliveryInstance delivery)
		{
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F6")]
		[Address(RVA = "0x7A1540", Offset = "0x79FF40", VA = "0x1807A1540")]
		[ObserversRpc(RunLocally = true)]
		private void SetDeliveryState(string deliveryID, EDeliveryStatus status)
		{
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F7")]
		[Address(RVA = "0x79FC50", Offset = "0x79E650", VA = "0x18079FC50")]
		private DeliveryInstance GetDelivery(string deliveryID)
		{
			return null;
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x79FD30", Offset = "0x79E730", VA = "0x18079FD30")]
		public DeliveryInstance GetDelivery(Property destination)
		{
			return null;
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F9")]
		[Address(RVA = "0x79FB70", Offset = "0x79E570", VA = "0x18079FB70")]
		public DeliveryInstance GetActiveShopDelivery(DeliveryShop shop)
		{
			return null;
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x7A00C0", Offset = "0x79EAC0", VA = "0x1807A00C0")]
		public ShopInterface GetShopInterface(string shopName)
		{
			return null;
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x79FE10", Offset = "0x79E810", VA = "0x18079FE10", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x7A17C0", Offset = "0x7A01C0", VA = "0x1807A17C0")]
		public DeliveryManager()
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x7A0380", Offset = "0x79ED80", VA = "0x1807A0380", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x7A0330", Offset = "0x79ED30", VA = "0x1807A0330", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003400")]
		[Address(RVA = "0x7A12B0", Offset = "0x79FCB0", VA = "0x1807A12B0")]
		private void RpcWriter___Server_SendDelivery_2813439055(DeliveryInstance delivery)
		{
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003401")]
		[Address(RVA = "0x7A0DB0", Offset = "0x79F7B0", VA = "0x1807A0DB0")]
		public void RpcLogic___SendDelivery_2813439055(DeliveryInstance delivery)
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003402")]
		[Address(RVA = "0x7A0F50", Offset = "0x79F950", VA = "0x1807A0F50")]
		private void RpcReader___Server_SendDelivery_2813439055(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003403")]
		[Address(RVA = "0x7A1000", Offset = "0x79FA00", VA = "0x1807A1000")]
		private void RpcWriter___Observers_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003404")]
		[Address(RVA = "0x7A0CA0", Offset = "0x79F6A0", VA = "0x1807A0CA0")]
		private void RpcLogic___ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003405")]
		[Address(RVA = "0x7A0E80", Offset = "0x79F880", VA = "0x1807A0E80")]
		private void RpcReader___Observers_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003406")]
		[Address(RVA = "0x7A13E0", Offset = "0x79FDE0", VA = "0x1807A13E0")]
		private void RpcWriter___Target_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003407")]
		[Address(RVA = "0x7A0FA0", Offset = "0x79F9A0", VA = "0x1807A0FA0")]
		private void RpcReader___Target_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003408")]
		[Address(RVA = "0x7A1140", Offset = "0x79FB40", VA = "0x1807A1140")]
		private void RpcWriter___Observers_SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003409")]
		[Address(RVA = "0x7A0DC0", Offset = "0x79F7C0", VA = "0x1807A0DC0")]
		private void RpcLogic___SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340A")]
		[Address(RVA = "0x7A0ED0", Offset = "0x79F8D0", VA = "0x1807A0ED0")]
		private void RpcReader___Observers_SetDeliveryState_316609003(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340B")]
		[Address(RVA = "0x79FAA0", Offset = "0x79E4A0", VA = "0x18079FAA0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Delivery.DeliveryManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x120")]
		public List<DeliveryInstance> Deliveries;

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x128")]
		public UnityEvent<DeliveryInstance> onDeliveryCreated;

		// Token: 0x04002430 RID: 9264
		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x130")]
		public UnityEvent<DeliveryInstance> onDeliveryCompleted;

		// Token: 0x04002431 RID: 9265
		[Token(Token = "0x4002431")]
		[FieldOffset(Offset = "0x138")]
		private DeliveriesLoader loader;

		// Token: 0x04002435 RID: 9269
		[Token(Token = "0x4002435")]
		[FieldOffset(Offset = "0x158")]
		private List<string> writtenVehicles;

		// Token: 0x04002437 RID: 9271
		[Token(Token = "0x4002437")]
		[FieldOffset(Offset = "0x168")]
		private Dictionary<DeliveryInstance, int> minsSinceVehicleEmpty;

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002439 RID: 9273
		[Token(Token = "0x4002439")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted;
	}
}
