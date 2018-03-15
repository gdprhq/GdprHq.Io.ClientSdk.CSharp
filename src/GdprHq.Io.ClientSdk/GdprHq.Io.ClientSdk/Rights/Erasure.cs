using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights
{
    public class Erasure : Interfaces.IErasure
    {
        /// <summary>
        /// Erase personal data for the data subject.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns>True if the personal data is successfully deleted; otherwise, returns false.</returns>
        public bool ErasePersonalData(object dataSubjectIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inform data recipients of erasure request.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="dataRecipients"></param>
        /// <returns></returns>
        public bool InformDataRecipientsOfErasureRequest(object dataSubjectIdentifier, object dataRecipients)
        {
            throw new NotImplementedException();
        }
    }
}
