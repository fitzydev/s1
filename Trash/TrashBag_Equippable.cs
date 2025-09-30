using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.Trash
{
	// Token: 0x020008C9 RID: 2249
	[Token(Token = "0x20008C9")]
	public class TrashBag_Equippable : Equippable_Viewmodel
	{
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		[Token(Token = "0x170008C5")]
		public static bool IsHoveringTrash
		{
			[Token(Token = "0x6003E20")]
			[Address(RVA = "0x850270", Offset = "0x84EC70", VA = "0x180850270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06003E21 RID: 15905 RVA: 0x00010B00 File Offset: 0x0000ED00
		// (set) Token: 0x06003E22 RID: 15906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008C6")]
		public bool IsBaggingTrash
		{
			[Token(Token = "0x6003E21")]
			[Address(RVA = "0x850260", Offset = "0x84EC60", VA = "0x180850260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E22")]
			[Address(RVA = "0x850310", Offset = "0x84ED10", VA = "0x180850310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x00010B18 File Offset: 0x0000ED18
		// (set) Token: 0x06003E24 RID: 15908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008C7")]
		public bool IsPickingUpTrash
		{
			[Token(Token = "0x6003E23")]
			[Address(RVA = "0x850300", Offset = "0x84ED00", VA = "0x180850300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E24")]
			[Address(RVA = "0x850320", Offset = "0x84ED20", VA = "0x180850320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E25")]
		[Address(RVA = "0x84EA30", Offset = "0x84D430", VA = "0x18084EA30", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E26")]
		[Address(RVA = "0x84F7B0", Offset = "0x84E1B0", VA = "0x18084F7B0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E27")]
		[Address(RVA = "0x84F880", Offset = "0x84E280", VA = "0x18084F880", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E28")]
		[Address(RVA = "0x84ECF0", Offset = "0x84D6F0", VA = "0x18084ECF0")]
		private TrashContainer GetHoveredTrashContainer()
		{
			return null;
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00010B30 File Offset: 0x0000ED30
		[Token(Token = "0x6003E29")]
		[Address(RVA = "0x84F110", Offset = "0x84DB10", VA = "0x18084F110")]
		private bool RaycastLook(out RaycastHit hit)
		{
			return default(bool);
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x00010B48 File Offset: 0x0000ED48
		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0x84F080", Offset = "0x84DA80", VA = "0x18084F080")]
		private bool IsPickupLocationValid(RaycastHit hit)
		{
			return default(bool);
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E2B")]
		[Address(RVA = "0x84EE90", Offset = "0x84D890", VA = "0x18084EE90")]
		private List<TrashItem> GetTrashItemsAtPoint(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x84F1C0", Offset = "0x84DBC0", VA = "0x18084F1C0")]
		private void StartBagTrash(TrashContainer container)
		{
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2D")]
		[Address(RVA = "0x84F260", Offset = "0x84DC60", VA = "0x18084F260")]
		private void StopBagTrash(bool complete)
		{
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0x84F220", Offset = "0x84DC20", VA = "0x18084F220")]
		private void StartPickup()
		{
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x84F310", Offset = "0x84DD10", VA = "0x18084F310")]
		private void StopPickup(bool complete)
		{
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x850250", Offset = "0x84EC50", VA = "0x180850250")]
		public TrashBag_Equippable()
		{
		}

		// Token: 0x04002BB2 RID: 11186
		[Token(Token = "0x4002BB2")]
		public const float TRASH_CONTAINER_INTERACT_DISTANCE = 2.75f;

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		public const float BAG_TRASH_TIME = 1f;

		// Token: 0x04002BB4 RID: 11188
		[Token(Token = "0x4002BB4")]
		public const float PICKUP_RANGE = 3f;

		// Token: 0x04002BB5 RID: 11189
		[Token(Token = "0x4002BB5")]
		public const float PICKUP_AREA_RADIUS = 0.5f;

		// Token: 0x04002BB8 RID: 11192
		[Token(Token = "0x4002BB8")]
		[FieldOffset(Offset = "0x6C")]
		public LayerMask PickupLookMask;

		// Token: 0x04002BB9 RID: 11193
		[Token(Token = "0x4002BB9")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		public DecalProjector PickupAreaProjector;

		// Token: 0x04002BBA RID: 11194
		[Token(Token = "0x4002BBA")]
		[FieldOffset(Offset = "0x78")]
		public AudioSourceController RustleSound;

		// Token: 0x04002BBB RID: 11195
		[Token(Token = "0x4002BBB")]
		[FieldOffset(Offset = "0x80")]
		public AudioSourceController BagSound;

		// Token: 0x04002BBC RID: 11196
		[Token(Token = "0x4002BBC")]
		[FieldOffset(Offset = "0x88")]
		private float _bagTrashTime;

		// Token: 0x04002BBD RID: 11197
		[Token(Token = "0x4002BBD")]
		[FieldOffset(Offset = "0x90")]
		private TrashContainer _baggedContainer;

		// Token: 0x04002BBE RID: 11198
		[Token(Token = "0x4002BBE")]
		[FieldOffset(Offset = "0x98")]
		private float _pickupTrashTime;
	}
}
