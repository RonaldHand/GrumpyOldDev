﻿
using Serenity.ComponentModel;
using System.ComponentModel;

namespace GrumpyOldDev.Meeting
{
    [EnumKey("Meeting.MeetingAttendeeType")]
    public enum MeetingAttendeeType
    {
        [Description("Attendee")]
        Attendee = 1,
        [Description("Guest")]
        Guest = 2
    }
}