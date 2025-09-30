using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.Packaging;
using ScheduleOne.Properties;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000992 RID: 2450
	[Token(Token = "0x2000992")]
	public class NewMixDiscoveryBox : MonoBehaviour
	{
		// Token: 0x060042D0 RID: 17104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D0")]
		[Address(RVA = "0x8804F0", Offset = "0x87EEF0", VA = "0x1808804F0")]
		public void Start()
		{
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D1")]
		[Address(RVA = "0x87F550", Offset = "0x87DF50", VA = "0x18087F550")]
		public void ShowProduct(ProductDefinition baseDefinition, List<Property> properties)
		{
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D2")]
		[Address(RVA = "0x87F430", Offset = "0x87DE30", VA = "0x18087F430")]
		private void CloseCase()
		{
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D3")]
		[Address(RVA = "0x87F500", Offset = "0x87DF00", VA = "0x18087F500")]
		private void OpenCase()
		{
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D4")]
		[Address(RVA = "0x87F490", Offset = "0x87DE90", VA = "0x18087F490")]
		private void Interacted()
		{
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D5")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public NewMixDiscoveryBox()
		{
		}

		// Token: 0x04002EED RID: 12013
		[Token(Token = "0x4002EED")]
		[FieldOffset(Offset = "0x20")]
		private bool isOpen;

		// Token: 0x04002EEE RID: 12014
		[Token(Token = "0x4002EEE")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x04002EEF RID: 12015
		[Token(Token = "0x4002EEF")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshPro PropertiesText;

		// Token: 0x04002EF0 RID: 12016
		[Token(Token = "0x4002EF0")]
		[FieldOffset(Offset = "0x38")]
		public NewMixDiscoveryBox.DrugTypeVisuals[] Visuals;

		// Token: 0x04002EF1 RID: 12017
		[Token(Token = "0x4002EF1")]
		[FieldOffset(Offset = "0x40")]
		public Animation Animation;

		// Token: 0x04002EF2 RID: 12018
		[Token(Token = "0x4002EF2")]
		[FieldOffset(Offset = "0x48")]
		public InteractableObject IntObj;

		// Token: 0x04002EF3 RID: 12019
		[Token(Token = "0x4002EF3")]
		[FieldOffset(Offset = "0x50")]
		public Transform Lid;

		// Token: 0x04002EF4 RID: 12020
		[Token(Token = "0x4002EF4")]
		[FieldOffset(Offset = "0x58")]
		private Pose closedLidPose;

		// Token: 0x04002EF5 RID: 12021
		[Token(Token = "0x4002EF5")]
		[FieldOffset(Offset = "0x78")]
		private NewMixOperation currentMix;

		// Token: 0x02000993 RID: 2451
		[Token(Token = "0x2000993")]
		[Serializable]
		public class DrugTypeVisuals
		{
			// Token: 0x060042D6 RID: 17110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042D6")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public DrugTypeVisuals()
			{
			}

			// Token: 0x04002EF6 RID: 12022
			[Token(Token = "0x4002EF6")]
			[FieldOffset(Offset = "0x10")]
			public EDrugType DrugType;

			// Token: 0x04002EF7 RID: 12023
			[Token(Token = "0x4002EF7")]
			[FieldOffset(Offset = "0x18")]
			public FilledPackagingVisuals Visuals;
		}
	}
}
