using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	// Token: 0x0200057D RID: 1405
	[Token(Token = "0x200057D")]
	public class InteractableToggleable : MonoBehaviour
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x0000A4D0 File Offset: 0x000086D0
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056E")]
		public bool IsActivated
		{
			[Token(Token = "0x6001F7F")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F80")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F81")]
		[Address(RVA = "0x6739A0", Offset = "0x6723A0", VA = "0x1806739A0")]
		public void Start()
		{
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F82")]
		[Address(RVA = "0x6737F0", Offset = "0x6721F0", VA = "0x1806737F0")]
		public void Hovered()
		{
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F83")]
		[Address(RVA = "0x673870", Offset = "0x672270", VA = "0x180673870")]
		public void Interacted()
		{
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F84")]
		[Address(RVA = "0x673870", Offset = "0x672270", VA = "0x180673870")]
		public void Toggle()
		{
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F85")]
		[Address(RVA = "0x673940", Offset = "0x672340", VA = "0x180673940")]
		public void SetState(bool activated)
		{
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F86")]
		[Address(RVA = "0x6738D0", Offset = "0x6722D0", VA = "0x1806738D0")]
		public void PoliceDetected()
		{
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F87")]
		[Address(RVA = "0x673A90", Offset = "0x672490", VA = "0x180673A90")]
		public InteractableToggleable()
		{
		}

		// Token: 0x040019D4 RID: 6612
		[Token(Token = "0x40019D4")]
		[FieldOffset(Offset = "0x28")]
		public string ActivateMessage;

		// Token: 0x040019D5 RID: 6613
		[Token(Token = "0x40019D5")]
		[FieldOffset(Offset = "0x30")]
		public string DeactivateMessage;

		// Token: 0x040019D6 RID: 6614
		[Token(Token = "0x40019D6")]
		[FieldOffset(Offset = "0x38")]
		public float CoolDown;

		// Token: 0x040019D7 RID: 6615
		[Token(Token = "0x40019D7")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x040019D8 RID: 6616
		[Token(Token = "0x40019D8")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onToggle;

		// Token: 0x040019D9 RID: 6617
		[Token(Token = "0x40019D9")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent onActivate;

		// Token: 0x040019DA RID: 6618
		[Token(Token = "0x40019DA")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onDeactivate;

		// Token: 0x040019DB RID: 6619
		[Token(Token = "0x40019DB")]
		[FieldOffset(Offset = "0x60")]
		private float lastActivated;
	}
}
