using System;
using NAudio.Midi;

namespace NAudioUtils.Extensions
{
    public static class MidiFileExtensions
    {
        public static string FileFormatDescription(this MidiFile file)
        {
            switch (file.FileFormat)
            {
                case 0:
                    return "Single track";
                case 1:
                    return "Multiple tracks";
                case 2:
                    return "Multiple songs";
                default:
                    throw new ArgumentOutOfRangeException($"Invalid MIDI file format provided: {file.FileFormat}");
            }
        }

    }
}
