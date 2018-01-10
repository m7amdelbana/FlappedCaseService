using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FlipCaseService
{
    public class FlipCaseService : IFlipCaseService
    {
        public StringData FlipTheCase(StringData sd)
        {
            sd.FlippedCaseString = null;

            foreach (char c in sd.OriginalString)
            {
                sd.FlippedCaseString += Char.IsLower(c) ? Char.ToUpper(c) : Char.ToLower(c);
            }

            return sd;
        }
    }
}
