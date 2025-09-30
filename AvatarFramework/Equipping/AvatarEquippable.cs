using System;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000A40 RID: 2624
	[Token(Token = "0x2000A40")]
	public class AvatarEquippable : MonoBehaviour
	{
		// Token: 0x060047DB RID: 18395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DB")]
		[Address(RVA = "0x8ED700", Offset = "0x8EC100", VA = "0x1808ED700")]
		[Button]
		public void RecalculateAssetPath()
		{
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DC")]
		[Address(RVA = "0x8ED010", Offset = "0x8EBA10", VA = "0x1808ED010", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DD")]
		[Address(RVA = "0x8ED0D0", Offset = "0x8EBAD0", VA = "0x1808ED0D0", Slot = "5")]
		public virtual void Equip(Avatar _avatar)
		{
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DE")]
		[Address(RVA = "0x8ED2C0", Offset = "0x8EBCC0", VA = "0x1808ED2C0", Slot = "6")]
		public virtual void InitializeAnimation()
		{
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DF")]
		[Address(RVA = "0x8EDBE0", Offset = "0x8EC5E0", VA = "0x1808EDBE0", Slot = "7")]
		public virtual void Unequip()
		{
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E0")]
		[Address(RVA = "0x8ED2E0", Offset = "0x8EBCE0", VA = "0x1808ED2E0")]
		private void PositionAnimationModel()
		{
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E1")]
		[Address(RVA = "0x8EDAA0", Offset = "0x8EC4A0", VA = "0x1808EDAA0")]
		protected void SetTrigger(string anim)
		{
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E2")]
		[Address(RVA = "0x8ED950", Offset = "0x8EC350", VA = "0x1808ED950")]
		protected void SetBool(string anim, bool val)
		{
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E3")]
		[Address(RVA = "0x8ED810", Offset = "0x8EC210", VA = "0x1808ED810")]
		protected void ResetTrigger(string anim)
		{
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E4")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "8")]
		public virtual void ReceiveMessage(string message, object parameter)
		{
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E5")]
		[Address(RVA = "0x8EDC70", Offset = "0x8EC670", VA = "0x1808EDC70")]
		public AvatarEquippable()
		{
		}

		// Token: 0x040032CA RID: 13002
		[Token(Token = "0x40032CA")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public Transform AlignmentPoint;

		// Token: 0x040032CB RID: 13003
		[Token(Token = "0x40032CB")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float Suspiciousness;

		// Token: 0x040032CC RID: 13004
		[Token(Token = "0x40032CC")]
		[FieldOffset(Offset = "0x2C")]
		public AvatarEquippable.EHand Hand;

		// Token: 0x040032CD RID: 13005
		[Token(Token = "0x40032CD")]
		[FieldOffset(Offset = "0x30")]
		public AvatarEquippable.ETriggerType TriggerType;

		// Token: 0x040032CE RID: 13006
		[Token(Token = "0x40032CE")]
		[FieldOffset(Offset = "0x38")]
		public string AnimationTrigger;

		// Token: 0x040032CF RID: 13007
		[Token(Token = "0x40032CF")]
		[FieldOffset(Offset = "0x40")]
		public string AssetPath;

		// Token: 0x040032D0 RID: 13008
		[Token(Token = "0x40032D0")]
		[FieldOffset(Offset = "0x48")]
		protected Avatar avatar;

		// Token: 0x02000A41 RID: 2625
		[Token(Token = "0x2000A41")]
		public enum ETriggerType
		{
			// Token: 0x040032D2 RID: 13010
			[Token(Token = "0x40032D2")]
			Trigger,
			// Token: 0x040032D3 RID: 13011
			[Token(Token = "0x40032D3")]
			Bool
		}

		// Token: 0x02000A42 RID: 2626
		[Token(Token = "0x2000A42")]
		public enum EHand
		{
			// Token: 0x040032D5 RID: 13013
			[Token(Token = "0x40032D5")]
			Left,
			// Token: 0x040032D6 RID: 13014
			[Token(Token = "0x40032D6")]
			Right
		}
	}
}
