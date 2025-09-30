using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000665 RID: 1637
	[Token(Token = "0x2000665")]
	public class NPCManager : NetworkSingleton<NPCManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000683")]
		public string SaveFolderName
		{
			[Token(Token = "0x6002936")]
			[Address(RVA = "0x71CA50", Offset = "0x71B450", VA = "0x18071CA50", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000684")]
		public string SaveFileName
		{
			[Token(Token = "0x6002937")]
			[Address(RVA = "0x71CA20", Offset = "0x71B420", VA = "0x18071CA20", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000685")]
		public Loader Loader
		{
			[Token(Token = "0x6002938")]
			[Address(RVA = "0x71CA10", Offset = "0x71B410", VA = "0x18071CA10", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		[Token(Token = "0x17000686")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6002939")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600293B RID: 10555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000687")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x600293A")]
			[Address(RVA = "0x63D950", Offset = "0x63C350", VA = "0x18063D950", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600293B")]
			[Address(RVA = "0x71CA90", Offset = "0x71B490", VA = "0x18071CA90", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600293D RID: 10557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000688")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x600293C")]
			[Address(RVA = "0x63D960", Offset = "0x63C360", VA = "0x18063D960", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600293D")]
			[Address(RVA = "0x63DA60", Offset = "0x63C460", VA = "0x18063DA60", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000689")]
		public bool HasChanged
		{
			[Token(Token = "0x600293E")]
			[Address(RVA = "0x71C9F0", Offset = "0x71B3F0", VA = "0x18071C9F0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600293F")]
			[Address(RVA = "0x71CA80", Offset = "0x71B480", VA = "0x18071CA80", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		[Token(Token = "0x1700068A")]
		public int LoadOrder
		{
			[Token(Token = "0x6002940")]
			[Address(RVA = "0x71CA00", Offset = "0x71B400", VA = "0x18071CA00", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002941")]
		[Address(RVA = "0x71BB90", Offset = "0x71A590", VA = "0x18071BB90", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002942")]
		[Address(RVA = "0x71C440", Offset = "0x71AE40", VA = "0x18071C440", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002943")]
		[Address(RVA = "0x71C310", Offset = "0x71AD10", VA = "0x18071C310", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002944")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		public void Update()
		{
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002945")]
		[Address(RVA = "0x71BC10", Offset = "0x71A610", VA = "0x18071BC10")]
		public static NPC GetNPC(string id)
		{
			return null;
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002946")]
		[Address(RVA = "0x71BDC0", Offset = "0x71A7C0", VA = "0x18071BDC0")]
		public static List<NPC> GetNPCsInRegion(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x71C0F0", Offset = "0x71AAF0", VA = "0x18071C0F0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002948")]
		[Address(RVA = "0x71BFC0", Offset = "0x71A9C0", VA = "0x18071BFC0")]
		public List<Transform> GetOrderedDistanceWarpPoints(Vector3 origin)
		{
			return null;
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x71C5C0", Offset = "0x71AFC0", VA = "0x18071C5C0", Slot = "51")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x71C8F0", Offset = "0x71B2F0", VA = "0x18071C8F0")]
		public NPCManager()
		{
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x71C3F0", Offset = "0x71ADF0", VA = "0x18071C3F0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x71C3A0", Offset = "0x71ADA0", VA = "0x18071C3A0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x71BB40", Offset = "0x71A540", VA = "0x18071BB40", Slot = "52")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001EE7 RID: 7911
		[Token(Token = "0x4001EE7")]
		[FieldOffset(Offset = "0x0")]
		public static List<NPC> NPCRegistry;

		// Token: 0x04001EE8 RID: 7912
		[Token(Token = "0x4001EE8")]
		[FieldOffset(Offset = "0x120")]
		public Transform[] NPCWarpPoints;

		// Token: 0x04001EE9 RID: 7913
		[Token(Token = "0x4001EE9")]
		[FieldOffset(Offset = "0x128")]
		public Transform NPCContainer;

		// Token: 0x04001EEA RID: 7914
		[Token(Token = "0x4001EEA")]
		[FieldOffset(Offset = "0x130")]
		[Header("Prefabs")]
		public NPCPoI NPCPoIPrefab;

		// Token: 0x04001EEB RID: 7915
		[Token(Token = "0x4001EEB")]
		[FieldOffset(Offset = "0x138")]
		public NPCPoI PotentialCustomerPoIPrefab;

		// Token: 0x04001EEC RID: 7916
		[Token(Token = "0x4001EEC")]
		[FieldOffset(Offset = "0x140")]
		public NPCPoI PotentialDealerPoIPrefab;

		// Token: 0x04001EED RID: 7917
		[Token(Token = "0x4001EED")]
		[FieldOffset(Offset = "0x148")]
		private NPCsLoader loader;

		// Token: 0x04001EF2 RID: 7922
		[Token(Token = "0x4001EF2")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001EF3 RID: 7923
		[Token(Token = "0x4001EF3")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted;
	}
}
