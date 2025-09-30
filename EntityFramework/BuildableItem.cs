using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EasyButtons;
using EPOOutline;
using FishNet.Component.Ownership;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x200059C")]
	[RequireComponent(typeof(PredictedSpawn))]
	public class BuildableItem : NetworkBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020A3 RID: 8355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000591")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x60020A2")]
			[Address(RVA = "0x66EF30", Offset = "0x66D930", VA = "0x18066EF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A3")]
			[Address(RVA = "0x66F090", Offset = "0x66DA90", VA = "0x18066F090")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020A5 RID: 8357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000592")]
		public Property ParentProperty
		{
			[Token(Token = "0x60020A4")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10", Slot = "45")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A5")]
			[Address(RVA = "0x630490", Offset = "0x62EE90", VA = "0x180630490")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0000A860 File Offset: 0x00008A60
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000593")]
		public bool IsDestroyed
		{
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x567020", Offset = "0x565A20", VA = "0x180567020", Slot = "46")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x66F080", Offset = "0x66DA80", VA = "0x18066F080")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0000A878 File Offset: 0x00008A78
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000594")]
		public bool Initialized
		{
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x66EF10", Offset = "0x66D910", VA = "0x18066EF10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020A9")]
			[Address(RVA = "0x66F060", Offset = "0x66DA60", VA = "0x18066F060")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0000A890 File Offset: 0x00008A90
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000595")]
		public Guid GUID
		{
			[Token(Token = "0x60020AA")]
			[Address(RVA = "0x66EEF0", Offset = "0x66D8F0", VA = "0x18066EEF0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x60020AB")]
			[Address(RVA = "0x66F040", Offset = "0x66DA40", VA = "0x18066F040")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		// (set) Token: 0x060020AD RID: 8365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000596")]
		public bool IsCulled
		{
			[Token(Token = "0x60020AC")]
			[Address(RVA = "0x66EF20", Offset = "0x66D920", VA = "0x18066EF20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020AD")]
			[Address(RVA = "0x66F070", Offset = "0x66DA70", VA = "0x18066F070")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000597")]
		public GameObject BuildHandler
		{
			[Token(Token = "0x60020AE")]
			[Address(RVA = "0x66EEE0", Offset = "0x66D8E0", VA = "0x18066EEE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x669670", Offset = "0x668070", VA = "0x180669670")]
		[Button]
		public void AddChildMeshes()
		{
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		// (set) Token: 0x060020B1 RID: 8369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000598")]
		public bool LocallyBuilt
		{
			[Token(Token = "0x60020B0")]
			[Address(RVA = "0x66EF60", Offset = "0x66D960", VA = "0x18066EF60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020B1")]
			[Address(RVA = "0x66F0F0", Offset = "0x66DAF0", VA = "0x18066F0F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x66E5E0", Offset = "0x66CFE0", VA = "0x18066E5E0")]
		public void SetLocallyBuilt()
		{
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000599")]
		public string SaveFolderName
		{
			[Token(Token = "0x60020B3")]
			[Address(RVA = "0x66EFA0", Offset = "0x66D9A0", VA = "0x18066EFA0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059A")]
		public string SaveFileName
		{
			[Token(Token = "0x60020B4")]
			[Address(RVA = "0x66EF70", Offset = "0x66D970", VA = "0x18066EF70", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059B")]
		public Loader Loader
		{
			[Token(Token = "0x60020B5")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x1700059C")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60020B6")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059D")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60020B7")]
			[Address(RVA = "0x66EF40", Offset = "0x66D940", VA = "0x18066EF40", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020B8")]
			[Address(RVA = "0x66F0B0", Offset = "0x66DAB0", VA = "0x18066F0B0", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059E")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60020B9")]
			[Address(RVA = "0x66EF50", Offset = "0x66D950", VA = "0x18066EF50", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020BA")]
			[Address(RVA = "0x66F0D0", Offset = "0x66DAD0", VA = "0x18066F0D0", Slot = "29")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059F")]
		public bool HasChanged
		{
			[Token(Token = "0x60020BB")]
			[Address(RVA = "0x66EF00", Offset = "0x66D900", VA = "0x18066EF00", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020BC")]
			[Address(RVA = "0x66F050", Offset = "0x66DA50", VA = "0x18066F050", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BD")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "47")]
		public virtual void Awake()
		{
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x66EC10", Offset = "0x66D610", VA = "0x18066EC10", Slot = "48")]
		protected virtual void Start()
		{
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x66C6D0", Offset = "0x66B0D0", VA = "0x18066C6D0", Slot = "49")]
		protected virtual Property GetProperty([Optional] Transform searchTransform)
		{
			return null;
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x66D2B0", Offset = "0x66BCB0", VA = "0x18066D2B0", Slot = "50")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x66D510", Offset = "0x66BF10", VA = "0x18066D510", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x66E290", Offset = "0x66CC90", VA = "0x18066E290", Slot = "51")]
		protected virtual void SendInitToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x66DFC0", Offset = "0x66C9C0", VA = "0x18066DFC0")]
		[ServerRpc(RequireOwnership = false)]
		public void SendBuildableItemData(ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x66D690", Offset = "0x66C090", VA = "0x18066D690")]
		[ObserversRpc]
		[TargetRpc]
		public void ReceiveBuildableItemData(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x66CD50", Offset = "0x66B750", VA = "0x18066CD50", Slot = "52")]
		public virtual void InitializeBuildableItem(ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x669910", Offset = "0x668310", VA = "0x180669910")]
		public bool CanBePickedUp(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x60020C7")]
		[Address(RVA = "0x6698C0", Offset = "0x6682C0", VA = "0x1806698C0", Slot = "53")]
		public virtual bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x66D570", Offset = "0x66BF70", VA = "0x18066D570", Slot = "54")]
		public virtual void PickupItem()
		{
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x669B20", Offset = "0x668520", VA = "0x180669B20", Slot = "55")]
		public virtual void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x669D20", Offset = "0x668720", VA = "0x180669D20")]
		[ServerRpc(RequireOwnership = false)]
		private void Destroy_Networked()
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x669A00", Offset = "0x668400", VA = "0x180669A00")]
		[ObserversRpc]
		private void DestroyItemWrapper()
		{
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x66E570", Offset = "0x66CF70", VA = "0x18066E570", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x669EB0", Offset = "0x6688B0", VA = "0x180669EB0")]
		public static Color32 GetColorFromOutlineColorEnum(BuildableItem.EOutlineColor col)
		{
			return default(Color32);
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x66E6D0", Offset = "0x66D0D0", VA = "0x18066E6D0", Slot = "56")]
		public virtual void ShowOutline(Color color)
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x66E5F0", Offset = "0x66CFF0", VA = "0x18066E5F0")]
		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x66CC90", Offset = "0x66B690", VA = "0x18066CC90", Slot = "57")]
		public virtual void HideOutline()
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x669F10", Offset = "0x668910", VA = "0x180669F10")]
		public Vector3 GetFurthestPointFromBoundingCollider(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0000A968 File Offset: 0x00008B68
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x66AAA0", Offset = "0x6694A0", VA = "0x18066AAA0")]
		public bool GetPenetration(out float x, out float z, out float y)
		{
			return default(bool);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x66C870", Offset = "0x66B270", VA = "0x18066C870")]
		private bool HasLoS_IgnoreBuildables(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x66E370", Offset = "0x66CD70", VA = "0x18066E370", Slot = "58")]
		public virtual void SetCulled(bool culled)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x66C7C0", Offset = "0x66B1C0", VA = "0x18066C7C0", Slot = "59")]
		public virtual DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x669E30", Offset = "0x668830", VA = "0x180669E30", Slot = "60")]
		public virtual BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x66C830", Offset = "0x66B230", VA = "0x18066C830", Slot = "33")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x66ED70", Offset = "0x66D770", VA = "0x18066ED70", Slot = "61")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x66EDD0", Offset = "0x66D7D0", VA = "0x18066EDD0")]
		public BuildableItem()
		{
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x66D360", Offset = "0x66BD60", VA = "0x18066D360", Slot = "62")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x66D340", Offset = "0x66BD40", VA = "0x18066D340", Slot = "63")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x66DFC0", Offset = "0x66C9C0", VA = "0x18066DFC0")]
		private void RpcWriter___Server_SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x66DA90", Offset = "0x66C490", VA = "0x18066DA90")]
		public void RpcLogic___SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x66DD10", Offset = "0x66C710", VA = "0x18066DD10")]
		private void RpcReader___Server_SendBuildableItemData_3537728543(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x66DE40", Offset = "0x66C840", VA = "0x18066DE40")]
		private void RpcWriter___Observers_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x66DA60", Offset = "0x66C460", VA = "0x18066DA60")]
		public void RpcLogic___ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x66DB00", Offset = "0x66C500", VA = "0x18066DB00")]
		private void RpcReader___Observers_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x66E120", Offset = "0x66CB20", VA = "0x18066E120")]
		private void RpcWriter___Target_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x66DDA0", Offset = "0x66C7A0", VA = "0x18066DDA0")]
		private void RpcReader___Target_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x669D20", Offset = "0x668720", VA = "0x180669D20")]
		private void RpcWriter___Server_Destroy_Networked_2166136261()
		{
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x66D900", Offset = "0x66C300", VA = "0x18066D900")]
		private void RpcLogic___Destroy_Networked_2166136261()
		{
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x66DBA0", Offset = "0x66C5A0", VA = "0x18066DBA0")]
		private void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x669A00", Offset = "0x668400", VA = "0x180669A00")]
		private void RpcWriter___Observers_DestroyItemWrapper_2166136261()
		{
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x66D8E0", Offset = "0x66C2E0", VA = "0x18066D8E0")]
		private void RpcLogic___DestroyItemWrapper_2166136261()
		{
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x66DAC0", Offset = "0x66C4C0", VA = "0x18066DAC0")]
		private void RpcReader___Observers_DestroyItemWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "64")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.BuildableItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001ABD RID: 6845
		[Token(Token = "0x4001ABD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		[HideInInspector]
		public bool isGhost;

		// Token: 0x04001ABE RID: 6846
		[Token(Token = "0x4001ABE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Header("Build Settings")]
		[SerializeField]
		protected GameObject buildHandler;

		// Token: 0x04001ABF RID: 6847
		[Token(Token = "0x4001ABF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public float HoldDistance;

		// Token: 0x04001AC0 RID: 6848
		[Token(Token = "0x4001AC0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Transform BuildPoint;

		// Token: 0x04001AC1 RID: 6849
		[Token(Token = "0x4001AC1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Transform MidAirCenterPoint;

		// Token: 0x04001AC2 RID: 6850
		[Token(Token = "0x4001AC2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public BoxCollider BoundingCollider;

		// Token: 0x04001AC3 RID: 6851
		[Token(Token = "0x4001AC3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Header("Outline settings")]
		[SerializeField]
		protected List<GameObject> OutlineRenderers;

		// Token: 0x04001AC4 RID: 6852
		[Token(Token = "0x4001AC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		protected bool IncludeOutlineRendererChildren;

		// Token: 0x04001AC5 RID: 6853
		[Token(Token = "0x4001AC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		protected Outlinable OutlineEffect;

		// Token: 0x04001AC6 RID: 6854
		[Token(Token = "0x4001AC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[Header("Culling Settings")]
		public GameObject[] GameObjectsToCull;

		// Token: 0x04001AC7 RID: 6855
		[Token(Token = "0x4001AC7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public List<MeshRenderer> MeshesToCull;

		// Token: 0x04001AC8 RID: 6856
		[Token(Token = "0x4001AC8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Header("Buildable Events")]
		public UnityEvent onGhostModel;

		// Token: 0x04001AC9 RID: 6857
		[Token(Token = "0x4001AC9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public UnityEvent onInitialized;

		// Token: 0x04001ACA RID: 6858
		[Token(Token = "0x4001ACA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UnityEvent onDestroyed;

		// Token: 0x04001ACB RID: 6859
		[Token(Token = "0x4001ACB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public Action<BuildableItem> onDestroyedWithParameter;

		// Token: 0x04001AD0 RID: 6864
		[Token(Token = "0x4001AD0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001AD1 RID: 6865
		[Token(Token = "0x4001AD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted;

		// Token: 0x0200059D RID: 1437
		[Token(Token = "0x200059D")]
		public enum EOutlineColor
		{
			// Token: 0x04001AD3 RID: 6867
			[Token(Token = "0x4001AD3")]
			White,
			// Token: 0x04001AD4 RID: 6868
			[Token(Token = "0x4001AD4")]
			Blue,
			// Token: 0x04001AD5 RID: 6869
			[Token(Token = "0x4001AD5")]
			LightBlue
		}
	}
}
