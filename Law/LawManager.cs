using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;

namespace ScheduleOne.Law
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	public class LawManager : Singleton<LawManager>
	{
		// Token: 0x06001B75 RID: 7029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x63A460", Offset = "0x638E60", VA = "0x18063A460", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x639E80", Offset = "0x638880", VA = "0x180639E80")]
		public void PoliceCalled(Player target, Crime crime)
		{
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x63A020", Offset = "0x638A20", VA = "0x18063A020")]
		public PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers)
		{
			return null;
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x63A2A0", Offset = "0x638CA0", VA = "0x18063A2A0")]
		public PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route)
		{
			return null;
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x63A620", Offset = "0x639020", VA = "0x18063A620")]
		public LawManager()
		{
		}

		// Token: 0x0400176F RID: 5999
		[Token(Token = "0x400176F")]
		public const int DISPATCH_OFFICER_COUNT = 2;

		// Token: 0x04001770 RID: 6000
		[Token(Token = "0x4001770")]
		[FieldOffset(Offset = "0x0")]
		public static float DISPATCH_VEHICLE_USE_THRESHOLD;
	}
}
