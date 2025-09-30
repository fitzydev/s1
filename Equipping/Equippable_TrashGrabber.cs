using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C3 RID: 2499
	[Token(Token = "0x20009C3")]
	public class Equippable_TrashGrabber : Equippable_Viewmodel
	{
		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004444 RID: 17476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700097B")]
		public static Equippable_TrashGrabber Instance
		{
			[Token(Token = "0x6004443")]
			[Address(RVA = "0x894BC0", Offset = "0x8935C0", VA = "0x180894BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004444")]
			[Address(RVA = "0x894C90", Offset = "0x893690", VA = "0x180894C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06004445 RID: 17477 RVA: 0x00011E38 File Offset: 0x00010038
		[Token(Token = "0x1700097C")]
		public static bool IsEquipped
		{
			[Token(Token = "0x6004445")]
			[Address(RVA = "0x894C00", Offset = "0x893600", VA = "0x180894C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06004446 RID: 17478 RVA: 0x00011E50 File Offset: 0x00010050
		// (set) Token: 0x06004447 RID: 17479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700097D")]
		private float currentDropTime
		{
			[Token(Token = "0x6004446")]
			[Address(RVA = "0x894C80", Offset = "0x893680", VA = "0x180894C80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004447")]
			[Address(RVA = "0x894CF0", Offset = "0x8936F0", VA = "0x180894CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x00011E68 File Offset: 0x00010068
		// (set) Token: 0x06004449 RID: 17481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700097E")]
		private float timeSinceLastDrop
		{
			[Token(Token = "0x6004448")]
			[Address(RVA = "0x50D890", Offset = "0x50C290", VA = "0x18050D890")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004449")]
			[Address(RVA = "0x50DA20", Offset = "0x50C420", VA = "0x18050DA20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444A")]
		[Address(RVA = "0x893DA0", Offset = "0x8927A0", VA = "0x180893DA0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444B")]
		[Address(RVA = "0x894500", Offset = "0x892F00", VA = "0x180894500", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444C")]
		[Address(RVA = "0x8946B0", Offset = "0x8930B0", VA = "0x1808946B0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444D")]
		[Address(RVA = "0x8939F0", Offset = "0x8923F0", VA = "0x1808939F0")]
		private void EjectTrash()
		{
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444E")]
		[Address(RVA = "0x894140", Offset = "0x892B40", VA = "0x180894140")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444F")]
		[Address(RVA = "0x894210", Offset = "0x892C10", VA = "0x180894210")]
		public void PickupTrash(TrashItem item)
		{
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x00011E80 File Offset: 0x00010080
		[Token(Token = "0x6004450")]
		[Address(RVA = "0x894110", Offset = "0x892B10", VA = "0x180894110")]
		public int GetCapacity()
		{
			return 0;
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004451")]
		[Address(RVA = "0x8942A0", Offset = "0x892CA0", VA = "0x1808942A0")]
		private void RefreshVisuals()
		{
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004452")]
		[Address(RVA = "0x894B90", Offset = "0x893590", VA = "0x180894B90")]
		public Equippable_TrashGrabber()
		{
		}

		// Token: 0x04002FC5 RID: 12229
		[Token(Token = "0x4002FC5")]
		public const float TrashDropSpacing = 0.15f;

		// Token: 0x04002FC6 RID: 12230
		[Token(Token = "0x4002FC6")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public Transform TrashContent;

		// Token: 0x04002FC7 RID: 12231
		[Token(Token = "0x4002FC7")]
		[FieldOffset(Offset = "0x70")]
		public Transform TrashContent_Min;

		// Token: 0x04002FC8 RID: 12232
		[Token(Token = "0x4002FC8")]
		[FieldOffset(Offset = "0x78")]
		public Transform TrashContent_Max;

		// Token: 0x04002FC9 RID: 12233
		[Token(Token = "0x4002FC9")]
		[FieldOffset(Offset = "0x80")]
		public Animation GrabAnim;

		// Token: 0x04002FCA RID: 12234
		[Token(Token = "0x4002FCA")]
		[FieldOffset(Offset = "0x88")]
		public Transform Bin;

		// Token: 0x04002FCB RID: 12235
		[Token(Token = "0x4002FCB")]
		[FieldOffset(Offset = "0x90")]
		public Transform BinRaisedPosition;

		// Token: 0x04002FCC RID: 12236
		[Token(Token = "0x4002FCC")]
		[FieldOffset(Offset = "0x98")]
		public AudioSourceController TrashDropSound;

		// Token: 0x04002FCD RID: 12237
		[Token(Token = "0x4002FCD")]
		[FieldOffset(Offset = "0xA0")]
		[Header("Settings")]
		public float DropTime;

		// Token: 0x04002FCE RID: 12238
		[Token(Token = "0x4002FCE")]
		[FieldOffset(Offset = "0xA4")]
		public float DropForce;

		// Token: 0x04002FCF RID: 12239
		[Token(Token = "0x4002FCF")]
		[FieldOffset(Offset = "0xA8")]
		public Vector3 TrashDropOffset;

		// Token: 0x04002FD0 RID: 12240
		[Token(Token = "0x4002FD0")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onPickup;

		// Token: 0x04002FD3 RID: 12243
		[Token(Token = "0x4002FD3")]
		[FieldOffset(Offset = "0xC8")]
		private TrashGrabberInstance trashGrabberInstance;

		// Token: 0x04002FD4 RID: 12244
		[Token(Token = "0x4002FD4")]
		[FieldOffset(Offset = "0xD0")]
		private Pose defaultBinPosition;

		// Token: 0x04002FD5 RID: 12245
		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0xEC")]
		private Vector3 defaultBinScale;
	}
}
