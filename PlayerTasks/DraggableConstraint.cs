using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200034D RID: 845
	[Token(Token = "0x200034D")]
	public class DraggableConstraint : MonoBehaviour
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x1700038C")]
		private Vector3 RelativePos
		{
			[Token(Token = "0x600129C")]
			[Address(RVA = "0x591FF0", Offset = "0x5909F0", VA = "0x180591FF0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x591DA0", Offset = "0x5907A0", VA = "0x180591DA0")]
		private void Start()
		{
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x591C30", Offset = "0x590630", VA = "0x180591C30")]
		public void SetContainer(Transform container)
		{
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x591110", Offset = "0x58FB10", VA = "0x180591110", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x591120", Offset = "0x58FB20", VA = "0x180591120", Slot = "5")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x591A90", Offset = "0x590490", VA = "0x180591A90")]
		private void ProportionalClamp()
		{
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x5912F0", Offset = "0x58FCF0", VA = "0x1805912F0")]
		private void LockRotationX()
		{
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x5916C0", Offset = "0x5900C0", VA = "0x1805916C0")]
		private void LockRotationY()
		{
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x590CB0", Offset = "0x58F6B0", VA = "0x180590CB0")]
		private void AlignToContainerPlane()
		{
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x590F50", Offset = "0x58F950", VA = "0x180590F50")]
		private void ClampUpRot()
		{
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x591FE0", Offset = "0x5909E0", VA = "0x180591FE0")]
		public DraggableConstraint()
		{
		}

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x20")]
		public Transform Container;

		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody Anchor;

		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x30")]
		public bool ProportionalZClamp;

		// Token: 0x040011C5 RID: 4549
		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0x31")]
		public bool AlignUpToContainerPlane;

		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x32")]
		[Header("Up Direction Clamping")]
		public bool ClampUpDirection;

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x34")]
		public float UpDirectionMaxDifference;

		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 startLocalPos;

		// Token: 0x040011C9 RID: 4553
		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x48")]
		private Draggable draggable;

		// Token: 0x040011CA RID: 4554
		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;
	}
}
