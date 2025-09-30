using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EPOOutline;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Combat;
using ScheduleOne.Dialogue;
using ScheduleOne.Doors;
using ScheduleOne.Interaction;
using ScheduleOne.Map;
using ScheduleOne.Messaging;
using ScheduleOne.NPCs.Actions;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200065B RID: 1627
	[Token(Token = "0x200065B")]
	[RequireComponent(typeof(NPCHealth))]
	public class NPC : NetworkBehaviour, IGUIDRegisterable, ISaveable, ICombatTargetable, IDamageable, ISightable
	{
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065A")]
		public string fullName
		{
			[Token(Token = "0x60027B0")]
			[Address(RVA = "0x70A750", Offset = "0x709150", VA = "0x18070A750")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065B")]
		public float Scale
		{
			[Token(Token = "0x60027B1")]
			[Address(RVA = "0x716D70", Offset = "0x715770", VA = "0x180716D70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60027B2")]
			[Address(RVA = "0x716EE0", Offset = "0x7158E0", VA = "0x180716EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x0000C408 File Offset: 0x0000A608
		[Token(Token = "0x1700065C")]
		public bool IsConscious
		{
			[Token(Token = "0x60027B3")]
			[Address(RVA = "0x716B80", Offset = "0x715580", VA = "0x180716B80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065D")]
		public LandVehicle CurrentVehicle
		{
			[Token(Token = "0x60027B4")]
			[Address(RVA = "0x66EF50", Offset = "0x66D950", VA = "0x18066EF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027B5")]
			[Address(RVA = "0x66F0D0", Offset = "0x66DAD0", VA = "0x18066F0D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0000C420 File Offset: 0x0000A620
		[Token(Token = "0x1700065E")]
		public bool IsInVehicle
		{
			[Token(Token = "0x60027B6")]
			[Address(RVA = "0x716C30", Offset = "0x715630", VA = "0x180716C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x0000C438 File Offset: 0x0000A638
		[Token(Token = "0x1700065F")]
		public bool isInBuilding
		{
			[Token(Token = "0x60027B7")]
			[Address(RVA = "0x716DD0", Offset = "0x7157D0", VA = "0x180716DD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000660")]
		public NPCEnterableBuilding CurrentBuilding
		{
			[Token(Token = "0x60027B8")]
			[Address(RVA = "0x716B50", Offset = "0x715550", VA = "0x180716B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027B9")]
			[Address(RVA = "0x716E50", Offset = "0x715850", VA = "0x180716E50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000661")]
		public StaticDoor LastEnteredDoor
		{
			[Token(Token = "0x60027BA")]
			[Address(RVA = "0x6975E0", Offset = "0x695FE0", VA = "0x1806975E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027BB")]
			[Address(RVA = "0x6975F0", Offset = "0x695FF0", VA = "0x1806975F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000662")]
		public MSGConversation MSGConversation
		{
			[Token(Token = "0x60027BC")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027BD")]
			[Address(RVA = "0x6302A0", Offset = "0x62ECA0", VA = "0x1806302A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000663")]
		public string SaveFolderName
		{
			[Token(Token = "0x60027BE")]
			[Address(RVA = "0x70A750", Offset = "0x709150", VA = "0x18070A750", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000664")]
		public string SaveFileName
		{
			[Token(Token = "0x60027BF")]
			[Address(RVA = "0x716D40", Offset = "0x715740", VA = "0x180716D40", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000665")]
		public Loader Loader
		{
			[Token(Token = "0x60027C0")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x0000C450 File Offset: 0x0000A650
		[Token(Token = "0x17000666")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60027C1")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000667")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60027C2")]
			[Address(RVA = "0x716CB0", Offset = "0x7156B0", VA = "0x180716CB0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027C3")]
			[Address(RVA = "0x716EA0", Offset = "0x7158A0", VA = "0x180716EA0", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000668")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60027C4")]
			[Address(RVA = "0x716CC0", Offset = "0x7156C0", VA = "0x180716CC0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027C5")]
			[Address(RVA = "0x716EC0", Offset = "0x7158C0", VA = "0x180716EC0", Slot = "29")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x0000C468 File Offset: 0x0000A668
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000669")]
		public bool HasChanged
		{
			[Token(Token = "0x60027C6")]
			[Address(RVA = "0x62FDC0", Offset = "0x62E7C0", VA = "0x18062FDC0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027C7")]
			[Address(RVA = "0x6304D0", Offset = "0x62EED0", VA = "0x1806304D0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x0000C480 File Offset: 0x0000A680
		[Token(Token = "0x1700066A")]
		public Vector3 CenterPoint
		{
			[Token(Token = "0x60027C8")]
			[Address(RVA = "0x716B00", Offset = "0x715500", VA = "0x180716B00", Slot = "46")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066B")]
		public Transform CenterPointTransform
		{
			[Token(Token = "0x60027C9")]
			[Address(RVA = "0x716AD0", Offset = "0x7154D0", VA = "0x180716AD0", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x0000C498 File Offset: 0x0000A698
		[Token(Token = "0x1700066C")]
		public Vector3 LookAtPoint
		{
			[Token(Token = "0x60027CA")]
			[Address(RVA = "0x716CD0", Offset = "0x7156D0", VA = "0x180716CD0", Slot = "48")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[Token(Token = "0x1700066D")]
		public bool IsCurrentlyTargetable
		{
			[Token(Token = "0x60027CB")]
			[Address(RVA = "0x716BF0", Offset = "0x7155F0", VA = "0x180716BF0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x1700066E")]
		public float RangedHitChanceMultiplier
		{
			[Token(Token = "0x60027CC")]
			[Address(RVA = "0x716D30", Offset = "0x715730", VA = "0x180716D30", Slot = "50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		[Token(Token = "0x1700066F")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60027CD")]
			[Address(RVA = "0x716D90", Offset = "0x715790", VA = "0x180716D90", Slot = "51")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "52")]
		public void RecordLastKnownPosition(bool resetTimeSinceLastSeen)
		{
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x70AC00", Offset = "0x709600", VA = "0x18070AC00", Slot = "53")]
		public float GetSearchTime()
		{
			return 0f;
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000670")]
		public VisionEvent HighestProgressionEvent
		{
			[Token(Token = "0x60027D0")]
			[Address(RVA = "0x716B70", Offset = "0x715570", VA = "0x180716B70", Slot = "60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027D1")]
			[Address(RVA = "0x716E80", Offset = "0x715880", VA = "0x180716E80", Slot = "61")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000671")]
		public EntityVisibility VisibilityComponent
		{
			[Token(Token = "0x60027D2")]
			[Address(RVA = "0x66EF40", Offset = "0x66D940", VA = "0x18066EF40", Slot = "62")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x60027D3")]
		[Address(RVA = "0x70AD60", Offset = "0x709760", VA = "0x18070AD60", Slot = "63")]
		public bool IsCurrentlySightable()
		{
			return default(bool);
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x0000C528 File Offset: 0x0000A728
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000672")]
		public Guid GUID
		{
			[Token(Token = "0x60027D4")]
			[Address(RVA = "0x716B60", Offset = "0x715560", VA = "0x180716B60", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x60027D5")]
			[Address(RVA = "0x716E70", Offset = "0x715870", VA = "0x180716E70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x0000C540 File Offset: 0x0000A740
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000673")]
		public bool isVisible
		{
			[Token(Token = "0x60027D6")]
			[Address(RVA = "0x716E40", Offset = "0x715840", VA = "0x180716E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027D7")]
			[Address(RVA = "0x716F10", Offset = "0x715910", VA = "0x180716F10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x0000C558 File Offset: 0x0000A758
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000674")]
		public bool isUnsettled
		{
			[Token(Token = "0x60027D8")]
			[Address(RVA = "0x716E30", Offset = "0x715830", VA = "0x180716E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027D9")]
			[Address(RVA = "0x716F00", Offset = "0x715900", VA = "0x180716F00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x0000C570 File Offset: 0x0000A770
		[Token(Token = "0x17000675")]
		public bool IsPanicked
		{
			[Token(Token = "0x60027DA")]
			[Address(RVA = "0x716C90", Offset = "0x715690", VA = "0x180716C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x0000C588 File Offset: 0x0000A788
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000676")]
		public float TimeSincePanicked
		{
			[Token(Token = "0x60027DB")]
			[Address(RVA = "0x716D80", Offset = "0x715780", VA = "0x180716D80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60027DC")]
			[Address(RVA = "0x716EF0", Offset = "0x7158F0", VA = "0x180716EF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x709960", Offset = "0x708360", VA = "0x180709960", Slot = "64")]
		public virtual void Awake()
		{
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x7099B0", Offset = "0x7083B0", VA = "0x1807099B0", Slot = "65")]
		protected virtual void CheckAndGetReferences()
		{
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x70ACB0", Offset = "0x7096B0", VA = "0x18070ACB0", Slot = "66")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x715250", Offset = "0x713C50", VA = "0x180715250", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x70C900", Offset = "0x70B300", VA = "0x18070C900")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x709E20", Offset = "0x708820", VA = "0x180709E20", Slot = "67")]
		protected virtual void CreateMessageConversation()
		{
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x70A750", Offset = "0x709150", VA = "0x18070A750", Slot = "68")]
		protected virtual string GetMessagingName()
		{
			return null;
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x66EEE0", Offset = "0x66D8E0", VA = "0x18066EEE0", Slot = "69")]
		public virtual Sprite GetMessagingIcon()
		{
			return null;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x714440", Offset = "0x712E40", VA = "0x180714440")]
		public void SendTextMessage(string message)
		{
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x70C1E0", Offset = "0x70ABE0", VA = "0x18070C1E0", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x7161E0", Offset = "0x714BE0", VA = "0x1807161E0", Slot = "70")]
		protected virtual void Start()
		{
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x70BC30", Offset = "0x70A630", VA = "0x18070BC30", Slot = "71")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x70BE00", Offset = "0x70A800", VA = "0x18070BE00", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EA")]
		[Address(RVA = "0x715470", Offset = "0x713E70", VA = "0x180715470")]
		[ObserversRpc]
		private void SetTransform(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EB")]
		[Address(RVA = "0x70ADA0", Offset = "0x7097A0", VA = "0x18070ADA0", Slot = "72")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EC")]
		[Address(RVA = "0x7166B0", Offset = "0x7150B0", VA = "0x1807166B0", Slot = "73")]
		protected virtual void Update()
		{
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027ED")]
		[Address(RVA = "0x715920", Offset = "0x714320", VA = "0x180715920", Slot = "74")]
		public virtual void SetVisible(bool visible, bool networked = false)
		{
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EE")]
		[Address(RVA = "0x7157D0", Offset = "0x7141D0", VA = "0x1807157D0")]
		[ObserversRpc(RunLocally = true)]
		private void SetVisible_Networked(bool visible)
		{
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EF")]
		[Address(RVA = "0x7152C0", Offset = "0x713CC0", VA = "0x1807152C0")]
		public void SetScale(float scale)
		{
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F0")]
		[Address(RVA = "0x7152E0", Offset = "0x713CE0", VA = "0x1807152E0")]
		public void SetScale(float scale, float lerpTime)
		{
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F1")]
		[Address(RVA = "0x708C80", Offset = "0x707680", VA = "0x180708C80", Slot = "75")]
		protected virtual void ApplyScale()
		{
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F2")]
		[Address(RVA = "0x708B50", Offset = "0x707550", VA = "0x180708B50", Slot = "76")]
		[ServerRpc(RequireOwnership = false)]
		public virtual void AimedAtByPlayer(NetworkObject player)
		{
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F3")]
		[Address(RVA = "0x70C380", Offset = "0x70AD80", VA = "0x18070C380")]
		public void OverrideAggression(float aggression)
		{
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F4")]
		[Address(RVA = "0x70D040", Offset = "0x70BA40", VA = "0x18070D040")]
		public void ResetAggression()
		{
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x70BD50", Offset = "0x70A750", VA = "0x18070BD50", Slot = "77")]
		protected virtual void OnDie()
		{
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x70BD80", Offset = "0x70A780", VA = "0x18070BD80", Slot = "78")]
		protected virtual void OnKnockedOut()
		{
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x714300", Offset = "0x712D00", VA = "0x180714300", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void SendImpact(Impact impact)
		{
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x70CB50", Offset = "0x70B550", VA = "0x18070CB50", Slot = "80")]
		[ObserversRpc(RunLocally = true)]
		public virtual void ReceiveImpact(Impact impact)
		{
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x70C920", Offset = "0x70B320", VA = "0x18070C920", Slot = "81")]
		public virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FA")]
		[Address(RVA = "0x70A290", Offset = "0x708C90", VA = "0x18070A290", Slot = "82")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void EnterVehicle(NetworkConnection connection, LandVehicle veh)
		{
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x70A630", Offset = "0x709030", VA = "0x18070A630", Slot = "83")]
		[ObserversRpc(RunLocally = true)]
		public virtual void ExitVehicle()
		{
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x714500", Offset = "0x712F00", VA = "0x180714500")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendWorldspaceDialogueReaction(string key, float duration)
		{
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x70C780", Offset = "0x70B180", VA = "0x18070C780")]
		[ObserversRpc(RunLocally = true)]
		private void PlayWorldspaceDialogueReaction(string key, float duration)
		{
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FE")]
		[Address(RVA = "0x712BB0", Offset = "0x7115B0", VA = "0x180712BB0")]
		[ServerRpc(RequireOwnership = false)]
		public void SendWorldSpaceDialogue(string text, float duration)
		{
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FF")]
		[Address(RVA = "0x70EDA0", Offset = "0x70D7A0", VA = "0x18070EDA0")]
		[ObserversRpc(RunLocally = true)]
		public void ShowWorldSpaceDialogue(string text, float duration)
		{
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x714BC0", Offset = "0x7135C0", VA = "0x180714BC0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConversant(NetworkObject player)
		{
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x70AC90", Offset = "0x709690", VA = "0x18070AC90")]
		private void Hovered_Internal()
		{
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x70AD40", Offset = "0x709740", VA = "0x18070AD40")]
		private void Interacted_Internal()
		{
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "84")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "85")]
		protected virtual void Interacted()
		{
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x709FD0", Offset = "0x7089D0", VA = "0x180709FD0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void EnterBuilding(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x70A4F0", Offset = "0x708EF0", VA = "0x18070A4F0")]
		[ObserversRpc(RunLocally = true)]
		public void ExitBuilding(string buildingID = "")
		{
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x714FB0", Offset = "0x7139B0", VA = "0x180714FB0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetEquippable_Networked(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x714E40", Offset = "0x713840", VA = "0x180714E40")]
		public AvatarEquippable SetEquippable_Networked_Return(NetworkConnection conn, string assetPath)
		{
			return null;
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x715220", Offset = "0x713C20", VA = "0x180715220")]
		public AvatarEquippable SetEquippable_Return(string assetPath)
		{
			return null;
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x712140", Offset = "0x710B40", VA = "0x180712140")]
		[ObserversRpc(RunLocally = false, ExcludeServer = true)]
		private void SetEquippable_Networked_ExcludeServer(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x714090", Offset = "0x712A90", VA = "0x180714090")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SendEquippableMessage_Networked(NetworkConnection conn, string message)
		{
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x713D30", Offset = "0x712730", VA = "0x180713D30")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SendEquippableMessage_Networked_Vector(NetworkConnection conn, string message, Vector3 data)
		{
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x712810", Offset = "0x711210", VA = "0x180712810")]
		[ServerRpc(RequireOwnership = false)]
		public void SendAnimationTrigger(string trigger)
		{
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x714920", Offset = "0x713320", VA = "0x180714920")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280F")]
		[Address(RVA = "0x714B90", Offset = "0x713590", VA = "0x180714B90")]
		public void SetAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002810")]
		[Address(RVA = "0x70D050", Offset = "0x70BA50", VA = "0x18070D050")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x70D2C0", Offset = "0x70BCC0", VA = "0x18070D2C0")]
		public void ResetAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x714CF0", Offset = "0x7136F0", VA = "0x180714CF0")]
		[ObserversRpc(RunLocally = true)]
		public void SetCrouched_Networked(bool crouched)
		{
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x714650", Offset = "0x713050", VA = "0x180714650")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetAnimationBool_Networked(NetworkConnection conn, string id, bool value)
		{
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x7148F0", Offset = "0x7132F0", VA = "0x1807148F0")]
		public void SetAnimationBool(string trigger, bool val)
		{
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x7154B0", Offset = "0x713EB0", VA = "0x1807154B0", Slot = "86")]
		protected virtual void SetUnsettled_30s(Player player)
		{
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x715640", Offset = "0x714040", VA = "0x180715640")]
		protected void SetUnsettled(float duration)
		{
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x7130D0", Offset = "0x711AD0", VA = "0x1807130D0")]
		[ServerRpc(RequireOwnership = false)]
		public void SetPanicked()
		{
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002818")]
		[Address(RVA = "0x70CC90", Offset = "0x70B690", VA = "0x18070CC90")]
		[ObserversRpc]
		private void ReceivePanicked()
		{
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002819")]
		[Address(RVA = "0x70CF20", Offset = "0x70B920", VA = "0x18070CF20")]
		[ObserversRpc]
		private void RemovePanicked()
		{
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281A")]
		[Address(RVA = "0x66EF30", Offset = "0x66D930", VA = "0x18066EF30", Slot = "87")]
		public virtual string GetNameAddress()
		{
			return null;
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281B")]
		[Address(RVA = "0x70C610", Offset = "0x70B010", VA = "0x18070C610")]
		public void PlayVO(EVOLineType lineType, bool network = false)
		{
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281C")]
		[Address(RVA = "0x70C4E0", Offset = "0x70AEE0", VA = "0x18070C4E0")]
		[ServerRpc(RequireOwnership = false)]
		private void PlayVO_Server(EVOLineType lineType)
		{
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281D")]
		[Address(RVA = "0x70C390", Offset = "0x70AD90", VA = "0x18070C390")]
		[ObserversRpc(RunLocally = true)]
		private void PlayVO_Client(EVOLineType lineType)
		{
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281E")]
		[Address(RVA = "0x70CDB0", Offset = "0x70B7B0", VA = "0x18070CDB0")]
		[TargetRpc]
		public void ReceiveRelationshipData(NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281F")]
		[Address(RVA = "0x712FA0", Offset = "0x7119A0", VA = "0x180712FA0")]
		[ServerRpc(RequireOwnership = false)]
		public void SetIsBeingPickPocketed(bool pickpocketed)
		{
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002820")]
		[Address(RVA = "0x712A70", Offset = "0x711470", VA = "0x180712A70")]
		[ServerRpc(RequireOwnership = false)]
		public void SendRelationship(float relationship)
		{
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x70EC50", Offset = "0x70D650", VA = "0x18070EC50")]
		[ObserversRpc]
		private void SetRelationship(float relationship)
		{
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x715D20", Offset = "0x714720", VA = "0x180715D20", Slot = "88")]
		public void ShowOutline(Color color)
		{
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x70AC10", Offset = "0x709610", VA = "0x18070AC10", Slot = "89")]
		public void HideOutline()
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x715C70", Offset = "0x714670", VA = "0x180715C70", Slot = "90")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x715C30", Offset = "0x714630", VA = "0x180715C30", Slot = "91")]
		protected virtual bool ShouldSaveRelationshipData()
		{
			return default(bool);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x715BD0", Offset = "0x7145D0", VA = "0x180715BD0")]
		protected bool ShouldSaveMessages()
		{
			return default(bool);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x715B70", Offset = "0x714570", VA = "0x180715B70", Slot = "92")]
		protected virtual bool ShouldSaveInventory()
		{
			return default(bool);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0000C600 File Offset: 0x0000A800
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x715B20", Offset = "0x714520", VA = "0x180715B20", Slot = "93")]
		protected virtual bool ShouldSaveHealth()
		{
			return default(bool);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x70ABC0", Offset = "0x7095C0", VA = "0x18070ABC0", Slot = "33")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282A")]
		[Address(RVA = "0x70A7B0", Offset = "0x7091B0", VA = "0x18070A7B0", Slot = "94")]
		public virtual NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282B")]
		[Address(RVA = "0x70A810", Offset = "0x709210", VA = "0x18070A810", Slot = "95")]
		public virtual DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282C")]
		[Address(RVA = "0x716700", Offset = "0x715100", VA = "0x180716700", Slot = "96")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282D")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "97")]
		public virtual void Load(NPCData data, string containerPath)
		{
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282E")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "98")]
		public virtual void Load(DynamicSaveData dynamicData, NPCData npcData)
		{
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282F")]
		[Address(RVA = "0x716760", Offset = "0x715160", VA = "0x180716760")]
		public NPC()
		{
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002830")]
		[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0", Slot = "45")]
		private NetworkObject ScheduleOne.Combat.ICombatTargetable.get_NetworkObject()
		{
			return null;
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002831")]
		[Address(RVA = "0x62C680", Offset = "0x62B080", VA = "0x18062C680", Slot = "56")]
		private GameObject ScheduleOne.Combat.IDamageable.get_gameObject()
		{
			return null;
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002832")]
		[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0", Slot = "59")]
		private NetworkObject ScheduleOne.Vision.ISightable.get_NetworkObject()
		{
			return null;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002833")]
		[Address(RVA = "0x7165A0", Offset = "0x714FA0", VA = "0x1807165A0")]
		[CompilerGenerated]
		private void <Awake>g__Unlocked|134_0(NPCRelationData.EUnlockType unlockType, bool notify)
		{
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002834")]
		[Address(RVA = "0x70B040", Offset = "0x709A40", VA = "0x18070B040", Slot = "99")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x70AFF0", Offset = "0x7099F0", VA = "0x18070AFF0", Slot = "100")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002837")]
		[Address(RVA = "0x7122B0", Offset = "0x710CB0", VA = "0x1807122B0")]
		private void RpcWriter___Observers_SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x70F270", Offset = "0x70DC70", VA = "0x18070F270")]
		private void RpcLogic___SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x70FCE0", Offset = "0x70E6E0", VA = "0x18070FCE0")]
		private void RpcReader___Observers_SetTransform_4260003484(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x712560", Offset = "0x710F60", VA = "0x180712560")]
		private void RpcWriter___Observers_SetVisible_Networked_1140765316(bool visible)
		{
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283B")]
		[Address(RVA = "0x70F300", Offset = "0x70DD00", VA = "0x18070F300")]
		private void RpcLogic___SetVisible_Networked_1140765316(bool visible)
		{
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283C")]
		[Address(RVA = "0x70FE00", Offset = "0x70E800", VA = "0x18070FE00")]
		private void RpcReader___Observers_SetVisible_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283D")]
		[Address(RVA = "0x708B50", Offset = "0x707550", VA = "0x180708B50")]
		private void RpcWriter___Server_AimedAtByPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283E")]
		[Address(RVA = "0x70D2F0", Offset = "0x70BCF0", VA = "0x18070D2F0", Slot = "101")]
		public virtual void RpcLogic___AimedAtByPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283F")]
		[Address(RVA = "0x70FF10", Offset = "0x70E910", VA = "0x18070FF10")]
		private void RpcReader___Server_AimedAtByPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002840")]
		[Address(RVA = "0x712940", Offset = "0x711340", VA = "0x180712940")]
		private void RpcWriter___Server_SendImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002841")]
		[Address(RVA = "0x70EC30", Offset = "0x70D630", VA = "0x18070EC30", Slot = "102")]
		public virtual void RpcLogic___SendImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002842")]
		[Address(RVA = "0x710190", Offset = "0x70EB90", VA = "0x180710190")]
		private void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002843")]
		[Address(RVA = "0x7116A0", Offset = "0x7100A0", VA = "0x1807116A0")]
		private void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002844")]
		[Address(RVA = "0x70E450", Offset = "0x70CE50", VA = "0x18070E450", Slot = "103")]
		public virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002845")]
		[Address(RVA = "0x70F5F0", Offset = "0x70DFF0", VA = "0x18070F5F0")]
		private void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002846")]
		[Address(RVA = "0x711050", Offset = "0x70FA50", VA = "0x180711050")]
		private void RpcWriter___Observers_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x70D8A0", Offset = "0x70C2A0", VA = "0x18070D8A0", Slot = "104")]
		public virtual void RpcLogic___EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002848")]
		[Address(RVA = "0x70F3E0", Offset = "0x70DDE0", VA = "0x18070F3E0")]
		private void RpcReader___Observers_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x713350", Offset = "0x711D50", VA = "0x180713350")]
		private void RpcWriter___Target_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x7108D0", Offset = "0x70F2D0", VA = "0x1807108D0")]
		private void RpcReader___Target_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284B")]
		[Address(RVA = "0x7112D0", Offset = "0x70FCD0", VA = "0x1807112D0")]
		private void RpcWriter___Observers_ExitVehicle_2166136261()
		{
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284C")]
		[Address(RVA = "0x70E040", Offset = "0x70CA40", VA = "0x18070E040", Slot = "105")]
		public virtual void RpcLogic___ExitVehicle_2166136261()
		{
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284D")]
		[Address(RVA = "0x70F4A0", Offset = "0x70DEA0", VA = "0x18070F4A0")]
		private void RpcReader___Observers_ExitVehicle_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284E")]
		[Address(RVA = "0x712D10", Offset = "0x711710", VA = "0x180712D10")]
		private void RpcWriter___Server_SendWorldspaceDialogueReaction_606697822(string key, float duration)
		{
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284F")]
		[Address(RVA = "0x70C780", Offset = "0x70B180", VA = "0x18070C780")]
		public void RpcLogic___SendWorldspaceDialogueReaction_606697822(string key, float duration)
		{
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002850")]
		[Address(RVA = "0x710530", Offset = "0x70EF30", VA = "0x180710530")]
		private void RpcReader___Server_SendWorldspaceDialogueReaction_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002851")]
		[Address(RVA = "0x711530", Offset = "0x70FF30", VA = "0x180711530")]
		private void RpcWriter___Observers_PlayWorldspaceDialogueReaction_606697822(string key, float duration)
		{
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002852")]
		[Address(RVA = "0x70E410", Offset = "0x70CE10", VA = "0x18070E410")]
		private void RpcLogic___PlayWorldspaceDialogueReaction_606697822(string key, float duration)
		{
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002853")]
		[Address(RVA = "0x70F550", Offset = "0x70DF50", VA = "0x18070F550")]
		private void RpcReader___Observers_PlayWorldspaceDialogueReaction_606697822(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002854")]
		[Address(RVA = "0x712BB0", Offset = "0x7115B0", VA = "0x180712BB0")]
		private void RpcWriter___Server_SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002855")]
		[Address(RVA = "0x70EDA0", Offset = "0x70D7A0", VA = "0x18070EDA0")]
		public void RpcLogic___SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x710380", Offset = "0x70ED80", VA = "0x180710380")]
		private void RpcReader___Server_SendWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x7126A0", Offset = "0x7110A0", VA = "0x1807126A0")]
		private void RpcWriter___Observers_ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002858")]
		[Address(RVA = "0x70F320", Offset = "0x70DD20", VA = "0x18070F320")]
		public void RpcLogic___ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x70FE80", Offset = "0x70E880", VA = "0x18070FE80")]
		private void RpcReader___Observers_ShowWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x712E70", Offset = "0x711870", VA = "0x180712E70")]
		private void RpcWriter___Server_SetConversant_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x70EF90", Offset = "0x70D990", VA = "0x18070EF90")]
		public void RpcLogic___SetConversant_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x7105C0", Offset = "0x70EFC0", VA = "0x1807105C0")]
		private void RpcReader___Server_SetConversant_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285D")]
		[Address(RVA = "0x710ED0", Offset = "0x70F8D0", VA = "0x180710ED0")]
		private void RpcWriter___Observers_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285E")]
		[Address(RVA = "0x70D370", Offset = "0x70BD70", VA = "0x18070D370")]
		public void RpcLogic___EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285F")]
		[Address(RVA = "0x70F350", Offset = "0x70DD50", VA = "0x18070F350")]
		private void RpcReader___Observers_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002860")]
		[Address(RVA = "0x7131E0", Offset = "0x711BE0", VA = "0x1807131E0")]
		private void RpcWriter___Target_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002861")]
		[Address(RVA = "0x710840", Offset = "0x70F240", VA = "0x180710840")]
		private void RpcReader___Target_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x711190", Offset = "0x70FB90", VA = "0x180711190")]
		private void RpcWriter___Observers_ExitBuilding_3615296227(string buildingID = "")
		{
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002863")]
		[Address(RVA = "0x70DB20", Offset = "0x70C520", VA = "0x18070DB20")]
		public void RpcLogic___ExitBuilding_3615296227(string buildingID = "")
		{
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002864")]
		[Address(RVA = "0x70F440", Offset = "0x70DE40", VA = "0x18070F440")]
		private void RpcReader___Observers_ExitBuilding_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002865")]
		[Address(RVA = "0x712000", Offset = "0x710A00", VA = "0x180712000")]
		private void RpcWriter___Observers_SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002866")]
		[Address(RVA = "0x70F060", Offset = "0x70DA60", VA = "0x18070F060")]
		public void RpcLogic___SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002867")]
		[Address(RVA = "0x70FB80", Offset = "0x70E580", VA = "0x18070FB80")]
		private void RpcReader___Observers_SetEquippable_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002868")]
		[Address(RVA = "0x713BD0", Offset = "0x7125D0", VA = "0x180713BD0")]
		private void RpcWriter___Target_SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002869")]
		[Address(RVA = "0x710E60", Offset = "0x70F860", VA = "0x180710E60")]
		private void RpcReader___Target_SetEquippable_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286A")]
		[Address(RVA = "0x712140", Offset = "0x710B40", VA = "0x180712140")]
		private void RpcWriter___Observers_SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286B")]
		[Address(RVA = "0x70F060", Offset = "0x70DA60", VA = "0x18070F060")]
		private void RpcLogic___SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286C")]
		[Address(RVA = "0x70FC00", Offset = "0x70E600", VA = "0x18070FC00")]
		private void RpcReader___Observers_SetEquippable_Networked_ExcludeServer_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286D")]
		[Address(RVA = "0x711920", Offset = "0x710320", VA = "0x180711920")]
		private void RpcWriter___Observers_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286E")]
		[Address(RVA = "0x70EB50", Offset = "0x70D550", VA = "0x18070EB50")]
		public void RpcLogic___SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286F")]
		[Address(RVA = "0x70F800", Offset = "0x70E200", VA = "0x18070F800")]
		private void RpcReader___Observers_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x713610", Offset = "0x712010", VA = "0x180713610")]
		private void RpcWriter___Target_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002871")]
		[Address(RVA = "0x710B90", Offset = "0x70F590", VA = "0x180710B90")]
		private void RpcReader___Target_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002872")]
		[Address(RVA = "0x711A60", Offset = "0x710460", VA = "0x180711A60")]
		private void RpcWriter___Observers_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002873")]
		[Address(RVA = "0x70EB90", Offset = "0x70D590", VA = "0x18070EB90")]
		public void RpcLogic___SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002874")]
		[Address(RVA = "0x70F880", Offset = "0x70E280", VA = "0x18070F880")]
		private void RpcReader___Observers_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002875")]
		[Address(RVA = "0x713770", Offset = "0x712170", VA = "0x180713770")]
		private void RpcWriter___Target_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002876")]
		[Address(RVA = "0x710C00", Offset = "0x70F600", VA = "0x180710C00")]
		private void RpcReader___Target_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002877")]
		[Address(RVA = "0x712810", Offset = "0x711210", VA = "0x180712810")]
		private void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002878")]
		[Address(RVA = "0x70EB40", Offset = "0x70D540", VA = "0x18070EB40")]
		public void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002879")]
		[Address(RVA = "0x710130", Offset = "0x70EB30", VA = "0x180710130")]
		private void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287A")]
		[Address(RVA = "0x711D80", Offset = "0x710780", VA = "0x180711D80")]
		private void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287B")]
		[Address(RVA = "0x70EF50", Offset = "0x70D950", VA = "0x18070EF50")]
		public void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287C")]
		[Address(RVA = "0x70FA80", Offset = "0x70E480", VA = "0x18070FA80")]
		private void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287D")]
		[Address(RVA = "0x713A70", Offset = "0x712470", VA = "0x180713A70")]
		private void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287E")]
		[Address(RVA = "0x710DF0", Offset = "0x70F7F0", VA = "0x180710DF0")]
		private void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287F")]
		[Address(RVA = "0x7117E0", Offset = "0x7101E0", VA = "0x1807117E0")]
		private void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002880")]
		[Address(RVA = "0x70EB00", Offset = "0x70D500", VA = "0x18070EB00")]
		public void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002881")]
		[Address(RVA = "0x70F790", Offset = "0x70E190", VA = "0x18070F790")]
		private void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002882")]
		[Address(RVA = "0x7134B0", Offset = "0x711EB0", VA = "0x1807134B0")]
		private void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002883")]
		[Address(RVA = "0x710B20", Offset = "0x70F520", VA = "0x180710B20")]
		private void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002884")]
		[Address(RVA = "0x711EC0", Offset = "0x7108C0", VA = "0x180711EC0")]
		private void RpcWriter___Observers_SetCrouched_Networked_1140765316(bool crouched)
		{
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002885")]
		[Address(RVA = "0x70F030", Offset = "0x70DA30", VA = "0x18070F030")]
		public void RpcLogic___SetCrouched_Networked_1140765316(bool crouched)
		{
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002886")]
		[Address(RVA = "0x70FAF0", Offset = "0x70E4F0", VA = "0x18070FAF0")]
		private void RpcReader___Observers_SetCrouched_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002887")]
		[Address(RVA = "0x711C10", Offset = "0x710610", VA = "0x180711C10")]
		private void RpcWriter___Observers_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002888")]
		[Address(RVA = "0x70EF10", Offset = "0x70D910", VA = "0x18070EF10")]
		public void RpcLogic___SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002889")]
		[Address(RVA = "0x70F9D0", Offset = "0x70E3D0", VA = "0x18070F9D0")]
		private void RpcReader___Observers_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288A")]
		[Address(RVA = "0x713910", Offset = "0x712310", VA = "0x180713910")]
		private void RpcWriter___Target_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288B")]
		[Address(RVA = "0x710D40", Offset = "0x70F740", VA = "0x180710D40")]
		private void RpcReader___Target_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288C")]
		[Address(RVA = "0x7130D0", Offset = "0x711AD0", VA = "0x1807130D0")]
		private void RpcWriter___Server_SetPanicked_2166136261()
		{
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x70F0F0", Offset = "0x70DAF0", VA = "0x18070F0F0")]
		public void RpcLogic___SetPanicked_2166136261()
		{
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288E")]
		[Address(RVA = "0x7106E0", Offset = "0x70F0E0", VA = "0x1807106E0")]
		private void RpcReader___Server_SetPanicked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x70CC90", Offset = "0x70B690", VA = "0x18070CC90")]
		private void RpcWriter___Observers_ReceivePanicked_2166136261()
		{
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002890")]
		[Address(RVA = "0x70E690", Offset = "0x70D090", VA = "0x18070E690")]
		private void RpcLogic___ReceivePanicked_2166136261()
		{
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002891")]
		[Address(RVA = "0x70F650", Offset = "0x70E050", VA = "0x18070F650")]
		private void RpcReader___Observers_ReceivePanicked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002892")]
		[Address(RVA = "0x70CF20", Offset = "0x70B920", VA = "0x18070CF20")]
		private void RpcWriter___Observers_RemovePanicked_2166136261()
		{
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002893")]
		[Address(RVA = "0x70EA00", Offset = "0x70D400", VA = "0x18070EA00")]
		private void RpcLogic___RemovePanicked_2166136261()
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x70F680", Offset = "0x70E080", VA = "0x18070F680")]
		private void RpcReader___Observers_RemovePanicked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x70C4E0", Offset = "0x70AEE0", VA = "0x18070C4E0")]
		private void RpcWriter___Server_PlayVO_Server_1710085680(EVOLineType lineType)
		{
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002896")]
		[Address(RVA = "0x70C390", Offset = "0x70AD90", VA = "0x18070C390")]
		private void RpcLogic___PlayVO_Server_1710085680(EVOLineType lineType)
		{
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002897")]
		[Address(RVA = "0x70FFC0", Offset = "0x70E9C0", VA = "0x18070FFC0")]
		private void RpcReader___Server_PlayVO_Server_1710085680(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002898")]
		[Address(RVA = "0x7113F0", Offset = "0x70FDF0", VA = "0x1807113F0")]
		private void RpcWriter___Observers_PlayVO_Client_1710085680(EVOLineType lineType)
		{
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002899")]
		[Address(RVA = "0x70E3E0", Offset = "0x70CDE0", VA = "0x18070E3E0")]
		private void RpcLogic___PlayVO_Client_1710085680(EVOLineType lineType)
		{
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289A")]
		[Address(RVA = "0x70F4E0", Offset = "0x70DEE0", VA = "0x18070F4E0")]
		private void RpcReader___Observers_PlayVO_Client_1710085680(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289B")]
		[Address(RVA = "0x70CDB0", Offset = "0x70B7B0", VA = "0x18070CDB0")]
		private void RpcWriter___Target_ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289C")]
		[Address(RVA = "0x70E880", Offset = "0x70D280", VA = "0x18070E880")]
		public void RpcLogic___ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289D")]
		[Address(RVA = "0x710930", Offset = "0x70F330", VA = "0x180710930")]
		private void RpcReader___Target_ReceiveRelationshipData_4052192084(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289E")]
		[Address(RVA = "0x712FA0", Offset = "0x7119A0", VA = "0x180712FA0")]
		private void RpcWriter___Server_SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289F")]
		[Address(RVA = "0x70F0A0", Offset = "0x70DAA0", VA = "0x18070F0A0")]
		public void RpcLogic___SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A0")]
		[Address(RVA = "0x710640", Offset = "0x70F040", VA = "0x180710640")]
		private void RpcReader___Server_SetIsBeingPickPocketed_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x712A70", Offset = "0x711470", VA = "0x180712A70")]
		private void RpcWriter___Server_SendRelationship_431000436(float relationship)
		{
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x70EC50", Offset = "0x70D650", VA = "0x18070EC50")]
		public void RpcLogic___SendRelationship_431000436(float relationship)
		{
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x710210", Offset = "0x70EC10", VA = "0x180710210")]
		private void RpcReader___Server_SendRelationship_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x70EC50", Offset = "0x70D650", VA = "0x18070EC50")]
		private void RpcWriter___Observers_SetRelationship_431000436(float relationship)
		{
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x70F240", Offset = "0x70DC40", VA = "0x18070F240")]
		private void RpcLogic___SetRelationship_431000436(float relationship)
		{
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x70FC70", Offset = "0x70E670", VA = "0x18070FC70")]
		private void RpcReader___Observers_SetRelationship_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000677")]
		public NetworkObject SyncAccessor_PlayerConversant
		{
			[Token(Token = "0x60028A7")]
			[Address(RVA = "0x716F20", Offset = "0x715920", VA = "0x180716F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028A8")]
			[Address(RVA = "0x716F30", Offset = "0x715930", VA = "0x180716F30")]
			set
			{
			}
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0000C618 File Offset: 0x0000A818
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x70CA90", Offset = "0x70B490", VA = "0x18070CA90", Slot = "106")]
		public virtual bool ReadSyncVar___ScheduleOne.NPCs.NPC(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x708CD0", Offset = "0x7076D0", VA = "0x180708CD0", Slot = "107")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPC_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001E61 RID: 7777
		[Token(Token = "0x4001E61")]
		public const float PANIC_DURATION = 20f;

		// Token: 0x04001E62 RID: 7778
		[Token(Token = "0x4001E62")]
		public const bool RequiresRegionUnlocked = true;

		// Token: 0x04001E63 RID: 7779
		[Token(Token = "0x4001E63")]
		[FieldOffset(Offset = "0x118")]
		[Header("Info Settings")]
		public string FirstName;

		// Token: 0x04001E64 RID: 7780
		[Token(Token = "0x4001E64")]
		[FieldOffset(Offset = "0x120")]
		public bool hasLastName;

		// Token: 0x04001E65 RID: 7781
		[Token(Token = "0x4001E65")]
		[FieldOffset(Offset = "0x128")]
		public string LastName;

		// Token: 0x04001E67 RID: 7783
		[Token(Token = "0x4001E67")]
		[FieldOffset(Offset = "0x138")]
		public string ID;

		// Token: 0x04001E68 RID: 7784
		[Token(Token = "0x4001E68")]
		[FieldOffset(Offset = "0x140")]
		public Sprite MugshotSprite;

		// Token: 0x04001E69 RID: 7785
		[Token(Token = "0x4001E69")]
		[FieldOffset(Offset = "0x148")]
		public EMapRegion Region;

		// Token: 0x04001E6A RID: 7786
		[Token(Token = "0x4001E6A")]
		[FieldOffset(Offset = "0x14C")]
		[Header("If true, NPC will respawn next day instead of waiting 3 days.")]
		public bool IsImportant;

		// Token: 0x04001E6B RID: 7787
		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x150")]
		[Range(0f, 1f)]
		[Header("Personality")]
		public float Aggression;

		// Token: 0x04001E6C RID: 7788
		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Header("References")]
		protected Transform modelContainer;

		// Token: 0x04001E6D RID: 7789
		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x04001E6E RID: 7790
		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x168")]
		public NPCMovement Movement;

		// Token: 0x04001E6F RID: 7791
		[Token(Token = "0x4001E6F")]
		[FieldOffset(Offset = "0x170")]
		public DialogueHandler DialogueHandler;

		// Token: 0x04001E70 RID: 7792
		[Token(Token = "0x4001E70")]
		[FieldOffset(Offset = "0x178")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		// Token: 0x04001E71 RID: 7793
		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x180")]
		public NPCAwareness Awareness;

		// Token: 0x04001E72 RID: 7794
		[Token(Token = "0x4001E72")]
		[FieldOffset(Offset = "0x188")]
		public NPCResponses Responses;

		// Token: 0x04001E73 RID: 7795
		[Token(Token = "0x4001E73")]
		[FieldOffset(Offset = "0x190")]
		public NPCActions Actions;

		// Token: 0x04001E74 RID: 7796
		[Token(Token = "0x4001E74")]
		[FieldOffset(Offset = "0x198")]
		public NPCBehaviour Behaviour;

		// Token: 0x04001E75 RID: 7797
		[Token(Token = "0x4001E75")]
		[FieldOffset(Offset = "0x1A0")]
		public NPCInventory Inventory;

		// Token: 0x04001E76 RID: 7798
		[Token(Token = "0x4001E76")]
		[FieldOffset(Offset = "0x1A8")]
		public VOEmitter VoiceOverEmitter;

		// Token: 0x04001E77 RID: 7799
		[Token(Token = "0x4001E77")]
		[FieldOffset(Offset = "0x1B0")]
		public NPCHealth Health;

		// Token: 0x04001E78 RID: 7800
		[Token(Token = "0x4001E78")]
		[FieldOffset(Offset = "0x1B8")]
		public EntityVisibility Visibility;

		// Token: 0x04001E7A RID: 7802
		[Token(Token = "0x4001E7A")]
		[FieldOffset(Offset = "0x1C8")]
		public Action<LandVehicle> onEnterVehicle;

		// Token: 0x04001E7B RID: 7803
		[Token(Token = "0x4001E7B")]
		[FieldOffset(Offset = "0x1D0")]
		public Action<LandVehicle> onExitVehicle;

		// Token: 0x04001E7E RID: 7806
		[Token(Token = "0x4001E7E")]
		[FieldOffset(Offset = "0x1E8")]
		[Header("Summoning")]
		public bool CanBeSummoned;

		// Token: 0x04001E7F RID: 7807
		[Token(Token = "0x4001E7F")]
		[FieldOffset(Offset = "0x1F0")]
		[Header("Relationship")]
		public NPCRelationData RelationData;

		// Token: 0x04001E80 RID: 7808
		[Token(Token = "0x4001E80")]
		[FieldOffset(Offset = "0x1F8")]
		public string NPCUnlockedVariable;

		// Token: 0x04001E81 RID: 7809
		[Token(Token = "0x4001E81")]
		[FieldOffset(Offset = "0x200")]
		public bool ShowRelationshipInfo;

		// Token: 0x04001E82 RID: 7810
		[Token(Token = "0x4001E82")]
		[FieldOffset(Offset = "0x208")]
		[Header("Messaging")]
		public List<EConversationCategory> ConversationCategories;

		// Token: 0x04001E83 RID: 7811
		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x210")]
		public bool MessagingKnownByDefault;

		// Token: 0x04001E85 RID: 7813
		[Token(Token = "0x4001E85")]
		[FieldOffset(Offset = "0x220")]
		public bool ConversationCanBeHidden;

		// Token: 0x04001E86 RID: 7814
		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x228")]
		public Action onConversationCreated;

		// Token: 0x04001E87 RID: 7815
		[Token(Token = "0x4001E87")]
		[FieldOffset(Offset = "0x230")]
		[Header("Other Settings")]
		public bool CanOpenDoors;

		// Token: 0x04001E88 RID: 7816
		[Token(Token = "0x4001E88")]
		[FieldOffset(Offset = "0x231")]
		public bool OverrideParent;

		// Token: 0x04001E89 RID: 7817
		[Token(Token = "0x4001E89")]
		[FieldOffset(Offset = "0x238")]
		public Transform OverriddenParent;

		// Token: 0x04001E8A RID: 7818
		[Token(Token = "0x4001E8A")]
		[FieldOffset(Offset = "0x240")]
		public bool IgnoreImpacts;

		// Token: 0x04001E8B RID: 7819
		[Token(Token = "0x4001E8B")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		protected List<GameObject> OutlineRenderers;

		// Token: 0x04001E8C RID: 7820
		[Token(Token = "0x4001E8C")]
		[FieldOffset(Offset = "0x250")]
		protected Outlinable OutlineEffect;

		// Token: 0x04001E91 RID: 7825
		[Token(Token = "0x4001E91")]
		[FieldOffset(Offset = "0x278")]
		[Header("GUID")]
		public string BakedGUID;

		// Token: 0x04001E94 RID: 7828
		[Token(Token = "0x4001E94")]
		[FieldOffset(Offset = "0x298")]
		public Action<bool> onVisibilityChanged;

		// Token: 0x04001E95 RID: 7829
		[Token(Token = "0x4001E95")]
		[FieldOffset(Offset = "0x2A0")]
		[SyncVar]
		[HideInInspector]
		public NetworkObject PlayerConversant;

		// Token: 0x04001E97 RID: 7831
		[Token(Token = "0x4001E97")]
		[FieldOffset(Offset = "0x2B0")]
		private Coroutine resetUnsettledCoroutine;

		// Token: 0x04001E99 RID: 7833
		[Token(Token = "0x4001E99")]
		[FieldOffset(Offset = "0x2C0")]
		private List<int> impactHistory;

		// Token: 0x04001E9A RID: 7834
		[Token(Token = "0x4001E9A")]
		[FieldOffset(Offset = "0x2C8")]
		private int headlightStartTime;

		// Token: 0x04001E9B RID: 7835
		[Token(Token = "0x4001E9B")]
		[FieldOffset(Offset = "0x2CC")]
		private int heaedLightsEndTime;

		// Token: 0x04001E9C RID: 7836
		[Token(Token = "0x4001E9C")]
		[FieldOffset(Offset = "0x2D0")]
		protected float defaultAggression;

		// Token: 0x04001E9D RID: 7837
		[Token(Token = "0x4001E9D")]
		[FieldOffset(Offset = "0x2D8")]
		private Coroutine lerpScaleRoutine;

		// Token: 0x04001E9E RID: 7838
		[Token(Token = "0x4001E9E")]
		[FieldOffset(Offset = "0x2E0")]
		public SyncVar<NetworkObject> syncVar___PlayerConversant;

		// Token: 0x04001E9F RID: 7839
		[Token(Token = "0x4001E9F")]
		[FieldOffset(Offset = "0x2E8")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCAssembly-CSharp.dll_Excuted;

		// Token: 0x04001EA0 RID: 7840
		[Token(Token = "0x4001EA0")]
		[FieldOffset(Offset = "0x2E9")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCAssembly-CSharp.dll_Excuted;
	}
}
