using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	// Token: 0x0200057A RID: 1402
	[Token(Token = "0x200057A")]
	public class InteractableObject : MonoBehaviour
	{
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x1700056C")]
		public InteractableObject.EInteractionType _interactionType
		{
			[Token(Token = "0x6001F74")]
			[Address(RVA = "0x47D760", Offset = "0x47C160", VA = "0x18047D760")]
			get
			{
				return InteractableObject.EInteractionType.Key_Press;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x1700056D")]
		public InteractableObject.EInteractableState _interactionState
		{
			[Token(Token = "0x6001F75")]
			[Address(RVA = "0x6737E0", Offset = "0x6721E0", VA = "0x1806737E0")]
			get
			{
				return InteractableObject.EInteractableState.Default;
			}
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x47D820", Offset = "0x47C220", VA = "0x18047D820")]
		public void SetInteractionType(InteractableObject.EInteractionType type)
		{
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x673170", Offset = "0x671B70", VA = "0x180673170")]
		public void SetInteractableState(InteractableObject.EInteractableState state)
		{
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
		public void SetMessage(string _message)
		{
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x673120", Offset = "0x671B20", VA = "0x180673120", Slot = "4")]
		public virtual void Hovered()
		{
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0x673630", Offset = "0x672030", VA = "0x180673630", Slot = "5")]
		public virtual void StartInteract()
		{
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0x673080", Offset = "0x671A80", VA = "0x180673080", Slot = "6")]
		public virtual void EndInteract()
		{
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0x673180", Offset = "0x671B80", VA = "0x180673180", Slot = "7")]
		protected virtual void ShowMessage()
		{
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x672E10", Offset = "0x671810", VA = "0x180672E10")]
		public bool CheckAngleLimit(Vector3 interactionSource)
		{
			return default(bool);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0x6736E0", Offset = "0x6720E0", VA = "0x1806736E0")]
		public InteractableObject()
		{
		}

		// Token: 0x040019BE RID: 6590
		[Token(Token = "0x40019BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Settings")]
		protected string message;

		// Token: 0x040019BF RID: 6591
		[Token(Token = "0x40019BF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected InteractableObject.EInteractionType interactionType;

		// Token: 0x040019C0 RID: 6592
		[Token(Token = "0x40019C0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected InteractableObject.EInteractableState interactionState;

		// Token: 0x040019C1 RID: 6593
		[Token(Token = "0x40019C1")]
		[FieldOffset(Offset = "0x30")]
		public float MaxInteractionRange;

		// Token: 0x040019C2 RID: 6594
		[Token(Token = "0x40019C2")]
		[FieldOffset(Offset = "0x34")]
		public bool RequiresUniqueClick;

		// Token: 0x040019C3 RID: 6595
		[Token(Token = "0x40019C3")]
		[FieldOffset(Offset = "0x38")]
		public int Priority;

		// Token: 0x040019C4 RID: 6596
		[Token(Token = "0x40019C4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Collider displayLocationCollider;

		// Token: 0x040019C5 RID: 6597
		[Token(Token = "0x40019C5")]
		[FieldOffset(Offset = "0x48")]
		public Transform displayLocationPoint;

		// Token: 0x040019C6 RID: 6598
		[Token(Token = "0x40019C6")]
		[FieldOffset(Offset = "0x50")]
		[Header("Angle Limits")]
		public bool LimitInteractionAngle;

		// Token: 0x040019C7 RID: 6599
		[Token(Token = "0x40019C7")]
		[FieldOffset(Offset = "0x54")]
		public float AngleLimit;

		// Token: 0x040019C8 RID: 6600
		[Token(Token = "0x40019C8")]
		[FieldOffset(Offset = "0x58")]
		[Header("Events")]
		public UnityEvent onHovered;

		// Token: 0x040019C9 RID: 6601
		[Token(Token = "0x40019C9")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onInteractStart;

		// Token: 0x040019CA RID: 6602
		[Token(Token = "0x40019CA")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onInteractEnd;

		// Token: 0x0200057B RID: 1403
		[Token(Token = "0x200057B")]
		public enum EInteractionType
		{
			// Token: 0x040019CC RID: 6604
			[Token(Token = "0x40019CC")]
			Key_Press,
			// Token: 0x040019CD RID: 6605
			[Token(Token = "0x40019CD")]
			LeftMouse_Click
		}

		// Token: 0x0200057C RID: 1404
		[Token(Token = "0x200057C")]
		public enum EInteractableState
		{
			// Token: 0x040019CF RID: 6607
			[Token(Token = "0x40019CF")]
			Default,
			// Token: 0x040019D0 RID: 6608
			[Token(Token = "0x40019D0")]
			Invalid,
			// Token: 0x040019D1 RID: 6609
			[Token(Token = "0x40019D1")]
			Disabled,
			// Token: 0x040019D2 RID: 6610
			[Token(Token = "0x40019D2")]
			Label
		}
	}
}
