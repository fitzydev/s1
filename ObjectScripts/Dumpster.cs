using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CC7 RID: 3271
	[Token(Token = "0x2000CC7")]
	public class Dumpster : GridItem
	{
		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06005C9D RID: 23709 RVA: 0x00016668 File Offset: 0x00014868
		// (set) Token: 0x06005C9E RID: 23710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CF9")]
		public bool lidOpen
		{
			[Token(Token = "0x6005C9D")]
			[Address(RVA = "0x62FDA0", Offset = "0x62E7A0", VA = "0x18062FDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C9E")]
			[Address(RVA = "0x841300", Offset = "0x83FD00", VA = "0x180841300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06005C9F RID: 23711 RVA: 0x00016680 File Offset: 0x00014880
		// (set) Token: 0x06005CA0 RID: 23712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CFA")]
		public float currentTrashLevel
		{
			[Token(Token = "0x6005C9F")]
			[Address(RVA = "0xA3E590", Offset = "0xA3CF90", VA = "0x180A3E590")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005CA0")]
			[Address(RVA = "0xA3E610", Offset = "0xA3D010", VA = "0x180A3E610")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06005CA1 RID: 23713 RVA: 0x00016698 File Offset: 0x00014898
		[Token(Token = "0x17000CFB")]
		public bool isFull
		{
			[Token(Token = "0x6005CA1")]
			[Address(RVA = "0xA3E5A0", Offset = "0xA3CFA0", VA = "0x180A3E5A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0xA3E450", Offset = "0xA3CE50", VA = "0x180A3E450", Slot = "71")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0xA3E090", Offset = "0xA3CA90", VA = "0x180A3E090", Slot = "72")]
		public virtual void Lid_Hovered()
		{
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA4")]
		[Address(RVA = "0xA3E120", Offset = "0xA3CB20", VA = "0x180A3E120", Slot = "73")]
		public virtual void Lid_Interacted()
		{
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x000166B0 File Offset: 0x000148B0
		[Token(Token = "0x6005CA5")]
		[Address(RVA = "0xA3DF60", Offset = "0xA3C960", VA = "0x180A3DF60")]
		protected bool DoesPlayerHaveBinEquipped()
		{
			return default(bool);
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0xA3DDB0", Offset = "0xA3C7B0", VA = "0x180A3DDB0")]
		public void ChangeTrashLevel(float change)
		{
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0xA3E180", Offset = "0xA3CB80", VA = "0x180A3E180")]
		public void SetTrashLevel(float trashLevel)
		{
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0xA3E320", Offset = "0xA3CD20", VA = "0x180A3E320")]
		private void UpdateTrashVisuals()
		{
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x000166C8 File Offset: 0x000148C8
		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0xA3DD30", Offset = "0xA3C730", VA = "0x180A3DD30", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0x9C5880", Offset = "0x9C4280", VA = "0x1809C5880")]
		public Dumpster()
		{
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAC")]
		[Address(RVA = "0xA3E160", Offset = "0xA3CB60", VA = "0x180A3E160", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAD")]
		[Address(RVA = "0xA3E140", Offset = "0xA3CB40", VA = "0x180A3E140", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAE")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0x9C4910", Offset = "0x9C3310", VA = "0x1809C4910", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04004345 RID: 17221
		[Token(Token = "0x4004345")]
		[FieldOffset(Offset = "0x0")]
		public static float capacity;

		// Token: 0x04004346 RID: 17222
		[Token(Token = "0x4004346")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		[Header("References")]
		protected InteractableObject lid_IntObj;

		// Token: 0x04004347 RID: 17223
		[Token(Token = "0x4004347")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		protected InteractableObject inner_IntObj;

		// Token: 0x04004348 RID: 17224
		[Token(Token = "0x4004348")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		protected Transform lid;

		// Token: 0x04004349 RID: 17225
		[Token(Token = "0x4004349")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		protected Transform trash;

		// Token: 0x0400434A RID: 17226
		[Token(Token = "0x400434A")]
		[FieldOffset(Offset = "0x238")]
		public Transform standPoint;

		// Token: 0x0400434B RID: 17227
		[Token(Token = "0x400434B")]
		[FieldOffset(Offset = "0x240")]
		[Header("Settings")]
		[SerializeField]
		protected float trash_MinY;

		// Token: 0x0400434C RID: 17228
		[Token(Token = "0x400434C")]
		[FieldOffset(Offset = "0x244")]
		[SerializeField]
		protected float trash_MaxY;

		// Token: 0x0400434F RID: 17231
		[Token(Token = "0x400434F")]
		[FieldOffset(Offset = "0x250")]
		private float lid_CurrentAngle;

		// Token: 0x04004350 RID: 17232
		[Token(Token = "0x4004350")]
		[FieldOffset(Offset = "0x254")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted;

		// Token: 0x04004351 RID: 17233
		[Token(Token = "0x4004351")]
		[FieldOffset(Offset = "0x255")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted;
	}
}
