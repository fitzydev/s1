using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C75 RID: 3189
	[Token(Token = "0x2000C75")]
	[RequireComponent(typeof(TrashContainer))]
	public class TrashContainerItem : GridItem, ITransitEntity
	{
		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06005633 RID: 22067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD5")]
		public string Name
		{
			[Token(Token = "0x6005633")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "71")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06005634 RID: 22068 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005635 RID: 22069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD6")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6005634")]
			[Address(RVA = "0x9DC5F0", Offset = "0x9DAFF0", VA = "0x1809DC5F0", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005635")]
			[Address(RVA = "0x9DC610", Offset = "0x9DB010", VA = "0x1809DC610", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06005636 RID: 22070 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005637 RID: 22071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD7")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6005636")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005637")]
			[Address(RVA = "0x6301C0", Offset = "0x62EBC0", VA = "0x1806301C0", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06005638 RID: 22072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD8")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6005638")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "76")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06005639 RID: 22073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD9")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6005639")]
			[Address(RVA = "0x9DC5E0", Offset = "0x9DAFE0", VA = "0x1809DC5E0", Slot = "77")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x0600563A RID: 22074 RVA: 0x000155B8 File Offset: 0x000137B8
		[Token(Token = "0x17000BDA")]
		public bool Selectable
		{
			[Token(Token = "0x600563A")]
			[Address(RVA = "0x84B300", Offset = "0x849D00", VA = "0x18084B300", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600563B RID: 22075 RVA: 0x000155D0 File Offset: 0x000137D0
		// (set) Token: 0x0600563C RID: 22076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BDB")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x600563B")]
			[Address(RVA = "0x9DC600", Offset = "0x9DB000", VA = "0x1809DC600", Slot = "79")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600563C")]
			[Address(RVA = "0x9DC630", Offset = "0x9DB030", VA = "0x1809DC630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563D")]
		[Address(RVA = "0x9DB3C0", Offset = "0x9D9DC0", VA = "0x1809DB3C0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563E")]
		[Address(RVA = "0x9DC190", Offset = "0x9DAB90", VA = "0x1809DC190", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563F")]
		[Address(RVA = "0x9DB9A0", Offset = "0x9DA3A0", VA = "0x1809DB9A0", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005640")]
		[Address(RVA = "0x9DC3F0", Offset = "0x9DADF0", VA = "0x1809DC3F0")]
		private void TrashLevelChanged()
		{
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x6005641")]
		[Address(RVA = "0x9DB4A0", Offset = "0x9D9EA0", VA = "0x1809DB4A0", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005642")]
		[Address(RVA = "0x9DB830", Offset = "0x9DA230", VA = "0x1809DB830", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005643")]
		[Address(RVA = "0x9DC2B0", Offset = "0x9DACB0", VA = "0x1809DC2B0")]
		private void TrashAdded(string trashID)
		{
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005644")]
		[Address(RVA = "0x9DC150", Offset = "0x9DAB50", VA = "0x1809DC150", Slot = "56")]
		public override void ShowOutline(Color color)
		{
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005645")]
		[Address(RVA = "0x9DB960", Offset = "0x9DA360", VA = "0x1809DB960", Slot = "57")]
		public override void HideOutline()
		{
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005646")]
		[Address(RVA = "0x9DB530", Offset = "0x9D9F30", VA = "0x1809DB530")]
		private void CheckTrashItems()
		{
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005647")]
		[Address(RVA = "0x9DB120", Offset = "0x9D9B20", VA = "0x1809DB120")]
		private void AddTrashToRadius(TrashItem trashItem)
		{
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005648")]
		[Address(RVA = "0x9DAF60", Offset = "0x9D9960", VA = "0x1809DAF60")]
		private void AddTrashBagToRadius(TrashBag trashBag)
		{
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005649")]
		[Address(RVA = "0x9DBE30", Offset = "0x9DA830", VA = "0x1809DBE30")]
		private void RemoveTrashItemFromRadius(TrashItem trashItem)
		{
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564A")]
		[Address(RVA = "0x9DBCD0", Offset = "0x9DA6D0", VA = "0x1809DBCD0")]
		private void RemoveTrashBagFromRadius(TrashBag trashBag)
		{
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x00015600 File Offset: 0x00013800
		[Token(Token = "0x600564B")]
		[Address(RVA = "0x9DBB60", Offset = "0x9DA560", VA = "0x1809DBB60")]
		private bool IsTrashValid(TrashItem trashItem)
		{
			return default(bool);
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00015618 File Offset: 0x00013818
		[Token(Token = "0x600564C")]
		[Address(RVA = "0x9DBA70", Offset = "0x9DA470", VA = "0x1809DBA70")]
		public bool IsPointInPickupZone(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564D")]
		[Address(RVA = "0x9DC480", Offset = "0x9DAE80", VA = "0x1809DC480")]
		public TrashContainerItem()
		{
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564E")]
		[Address(RVA = "0x9DBCB0", Offset = "0x9DA6B0", VA = "0x1809DBCB0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564F")]
		[Address(RVA = "0x9DBC90", Offset = "0x9DA690", VA = "0x1809DBC90", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005650")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005651")]
		[Address(RVA = "0x9DB310", Offset = "0x9D9D10", VA = "0x1809DB310", Slot = "93")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.TrashContainerItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003FE7 RID: 16359
		[Token(Token = "0x4003FE7")]
		public const float MAX_VERTICAL_OFFSET = 2f;

		// Token: 0x04003FE8 RID: 16360
		[Token(Token = "0x4003FE8")]
		[FieldOffset(Offset = "0x218")]
		public TrashContainer Container;

		// Token: 0x04003FE9 RID: 16361
		[Token(Token = "0x4003FE9")]
		[FieldOffset(Offset = "0x220")]
		public ParticleSystem Flies;

		// Token: 0x04003FEA RID: 16362
		[Token(Token = "0x4003FEA")]
		[FieldOffset(Offset = "0x228")]
		public AudioSourceController TrashAddedSound;

		// Token: 0x04003FEB RID: 16363
		[Token(Token = "0x4003FEB")]
		[FieldOffset(Offset = "0x230")]
		public DecalProjector PickupAreaProjector;

		// Token: 0x04003FEC RID: 16364
		[Token(Token = "0x4003FEC")]
		[FieldOffset(Offset = "0x238")]
		public Transform[] accessPoints;

		// Token: 0x04003FED RID: 16365
		[Token(Token = "0x4003FED")]
		[FieldOffset(Offset = "0x240")]
		[Header("Pickup settings")]
		public bool UsableByCleaners;

		// Token: 0x04003FEE RID: 16366
		[Token(Token = "0x4003FEE")]
		[FieldOffset(Offset = "0x244")]
		public float PickupSquareWidth;

		// Token: 0x04003FF3 RID: 16371
		[Token(Token = "0x4003FF3")]
		[FieldOffset(Offset = "0x260")]
		public List<TrashItem> TrashItemsInRadius;

		// Token: 0x04003FF4 RID: 16372
		[Token(Token = "0x4003FF4")]
		[FieldOffset(Offset = "0x268")]
		public List<TrashBag> TrashBagsInRadius;

		// Token: 0x04003FF5 RID: 16373
		[Token(Token = "0x4003FF5")]
		[FieldOffset(Offset = "0x270")]
		private float calculatedPickupRadius;

		// Token: 0x04003FF6 RID: 16374
		[Token(Token = "0x4003FF6")]
		[FieldOffset(Offset = "0x274")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04003FF7 RID: 16375
		[Token(Token = "0x4003FF7")]
		[FieldOffset(Offset = "0x275")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted;
	}
}
