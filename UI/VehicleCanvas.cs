using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000B12 RID: 2834
	[Token(Token = "0x2000B12")]
	public class VehicleCanvas : Singleton<VehicleCanvas>
	{
		// Token: 0x06004CE0 RID: 19680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE0")]
		[Address(RVA = "0x93FAC0", Offset = "0x93E4C0", VA = "0x18093FAC0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE1")]
		[Address(RVA = "0x93FC10", Offset = "0x93E610", VA = "0x18093FC10")]
		private void Subscribe()
		{
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE2")]
		[Address(RVA = "0x940040", Offset = "0x93EA40", VA = "0x180940040")]
		private void Update()
		{
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE3")]
		[Address(RVA = "0x93FA50", Offset = "0x93E450", VA = "0x18093FA50")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE4")]
		[Address(RVA = "0x940180", Offset = "0x93EB80", VA = "0x180940180")]
		private void VehicleEntered(LandVehicle veh)
		{
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE5")]
		[Address(RVA = "0x9401E0", Offset = "0x93EBE0", VA = "0x1809401E0")]
		private void VehicleExited(LandVehicle veh, Transform exitPoint)
		{
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE6")]
		[Address(RVA = "0x93FE30", Offset = "0x93E830", VA = "0x18093FE30")]
		private void UpdateSpeedText()
		{
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x940220", Offset = "0x93EC20", VA = "0x180940220")]
		public VehicleCanvas()
		{
		}

		// Token: 0x040037BA RID: 14266
		[Token(Token = "0x40037BA")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040037BB RID: 14267
		[Token(Token = "0x40037BB")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI SpeedText;

		// Token: 0x040037BC RID: 14268
		[Token(Token = "0x40037BC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject DriverPromptsContainer;

		// Token: 0x040037BD RID: 14269
		[Token(Token = "0x40037BD")]
		[FieldOffset(Offset = "0x40")]
		private LandVehicle currentVehicle;
	}
}
