using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;

namespace SA
{
    public class Tools
    {
        // subtitles handled formats
        public enum SubtitleType
        {
            None      = 0,
            SubRip    = 1,
            SubViewer = 2
        };

        #region Time functions

        // format "hh:mm:ss,fff" or "hh:mm:ss.ff"
        public static long TimeToMilliseconds(string timeString, out SubtitleType type)
        {
            DateTime date;
            type = SubtitleType.None; // default

            try
            {
                // try SubRip format by default
                date = DateTime.ParseExact(timeString, "hh:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                type = SubtitleType.SubRip;
            }
            catch (Exception /*e*/)
            {
                try
                {
                    // try SubViewer format
                    date = DateTime.ParseExact(timeString, "hh:mm:ss.ff", System.Globalization.CultureInfo.InvariantCulture);
                    type = SubtitleType.SubViewer;
                }
                catch (Exception /*e*/)
                {
                    throw new Exception("Cannot convert time " + timeString);
                }
            }

            long totalMilliseconds = 1000 * (3600 * date.Hour + 60 * date.Minute + date.Second) + date.Millisecond;

            return totalMilliseconds;
        }

        public static string MillisecondsToTime(long totalMilliseconds, SubtitleType type)
        {
            try
            {
                DateTime date = DateTime.Now.Date; // dummy
                date = date.AddMilliseconds((double)totalMilliseconds);
                
                string timeString = "";
                switch (type)
                {
                    case SubtitleType.SubRip:
                        timeString = date.ToString("HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                        break;

                    case SubtitleType.SubViewer:
                        timeString = date.ToString("HH:mm:ss.ff", System.Globalization.CultureInfo.InvariantCulture);
                        break;

                    default:
                        throw new Exception("Cannot convert milliseconds " + totalMilliseconds.ToString());
                }

                return timeString;
            }
            catch (Exception /*e*/)
            {
                throw new Exception("Cannot convert milliseconds " + totalMilliseconds.ToString());
            }
        }

        public static string AdjustTime(string timeString, double speed = 1.0, long delay = 0)
        {
            try
            {
                SubtitleType type = SubtitleType.None;
                long milliseconds = TimeToMilliseconds(timeString, out type);
                long adjustedMilliseconds = (long)((1.0 / speed) * milliseconds + delay); // adjust
                adjustedMilliseconds = Math.Max(0, adjustedMilliseconds); // ensure positive time
                string adjustedTimeString = MillisecondsToTime(adjustedMilliseconds, type);

                return adjustedTimeString;
            }
            catch (Exception /*e*/)
            {
                throw new Exception("Cannot convert time " + timeString);
            }
        }

        #endregion

        /// <summary>
        /// Determines a text file's encoding by analyzing its byte order mark (BOM).
        /// Defaults to ASCII when detection of the text file's endianness fails.
        /// </summary>
        /// <param name="filename">The text file to analyze.</param>
        /// <returns>The detected encoding.</returns>
        //public static Encoding GetEncoding(string filename)
        //{
        //    // Read the BOM
        //    var bom = new byte[4];
        //    using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
        //    {
        //        file.Read(bom, 0, 4);
        //    }
        //
        //    // Analyze the BOM
        //    if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
        //    if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
        //    if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
        //    if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
        //    if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
        //    return Encoding.ASCII;
        //}

        public static Encoding GetEncoding(string filename)
        {
            Encoding encoding = Encoding.Default;
            using (StreamReader reader = new StreamReader(filename, Encoding.Default, true))
            {
                reader.Peek();
                encoding = reader.CurrentEncoding;
            }

            return encoding;
        }
    }
}
