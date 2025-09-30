using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AF6 RID: 2806
	[Token(Token = "0x2000AF6")]
	public class PropertySelector : MonoBehaviour
	{
		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06004C35 RID: 19509 RVA: 0x00013B48 File Offset: 0x00011D48
		[Token(Token = "0x17000AB7")]
		public bool isOpen
		{
			[Token(Token = "0x6004C35")]
			[Address(RVA = "0x930A10", Offset = "0x92F410", VA = "0x180930A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C36")]
		[Address(RVA = "0x930250", Offset = "0x92EC50", VA = "0x180930250", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C37")]
		[Address(RVA = "0x930970", Offset = "0x92F370", VA = "0x180930970", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C38")]
		[Address(RVA = "0x930640", Offset = "0x92F040", VA = "0x180930640", Slot = "6")]
		public virtual void Exit(ExitAction exit)
		{
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x9306A0", Offset = "0x92F0A0", VA = "0x1809306A0")]
		public void OpenSelector(PropertySelector.PropertySelected p)
		{
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void PropertyAcquired(Property p)
		{
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3B")]
		[Address(RVA = "0x930930", Offset = "0x92F330", VA = "0x180930930")]
		private void SelectProperty(Property p)
		{
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3C")]
		[Address(RVA = "0x9303B0", Offset = "0x92EDB0", VA = "0x1809303B0")]
		private void Close(bool reenableShit)
		{
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3D")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public PropertySelector()
		{
		}

		// Token: 0x0400372E RID: 14126
		[Token(Token = "0x400372E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		protected GameObject container;

		// Token: 0x0400372F RID: 14127
		[Token(Token = "0x400372F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected RectTransform buttonContainer;

		// Token: 0x04003730 RID: 14128
		[Token(Token = "0x4003730")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Prefabs")]
		protected GameObject buttonPrefab;

		// Token: 0x04003731 RID: 14129
		[Token(Token = "0x4003731")]
		[FieldOffset(Offset = "0x38")]
		private PropertySelector.PropertySelected pCallback;

		// Token: 0x02000AF7 RID: 2807
		// (Invoke) Token: 0x06004C3F RID: 19519
		[Token(Token = "0x2000AF7")]
		public delegate void PropertySelected(Property p);
	}
}
