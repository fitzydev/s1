using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CA3 RID: 3235
	[Token(Token = "0x2000CA3")]
	public class LabStand : MonoBehaviour
	{
		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06005930 RID: 22832 RVA: 0x00015E40 File Offset: 0x00014040
		// (set) Token: 0x06005931 RID: 22833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C62")]
		public bool Interactable
		{
			[Token(Token = "0x6005930")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005931")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06005932 RID: 22834 RVA: 0x00015E58 File Offset: 0x00014058
		// (set) Token: 0x06005933 RID: 22835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C63")]
		public float CurrentPosition
		{
			[Token(Token = "0x6005932")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005933")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005934")]
		[Address(RVA = "0xA333E0", Offset = "0xA31DE0", VA = "0x180A333E0")]
		private void Start()
		{
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005935")]
		[Address(RVA = "0xA32EA0", Offset = "0xA318A0", VA = "0x180A32EA0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005936")]
		[Address(RVA = "0xA33050", Offset = "0xA31A50", VA = "0x180A33050")]
		private void Move()
		{
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005937")]
		[Address(RVA = "0xA33520", Offset = "0xA31F20", VA = "0x180A33520")]
		private void UpdateSound(float difference)
		{
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005938")]
		[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
		public void SetPosition(float position)
		{
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005939")]
		[Address(RVA = "0xA333A0", Offset = "0xA31DA0", VA = "0x180A333A0")]
		public void SetInteractable(bool e)
		{
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593A")]
		[Address(RVA = "0xA32B40", Offset = "0xA31540", VA = "0x180A32B40")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x00015E70 File Offset: 0x00014070
		[Token(Token = "0x600593B")]
		[Address(RVA = "0xA32BF0", Offset = "0xA315F0", VA = "0x180A32BF0")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593C")]
		[Address(RVA = "0xA32B30", Offset = "0xA31530", VA = "0x180A32B30")]
		public void ClickEnd()
		{
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593D")]
		[Address(RVA = "0xA33690", Offset = "0xA32090", VA = "0x180A33690")]
		public LabStand()
		{
		}

		// Token: 0x04004190 RID: 16784
		[Token(Token = "0x4004190")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public float MoveSpeed;

		// Token: 0x04004191 RID: 16785
		[Token(Token = "0x4004191")]
		[FieldOffset(Offset = "0x2C")]
		public bool FunnelEnabled;

		// Token: 0x04004192 RID: 16786
		[Token(Token = "0x4004192")]
		[FieldOffset(Offset = "0x30")]
		public float FunnelThreshold;

		// Token: 0x04004193 RID: 16787
		[Token(Token = "0x4004193")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Animation Anim;

		// Token: 0x04004194 RID: 16788
		[Token(Token = "0x4004194")]
		[FieldOffset(Offset = "0x40")]
		public Transform GripTransform;

		// Token: 0x04004195 RID: 16789
		[Token(Token = "0x4004195")]
		[FieldOffset(Offset = "0x48")]
		public Transform SpinnyThingy;

		// Token: 0x04004196 RID: 16790
		[Token(Token = "0x4004196")]
		[FieldOffset(Offset = "0x50")]
		public Transform RaisedTransform;

		// Token: 0x04004197 RID: 16791
		[Token(Token = "0x4004197")]
		[FieldOffset(Offset = "0x58")]
		public Transform LoweredTransform;

		// Token: 0x04004198 RID: 16792
		[Token(Token = "0x4004198")]
		[FieldOffset(Offset = "0x60")]
		public Transform PlaneNormal;

		// Token: 0x04004199 RID: 16793
		[Token(Token = "0x4004199")]
		[FieldOffset(Offset = "0x68")]
		public Clickable HandleClickable;

		// Token: 0x0400419A RID: 16794
		[Token(Token = "0x400419A")]
		[FieldOffset(Offset = "0x70")]
		public Transform Funnel;

		// Token: 0x0400419B RID: 16795
		[Token(Token = "0x400419B")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Highlight;

		// Token: 0x0400419C RID: 16796
		[Token(Token = "0x400419C")]
		[FieldOffset(Offset = "0x80")]
		public AudioSourceController LowerSound;

		// Token: 0x0400419D RID: 16797
		[Token(Token = "0x400419D")]
		[FieldOffset(Offset = "0x88")]
		public AudioSourceController RaiseSound;

		// Token: 0x0400419E RID: 16798
		[Token(Token = "0x400419E")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 clickOffset;

		// Token: 0x0400419F RID: 16799
		[Token(Token = "0x400419F")]
		[FieldOffset(Offset = "0x9C")]
		private bool isMoving;
	}
}
